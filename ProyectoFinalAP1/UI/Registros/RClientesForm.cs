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
        public RClientesForm()
        {
            InitializeComponent();
        }
        
        private void Limpiar()
        {
            ClienteIdnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            NombrestextBox.Text = string.Empty;
            ApellidostextBox.Text = string.Empty;
            CedulamaskedTextBox.Text = string.Empty;
            TelefonomaskedTextBox.Text = string.Empty;
            DirecciontextBox.Text = string.Empty;
            ActivocheckBox.Checked = false;
            BalancetextBox.Text = "0.00";
            MyerrorProvider.Clear();
        }

        private Clientes LlenaClase()
        {
            Clientes cliente = new Clientes();

            cliente.ClienteId = (int)ClienteIdnumericUpDown.Value;
            cliente.Fecha = FechadateTimePicker.Value;
            cliente.Nombres = NombrestextBox.Text;
            cliente.Apellidos = ApellidostextBox.Text;
            cliente.Cedula = CedulamaskedTextBox.Text;
            cliente.Telefono = TelefonomaskedTextBox.Text;
            cliente.Direccion = DirecciontextBox.Text;
            cliente.Activo = ActivocheckBox.Checked;
            
            return cliente;
        }

        private void LlenaCampos(Clientes cliente)
        {
            ClienteIdnumericUpDown.Value = cliente.ClienteId;
            FechadateTimePicker.Value = cliente.Fecha;
            NombrestextBox.Text = cliente.Nombres;
            ApellidostextBox.Text = cliente.Apellidos;
            CedulamaskedTextBox.Text = cliente.Cedula;
            TelefonomaskedTextBox.Text = cliente.Telefono;
            DirecciontextBox.Text = cliente.Direccion;
            ActivocheckBox.Checked = cliente.Activo;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
            Clientes cliente = repositorio.Buscar((int)ClienteIdnumericUpDown.Value);
            return cliente != null;
        }

        private bool Validar()
        {
            bool paso = true;

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
                MyerrorProvider.SetError(DirecciontextBox, "El campo Direccion no puede estar vacio");
                DirecciontextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CedulamaskedTextBox.Text.Replace(' ', '-')))
            {
                MyerrorProvider.SetError(CedulamaskedTextBox, "El campo Cedula no puede estar vacio");
                CedulamaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(TelefonomaskedTextBox.Text))
            {
                MyerrorProvider.SetError(TelefonomaskedTextBox, "El campo Telefono no puede estar vacio");
                TelefonomaskedTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)//todo: HACER QUE SE CALCULE Y SE PRESENTE EL BALANCE DEL CLIENTE EN BASE AL TOTAL DE TODOS LOS PRESTAMOS QUE HAYA TOMADO
        {
            bool paso = false;
            Clientes cliente;
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();

            if (!Validar())
                return;

            cliente = LlenaClase();

            if (ClienteIdnumericUpDown.Value == 0)
                paso = repositorio.Guardar(cliente);
            else
            {
                if(!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un cliene que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            RepositorioBase<Cobradores> repositorio = new RepositorioBase<Cobradores>();

            int.TryParse(Convert.ToString(ClienteIdnumericUpDown.Value), out id);

            Limpiar();

            if (repositorio.Eliminar(id))
            {
                MessageBox.Show("¡Eliminado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MyerrorProvider.SetError(ClienteIdnumericUpDown, "No se puede eliminar un cliente que no existe");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Clientes cliente = new Clientes();
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();

            int.TryParse(Convert.ToString(ClienteIdnumericUpDown.Value), out id);

            Limpiar();

            cliente = repositorio.Buscar(id);

            if (cliente != null)
            {
                LlenaCampos(cliente);
            }
            else
            {
                MessageBox.Show("Cliente no encontrado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ActivocheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ActivocheckBox.Checked)
                ActivocheckBox.ForeColor = Color.Green;
            else
                ActivocheckBox.ForeColor = Color.Red;
        }
    }
}
