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
    public partial class cClientes : Form
    {
        List<Clientes> listado = new List<Clientes>();

        public cClientes()
        {
            InitializeComponent();
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            ClientesRepositorio repositorio = new ClientesRepositorio();

            if (CriteriotextBox.Text.Trim().Length > 0)
            {
                switch (FiltrocomboBox.SelectedIndex)
                {
                    case 0://Todos
                        listado = repositorio.GetList(c => true);
                        break;

                    case 1://Id
                        int id = Convert.ToInt32(CriteriotextBox.Text);
                        listado = repositorio.GetList(c => c.ClienteId == id);
                        break;

                    case 2://Nombres
                        listado = repositorio.GetList(c => c.Nombres.Contains(CriteriotextBox.Text));
                        break;

                    case 3://Apellidos
                        listado = repositorio.GetList(c => c.Apellidos.Contains(CriteriotextBox.Text));
                        break;

                    case 4://Direccion
                        listado = repositorio.GetList(c => c.Direccion.Contains(CriteriotextBox.Text));
                        break;

                    case 5://Activo
                        listado = repositorio.GetList(c => true).Where(c => c.Activo == true).ToList();
                        break;

                    case 6://Inactivo
                        listado = repositorio.GetList(c => true).Where(c => c.Activo == false).ToList();
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

            ClientesReportViewer clientesReportViewer = new ClientesReportViewer(listado);
            clientesReportViewer.ShowDialog();
        }
    }
}
