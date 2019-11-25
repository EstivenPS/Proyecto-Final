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

namespace ProyectoFinalAP1.UI.Reportes
{
    public partial class ClientesReportViewer : Form
    {
        private List<Clientes> ListaClientes;

        public ClientesReportViewer(List<Clientes> clientes)
        {
            this.ListaClientes = clientes;
            InitializeComponent();
        }

        private void ClientesReportViewer_Load(object sender, EventArgs e)
        {
            ReporteClientesCrystalReport listadoClientes = new ReporteClientesCrystalReport();
            listadoClientes.SetDataSource(ListaClientes);

            MycrystalReportViewer.ReportSource = listadoClientes;
            MycrystalReportViewer.Refresh();
        }
    }
}
