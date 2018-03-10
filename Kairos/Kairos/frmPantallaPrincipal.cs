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

                var resultado = (from o in db.Origenes select new { o.nombreOrigen, o.Id }).ToList();
                lbProyectosRecientes.ValueMember = "nombreOrigen";
                lbProyectosRecientes.Items.AddRange(resultado.ToArray());
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
                var seleccionado = lbProyectosRecientes.SelectedItem;
                var a = new { nombreOrigen = "", Id=0 };
                a = Cast(a, seleccionado);
                frmProcesamiento frm = new frmProcesamiento(a.Id, a.nombreOrigen);
                Visible = false;
                frm.ShowDialog();
                Visible = true;
            }
        }

        private static T Cast<T>(T typeHolder, Object x)
        {
            // typeHolder above is just for compiler magic
            // to infer the type to cast x to
            return (T)x;
        }

        private void btnNuevoProyecto_Click(object sender, EventArgs e)
        {
            //ejemplo
            //asdasrasedad
        }
    }
}
