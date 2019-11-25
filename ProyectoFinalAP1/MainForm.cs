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
        
        private void registroDeCobradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCobradores rcob = new rCobradores(usuario);
            rcob.MdiParent = this;
            rcob.Show();
        }

        private void registroDePrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rPrestamos rp = new rPrestamos(usuario);
            rp.MdiParent = this;
            rp.Show();
        }

        private void registroDeCobrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCobros rco = new rCobros(usuario);
            rco.MdiParent = this;
            rco.Show();
        }

        private void registroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rClientes rcli = new rClientes(usuario);
            rcli.MdiParent = this;
            rcli.Show();
        }

        private void consultaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cClientes ccl = new cClientes();
            ccl.MdiParent = this;
            ccl.Show();
        }

        private void consultaDeCobradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cCobradores ccr = new cCobradores();
            ccr.MdiParent = this;
            ccr.Show();
        }
        
        private void consultaDePrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cPrestamos cpr = new cPrestamos();
            cpr.MdiParent = this;
            cpr.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registroDeUsuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (usuario.TipoUsuario == 0)
            {
                rUsuarios ru = new rUsuarios();
                ru.MdiParent = this;
                ru.Show();
            }
            else
            {
                MessageBox.Show("Lo sentimos, no tienes permisos para acceder a este módulo", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void consultaDeUsuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (usuario.TipoUsuario == 0)
            {
                cUsuarios cu = new cUsuarios();
                cu.MdiParent = this;
                cu.Show();
            }
            else
            {
                MessageBox.Show("Lo sentimos, no tienes permisos para acceder a este módulo", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
