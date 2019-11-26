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
            bool paso = false;
            Usuarios usuario = new Usuarios();
            var Lista = new List<Usuarios>();
            UsuariosRepositorio repositorio = new UsuariosRepositorio();
            MyerrorProvider.Clear();

            if (!Validar())
                return;

            Lista = repositorio.GetList(u => true).ToList();

            if (UsuariotextBox.Text == "admin" && ContraseñatextBox.Text == "admin")
            {
                usuario.UsuarioId = 1;
                usuario.Fecha = DateTime.Now;
                usuario.Nombres = "Usuario";
                usuario.Apellidos = "Administrador";
                usuario.Cedula = "000-0000000-0";
                usuario.Email = "admin@ucne.edu.do";
                usuario.NombreUsuario = "admin";
                usuario.ClaveUsuario = Encriptar("admin");
                usuario.TipoUsuario = 0;
                usuario.Activo = true;

                if (Lista.Count() == 0)
                {
                    usuario.UsuarioId = 0;
                    paso = repositorio.Guardar(usuario);
                }
                else
                    paso = true;
            }
            else
            {
                foreach (var item in Lista)
                {
                    if (UsuariotextBox.Text == item.NombreUsuario && ContraseñatextBox.Text == DesEncriptar(item.ClaveUsuario))
                    {
                        usuario = item;
                        paso = true;
                        break;
                    }
                }
            }

            if (paso)
            {
                MainForm menu = new MainForm(usuario);
                this.Hide();
                menu.ShowDialog();
                this.Dispose();
            }
            else
            {
                MyerrorProvider.SetError(Accederbutton, "El nombre de usuario o la contraseña es incorrecta");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ContraseñatextBox.UseSystemPasswordChar = true;
            MyerrorProvider.Clear();
        }

        private string Encriptar(string cadenaAencriptar)//Esta función encripta una cadena que se le pasa por parámentro
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        private string DesEncriptar(string cadenaAdesencriptar)//Esta función desencripta la cadena que se le pasa por parámentro
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(cadenaAdesencriptar);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }
    }
}
