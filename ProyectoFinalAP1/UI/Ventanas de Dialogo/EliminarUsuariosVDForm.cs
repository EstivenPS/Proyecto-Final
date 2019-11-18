using ProyectoFinalAP1.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalAP1.UI.Ventanas_de_Dialogo
{
    public partial class EliminarUsuariosVDForm : Form
    {
        private int UsuarioId { get; set; }

        public EliminarUsuariosVDForm(int id)
        {
            this.UsuarioId = id;
            InitializeComponent();
        }

        private void EliminarVDbutton_Click(object sender, EventArgs e)
        {
            UsuariosRepositorio repositorio = new UsuariosRepositorio();
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea ELIMINAR permanentemente este registro?", "¡Peligro!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                if (repositorio.Eliminar(UsuarioId))
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
            UsuariosRepositorio repositorio = new UsuariosRepositorio();
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea DESACTIVAR este registro?", "¡Peligro!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                if (repositorio.Desactivar(UsuarioId))
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
