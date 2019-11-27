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
    public partial class UsuariosReportViewer : Form
    {
        private List<Usuarios> ListaUsuarios;
        public UsuariosReportViewer(List<Usuarios> usuarios)
        {
            this.ListaUsuarios = usuarios;
            InitializeComponent();
        }

        private void UsuariosReportViewer_Load(object sender, EventArgs e)
        {
            ReporteUsuariosCrystalReport listadoUsuarios = new ReporteUsuariosCrystalReport();
            listadoUsuarios.SetDataSource(ListaUsuarios);

            MycrystalReportViewer.ReportSource = listadoUsuarios;
            MycrystalReportViewer.Refresh();
        }
    }
}
