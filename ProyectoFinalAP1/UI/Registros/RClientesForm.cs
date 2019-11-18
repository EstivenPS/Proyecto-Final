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
    public partial class RClientesForm : Form
    {
        private Usuarios usuario { get; set; }

        public RClientesForm(Usuarios usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }
        
        private void Limpiar()
        {
            ClienteIdnumericUpDown.Value = 0;
            UsuarioIdnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            NombrestextBox.Text = string.Empty;
            ApellidostextBox.Text = string.Empty;
            CedulamaskedTextBox.Text = string.Empty;
            EmailtextBox.Text = string.Empty;
            TelefonomaskedTextBox.Text = string.Empty;
            CelularmaskedTextBox.Text = string.Empty;
            DirecciontextBox.Text = string.Empty;
            ActivocheckBox.Checked = true;
            BalancetextBox.Text = "0.00";
            MyerrorProvider.Clear();
        }

        private Clientes LlenaClase()
        {
            Clientes cliente = new Clientes();

            cliente.ClienteId = (int)ClienteIdnumericUpDown.Value;
            cliente.UsuarioId = (int)UsuarioIdnumericUpDown.Value;
            cliente.Fecha = FechadateTimePicker.Value;
            cliente.Nombres = NombrestextBox.Text;
            cliente.Apellidos = ApellidostextBox.Text;
            cliente.Cedula = CedulamaskedTextBox.Text;
            cliente.Email = EmailtextBox.Text;
            cliente.Telefono = TelefonomaskedTextBox.Text;
            cliente.Celular = CelularmaskedTextBox.Text;
            cliente.Direccion = DirecciontextBox.Text;
            cliente.Activo = ActivocheckBox.Checked;
            
            return cliente;
        }

        private void LlenaCampos(Clientes cliente)
        {
            ClienteIdnumericUpDown.Value = cliente.ClienteId;
            UsuarioIdnumericUpDown.Value = cliente.UsuarioId;
            FechadateTimePicker.Value = cliente.Fecha;
            NombrestextBox.Text = cliente.Nombres;
            ApellidostextBox.Text = cliente.Apellidos;
            CedulamaskedTextBox.Text = cliente.Cedula;
            EmailtextBox.Text = cliente.Email;
            TelefonomaskedTextBox.Text = cliente.Telefono;
            CelularmaskedTextBox.Text = cliente.Celular;
            DirecciontextBox.Text = cliente.Direccion;
            ActivocheckBox.Checked = cliente.Activo;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            ClientesRepositorio repositorio = new ClientesRepositorio();
            Clientes cliente = repositorio.Buscar((int)ClienteIdnumericUpDown.Value);
            return (cliente != null);
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

            if (string.IsNullOrWhiteSpace(EmailtextBox.Text))
            {
                MyerrorProvider.SetError(EmailtextBox, "El campo Email no puede estar vacio");
                EmailtextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(TelefonomaskedTextBox.Text.Replace("-", "")))
            {
                MyerrorProvider.SetError(TelefonomaskedTextBox, "El campo Teléfono no puede estar vacio");
                TelefonomaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CelularmaskedTextBox.Text.Replace("-", "")))
            {
                MyerrorProvider.SetError(CelularmaskedTextBox, "El campo Celular no puede estar vacio");
                CelularmaskedTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)//todo: (OPCIONAL) HACER QUE SE CALCULE Y SE PRESENTE EL BALANCE DEL CLIENTE EN BASE AL TOTAL DE TODOS LOS PRESTAMOS QUE NO HAYA PAGADO
        {
            bool paso = false;
            Clientes cliente;
            ClientesRepositorio repositorio = new ClientesRepositorio();

            if (!Validar())
                return;

            cliente = LlenaClase();

            if (ClienteIdnumericUpDown.Value == 0)
                paso = repositorio.Guardar(cliente);
            else
            {
                if(!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un cliente que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = repositorio.Modificar(cliente);
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
            ClientesRepositorio repositorio = new ClientesRepositorio();

            int.TryParse(Convert.ToString(ClienteIdnumericUpDown.Value), out id);

            if (repositorio.Buscar(id) != null)
            {
                EliminarClientesVDForm EliminarVentanaDialogo = new EliminarClientesVDForm(id);
                EliminarVentanaDialogo.ShowDialog();
                Limpiar();
            }
            else
            {
                MyerrorProvider.SetError(ClienteIdnumericUpDown, "No se puede eliminar o desactivar un cliente que no existe");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Clientes cliente = new Clientes(); 
            ClientesRepositorio repositorio = new ClientesRepositorio();

            int.TryParse(Convert.ToString(ClienteIdnumericUpDown.Value), out id);

            Limpiar();

            cliente = repositorio.Buscar(id);

            if (cliente != null)
            {
                if (cliente.Activo)
                    LlenaCampos(cliente);
                else
                {
                    DialogResult resultado = MessageBox.Show("El cliente se encuentra INACTIVO, ¿Desea buscarlo entre los clientes INACTIVOS?", "",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if(resultado == DialogResult.Yes)
                        LlenaCampos(cliente);
                }
            }
            else
            {
                MessageBox.Show("Cliente no encontrado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void RClientesForm_Load(object sender, EventArgs e)
        {
            UsuarioIdnumericUpDown.Value = usuario.UsuarioId;
            BalancetextBox.Text = "0.00";
            ActivocheckBox.Checked = true;
        }
    }
}
