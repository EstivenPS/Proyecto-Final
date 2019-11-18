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
    public partial class PrestamosReportViewer : Form
    {
        public List<Prestamos> ListaPrestamos;

        public PrestamosReportViewer(List<Prestamos> prestamos)
        {
            this.ListaPrestamos = prestamos;
            InitializeComponent();
        }

        private void PrestamosReportViewer_Load(object sender, EventArgs e)
        {
            ReportePrestamosCrystalReport listadoPrestamos = new ReportePrestamosCrystalReport();
            listadoPrestamos.SetDataSource(ListaPrestamos);

            MycrystalReportViewer.ReportSource = listadoPrestamos;
            MycrystalReportViewer.Refresh();
        }
    }
}
