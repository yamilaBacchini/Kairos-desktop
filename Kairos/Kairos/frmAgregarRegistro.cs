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
    public partial class frmAgregarRegistro : Form
    {
        string nombreProyecto = "";

        public frmAgregarRegistro(string nombreProyecto)
        {
            InitializeComponent();
            this.nombreProyecto = nombreProyecto;
            lblNombreProyecto.Text = nombreProyecto;
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(DateTime.Now),"dd");
        }
    }
}
