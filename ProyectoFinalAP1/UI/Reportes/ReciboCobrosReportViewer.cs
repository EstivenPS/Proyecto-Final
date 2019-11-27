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

namespace ProyectoFinalAP1.UI.Reportes
{
    public partial class ReciboCobrosReportViewer : Form
    {
        List<Cobros> ListaCobros;
        public ReciboCobrosReportViewer(List<Cobros> cobros)
        {
            this.ListaCobros = cobros;
            InitializeComponent();
        }

        private void ReciboCobrosReportViewer_Load(object sender, EventArgs e)
        {
            ReporteReciboCobroCrystalReport cobro = new ReporteReciboCobroCrystalReport();
            cobro.SetDataSource(ListaCobros);

            MycrystalReportViewer.ReportSource = cobro;
            MycrystalReportViewer.Refresh();
        }
    }
}
