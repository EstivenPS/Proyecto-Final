using ProyectoFinalAP1.BLL;
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

namespace ProyectoFinalAP1.UI.Consultas
{
    public partial class CPrestamosForm : Form
    {
        public CPrestamosForm()
        {
            InitializeComponent();
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            var listado = new List<Prestamos>();
            PrestamosRepositorio repositorioPrestamo = new PrestamosRepositorio();

            if (CriteriotextBox.Text.Trim().Length > 0)
            {
                switch (FiltrocomboBox.SelectedIndex)
                {
                    case 0://Todos
                        listado = repositorioPrestamo.GetList(c => true);
                        break;

                    case 1://Prestamo Id
                        int id = Convert.ToInt32(CriteriotextBox.Text);
                        listado = repositorioPrestamo.GetList(c => c.ClienteId == id);
                        break;

                    case 2://Cliente Id
                        int ClienteId = Convert.ToInt32(CriteriotextBox.Text);
                        listado = repositorioPrestamo.GetList(c => c.ClienteId == ClienteId);
                        break;

                    case 3://Cobrador Id
                        int CobradorId = Convert.ToInt32(CriteriotextBox.Text);
                        listado = repositorioPrestamo.GetList(c => c.CobradorId == CobradorId);
                        break;

                    case 4://Balance
                        decimal balance = Convert.ToDecimal(CriteriotextBox.Text);
                        listado = repositorioPrestamo.GetList(c => c.Balance == balance);
                        break;
                }

                listado = listado.Where(c => c.Fecha.Date >= DesdedateTimePicker.Value.Date && c.Fecha.Date <= HastadateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = repositorioPrestamo.GetList(c => true);
            }

            ConsultadataGridView.DataSource = null;
            ConsultadataGridView.DataSource = listado;
        }
    }
}
