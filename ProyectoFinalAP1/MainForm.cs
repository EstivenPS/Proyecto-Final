using ProyectoFinalAP1.BLL;
using ProyectoFinalAP1.Entidades;
using ProyectoFinalAP1.UI;
using ProyectoFinalAP1.UI.Consultas;
using ProyectoFinalAP1.UI.Registros;
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

namespace ProyectoFinalAP1
{
    public partial class MainForm : Form
    {
        private Usuarios usuario { get; set; }
        private List<Prestamos> ListaPrestamos;
        private List<Cobros> ListaCobros;

        public MainForm(Usuarios usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        private void registroDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(usuario.TipoUsuario == 0)
            {
                RUsuariosForm ru = new RUsuariosForm();
                ru.MdiParent = this;
                ru.Show();
            }
            else
            {
                MessageBox.Show("Lo sentimos, no tienes permisos para acceder a este módulo", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void registroDeCobradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RCobradoresForm rcob = new RCobradoresForm(usuario);
            rcob.MdiParent = this;
            rcob.Show();
        }

        private void registroDePrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RPrestamosForm rp = new RPrestamosForm(usuario);
            rp.MdiParent = this;
            rp.Show();
        }

        private void registroDeCobrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RCobrosForm rco = new RCobrosForm(usuario);
            rco.MdiParent = this;
            rco.Show();
        }

        private void registroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RClientesForm rcli = new RClientesForm(usuario);
            rcli.MdiParent = this;
            rcli.Show();
        }

        private void consultaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CClientesForm ccl = new CClientesForm();
            ccl.MdiParent = this;
            ccl.Show();
        }

        private void consultaDeCobradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CCobradoresForm ccr = new CCobradoresForm();
            ccr.MdiParent = this;
            ccr.Show();
        }

        private void consultaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuario.TipoUsuario == 0)
            {
                CUsuariosForm cu = new CUsuariosForm();
                cu.MdiParent = this;
                cu.Show();
            }
            else
            {
                MessageBox.Show("Lo sentimos, no tienes permisos para acceder a este módulo", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
        private void consultaDePrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CPrestamosForm cpr = new CPrestamosForm();
            cpr.MdiParent = this;
            cpr.Show();
        }

        private void reporteDePréstamosDeHoyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrestamosRepositorio repositorio = new PrestamosRepositorio();

            ListaPrestamos = repositorio.GetList(p => p.Fecha == DateTime.Today).ToList();

            if (ListaPrestamos.Count == 0)
            {
                MessageBox.Show("No hay datos para imprimir");
                return;
            }

            PrestamosReportViewer prestamosReportViewer = new PrestamosReportViewer(ListaPrestamos);
            prestamosReportViewer.ShowDialog();
        }

        private void reporteDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CobrosRepositorio repositorio = new CobrosRepositorio();

            ListaCobros = repositorio.GetList(p => p.Fecha == DateTime.Today).ToList();

            if (ListaCobros.Count == 0)
            {
                MessageBox.Show("No hay datos para imprimir");
                return;
            }

            CobrosReportViewer cobrosReportViewer = new CobrosReportViewer(ListaCobros);
            cobrosReportViewer.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
