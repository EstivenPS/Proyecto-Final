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

namespace ProyectoFinalAP1.UI.Consultas
{
    public partial class cCobros : Form
    {
        List<Cobros> listado = new List<Cobros>();

        public cCobros()
        {
            InitializeComponent();
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            CobrosRepositorio repositorio = new CobrosRepositorio();

            if (CriteriotextBox.Text.Trim().Length > 0)
            {
                switch (FiltrocomboBox.SelectedIndex)
                {
                    case 0://Todos
                        listado = repositorio.GetList(c => true);
                        break;

                    case 1://Id
                        int id = Convert.ToInt32(CriteriotextBox.Text);
                        listado = repositorio.GetList(c => c.CobroId == id);
                        break;

                    case 2://Prestamo Id
                        int prestamoId = Convert.ToInt32(CriteriotextBox.Text);
                        listado = repositorio.GetList(c => c.PrestamoId == prestamoId);
                        break;

                    case 3://Cliente
                        List<Clientes> clientes = new List<Clientes>();
                        ClientesRepositorio repositorioClientes = new ClientesRepositorio();

                        clientes = repositorioClientes.GetList(c => true);

                        foreach (var item in clientes)
                        {
                            if (item.Nombres.Contains(CriteriotextBox.Text))
                            {
                                listado = repositorio.GetList(c => c.ClienteId == item.ClienteId);
                                break;
                            }
                        }
                        break;

                    case 4://Número de cuota
                        int numeroCuota = Convert.ToInt32(CriteriotextBox.Text);
                        listado = repositorio.GetList(c => c.NumeroCuota == numeroCuota);
                        break;

                    case 5://Monto cobrado
                        decimal monto = Convert.ToDecimal(CriteriotextBox.Text);
                        listado = repositorio.GetList(c => c.Monto == monto);
                        break;
                }

                listado = listado.Where(c => c.Fecha.Date >= DesdedateTimePicker.Value.Date && c.Fecha.Date <= HastadateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = repositorio.GetList(c => true);
            }

            ConsultadataGridView.DataSource = null;
            ConsultadataGridView.DataSource = listado;
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if(listado.Count == 0)
            {
                MessageBox.Show("No hay datos para imprimir");
                return;
            }

            CobrosReportViewer cobrosReportViewer = new CobrosReportViewer(listado);
            cobrosReportViewer.ShowDialog();
        }
    }
}
