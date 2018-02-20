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
    public partial class frmProcesamiento : Form
    {
        string nombreProyecto = "";
        int idOrigen = -1;

        public frmProcesamiento(int idOrigen, string nombreProyecto)
        {
            InitializeComponent();
            this.idOrigen = idOrigen;
            this.nombreProyecto = nombreProyecto;
            lblNombreProyecto.Text = nombreProyecto;

            cargarEventos();
        }

        private void cargarEventos()
        {
            //lleno la grilla con los eventos
            //dgwEventos.DataBindings.Clear();
            using (var db = new EventoContexto())
            {
                var listaEventos = (from e in db.Eventos
                                    join o in db.Origenes
                                    on e.idOrigen equals o.Id
                                    where e.activo == true && o.nombreOrigen == this.nombreProyecto
                                    orderby e.fecha ascending
                                    select new { e.Id, TimeStamps = e.fecha }).ToList();

                dgwEventos.DataSource = listaEventos;
                dgwEventos.Columns[1].Width = 235;
                dgwEventos.Columns[0].Visible = false;
                dgwEventos.Columns[1].DefaultCellStyle.Format = "dd'/'MM'/'yyyy HH:mm:ss";
            }
        }

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            frmAgregarRegistro frm = new frmAgregarRegistro(this.idOrigen, this.nombreProyecto);
            Visible = false;
            frm.ShowDialog();
            Visible = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModificarRegistro_Click(object sender, EventArgs e)
        {
            if (dgwEventos.CurrentRow.Index == -1)
            {
                MessageBox.Show("Seleccione el evento que desea modificar", "Falta Selección", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }//falta terminar
            /*else if (dgwEventos.SelectedRows.Count > 1)
            {
                MessageBox.Show("Seleccione un solo evento para modificar", "Error de Selección", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else*/
            else
            {
                int idEvento = Convert.ToInt32(dgwEventos.SelectedCells[0].Value);
                frmModificarRegistro frm = new frmModificarRegistro(this.nombreProyecto, idEvento, Convert.ToDateTime(dgwEventos.SelectedCells[1].Value));
                Visible = false;
                frm.ShowDialog();
                Visible = true;
            }
        }

        private void frmProcesamiento_Activated(object sender, EventArgs e)
        {
            cargarEventos();
        }

        private void btnBorrarSeleccion_Click(object sender, EventArgs e)
        {
            if (dgwEventos.SelectedRows.Count > 0)
            {
                using (var db = new EventoContexto())
                {
                    foreach (DataGridViewRow item in dgwEventos.SelectedRows)
                    {
                        int idEventoAEliminar = Convert.ToInt32(item.Cells[0].Value);
                        db.Remove<Evento>(db.Find<Evento>(idEventoAEliminar));
                    }
                    db.SaveChanges();
                }
                cargarEventos();
            }
            else
                MessageBox.Show("Seleccione la/s fila/s a borrar",  "Error de Selección", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnSelecionarTodo_Click(object sender, EventArgs e)
        {
            dgwEventos.SelectAll();
        }
    }
}
