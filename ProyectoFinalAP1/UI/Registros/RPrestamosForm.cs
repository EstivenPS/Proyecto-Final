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
    public partial class RPrestamosForm : Form
    {
        private Usuarios usuario { get; set; }
        public List<PrestamosDetalles> Detalle { get; set; }

        public RPrestamosForm(Usuarios usuario)
        {
            this.usuario = usuario;
            this.Detalle = new List<PrestamosDetalles>();
            InitializeComponent();
        }

        private void Limpiar()
        {
            PrestamoIdnumericUpDown.Value = 0;
            UsuarioIdnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            ClientecomboBox.Text = string.Empty;
            CobradorcomboBox.Text = string.Empty;
            MontotextBox.Text = "0.00";
            CantidadCuotasnumericUpDown.Value = 0;
            MyerrorProvider.Clear();

            this.Detalle = new List<PrestamosDetalles>();
            CargarGrid();
        }

        private Prestamos LlenaClase()
        {
            Prestamos prestamo = new Prestamos();

            prestamo.PrestamoId = (int)PrestamoIdnumericUpDown.Value;
            prestamo.UsuarioId = (int)UsuarioIdnumericUpDown.Value;
            prestamo.Fecha = FechadateTimePicker.Value;
            prestamo.ClienteId = Convert.ToInt32(ClientecomboBox.SelectedValue);
            prestamo.CobradorId = Convert.ToInt32(CobradorcomboBox.SelectedValue);
            prestamo.MontoPrestado = Convert.ToDecimal(MontotextBox.Text);
            prestamo.Interes = Convert.ToDecimal(Intereslabel.Text);
            prestamo.Balance = Convert.ToDecimal(Balancelabel.Text);
            prestamo.CantidadCuotas = Convert.ToInt32(CantidadCuotasnumericUpDown.Value);
            
            prestamo.Cuotas = this.Detalle;

            return prestamo;
        }

        private void LlenaCampos(Prestamos prestamo)
        {
            ClientesRepositorio repositorioCliente = new ClientesRepositorio();
            CobradoresRepositorio repositorioCobrador = new CobradoresRepositorio();

            PrestamoIdnumericUpDown.Value = prestamo.PrestamoId;
            UsuarioIdnumericUpDown.Value = prestamo.UsuarioId;
            FechadateTimePicker.Value = prestamo.Fecha;
            ClientecomboBox.Text = repositorioCliente.Buscar(prestamo.ClienteId).Nombres;
            CobradorcomboBox.Text = repositorioCobrador.Buscar(prestamo.CobradorId).Nombres;
            MontotextBox.Text = Convert.ToString(prestamo.MontoPrestado);
            CantidadCuotasnumericUpDown.Value = prestamo.CantidadCuotas;
            MyerrorProvider.Clear();

            this.Detalle = prestamo.Cuotas;
            CargarGrid();
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            PrestamosRepositorio repositorio = new PrestamosRepositorio();
            Prestamos prestamo = repositorio.Buscar((int)PrestamoIdnumericUpDown.Value);
            return (prestamo != null);
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

            if (string.IsNullOrWhiteSpace(ClientecomboBox.Text))
            {
                MyerrorProvider.SetError(ClientecomboBox, "Debe seleccionar un cliente");
                ClientecomboBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CobradorcomboBox.Text))
            {
                MyerrorProvider.SetError(CobradorcomboBox, "Debe seleccionar un cobrador");
                CobradorcomboBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(MontotextBox.Text))
            {
                MyerrorProvider.SetError(MontotextBox, "El campo Monto no puede estar vacio");
                MontotextBox.Focus();
                paso = false;
            }

            if (CantidadCuotasnumericUpDown.Value == 0)
            {
                MyerrorProvider.SetError(CantidadCuotasnumericUpDown, "El campo Cantidad de cuotas no puede ser cero");
                CantidadCuotasnumericUpDown.Focus();
                paso = false;
            }

            if (this.Detalle.Count() == 0)
            {
                MyerrorProvider.SetError(CalcularCuotasbutton, "Debe calcular las cuotas");
                CalcularCuotasbutton.Focus();
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
            Prestamos prestamo;
            PrestamosRepositorio repositorio = new PrestamosRepositorio();

            if (!Validar())
                return;

            prestamo = LlenaClase();

            if (PrestamoIdnumericUpDown.Value == 0)
                paso = repositorio.Guardar(prestamo);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un prestamo que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = repositorio.Modificar(prestamo);
            }

            if (paso)
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
            PrestamosRepositorio repositorio = new PrestamosRepositorio();

            int.TryParse(Convert.ToString(PrestamoIdnumericUpDown.Value), out id);

            Limpiar();

            if (repositorio.Eliminar(id))
            {
                MessageBox.Show("¡Eliminado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MyerrorProvider.SetError(PrestamoIdnumericUpDown, "No se puede eliminar un prestamo que no existe");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Prestamos prestamo = new Prestamos();
            PrestamosRepositorio repositorio = new PrestamosRepositorio();

            int.TryParse(Convert.ToString(PrestamoIdnumericUpDown.Value), out id);

            Limpiar();

            prestamo = repositorio.Buscar(id);

            if (prestamo != null)
            {
                LlenaCampos(prestamo);
            }
            else
            {
                MessageBox.Show("Prestamo no encontrado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalcularCuotasbutton_Click(object sender, EventArgs e)
        {
            DateTime fecha = FechadateTimePicker.Value;//Se almacena la fecha en la que se registró el prestamo

            //if (DetalledataGridView.DataSource != null)
            //  this.Detalle = (List<PrestamosDetalles>)DetalledataGridView.DataSource;

            DetalledataGridView.Rows.Clear();//Limpia las filas del DataGridView

            for (int i = 0; i < (int)CantidadCuotasnumericUpDown.Value; i++)
            {

                this.Detalle.Add(
                    new PrestamosDetalles(
                        cuotaId: 0,
                        prestamoId: 0,
                        fecha: fecha,
                        numerocuota: i + 1,
                        capital: Convert.ToDecimal(MontotextBox.Text) / CantidadCuotasnumericUpDown.Value,
                        interes: Convert.ToDecimal(Intereslabel.Text) / CantidadCuotasnumericUpDown.Value,
                        balance: (Convert.ToDecimal(MontotextBox.Text) / CantidadCuotasnumericUpDown.Value) + (Convert.ToDecimal(Intereslabel.Text) / CantidadCuotasnumericUpDown.Value)
                        )
                    );
            }

            CargarGrid();
        }

        private void CargarGrid()
        {
            DetalledataGridView.DataSource = null;
            DetalledataGridView.Rows.Clear();//Limpia las filas del DataGridView

            foreach (var item in this.Detalle)
            {
                int n = DetalledataGridView.Rows.Add();
                DetalledataGridView.Rows[n].Cells[0].Value = item.NumeroCuota;
                DetalledataGridView.Rows[n].Cells[1].Value = item.Fecha;
                DetalledataGridView.Rows[n].Cells[2].Value = item.Capital;
                DetalledataGridView.Rows[n].Cells[3].Value = item.Interes;
                DetalledataGridView.Rows[n].Cells[4].Value = item.Balance;
            }
        }

        private void MontotextBox_TextChanged(object sender, EventArgs e)
        {
            if(MontotextBox.Text == "")
            {
                return;
            }
            else if (Convert.ToDecimal(MontotextBox.Text) == 0)
            {
                Intereslabel.Text = "0.00";
                Balancelabel.Text = "0.00";
            }
            else
            {
                Intereslabel.Text = Convert.ToString(Convert.ToDecimal(MontotextBox.Text) * Convert.ToDecimal(0.05));
                Balancelabel.Text = Convert.ToString(Convert.ToDecimal(MontotextBox.Text) + Convert.ToDecimal(Intereslabel.Text));
            }
        }

        private void RPrestamosForm_Load(object sender, EventArgs e)
        {
            ClientesRepositorio repositorioClientes = new ClientesRepositorio();
            CobradoresRepositorio repositorioCobradores = new CobradoresRepositorio();
            List<Clientes> clientes = new List<Clientes>();
            List<Cobradores> cobradores = new List<Cobradores>();

            clientes = repositorioClientes.GetList(p => true).ToList();
            cobradores = repositorioCobradores.GetList(p => true).ToList();
            
            ClientecomboBox.DataSource = clientes;
            ClientecomboBox.DisplayMember = "Nombres";
            ClientecomboBox.ValueMember = "ClienteId";

            CobradorcomboBox.DataSource = cobradores;
            CobradorcomboBox.DisplayMember = "Nombres";
            CobradorcomboBox.ValueMember = "CobradorId";

            UsuarioIdnumericUpDown.Value = usuario.UsuarioId;
            MontotextBox.Text = "0.00";
            ClientecomboBox.Text = "Seleccione un cliente";
            CobradorcomboBox.Text = "Seleccione un cobrador";
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
    }
}
