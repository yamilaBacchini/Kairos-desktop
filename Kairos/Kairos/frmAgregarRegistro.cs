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
    public partial class frmAgregarRegistro : Form
    {
        string nombreProyecto = "";
        int idOrigen = -1;

        public frmAgregarRegistro(int idOrigen, string nombreProyecto)
        {
            InitializeComponent();
            this.idOrigen = idOrigen;
            this.nombreProyecto = nombreProyecto;
            lblNombreProyecto.Text = nombreProyecto;
        }
        
        private void btnTerminar_Click(object sender, EventArgs e)
        {
            DateTime fecha = new DateTime(dtpFecha.Value.Year, dtpFecha.Value.Month, dtpFecha.Value.Day, dtpHora.Value.Hour, dtpHora.Value.Minute, dtpHora.Value.Second);
            EventoService.nuevo(fecha, this.idOrigen);
            MessageBox.Show("Registro Insertado con Exito!", "Insertar Registro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Close();
        }




        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void btmAgregarOtro_Click(object sender, EventArgs e)
        {
            DateTime fecha = new DateTime(dtpFecha.Value.Year, dtpFecha.Value.Month, dtpFecha.Value.Day, dtpHora.Value.Hour, dtpHora.Value.Minute, dtpHora.Value.Second);
            EventoService.nuevo(fecha, this.idOrigen);
            MessageBox.Show("Registro Insertado con Exito!", "Insertar Registro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

    }
}
