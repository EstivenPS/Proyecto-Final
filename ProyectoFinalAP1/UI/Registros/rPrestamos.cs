using BLL;
using Entidades;
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
    public partial class rPrestamos : Form
    {
        private Usuarios usuario { get; set; }
        public List<PrestamosDetalles> Detalle { get; set; }

        public rPrestamos(Usuarios usuario)
        {
            this.usuario = usuario;
            this.Detalle = new List<PrestamosDetalles>();
            InitializeComponent();
        }

        private void Limpiar()
        {
            PrestamoIdnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            ClientecomboBox.Text = "Seleccione un cliente";
            CobradorcomboBox.Text = "Seleccione un cobrador";
            MontonumericUpDown.Value = 0;
            PorcientoInteresnumericUpDown.Value = 0;
            CantidadCuotasnumericUpDown.Value = 0;
            MyerrorProvider.Clear();

            this.Detalle = new List<PrestamosDetalles>();
            CargarGrid();
        }

        private Prestamos LlenaClase()
        {
            Prestamos prestamo = new Prestamos();

            prestamo.PrestamoId = (int)PrestamoIdnumericUpDown.Value;
            prestamo.UsuarioId = usuario.UsuarioId;
            prestamo.Fecha = FechadateTimePicker.Value;
            prestamo.ClienteId = Convert.ToInt32(ClientecomboBox.SelectedValue);
            prestamo.CobradorId = Convert.ToInt32(CobradorcomboBox.SelectedValue);
            prestamo.MontoPrestado = MontonumericUpDown.Value;
            prestamo.PorcientoInteres = PorcientoInteresnumericUpDown.Value;
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
            FechadateTimePicker.Value = prestamo.Fecha;
            ClientecomboBox.Text = repositorioCliente.Buscar(prestamo.ClienteId).Nombres;
            CobradorcomboBox.Text = repositorioCobrador.Buscar(prestamo.CobradorId).Nombres;
            MontonumericUpDown.Value = prestamo.MontoPrestado;
            PorcientoInteresnumericUpDown.Value = prestamo.PorcientoInteres;
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

            if (string.IsNullOrWhiteSpace(ClientecomboBox.Text) || ClientecomboBox.Text.Contains("Seleccione un cliente"))
            {
                MyerrorProvider.SetError(ClientecomboBox, "Debe seleccionar un cliente");
                ClientecomboBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CobradorcomboBox.Text) || CobradorcomboBox.Text.Contains("Seleccione un cobrador"))
            {
                MyerrorProvider.SetError(CobradorcomboBox, "Debe seleccionar un cobrador");
                CobradorcomboBox.Focus();
                paso = false;
            }

            if (MontonumericUpDown.Value == 0)
            {
                MyerrorProvider.SetError(MontonumericUpDown, "El campo Monto no puede ser cero");
                MontonumericUpDown.Focus();
                paso = false;
            }

            if (PorcientoInteresnumericUpDown.Value == 0)
            {
                MyerrorProvider.SetError(PorcientoInteresnumericUpDown, "El campo Porciento de interes no puede ser cero");
                PorcientoInteresnumericUpDown.Focus();
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
            this.Detalle = new List<PrestamosDetalles>();
            DateTime fecha = FechadateTimePicker.Value;//Se almacena la fecha en la que se registró el prestamo
            DetalledataGridView.DataSource = null;
            DetalledataGridView.Rows.Clear();//Limpia las filas del DataGridView

            for (int i = 1; i <= (int)CantidadCuotasnumericUpDown.Value; i++)
            {
                fecha = fecha.AddDays(7);

                this.Detalle.Add(
                    new PrestamosDetalles(
                        cuotaId: 0,
                        prestamoId: (int)PrestamoIdnumericUpDown.Value,
                        fecha: fecha, 
                        numerocuota: i,
                        capital: Math.Round((MontonumericUpDown.Value / CantidadCuotasnumericUpDown.Value), 2),
                        interes: Math.Round((Convert.ToDecimal(Intereslabel.Text) / CantidadCuotasnumericUpDown.Value), 2),
                        balance: Math.Round(((MontonumericUpDown.Value / CantidadCuotasnumericUpDown.Value) + (Convert.ToDecimal(Intereslabel.Text) / CantidadCuotasnumericUpDown.Value)), 2)
                        )
                    );
            }

            CargarGrid();
        }

        private void CargarGrid()
        {
            DetalledataGridView.DataSource = null;
            DetalledataGridView.Rows.Clear();//Borrar las filas del DataGridView

            foreach (var item in this.Detalle)
            {
                int n = DetalledataGridView.Rows.Add();
                DetalledataGridView.Rows[n].Cells[0].Value = item.NumeroCuota;
                DetalledataGridView.Rows[n].Cells[1].Value = item.Fecha.ToShortDateString(); //ToShortDateString devuelve una cadena de caracteres de la fecha en formato corto
                DetalledataGridView.Rows[n].Cells[2].Value = item.Capital;
                DetalledataGridView.Rows[n].Cells[3].Value = item.Interes;
                DetalledataGridView.Rows[n].Cells[4].Value = item.Balance;
            }
        }
        
        private void RPrestamosForm_Load(object sender, EventArgs e)
        {
            ClientesRepositorio repositorioClientes = new ClientesRepositorio();
            CobradoresRepositorio repositorioCobradores = new CobradoresRepositorio();
            List<Clientes> clientes = new List<Clientes>();
            List<Cobradores> cobradores = new List<Cobradores>();

            clientes = repositorioClientes.GetList(c => true).ToList();
            cobradores = repositorioCobradores.GetList(c => true).ToList();
            
            ClientecomboBox.DataSource = clientes;
            ClientecomboBox.DisplayMember = "Nombres";
            ClientecomboBox.ValueMember = "ClienteId";

            CobradorcomboBox.DataSource = cobradores;
            CobradorcomboBox.DisplayMember = "Nombres";
            CobradorcomboBox.ValueMember = "CobradorId";

            Usuariolabel.Text = usuario.NombreUsuario;
            ClientecomboBox.Text = "Seleccione un cliente";
            CobradorcomboBox.Text = "Seleccione un cobrador";
        }

        private void MontonumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if(MontonumericUpDown.Value == 0)
            {
                Balancelabel.Text = "0.00";
            }
            else
            {
                Intereslabel.Text = Convert.ToString(MontonumericUpDown.Value * (PorcientoInteresnumericUpDown.Value / 100));
                Balancelabel.Text = Convert.ToString(MontonumericUpDown.Value + Convert.ToDecimal(Intereslabel.Text));
            }
        }

        private void PorcientoInteresnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (PorcientoInteresnumericUpDown.Value == 0)
            {
                Intereslabel.Text = "0.00";
            }
            else
            {
                Intereslabel.Text = Convert.ToString(MontonumericUpDown.Value * (PorcientoInteresnumericUpDown.Value / 100));
                Balancelabel.Text = Convert.ToString(MontonumericUpDown.Value + Convert.ToDecimal(Intereslabel.Text));
            }
        }
    }
}
