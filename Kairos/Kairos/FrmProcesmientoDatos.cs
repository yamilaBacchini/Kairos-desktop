using Kairos.Entidades;
using Kairos.Modelo;
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
    public partial class FrmProcesmientoDatos : Form
    {
        private TipoAccionProcesamiento tipoAccion;
        private string nombreProyecto = "";
        private int idOrigen = -1;
        private List<Evento> eventos = null;
        private List<Evento> eventosSeleccionados = new List<Evento>();

        public FrmProcesmientoDatos(string nombreProyecto, int idOrigen)
        {
            InitializeComponent();
            this.idOrigen = idOrigen;
            this.nombreProyecto = nombreProyecto;
            //lblNombreProyecto.Text = nombreProyecto;
            //setUpTiposFiltros();
            //cambiarFiltros(0);
            cargarEventos();
        }

        private void cargarEventos()
        {
            //lleno la grilla con los eventos
            eventos = EventoService.cargarEventos(idOrigen);
            dgwEventos.DataSource = eventos;
            dgwEventos.Columns[1].Width = 235;
            dgwEventos.Columns[1].DefaultCellStyle.Format = "dd'/'MM'/'yyyy HH:mm:ss";
            dgwEventos.Columns[0].Visible = false;
            dgwEventos.Columns[2].Visible = false;
            dgwEventos.Columns[3].Visible = false;
            dgwEventos.Columns[4].Visible = false;

            if (eventos != null)
                filtrar();
        }

        private void filtrar()
        {
        }

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            tipoAccion = TipoAccionProcesamiento.AGREGAR_REGISTRO;
            modificarLayout(tipoAccion);
        }

        private void btnModificarRegistro_Click(object sender, EventArgs e)
        {
            tipoAccion = TipoAccionProcesamiento.MODIFICAR_REGISTRO;
            modificarLayout(tipoAccion);
        }

        private void btnBorrarSeleccionados_Click(object sender, EventArgs e)
        {
            tipoAccion = TipoAccionProcesamiento.BORRAR_SELECCIONADOS;
            modificarLayout(tipoAccion);
            foreach (var item in eventosSeleccionados)
            {
                EventoService.borrar(item.Id);
            }
            cargarEventos();
        }

        private void btnSeleccionarTodos_Click(object sender, EventArgs e)
        {
            tipoAccion = TipoAccionProcesamiento.SELECCIONAR_TODOS;
            modificarLayout(tipoAccion);
            dgwEventos.SelectAll();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            tipoAccion = TipoAccionProcesamiento.FILTRAR;
            modificarLayout(tipoAccion);
        }

        private void modificarLayout(TipoAccionProcesamiento tipoAccion)
        {
            hacerVisible(tipoAccion);
            switch (tipoAccion)
            {
                case TipoAccionProcesamiento.AGREGAR_REGISTRO:
                    lblTituloAccion.Text = "Agregar Registro";
                    lblAccion1.Text = "Fecha";
                    dtp1.Format = DateTimePickerFormat.Short;
                    lblAccion2.Text = "Hora";
                    dtp2.Format = DateTimePickerFormat.Custom;
                    dtp2.CustomFormat = "HH:mm:ss";
                    break;
                case TipoAccionProcesamiento.MODIFICAR_REGISTRO:
                    lblTituloAccion.Text = "Modificar Registro";
                    lblAccion1.Text = "Fecha";
                    dtp1.Format = DateTimePickerFormat.Short;
                    lblAccion2.Text = "Hora";
                    dtp2.Format = DateTimePickerFormat.Custom;
                    dtp2.CustomFormat = "HH:mm:ss";
                    break;
                case TipoAccionProcesamiento.FILTRAR:
                    lblTituloAccion.Text = "Filtrar";
                    lblAccion1.Text = "Fecha";
                    dtp1.Format = DateTimePickerFormat.Short;
                    lblAccion2.Text = "Hora";
                    dtp2.Format = DateTimePickerFormat.Custom;
                    dtp2.CustomFormat = "HH:mm:ss";
                    break;
                default:
                    break;
            }
        }

        private void hacerVisible(TipoAccionProcesamiento tipoAccion)
        {
            switch (tipoAccion)
            {
                case TipoAccionProcesamiento.AGREGAR_REGISTRO:
                case TipoAccionProcesamiento.MODIFICAR_REGISTRO:
                    pnlModificable.Visible = true;
                    lblTipoFiltro.Visible = false;
                    cmbTipoFiltro.Visible = false;
                    break;
                case TipoAccionProcesamiento.BORRAR_SELECCIONADOS:
                case TipoAccionProcesamiento.SELECCIONAR_TODOS:
                    pnlModificable.Visible = false;
                    break;
                case TipoAccionProcesamiento.FILTRAR:
                    pnlModificable.Visible = true;
                    lblTipoFiltro.Visible = true;
                    cmbTipoFiltro.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DateTime fecha;
            switch (tipoAccion)
            {
                case TipoAccionProcesamiento.AGREGAR_REGISTRO:
                    fecha = new DateTime(dtp1.Value.Year, dtp1.Value.Month, dtp1.Value.Day, dtp2.Value.Hour, dtp2.Value.Minute, dtp2.Value.Second);
                    EventoService.nuevo(fecha, this.idOrigen);
                    cargarEventos();
                    break;
                case TipoAccionProcesamiento.MODIFICAR_REGISTRO:
                    fecha = new DateTime(dtp1.Value.Year, dtp1.Value.Month, dtp1.Value.Day, dtp2.Value.Hour, dtp2.Value.Minute, dtp2.Value.Second);
                    if (eventosSeleccionados.Count == 1)
                    {
                        EventoService.modificar(eventosSeleccionados[0].Id, fecha);
                        cargarEventos();
                    }
                    else
                        MessageBox.Show("No seas forro, se edita de a 1");
                    break;
                case TipoAccionProcesamiento.BORRAR_SELECCIONADOS:
                case TipoAccionProcesamiento.SELECCIONAR_TODOS:
                    pnlModificable.Visible = false;
                    break;
                case TipoAccionProcesamiento.FILTRAR:
                    pnlModificable.Visible = true;
                    lblTipoFiltro.Visible = true;
                    cmbTipoFiltro.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgwEventos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwEventos.SelectedRows.Count > 0)
            {
                eventosSeleccionados = new List<Evento>();
                if (eventos != null)
                {
                    foreach (DataGridViewRow item in dgwEventos.SelectedRows)
                    {
                        eventosSeleccionados.Add(eventos[item.Index]);
                    }
                    if (tipoAccion == TipoAccionProcesamiento.MODIFICAR_REGISTRO && eventosSeleccionados.Count == 1)
                    {
                        dtp1.Value = eventosSeleccionados[0].fecha;
                        dtp2.Value = eventosSeleccionados[0].fecha;
                    }
                }

            }
        }
    }
}
