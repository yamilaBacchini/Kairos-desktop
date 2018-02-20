using Kairos.Entidades;
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
        {   //inserto el nuevo evento
            using (var db = new EventoContexto())
            {
                DateTime fecha = new DateTime(dtpFecha.Value.Year, dtpFecha.Value.Month, dtpFecha.Value.Day, dtpHora.Value.Hour, dtpHora.Value.Minute, dtpHora.Value.Second);
                db.Eventos.Add(new Entidades.Evento { fecha = fecha, idOrigen = this.idOrigen, activo = true });
                db.SaveChanges();
            }
            MessageBox.Show("Registro Insertado con Exito!", "Insertar Registro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btmAgregarOtro_Click(object sender, EventArgs e)
        {   //inserto el nuevo evento
            using (var db = new EventoContexto())
            {//falta buscar el idorigen en la tabla por el nombre de origen
                DateTime fecha = new DateTime(dtpFecha.Value.Year, dtpFecha.Value.Month, dtpFecha.Value.Day, dtpHora.Value.Hour, dtpHora.Value.Minute, dtpHora.Value.Second);
                db.Eventos.Add(new Entidades.Evento { fecha = fecha, idOrigen = this.idOrigen, activo = true });
                db.SaveChanges();
            }
            MessageBox.Show("Registro Insertado con Exito!", "Insertar Registro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
