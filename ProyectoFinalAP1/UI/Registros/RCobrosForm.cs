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
        private Usuarios usuario { get; set; }

        public RCobrosForm(Usuarios usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        public void Limpiar()
        {
            CobroIdnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            PrestamoIdnumericUpDown.Value = 0;
            UsuarioIdnumericUpDown.Value = 0;
            NumeroCuotacomboBox.Text = string.Empty;
            MontotextBox.Text = "0.00";
        }

        public Cobros LlenaClase()
        {
            Cobros cobro = new Cobros();

            cobro.CobroId = (int)CobroIdnumericUpDown.Value;
            cobro.Fecha = FechadateTimePicker.Value;
            cobro.PrestamoId = (int)PrestamoIdnumericUpDown.Value;
            cobro.UsuarioId = (int)UsuarioIdnumericUpDown.Value;
            cobro.NumeroCuota = Convert.ToInt32(NumeroCuotacomboBox.Text);
            cobro.Monto = Convert.ToDecimal(MontotextBox.Text);

            return cobro;
        }

        public void LlenaCampos(Cobros cobro)
        {
            CobroIdnumericUpDown.Value = cobro.CobroId;
            FechadateTimePicker.Value = cobro.Fecha;
            PrestamoIdnumericUpDown.Value = cobro.PrestamoId;
            UsuarioIdnumericUpDown.Value = cobro.UsuarioId;
            NumeroCuotacomboBox.Text = Convert.ToString(cobro.NumeroCuota);
            MontotextBox.Text = Convert.ToString(cobro.Monto);
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

            if (UsuarioIdnumericUpDown.Value == 0)
            {
                MyerrorProvider.SetError(UsuarioIdnumericUpDown, "El campo Usuario Id no puede ser cero");
                UsuarioIdnumericUpDown.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(NumeroCuotacomboBox.Text))
            {
                MyerrorProvider.SetError(NumeroCuotacomboBox, "El campo Número de cuota no puede estar vacio");
                NumeroCuotacomboBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(MontotextBox.Text))
            {
                MyerrorProvider.SetError(MontotextBox, "El campo Monto no puede estar vacio");
                MontotextBox.Focus();
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
            CobrosRepositorio repositorio = new CobrosRepositorio();
            Cobros cobro = new Cobros();

            if (!Validar())
                return;

            if (!ValidarMonto())
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
                repositorio.CobrarCuota(cobro);

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
            CobrosRepositorio repositorio = new CobrosRepositorio();

            int.TryParse(Convert.ToString(CobroIdnumericUpDown.Value), out id);

            Limpiar();
            
            if(repositorio.Eliminar(id))
                MessageBox.Show("¡Eliminado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MyerrorProvider.SetError(CobroIdnumericUpDown, "No se puede eliminar un cobro que no existe");
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Cobros cobro = new Cobros();
            CobrosRepositorio repositorio = new CobrosRepositorio();

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

        private void PrestamoIdnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (PrestamoIdnumericUpDown.Value == 0)//Para que cuando se limpien los campos, no salte el ErrorProvider
                return;
            else
            {
                PrestamosRepositorio repositorio = new PrestamosRepositorio();
                Prestamos prestamo = new Prestamos();
                MyerrorProvider.Clear();

                prestamo = repositorio.Buscar((int)PrestamoIdnumericUpDown.Value);
                NumeroCuotacomboBox.Items.Clear();//Limpia todo lo que hay en el comboBox

                if (prestamo != null)
                {
                    foreach (var item in prestamo.Cuotas)
                    {
                        NumeroCuotacomboBox.Items.Add(item.NumeroCuota);
                    }
                }
                else
                {
                    MyerrorProvider.SetError(PrestamoIdnumericUpDown, "Este Prestamo no existe");
                }
            }
            
        }

        private void RCobrosForm_Load(object sender, EventArgs e)
        {
            UsuarioIdnumericUpDown.Value = usuario.UsuarioId;
        }

        private void SoloNumerosDecimales(KeyPressEventArgs e)//Metodo para hacer que un textBox solo admita numeros y la coma
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (e.KeyChar.ToString().Equals(","))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void MontotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumerosDecimales(e);
        }

        private bool ValidarMonto()
        {
            bool paso = true;
            MyerrorProvider.Clear();

            if(string.IsNullOrWhiteSpace(MontotextBox.Text))
                return (paso = false);
            else
            {
                PrestamosRepositorio repositorio = new PrestamosRepositorio();
                List<PrestamosDetalles> cuotas = repositorio.Buscar((int)PrestamoIdnumericUpDown.Value).Cuotas;

                foreach (var item in cuotas)
                {
                    if (item.NumeroCuota == Convert.ToInt32(NumeroCuotacomboBox.Text))
                    {
                        if (Convert.ToDecimal(MontotextBox.Text) > item.Balance)
                        {
                            MyerrorProvider.SetError(MontotextBox, "El monto no puede ser mayor que el balance de la cuota");
                            paso = false;
                        }
                    }
                }
            }

            return paso;
        }

        private void MontotextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
