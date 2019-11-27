using BLL;
using Entidades;
using ProyectoFinalAP1.UI.Ventanas_de_Dialogo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalAP1.UI.Registros
{
    public partial class rUsuarios : Form
    {
        public rUsuarios()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            UsuarioIdnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            NombrestextBox.Text = string.Empty;
            ApellidostextBox.Text = string.Empty;
            CedulamaskedTextBox.Text = string.Empty;
            EmailtextBox.Text = string.Empty;
            NombreUsuariotextBox.Text = string.Empty;
            ContrasenatextBox.Text = string.Empty;
            TipoUsuariocomboBox.Text = string.Empty;
            ActivocheckBox.Checked = true;
            MyerrorProvider.Clear();
        }

        private Usuarios LlenaClase()
        {
            Usuarios usuario = new Usuarios();

            usuario.UsuarioId = (int)UsuarioIdnumericUpDown.Value;
            usuario.Fecha = FechadateTimePicker.Value;
            usuario.Nombres = NombrestextBox.Text;
            usuario.Apellidos = ApellidostextBox.Text;
            usuario.Cedula = CedulamaskedTextBox.Text;
            usuario.Email = EmailtextBox.Text;
            usuario.NombreUsuario = NombreUsuariotextBox.Text;
            usuario.ClaveUsuario = Encriptar(ContrasenatextBox.Text);
            usuario.TipoUsuario = TipoUsuariocomboBox.SelectedIndex;
            usuario.Activo = ActivocheckBox.Checked;
            
            return usuario;
        }

        private void LlenaCampos(Usuarios usuario)
        {
            UsuarioIdnumericUpDown.Value = usuario.UsuarioId;
            FechadateTimePicker.Value = usuario.Fecha;
            NombrestextBox.Text = usuario.Nombres;
            ApellidostextBox.Text = usuario.Apellidos;
            CedulamaskedTextBox.Text = usuario.Cedula;
            EmailtextBox.Text = usuario.Email;
            NombreUsuariotextBox.Text = usuario.NombreUsuario;
            ContrasenatextBox.Text = DesEncriptar(usuario.ClaveUsuario);
            TipoUsuariocomboBox.SelectedIndex = usuario.TipoUsuario;
            ActivocheckBox.Checked = usuario.Activo;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            Usuarios usuario = repositorio.Buscar((int)UsuarioIdnumericUpDown.Value);
            return usuario != null;
        }

        private bool Validar()
        {
            bool paso = true;
            MyerrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(NombrestextBox.Text))
            {
                MyerrorProvider.SetError(NombrestextBox, "El campo Nombres no puede estar vacio");
                NombrestextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(ApellidostextBox.Text))
            {
                MyerrorProvider.SetError(ApellidostextBox, "El campo Apellidos no puede estar vacio");
                ApellidostextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CedulamaskedTextBox.Text.Replace("-", "")))
            {
                MyerrorProvider.SetError(CedulamaskedTextBox, "El campo Cédula no puede estar vacio");
                CedulamaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(EmailtextBox.Text))
            {
                MyerrorProvider.SetError(EmailtextBox, "El campo Email no puede estar vacio");
                EmailtextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(NombreUsuariotextBox.Text))
            {
                MyerrorProvider.SetError(NombreUsuariotextBox, "El campo Nombre de Usuario no puede estar vacio");
                NombreUsuariotextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(ContrasenatextBox.Text))
            {
                MyerrorProvider.SetError(ContrasenatextBox, "El campo Contraseña no puede estar vacio");
                ContrasenatextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(TipoUsuariocomboBox.Text))
            {
                MyerrorProvider.SetError(TipoUsuariocomboBox, "El campo Tipo de Usuario no puede estar vacio");
                TipoUsuariocomboBox.Focus();
                paso = false;
            }

            return paso;
        }

        private string Encriptar(string cadenaAencriptar)//Esta función encripta una cadena que se le pasa por parámentro
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        private string DesEncriptar(string cadenaAdesencriptar)//Esta función desencripta la cadena que se le pasa por parámentro
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(cadenaAdesencriptar);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Usuarios usuario;
            UsuariosRepositorio repositorio = new UsuariosRepositorio();

            if (!Validar())
                return;

            usuario = LlenaClase();

            if (UsuarioIdnumericUpDown.Value == 0)
                paso = repositorio.Guardar(usuario);
            else
            {
                if(!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un usuario que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = repositorio.Modificar(usuario);
            }

            if(paso)
            {
                Limpiar();
                MessageBox.Show("¡Guardado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("¡No fue posible guardar!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id;
            UsuariosRepositorio repositorio = new UsuariosRepositorio();

            int.TryParse(Convert.ToString(UsuarioIdnumericUpDown.Value), out id);

            if (repositorio.Buscar(id) != null)
            {
                EliminarUsuariosVDForm EliminarVentanaDialogo = new EliminarUsuariosVDForm(id);
                EliminarVentanaDialogo.ShowDialog();
                Limpiar();
            }
            else
            {
                MyerrorProvider.SetError(UsuarioIdnumericUpDown, "No se puede eliminar o desactivar un usuario que no existe");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Usuarios usuario = new Usuarios();
            UsuariosRepositorio repositorio = new UsuariosRepositorio();

            int.TryParse(Convert.ToString(UsuarioIdnumericUpDown.Value), out id);

            Limpiar();

            usuario = repositorio.Buscar(id);

            if (usuario != null)
            {
                if (usuario.Activo)
                    LlenaCampos(usuario);
                else
                {
                    DialogResult resultado = MessageBox.Show("El cobrador se encuentra INACTIVO, ¿Desea buscarlo entre los usuarios INACTIVOS?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                        LlenaCampos(usuario);
                }
            }
            else
            {
                MessageBox.Show("Usuario no encontrado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActivocheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ActivocheckBox.Checked)
            {
                ActivocheckBox.Text = "ACTIVO";
                ActivocheckBox.ForeColor = Color.Green;
            }
            else
            {
                ActivocheckBox.Text = "INACTIVO";
                ActivocheckBox.ForeColor = Color.Red;
            }
        }

        private void RUsuariosForm_Load(object sender, EventArgs e)
        {
            ActivocheckBox.Checked = true;
        }
    }
}
