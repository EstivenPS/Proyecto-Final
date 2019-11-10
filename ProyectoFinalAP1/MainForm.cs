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
        public MainForm()
        {
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
            RCobradoresForm rc = new RCobradoresForm();
            rc.MdiParent = this;
            rc.Show();
        }
    }
}
