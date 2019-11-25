using ProyectoFinalAP1.BLL;
using ProyectoFinalAP1.Entidades;
using ProyectoFinalAP1.UI.Reportes;
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
    public partial class rCobros : Form
    {
        private Usuarios usuario { get; set; }

        public rCobros(Usuarios usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        public void Limpiar()
        {
            CobroIdnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            ClientecomboBox.Text = "Seleccione un cliente";
            PrestamoIdcomboBox.DataSource = null;
            PrestamoIdcomboBox.Text = string.Empty;
            NumeroCuotacomboBox.DataSource = null;
            NumeroCuotacomboBox.Text = string.Empty;
            BalanceCuotalabel.Text = "0.00";
            BalancePrestamolabel.Text = "0.00";
            MontonumericUpDown.Value = 0;
            PrestamoIdcomboBox.Enabled = false;
            NumeroCuotacomboBox.Enabled = false;
            MontonumericUpDown.Enabled = false;
            MyerrorProvider.Clear();
        }

        public Cobros LlenaClase()
        {
            Cobros cobro = new Cobros();

            cobro.CobroId = (int)CobroIdnumericUpDown.Value;
            cobro.Fecha = FechadateTimePicker.Value;
            cobro.ClienteId = Convert.ToInt32(ClientecomboBox.SelectedValue);
            cobro.PrestamoId = Convert.ToInt32(PrestamoIdcomboBox.SelectedValue);
            cobro.UsuarioId = usuario.UsuarioId;
            cobro.NumeroCuota = Convert.ToInt32(NumeroCuotacomboBox.Text);
            cobro.Monto = MontonumericUpDown.Value;

            return cobro;
        }

        public void LlenaCampos(Cobros cobro)
        {
            List<PrestamosDetalles> ListaCuotas = new List<PrestamosDetalles>();
            PrestamosRepositorio repositorioPrestamo = new PrestamosRepositorio();
            ClientesRepositorio repositorioClientes = new ClientesRepositorio();
            RepositorioBase<PrestamosDetalles> repositorioCuotas = new RepositorioBase<PrestamosDetalles>();

            CobroIdnumericUpDown.Value = cobro.CobroId;
            FechadateTimePicker.Value = cobro.Fecha;
            ClientecomboBox.Text = repositorioClientes.Buscar(Convert.ToInt32(cobro.ClienteId)).Nombres;
            PrestamoIdcomboBox.Text = Convert.ToString(cobro.PrestamoId);
            NumeroCuotacomboBox.Text = Convert.ToString(cobro.NumeroCuota);
            BalancePrestamolabel.Text = Convert.ToString(repositorioPrestamo.Buscar(cobro.PrestamoId).Balance);
            MontonumericUpDown.Value = cobro.Monto;

            ListaCuotas = repositorioCuotas.GetList(p => true).Where(p => p.PrestamoId == cobro.PrestamoId && p.NumeroCuota == cobro.NumeroCuota).ToList();

            foreach (var item in ListaCuotas)
            {
                BalanceCuotalabel.Text = Convert.ToString(item.Balance);
            }
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

            if (string.IsNullOrWhiteSpace(ClientecomboBox.Text) || ClientecomboBox.Text.Contains("Seleccione un cliente"))
            {
                MyerrorProvider.SetError(ClientecomboBox, "Debe seleccionar un cliente");
                ClientecomboBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(PrestamoIdcomboBox.Text))
            {
                MyerrorProvider.SetError(PrestamoIdcomboBox, "Debe seleccionar un prestamo id");
                PrestamoIdcomboBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(NumeroCuotacomboBox.Text))
            {
                MyerrorProvider.SetError(NumeroCuotacomboBox, "Debe seleccionar un número de cuota");
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
            CobrosRepositorio repositorio = new CobrosRepositorio();
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
                if (!repositorio.CobrarCuota(cobro))
                    MessageBox.Show("¡A ocurrido un error!");

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

        private void RCobrosForm_Load(object sender, EventArgs e)
        {
            ClientesRepositorio repositorioClientes = new ClientesRepositorio();
            List<Clientes> clientes = new List<Clientes>();

            clientes = repositorioClientes.GetList(c => true);

            ClientecomboBox.DataSource = clientes;
            ClientecomboBox.DisplayMember = "Nombres";
            ClientecomboBox.ValueMember = "ClienteId";

            Usuariolabel.Text = usuario.NombreUsuario;
            ClientecomboBox.Text = "Seleccione un cliente";
            PrestamoIdcomboBox.Enabled = false;
            NumeroCuotacomboBox.Enabled = false;
            MontonumericUpDown.Enabled = false;
        }

        private void ClientecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrestamosRepositorio repositorioPrestamos = new PrestamosRepositorio();
            List<Prestamos> prestamos = new List<Prestamos>();
            int ClienteId;

            int.TryParse(ClientecomboBox.SelectedValue.ToString(), out ClienteId);

            prestamos = repositorioPrestamos.GetList(p => p.ClienteId == ClienteId);

            PrestamoIdcomboBox.DataSource = prestamos;
            PrestamoIdcomboBox.DisplayMember = "PrestamoId";
            PrestamoIdcomboBox.ValueMember = "PrestamoId";
            PrestamoIdcomboBox.Text = string.Empty;
            PrestamoIdcomboBox.Enabled = true;
        }

        private void PrestamoIdcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClientecomboBox.Text != "Seleccione un cliente" && PrestamoIdcomboBox.Enabled)
            {
                RepositorioBase<PrestamosDetalles> repositorio = new RepositorioBase<PrestamosDetalles>();
                PrestamosRepositorio repositorioPrestamos = new PrestamosRepositorio();
                List<PrestamosDetalles> cuotas = new List<PrestamosDetalles>();
                List<Prestamos> ListaPrestamos = new List<Prestamos>();
                int id;

                int.TryParse(PrestamoIdcomboBox.SelectedValue.ToString(), out id);
                cuotas = repositorio.GetList(c => c.PrestamoId == id);

                //Uso el GetList debido a que es el único que conozco que me permite aplicar condiciones a la hora de buscar registros
                ListaPrestamos = repositorioPrestamos.GetList(p => true).Where(p => p.PrestamoId == id).ToList();

                //Uso el foreach para poder sacar el único elemento que tendrá la lista enlazada, el cual es la cuota seleccionada
                foreach (var item in ListaPrestamos)
                {
                    BalancePrestamolabel.Text = Convert.ToString(item.Balance);
                }

                NumeroCuotacomboBox.DataSource = cuotas;
                NumeroCuotacomboBox.DisplayMember = "NumeroCuota";
                NumeroCuotacomboBox.ValueMember = "CuotaId";
                NumeroCuotacomboBox.Text = string.Empty;
                NumeroCuotacomboBox.Enabled = true;
            }
        }
        
        private void NumeroCuotacomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (ClientecomboBox.Text != "Seleccione un cliente" && PrestamoIdcomboBox.SelectedIndex != 0 && NumeroCuotacomboBox.SelectedIndex != 0)
            if (ClientecomboBox.Text != "Seleccione un cliente" && PrestamoIdcomboBox.Enabled && NumeroCuotacomboBox.Enabled)
            {
                RepositorioBase<PrestamosDetalles> repositorio = new RepositorioBase<PrestamosDetalles>();
                List<PrestamosDetalles> ListaCuotas = new List<PrestamosDetalles>();
                PrestamosDetalles cuota = new PrestamosDetalles();
                int CuotaId, PrestamoId, NumeroCuota;

                int.TryParse(NumeroCuotacomboBox.SelectedValue.ToString(), out CuotaId);
                int.TryParse(PrestamoIdcomboBox.SelectedValue.ToString(), out PrestamoId);
                int.TryParse(NumeroCuotacomboBox.Text, out NumeroCuota);
                cuota = repositorio.Buscar(CuotaId);
                BalanceCuotalabel.Text = Convert.ToString(cuota.Balance);
                
                //Uso el GetList debido a que es el único que conozco que me permite aplicar condiciones a la hora de buscar registros
                ListaCuotas = repositorio.GetList(p => true).Where(p => p.PrestamoId == PrestamoId && p.NumeroCuota == NumeroCuota).ToList();

                //Uso el foreach para poder sacar el único elemento que tendrá la lista enlazada, el cual es la cuota seleccionada
                foreach (var item in ListaCuotas)
                {
                    BalanceCuotalabel.Text = Convert.ToString(item.Balance);
                }

                MontonumericUpDown.Enabled = true;
            }
        }
        
        private void MontonumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            MyerrorProvider.Clear();

            if (MontonumericUpDown.Value > Convert.ToDecimal(BalanceCuotalabel.Text) && MontonumericUpDown.Enabled == true)
            {
                MyerrorProvider.SetError(MontonumericUpDown, "El monto del cobro no puede ser mayor que el balance de la cuota seleccionada");
            }
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if (CobroIdnumericUpDown.Value != 0)
            {
                CobrosRepositorio repositorio = new CobrosRepositorio();
                List<Cobros> cobros = new List<Cobros>();

                cobros = repositorio.GetList(c => true).Where(c => c.CobroId == CobroIdnumericUpDown.Value).ToList();

                ReciboCobrosReportViewer reciboReportViewer = new ReciboCobrosReportViewer(cobros);
                reciboReportViewer.ShowDialog();
            }
            else
            {
                MessageBox.Show("Para poder imprimir un recibo, primero debe buscar un registro");
                return;
            }
        }
    }
}