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
    public partial class frmModificarRegistro : Form
    {
        string nombreProyecto = "";
        int idEvento;

        public frmModificarRegistro(string nombreProyecto,int idEvento)
        {
            InitializeComponent();
            this.nombreProyecto = nombreProyecto;
            this.idEvento = idEvento;
            lblNombreProyecto.Text = nombreProyecto;

            //buscar el evento por el id
            using (var db = new EventoContexto())
            {
                var fechaEvento = (from e in db.Eventos
                                   where e.Id == this.idEvento
                                    select new { e.fecha }).ToList();

                //asignar la fecha edl evento a los distintos textbox para ser modificados
                //hacer update al registro yendo por id, de su campo fecha

            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmProcesamiento frm = new frmProcesamiento(this.nombreProyecto);
            Visible = false;
            frm.ShowDialog();
            Close();
        }
    }
}
