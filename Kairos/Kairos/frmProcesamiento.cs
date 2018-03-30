using Kairos.Entidades;
using Kairos.Filtros;
using Kairos.Filtros.Fecha;
using Kairos.Filtros.Hora;
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
        private List<Evento> eventos = null;

        public frmProcesamiento(int idOrigen, string nombreProyecto)
        {
            InitializeComponent();
            this.idOrigen = idOrigen;
            this.nombreProyecto = nombreProyecto;
            lblNombreProyecto.Text = nombreProyecto;
            setUpTiposFiltros();
            cambiarFiltros(0);
            cargarEventos();
        }

        private void setUpTiposFiltros()
        {
            List<ComboItem> tipos = new List<ComboItem> { new ComboItem(0, "Seleccione"), new ComboItem(1, "Fecha menor a"), new ComboItem(2, "Fecha mayor a"), new ComboItem(3, "Entre fechas"), new ComboItem(4, "Hora menor a"), new ComboItem(5, "Hora mayor a"), new ComboItem(6, "Entre horas") };
            cmbTipoFiltro.DisplayMember = "Display";
            cmbTipoFiltro.ValueMember = "Value";
            cmbTipoFiltro.DataSource = tipos;
        }

        private void cambiarFiltros(int valorSeleccionado)
        {
            if (valorSeleccionado > 3)
            {
                dtpFiltro.Format = DateTimePickerFormat.Time;
                dtpFiltro.ShowUpDown = true;
                dtpFiltroHasta.Format = DateTimePickerFormat.Time;
                dtpFiltroHasta.ShowUpDown = true;
            }   
            else
            {
                dtpFiltro.Format = DateTimePickerFormat.Short;
                dtpFiltro.ShowUpDown = false;
                dtpFiltroHasta.Format = DateTimePickerFormat.Short;
                dtpFiltroHasta.ShowUpDown = false;
            }
            switch (valorSeleccionado)
            {
                case 0:
                    lblTituloFiltro.Visible = false;
                    lblHasta.Visible = false;
                    dtpFiltro.Visible = false;
                    dtpFiltroHasta.Visible = false;
                    btnAplicarFiltro.Visible = false;
                    break;
                case 1:
                    btnAplicarFiltro.Visible = true;
                    lblTituloFiltro.Visible = true;
                    lblTituloFiltro.Text = "Fecha";
                    dtpFiltro.Visible = true;
                    lblHasta.Visible = false;
                    dtpFiltroHasta.Visible = false;
                    break;
                case 2:
                    btnAplicarFiltro.Visible = true;
                    lblTituloFiltro.Visible = true;
                    lblTituloFiltro.Text = "Fecha";
                    dtpFiltro.Visible = true;
                    lblHasta.Visible = false;
                    dtpFiltroHasta.Visible = false;
                    break;
                case 3:
                    btnAplicarFiltro.Visible = true;
                    lblTituloFiltro.Visible = true;
                    lblTituloFiltro.Text = "Fecha";
                    dtpFiltro.Visible = true;
                    lblHasta.Visible = true;
                    lblHasta.Text = "Fecha hasta";
                    dtpFiltroHasta.Visible = true;
                    break;
                case 4:
                    btnAplicarFiltro.Visible = true;
                    lblTituloFiltro.Visible = true;
                    lblTituloFiltro.Text = "Hora";
                    dtpFiltro.Visible = true;
                    lblHasta.Visible = false;
                    dtpFiltroHasta.Visible = false;
                    break;
                case 5:
                    btnAplicarFiltro.Visible = true;
                    lblTituloFiltro.Visible = true;
                    lblTituloFiltro.Text = "Hora";
                    dtpFiltro.Visible = true;
                    lblHasta.Visible = false;
                    dtpFiltroHasta.Visible = false;
                    break;
                case 6:
                    btnAplicarFiltro.Visible = true;
                    lblTituloFiltro.Visible = true;
                    lblTituloFiltro.Text = "Hora";
                    dtpFiltro.Visible = true;
                    lblHasta.Visible = true;
                    lblHasta.Text = "Hora hasta";
                    dtpFiltroHasta.Visible = true;
                    break;
                default:
                    break;
            }

        }

        private void cargarEventos()
        {
            //lleno la grilla con los eventos
            //dgwEventos.DataBindings.Clear();
            using (var db = new EventoContexto())
            {
                eventos = (from e in db.Eventos
                                    where e.activo == true && e.idOrigen == idOrigen
                                    orderby e.fecha ascending
                                    select e).ToList();

                dgwEventos.DataSource = eventos;
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
                MessageBox.Show("Seleccione la/s fila/s a borrar", "Error de Selección", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnSelecionarTodo_Click(object sender, EventArgs e)
        {
            dgwEventos.SelectAll();
        }

        private void cmbTipoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoFiltro.SelectedValue != null)
                cambiarFiltros(Convert.ToInt32(cmbTipoFiltro.SelectedValue));
        }

        private void btnAplicarFiltro_Click(object sender, EventArgs e)
        {
            List<Evento> filtrado = null;
            int selectedValue = Convert.ToInt32(cmbTipoFiltro.SelectedValue);
            bool filtroHora = false;
            if (selectedValue >= 4)
                filtroHora = true;
            if (!filtroHora)
            {
                IFiltroFecha filtro;
                DateTime fecha1 = dtpFiltro.Value;
                DateTime fecha2 = dtpFiltroHasta.Value;
                switch (selectedValue)
                {
                    case 1:
                        filtro = new FiltroFechaMenor();
                        break;
                    case 2:
                        filtro = new FiltroFechaMayor();
                        break;
                    case 3:
                        filtro = new FiltroFechaEntre();
                        break;
                    default:
                        filtro = null;
                        break;
                }
                filtrado = filtro.aplicarFiltroFecha(eventos, fecha1, fecha2);
            }
            else {
                IFiltroHora filtro;
                TimeSpan hora1 = dtpFiltro.Value.TimeOfDay;
                TimeSpan hora2 = dtpFiltroHasta.Value.TimeOfDay;
                switch (selectedValue)
                {
                    case 4:
                        filtro = new FiltroHoraMenor();
                        break;
                    case 5:
                        filtro = new FiltroHoraMayor();
                        break;
                    case 6:
                        filtro = new FiltroHoraEntre();
                        break;
                    default:
                        filtro = null;
                        break;
                }
                filtrado = filtro.aplicarFiltroHora(eventos, hora1, hora2);
            }
            if (filtrado != null)
            {
                eventos = filtrado;
                dgwEventos.DataSource = filtrado;
                dgwEventos.Columns[1].Width = 235;
                dgwEventos.Columns[0].Visible = false;
                dgwEventos.Columns[1].DefaultCellStyle.Format = "dd'/'MM'/'yyyy HH:mm:ss";
            }
                
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            cargarEventos();
        }
    }

    class ComboItem
    {
        public int Value { get; set; } 
        public string Display { get; set; }
        public ComboItem(int value, string display) { this.Value = value; this.Display = display; }
    }
}
