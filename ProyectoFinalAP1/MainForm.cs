using BLL;
using Entidades;
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

        public MainForm(Usuarios usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }
        
        private void registroDeCobradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuario.TipoUsuario == 0 || usuario.TipoUsuario == 1)
            {
                rCobradores registroCobradores = new rCobradores(usuario);
                registroCobradores.MdiParent = this;
                registroCobradores.Show();
            }
            else
            {
                MessageBox.Show("Lo sentimos, no tienes permisos para acceder a este módulo", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void registroDePrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rPrestamos registroPrestamos = new rPrestamos(usuario);
            registroPrestamos.MdiParent = this;
            registroPrestamos.Show();
        }

        private void registroDeCobrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCobros registroCobros = new rCobros(usuario);
            registroCobros.MdiParent = this;
            registroCobros.Show();
        }

        private void registroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuario.TipoUsuario == 0 || usuario.TipoUsuario == 1)
            {
                rClientes registroClientes = new rClientes(usuario);
                registroClientes.MdiParent = this;
                registroClientes.Show();
            }
            else
            {
                MessageBox.Show("Lo sentimos, no tienes permisos para acceder a este módulo", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void consultaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cClientes consultaClientes = new cClientes();
            consultaClientes.MdiParent = this;
            consultaClientes.Show();
        }

        private void consultaDeCobradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuario.TipoUsuario == 0 || usuario.TipoUsuario == 1)
            {
                cCobradores consultaCobradores = new cCobradores();
                consultaCobradores.MdiParent = this;
                consultaCobradores.Show();
            }
            else
            {
                MessageBox.Show("Lo sentimos, no tienes permisos para acceder a este módulo", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
        private void consultaDePrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cPrestamos consultaPrestamos = new cPrestamos();
            consultaPrestamos.MdiParent = this;
            consultaPrestamos.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void registroDeUsuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (usuario.TipoUsuario == 0)
            {
                rUsuarios registroUsuarios = new rUsuarios();
                registroUsuarios.MdiParent = this;
                registroUsuarios.Show();
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
                cUsuarios consultaUsuarios = new cUsuarios();
                consultaUsuarios.MdiParent = this;
                consultaUsuarios.Show();
            }
            else
            {
                MessageBox.Show("Lo sentimos, no tienes permisos para acceder a este módulo", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void consultaDeCobrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cCobros consultaCobros = new cCobros();
            consultaCobros.MdiParent = this;
            consultaCobros.Show();
        }
    }
}
