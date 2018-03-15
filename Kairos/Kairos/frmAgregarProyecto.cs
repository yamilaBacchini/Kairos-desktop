using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            using (var db = new OrigenContexto())
            {
                db.origenes.add(new Entidades.Origen { nombreOrigen = tboxNombreProyecto.Text });
            }
            MessageBox.Show("Proyecto creado con Exito!", "Crear Proyecto", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Close();
        }
    }
}
