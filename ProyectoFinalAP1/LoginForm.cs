using ProyectoFinalAP1.BLL;
using ProyectoFinalAP1.Entidades;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private bool Validar()
        {
            bool paso = true;

            if(string.IsNullOrWhiteSpace(UsuariotextBox.Text))
            {
                MyerrorProvider.SetError(UsuariotextBox, "El campo Usuario no puede estar vacío");
                UsuariotextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(ContraseñatextBox.Text))
            {
                MyerrorProvider.SetError(ContraseñatextBox, "El campo Contraseña no puede estar vacío");
                ContraseñatextBox.Focus();
                paso = false;
            }

            return paso;
        }
        
        private void Registrarselabel_Click(object sender, EventArgs e)
        {
            RUsuariosForm ru = new RUsuariosForm();
            ru.ShowDialog();
        }

        private void VisualizarpictureBox_Click(object sender, EventArgs e)
        {
            string contraseña = ContraseñatextBox.Text;

            if (ContraseñatextBox.UseSystemPasswordChar == true)
            {
                ContraseñatextBox.UseSystemPasswordChar = false;
                ContraseñatextBox.Text = contraseña;
            }
            else
            {
                ContraseñatextBox.UseSystemPasswordChar = true;
                ContraseñatextBox.Text = contraseña;
            }
        }

        private void Accederbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            Usuarios usuario = new Usuarios();
            List<Usuarios> Lista = new List<Usuarios>();
            bool paso = false;

            if (!Validar())
                return;

            Lista = repositorio.GetList(u => true);
            
            foreach (var item in Lista)
            {
                if (UsuariotextBox.Text == item.NombreUsuario && ContraseñatextBox.Text == item.ClaveUsuario)
                {
                    usuario = item;
                    paso = true;
                }
            }

            if (paso)
            {
                MainForm menu = new MainForm(usuario);
                menu.Show();
            }
            else
            {
                MyerrorProvider.SetError(Accederbutton, "El nombre de usuario o la contraseña es incorrecta");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ContraseñatextBox.UseSystemPasswordChar = true;
        }
    }
}
