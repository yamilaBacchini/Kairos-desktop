using Kairos.Entidades;
using Kairos.Services;
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
        int idEvento = -1;

        public frmModificarRegistro(string nombreProyecto, int idEvento, DateTime fecha)
        {
            InitializeComponent();
            this.nombreProyecto = nombreProyecto;
            this.idEvento = idEvento;
            lblNombreProyecto.Text = nombreProyecto;
            dtpFecha.Value = fecha;
            dtpHora.Value = fecha;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DateTime fecha = new DateTime(dtpFecha.Value.Year, dtpFecha.Value.Month, dtpFecha.Value.Day, dtpHora.Value.Hour, dtpHora.Value.Minute, dtpHora.Value.Second);
            EventoService.modificar(idEvento,fecha);
            Close();
        }
    }
}
