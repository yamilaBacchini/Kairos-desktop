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
    public partial class frmAgregarProyecto : Form
    {
        public frmAgregarProyecto()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            ProyectoService.nuevoProyecto(tboxNombreProyecto.Text);
            MessageBox.Show("Proyecto creado con Exito!", "Crear Proyecto", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
