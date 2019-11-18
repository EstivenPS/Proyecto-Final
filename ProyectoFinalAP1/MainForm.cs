using ProyectoFinalAP1.Entidades;
using ProyectoFinalAP1.UI;
using ProyectoFinalAP1.UI.Registros;
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

        public MainForm(Usuarios usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        private void registroDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RUsuariosForm ru = new RUsuariosForm();
            ru.MdiParent = this;
            ru.Show();
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
            RCobrosForm rco = new RCobrosForm();
            rco.MdiParent = this;
            rco.Show();
        }

        private void registroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RClientesForm rcli = new RClientesForm(usuario);
            rcli.MdiParent = this;
            rcli.Show();
        }
    }
}
