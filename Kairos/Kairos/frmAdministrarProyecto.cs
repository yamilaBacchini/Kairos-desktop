using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kairos.Services;

namespace Kairos
{
    public partial class frmAdministrarProyecto : Form
    {
        int idProyecto = -1;

        public frmAdministrarProyecto(int idProyecto, string nombreProyecto)
        {
            InitializeComponent();

            lblNombreProyecto.Text = nombreProyecto;
            this.idProyecto = idProyecto;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ProyectoService.modificarProyecto(idProyecto, tboxNombreProyecto.Text);
            MessageBox.Show("Proyecto modificado con Exito!", "Modificado Proyecto", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            ProyectoService.borrarProyecto(idProyecto);
            MessageBox.Show("Proyecto borrado con Exito!", "Borrar Proyecto", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Close();
        }
    }
}
