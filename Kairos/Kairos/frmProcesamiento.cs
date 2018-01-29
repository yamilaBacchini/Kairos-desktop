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
    public partial class frmProcesamiento : Form
    {
        string nombreProyecto="";

        public frmProcesamiento(string nombreProyecto)
        {
            InitializeComponent();
            this.nombreProyecto = nombreProyecto;
            lblNombreProyecto.Text = nombreProyecto;

            //lleno la grilla con los eventos
            using (var db = new EventoContexto())
            {
                var listaEventos = (from e in db.Eventos
                                    join o in db.Origenes
                                    on e.idOrigen equals o.Id
                                    where e.activo==true && o.nombreOrigen==this.nombreProyecto
                                 select new { TimeStamps=e.fecha }).ToList();

                dgwEventos.DataSource = listaEventos;
                dgwEventos.Columns[0].Width = 235;

            }
        }

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            frmAgregarRegistro frm = new frmAgregarRegistro(this.nombreProyecto);
            frm.ShowDialog();
        }
    }
}
