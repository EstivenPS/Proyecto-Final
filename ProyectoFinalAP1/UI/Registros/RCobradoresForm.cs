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
        public RCobradoresForm()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            CobradorIdnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            NombrestextBox.Text = string.Empty;
            ApellidostextBox.Text = string.Empty;
            DirecciontextBox.Text = string.Empty;
            CedulamaskedTextBox.Text = string.Empty;
            TelefonomaskedTextBox.Text = string.Empty;
            ActivocheckBox.Checked = false;
            MyerrorProvider.Clear();
        }

        private Cobradores LlenaClase()
        {
            Cobradores cobrador = new Cobradores();

            cobrador.CobradorId = (int)CobradorIdnumericUpDown.Value;
            cobrador.Fecha = FechadateTimePicker.Value;
            cobrador.Nombres = NombrestextBox.Text;
            cobrador.Apellidos = ApellidostextBox.Text;
            cobrador.Direccion = DirecciontextBox.Text;
            cobrador.Cedula = CedulamaskedTextBox.Text;
            cobrador.Telefono = TelefonomaskedTextBox.Text;
            cobrador.Activo = ActivocheckBox.Checked;

            return cobrador;
        }

        private void LlenaCampos(Cobradores cobrador)
        {
            CobradorIdnumericUpDown.Value = cobrador.CobradorId;
            FechadateTimePicker.Value = cobrador.Fecha;
            NombrestextBox.Text = cobrador.Nombres;
            ApellidostextBox.Text = cobrador.Apellidos;
            DirecciontextBox.Text = cobrador.Direccion;
            CedulamaskedTextBox.Text = cobrador.Cedula;
            TelefonomaskedTextBox.Text = cobrador.Telefono;
            ActivocheckBox.Checked = cobrador.Activo;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Cobradores> repositorio = new RepositorioBase<Cobradores>();
            Cobradores cobrador = repositorio.Buscar((int)CobradorIdnumericUpDown.Value);
            return cobrador != null;
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

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Cobradores cobrador;
            RepositorioBase<Cobradores> repositorio = new RepositorioBase<Cobradores>();

            if (!Validar())
                return;

            cobrador = LlenaClase();

            if (CobradorIdnumericUpDown.Value == 0)
                paso = repositorio.Guardar(cobrador);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un registro que no existe","Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            RepositorioBase<Cobradores> repositorio = new RepositorioBase<Cobradores>();

            int.TryParse(Convert.ToString(CobradorIdnumericUpDown.Value), out id);

            Limpiar();

            if (repositorio.Eliminar(id))
            {
                MessageBox.Show("¡Eliminado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MyerrorProvider.SetError(CobradorIdnumericUpDown, "No se puede eliminar un cobrador que no existe");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Cobradores cobrador = new Cobradores();
            RepositorioBase<Cobradores> repositorio = new RepositorioBase<Cobradores>();

            int.TryParse(Convert.ToString(CobradorIdnumericUpDown.Value), out id);

            Limpiar();

            cobrador = repositorio.Buscar(id);

            if (cobrador != null)
            {
                LlenaCampos(cobrador);
            }
            else
            {
                MessageBox.Show("Cobrador no encontrado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
