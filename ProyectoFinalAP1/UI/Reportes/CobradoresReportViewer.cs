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
    public partial class CobradoresReportViewer : Form
    {
        private List<Cobradores> ListaCobradores;

        public CobradoresReportViewer(List<Cobradores> cobradores)
        {
            this.ListaCobradores = cobradores;
            InitializeComponent();
        }

        private void CobradoresReportViewer_Load(object sender, EventArgs e)
        {
            ReportesCobradoresCrystalReport listadoCobradores = new ReportesCobradoresCrystalReport();
            listadoCobradores.SetDataSource(ListaCobradores);

            MycrystalReportViewer.ReportSource = listadoCobradores;
            MycrystalReportViewer.Refresh();
        }
    }
}
