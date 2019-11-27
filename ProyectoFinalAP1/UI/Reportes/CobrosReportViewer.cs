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
    public partial class CobrosReportViewer : Form
    {
        public List<Cobros> ListaCobros;

        public CobrosReportViewer(List<Cobros> cobros)
        {
            this.ListaCobros = cobros;
            InitializeComponent();
        }

        private void CobrosReportViewer_Load(object sender, EventArgs e)
        {
            ReporteCobrosCrystalReport listadoCobros = new ReporteCobrosCrystalReport();
            listadoCobros.SetDataSource(ListaCobros);

            MycrystalReportViewer.ReportSource = listadoCobros;
            MycrystalReportViewer.Refresh();
        }
    }
}
