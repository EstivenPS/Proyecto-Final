using BLL;
using Entidades;
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
    public partial class cPrestamos : Form
    {
        List<Prestamos> listado = new List<Prestamos>();

        public cPrestamos()
        {
            InitializeComponent();
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            PrestamosRepositorio repositorio = new PrestamosRepositorio();

            if (CriteriotextBox.Text.Trim().Length > 0)
            {
                switch (FiltrocomboBox.SelectedIndex)
                {
                    case 0://Todos
                        listado = repositorio.GetList(c => true);
                        break;

                    case 1://Prestamo Id
                        int id = Convert.ToInt32(CriteriotextBox.Text);
                        listado = repositorio.GetList(c => c.ClienteId == id);
                        break;

                    case 2://Cliente
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

                    case 3://Cobrador
                        List<Cobradores> cobradores = new List<Cobradores>();
                        CobradoresRepositorio repositorioCobradores = new CobradoresRepositorio();

                        cobradores = repositorioCobradores.GetList(c => true);

                        foreach (var item in cobradores)
                        {
                            if (item.Nombres.Contains(CriteriotextBox.Text))
                            {
                                listado = repositorio.GetList(c => c.CobradorId == item.CobradorId);
                                break;
                            }
                        }
                        break;

                    case 4://Cantidad de cuotas
                        int cantidadCuotas = Convert.ToInt32(CriteriotextBox.Text);
                        listado = repositorio.GetList(c => c.CantidadCuotas == cantidadCuotas);
                        break;

                    case 5://Balance
                        decimal balance = Convert.ToDecimal(CriteriotextBox.Text);
                        listado = repositorio.GetList(c => c.Balance == balance);
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

            PrestamosReportViewer prestamosReportViewer = new PrestamosReportViewer(listado);
            prestamosReportViewer.ShowDialog();
        }
    }
}
