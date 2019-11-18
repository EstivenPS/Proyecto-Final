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
    public partial class RCobrosForm : Form
    {
        public RCobrosForm()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            CobroIdnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            PrestamoIdnumericUpDown.Value = 0;
            UsuarioIdnumericUpDown.Value = 0;
            NumeroCuotacomboBox.Text = string.Empty;
            MontonumericUpDown.Value = 0;
        }

        public Cobros LlenaClase()
        {
            Cobros cobro = new Cobros();

            cobro.CobroId = (int)CobroIdnumericUpDown.Value;
            cobro.Fecha = FechadateTimePicker.Value;
            cobro.PrestamoId = (int)PrestamoIdnumericUpDown.Value;
            cobro.UsuarioId = (int)UsuarioIdnumericUpDown.Value;
            cobro.NumeroCuota = Convert.ToInt32(NumeroCuotacomboBox.Text);
            cobro.Monto = MontonumericUpDown.Value;

            return cobro;
        }

        public void LlenaCampos(Cobros cobro)
        {
            CobroIdnumericUpDown.Value = cobro.CobroId;
            FechadateTimePicker.Value = cobro.Fecha;
            PrestamoIdnumericUpDown.Value = cobro.PrestamoId;
            UsuarioIdnumericUpDown.Value = cobro.UsuarioId;
            NumeroCuotacomboBox.Text = Convert.ToString(cobro.NumeroCuota);
            MontonumericUpDown.Value = cobro.Monto;
        }

        public bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Cobros> repositorio = new RepositorioBase<Cobros>();
            Cobros cobro = repositorio.Buscar((int)CobroIdnumericUpDown.Value);
            return (cobro != null);
        }

        public bool Validar()
        {
            bool paso = true;

            if(PrestamoIdnumericUpDown.Value == 0)
            {
                MyerrorProvider.SetError(PrestamoIdnumericUpDown, "El campo Prestamo Id no puede ser cero");
                PrestamoIdnumericUpDown.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(NumeroCuotacomboBox.Text))
            {
                MyerrorProvider.SetError(NumeroCuotacomboBox, "El campo Número de cuota no puede estar vacio");
                NumeroCuotacomboBox.Focus();
                paso = false;
            }

            if (MontonumericUpDown.Value == 0)
            {
                MyerrorProvider.SetError(MontonumericUpDown, "El campo Monto no puede ser cero");
                MontonumericUpDown.Focus();
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
            RepositorioBase<Cobros> repositorio = new RepositorioBase<Cobros>();
            Cobros cobro = new Cobros();

            if (!Validar())
                return;

            cobro = LlenaClase();

            if (CobroIdnumericUpDown.Value == 0)
                paso = repositorio.Guardar(cobro);
            else
            {
                if(!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un cobro que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = repositorio.Modificar(cobro);
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
            RepositorioBase<Cobros> repositorio = new RepositorioBase<Cobros>();

            int.TryParse(Convert.ToString(CobroIdnumericUpDown.Value), out id);

            Limpiar();
            
            if(repositorio.Eliminar(id))
            {
                MessageBox.Show("¡Eliminado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MyerrorProvider.SetError(CobroIdnumericUpDown, "No se puede eliminar un cobro que no existe");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Cobros cobro = new Cobros();
            RepositorioBase<Cobros> repositorio = new RepositorioBase<Cobros>();

            int.TryParse(Convert.ToString(CobroIdnumericUpDown.Value), out id);

            Limpiar();

            cobro = repositorio.Buscar(id);

            if(cobro != null)
            {
                LlenaCampos(cobro);
            }
            else
            {
                MessageBox.Show("Cobro no encontrado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
