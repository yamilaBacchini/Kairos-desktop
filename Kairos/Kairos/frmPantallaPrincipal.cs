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
    public partial class frmPantallaPrincipal : Form
    {

        public frmPantallaPrincipal()
        {
            InitializeComponent();

            using (var db = new EventoContexto())
            {
                db.Database.EnsureCreated();

                var resultado = (from datos in db.Origenes select new { datos.nombreOrigen }).ToList();

                foreach (var item in resultado)
                {
                    lbProyectosRecientes.Items.Add(item.nombreOrigen);
                }

            }
        }

        private void btnProcesarDatos_Click(object sender, EventArgs e)
        {
            if (lbProyectosRecientes.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un proyecto de la lista", "Falta selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frmProcesamiento frm = new frmProcesamiento(Convert.ToString(lbProyectosRecientes.SelectedItem));
                frm.ShowDialog();
            }
        }
    }
}
