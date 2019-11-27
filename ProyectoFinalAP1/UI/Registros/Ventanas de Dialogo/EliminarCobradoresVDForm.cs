using BLL;
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

namespace ProyectoFinalAP1.UI
{
    public partial class EliminarCobradoresVDForm : Form
    {
        private int CobradorId { get; set; }

        public EliminarCobradoresVDForm(int id)
        {
            CobradorId = id;
            InitializeComponent();
        }

        private void EliminarVDbutton_Click(object sender, EventArgs e)
        {
            CobradoresRepositorio repositorio = new CobradoresRepositorio();
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea ELIMINAR permanentemente este registro?", "¡Peligro!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                if (repositorio.Eliminar(CobradorId))
                {
                    MessageBox.Show("¡Eliminado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("¡No fue posible eliminar el registro!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DesactivarVDbutton_Click(object sender, EventArgs e)
        {
            CobradoresRepositorio repositorio = new CobradoresRepositorio();
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea DESACTIVAR este registro?", "¡Peligro!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                if (repositorio.Desactivar(CobradorId))
                {
                    MessageBox.Show("¡Desactivado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("¡No fue posible desactivar el registro!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
