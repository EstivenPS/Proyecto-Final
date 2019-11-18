using ProyectoFinalAP1.BLL;
using ProyectoFinalAP1.Entidades;
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
    public partial class RCobradoresForm : Form
    {
        private Usuarios usuario { get; set; }

        public RCobradoresForm(Usuarios usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        private void Limpiar()
        {
            CobradorIdnumericUpDown.Value = 0;
            UsuarioIdnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            NombrestextBox.Text = string.Empty;
            ApellidostextBox.Text = string.Empty;
            DirecciontextBox.Text = string.Empty;
            CedulamaskedTextBox.Text = string.Empty;
            TelefonomaskedTextBox.Text = string.Empty;
            EmailtextBox.Text = string.Empty;
            ActivocheckBox.Checked = true;
            MyerrorProvider.Clear();
        }

        private Cobradores LlenaClase()
        {
            Cobradores cobrador = new Cobradores();

            cobrador.CobradorId = (int)CobradorIdnumericUpDown.Value;
            cobrador.UsuarioId = (int)UsuarioIdnumericUpDown.Value;
            cobrador.Fecha = FechadateTimePicker.Value;
            cobrador.Nombres = NombrestextBox.Text;
            cobrador.Apellidos = ApellidostextBox.Text;
            cobrador.Direccion = DirecciontextBox.Text;
            cobrador.Cedula = CedulamaskedTextBox.Text;
            cobrador.Telefono = TelefonomaskedTextBox.Text;
            cobrador.Email = EmailtextBox.Text;
            cobrador.Activo = ActivocheckBox.Checked;

            return cobrador;
        }

        private void LlenaCampos(Cobradores cobrador)
        {
            CobradorIdnumericUpDown.Value = cobrador.CobradorId;
            UsuarioIdnumericUpDown.Value = cobrador.UsuarioId;
            FechadateTimePicker.Value = cobrador.Fecha;
            NombrestextBox.Text = cobrador.Nombres;
            ApellidostextBox.Text = cobrador.Apellidos;
            DirecciontextBox.Text = cobrador.Direccion;
            CedulamaskedTextBox.Text = cobrador.Cedula;
            TelefonomaskedTextBox.Text = cobrador.Telefono;
            EmailtextBox.Text = cobrador.Email;
            ActivocheckBox.Checked = cobrador.Activo;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            CobradoresRepositorio repositorio = new CobradoresRepositorio();
            Cobradores cobrador = repositorio.Buscar((int)CobradorIdnumericUpDown.Value);
            return (cobrador != null);
        }

        private bool Validar()
        {
            bool paso = true;
            MyerrorProvider.Clear();

            if (UsuarioIdnumericUpDown.Value == 0)
            {
                MyerrorProvider.SetError(UsuarioIdnumericUpDown, "El campo Usuario Id no puede ser cero");
                UsuarioIdnumericUpDown.Focus();
                paso = false;
            }

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

            if (string.IsNullOrWhiteSpace(DirecciontextBox.Text))
            {
                MyerrorProvider.SetError(DirecciontextBox, "El campo Dirección no puede estar vacio");
                DirecciontextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CedulamaskedTextBox.Text.Replace("-", "")))
            {
                MyerrorProvider.SetError(CedulamaskedTextBox, "El campo Cédula no puede estar vacio");
                CedulamaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(TelefonomaskedTextBox.Text.Replace("-", "")))
            {
                MyerrorProvider.SetError(TelefonomaskedTextBox, "El campo Teléfono no puede estar vacio");
                TelefonomaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(EmailtextBox.Text))
            {
                MyerrorProvider.SetError(EmailtextBox, "El campo Email no puede estar vacio");
                EmailtextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Cobradores cobrador;
            CobradoresRepositorio repositorio = new CobradoresRepositorio();

            if (!Validar())
                return;

            cobrador = LlenaClase();

            if (CobradorIdnumericUpDown.Value == 0)
                paso = repositorio.Guardar(cobrador);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un cobrador que no existe","Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = repositorio.Modificar(cobrador);
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
            CobradoresRepositorio repositorio = new CobradoresRepositorio();

            int.TryParse(Convert.ToString(CobradorIdnumericUpDown.Value), out id);

            if (repositorio.Buscar(id) != null)
            {
                EliminarCobradoresVDForm EliminarVentanaDialogo = new EliminarCobradoresVDForm(id);
                EliminarVentanaDialogo.ShowDialog();
                Limpiar();
            }
            else
            {
                MyerrorProvider.SetError(CobradorIdnumericUpDown, "No se puede eliminar o desactivar un cobrador que no existe");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Cobradores cobrador = new Cobradores();
            CobradoresRepositorio repositorio = new CobradoresRepositorio();

            int.TryParse(Convert.ToString(CobradorIdnumericUpDown.Value), out id);

            Limpiar();

            cobrador = repositorio.Buscar(id);

            if (cobrador != null)
            {
                if (cobrador.Activo)
                    LlenaCampos(cobrador);
                else
                {
                    DialogResult resultado = MessageBox.Show("El cobrador se encuentra INACTIVO, ¿Desea buscarlo entre los cobradores INACTIVOS?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                        LlenaCampos(cobrador);
                }
            }
            else
            {
                MessageBox.Show("Cobrador no encontrado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void RCobradoresForm_Load(object sender, EventArgs e)
        {
            UsuarioIdnumericUpDown.Value = usuario.UsuarioId;
            ActivocheckBox.Checked = true;
        }
    }
}
