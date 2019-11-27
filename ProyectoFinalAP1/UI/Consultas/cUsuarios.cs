using BLL;
using Entidades;
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

namespace ProyectoFinalAP1.UI.Consultas
{
    public partial class cUsuarios : Form
    {
        List<Usuarios> listado = new List<Usuarios>();
        public cUsuarios()
        {
            InitializeComponent();
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();

            if (CriteriotextBox.Text.Trim().Length > 0)
            {
                switch (FiltrocomboBox.SelectedIndex)
                {
                    case 0://Todos
                        listado = repositorio.GetList(u => true);
                        break;

                    case 1://Id
                        int id = Convert.ToInt32(CriteriotextBox.Text);
                        listado = repositorio.GetList(u => u.UsuarioId == id);
                        break;

                    case 2://Nombres
                        listado = repositorio.GetList(u => u.Nombres.Contains(CriteriotextBox.Text));
                        break;

                    case 3://Apellidos
                        listado = repositorio.GetList(u => u.Apellidos.Contains(CriteriotextBox.Text));
                        break;

                    case 4://Tipo de Usuario
                        int tipo = Convert.ToInt32(CriteriotextBox.Text);
                        listado = repositorio.GetList(u => u.TipoUsuario == tipo);
                        break;

                    case 5://Nombre de Usuario
                        listado = repositorio.GetList(u => u.NombreUsuario.Contains(CriteriotextBox.Text));
                        break;

                    case 6://Activo
                        listado = repositorio.GetList(u => u.Activo == true);
                        break;

                    case 7://Inactivo
                        listado = repositorio.GetList(u => u.Activo == false);
                        break;
                }

                listado = listado.Where(u => u.Fecha.Date >= DesdedateTimePicker.Value.Date && u.Fecha.Date <= HastadateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = repositorio.GetList(u => true);
            }

            ConsultadataGridView.DataSource = null;
            ConsultadataGridView.DataSource = listado;
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if(listado.Count == 0)
            {
                MessageBox.Show("No hay datos para imprimir");
                return;
            }

            UsuariosReportViewer usuariosReportViewer = new UsuariosReportViewer(listado);
            usuariosReportViewer.ShowDialog();
        }
    }
}
