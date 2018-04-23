using Kairos.Entidades;
using Kairos.Filtros;
using Kairos.Filtros.Fecha;
using Kairos.Filtros.Hora;
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
            cargarFiltros();
            cambiarFiltros(0);
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

            if (eventos != null && tipoAccion==TipoAccionProcesamiento.FILTRAR)
                filtrar();
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
                    cambiarFiltros(0);
                    break;
                case TipoAccionProcesamiento.MODIFICAR_REGISTRO:
                    lblTituloAccion.Text = "Modificar Registro";
                    lblAccion1.Text = "Fecha";
                    dtp1.Format = DateTimePickerFormat.Short;
                    lblAccion2.Text = "Hora";
                    dtp2.Format = DateTimePickerFormat.Custom;
                    dtp2.CustomFormat = "HH:mm:ss";
                    cambiarFiltros(0);
                    break;
                case TipoAccionProcesamiento.FILTRAR:
                    lblTituloAccion.Text = "Filtrar";
                    lblAccion1.Text = "Fecha";
                    dtp1.Format = DateTimePickerFormat.Short;
                    lblAccion2.Text = "Hora";
                    dtp2.Format = DateTimePickerFormat.Custom;
                    dtp2.CustomFormat = "HH:mm:ss";
                    cambiarFiltros(0);
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
                    foreach (Control control in pnlModificable.Controls)
                    {
                        control.Visible = true;// Codigo de control para el componente
                    }
                    lblTipoFiltro.Visible = false;
                    cmbTipoFiltro.Visible = false;
                    btnLimpiar.Visible = false;
                    break;
                case TipoAccionProcesamiento.BORRAR_SELECCIONADOS:
                case TipoAccionProcesamiento.SELECCIONAR_TODOS:
                    pnlModificable.Visible = false;
                    break;
                case TipoAccionProcesamiento.FILTRAR:
                    pnlModificable.Visible = true;
                    foreach (Control control in pnlModificable.Controls)
                    {
                        control.Visible = true;// Codigo de control para el componente
                    }
                    lblTipoFiltro.Visible = true;
                    cmbTipoFiltro.Visible = true;
                    btnLimpiar.Visible = false;
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
                case TipoAccionProcesamiento.FILTRAR:
                    filtrar();
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

        //filtros

        class ComboItem
        {
            public int Value { get; set; }
            public string Display { get; set; }
            public ComboItem(int value, string display) { this.Value = value; this.Display = display; }
        }

        private void cargarFiltros()
        {
            List<ComboItem> tipos = new List<ComboItem> { new ComboItem(0, "Seleccione"), new ComboItem(1, "Fecha menor a"), new ComboItem(2, "Fecha mayor a"), new ComboItem(3, "Entre fechas"), new ComboItem(4, "Hora menor a"), new ComboItem(5, "Hora mayor a"), new ComboItem(6, "Entre horas") };
            cmbTipoFiltro.DisplayMember = "Display";
            cmbTipoFiltro.ValueMember = "Value";
            cmbTipoFiltro.DataSource = tipos;
        }

        private void cmbTipoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (cmbTipoFiltro.SelectedValue != null)
                    cambiarFiltros(Convert.ToInt32(cmbTipoFiltro.SelectedValue));
        }

        private void cambiarFiltros(int valorSeleccionado)
        {
            if(tipoAccion==TipoAccionProcesamiento.FILTRAR)
            {
                if (valorSeleccionado > 3)
                {
                    dtp1.Format = DateTimePickerFormat.Custom;
                    dtp1.CustomFormat = "HH:mm:ss";
                    dtp1.ShowUpDown = true;
                    dtp2.Format = DateTimePickerFormat.Custom;
                    dtp2.CustomFormat = "HH:mm:ss";
                    dtp2.ShowUpDown = true;
                }
                else
                {
                    dtp1.Format = DateTimePickerFormat.Short;
                    dtp1.ShowUpDown = false;
                    dtp2.Format = DateTimePickerFormat.Short;
                    dtp2.ShowUpDown = false;
                }
                switch (valorSeleccionado)
                {
                    case 0:
                        if(tipoAccion==TipoAccionProcesamiento.FILTRAR)
                        {
                            lblTituloAccion.Visible = false;
                            lblAccion1.Visible = false;
                            lblAccion2.Visible = false;
                            dtp1.Visible = false;
                            dtp2.Visible = false;
                            btnAceptar.Visible = false;
                            btnLimpiar.Visible = false;
                            cmbTipoFiltro.SelectedIndex = 0;
                        }
                        break;
                    case 1:
                        btnAceptar.Visible = true;
                        lblTituloAccion.Visible = true;
                        lblTituloAccion.Text = "Filtar";
                        lblAccion1.Visible = true;
                        lblAccion1.Text = "Fecha desde";
                        lblAccion1.Text = "Fecha";
                        dtp1.Visible = true;
                        lblAccion2.Visible = false;
                        dtp2.Visible = false;
                        btnLimpiar.Visible = true;
                        break;
                    case 2:
                        btnAceptar.Visible = true;
                        lblTituloAccion.Visible = true;
                        lblTituloAccion.Text = "Filtar";
                        lblAccion1.Text = "Fecha hasta";
                        dtp1.Visible = true;
                        lblAccion2.Visible = false;
                        dtp2.Visible = false;
                        btnLimpiar.Visible = true;
                        break;
                    case 3:
                        btnAceptar.Visible = true;
                        lblTituloAccion.Visible = true;
                        lblTituloAccion.Text = "Filtar";
                        lblAccion1.Text = "Fecha desde";
                        dtp1.Visible = true;
                        lblAccion2.Visible = true;
                        lblAccion2.Text = "Fecha hasta";
                        dtp2.Visible = true;
                        btnLimpiar.Visible = true;
                        break;
                    case 4:
                        btnAceptar.Visible = true;
                        lblTituloAccion.Visible = true;
                        lblTituloAccion.Text = "Filtar";
                        lblAccion1.Text = "Hora desde";
                        dtp1.Visible = true;
                        lblAccion2.Visible = false;
                        dtp2.Visible = false;
                        btnLimpiar.Visible = true;
                        break;
                    case 5:
                        btnAceptar.Visible = true;
                        lblTituloAccion.Visible = true;
                        lblTituloAccion.Text = "Filtar";
                        lblAccion1.Text = "Hora hasta";
                        dtp1.Visible = true;
                        lblAccion2.Visible = false;
                        dtp2.Visible = false;
                        btnLimpiar.Visible = true;
                        break;
                    case 6:
                        btnAceptar.Visible = true;
                        lblTituloAccion.Visible = true;
                        lblTituloAccion.Text = "Filtar";
                        lblAccion1.Text = "Hora desde";
                        dtp1.Visible = true;
                        lblAccion2.Visible = true;
                        lblAccion2.Text = "Hora hasta";
                        dtp2.Visible = true;
                        btnLimpiar.Visible = true;
                        break;
                    default:
                        break;
                }
            
            }

        }

        private void filtrar()
        {
            List<Evento> filtrado = null;
            int selectedValue = Convert.ToInt32(cmbTipoFiltro.SelectedValue);
            if (selectedValue == 0)
                return;
            bool filtroHora = false;
            if (selectedValue >= 4)
                filtroHora = true;
            if (!filtroHora)
            {
                IFiltroFecha filtro;
                DateTime fecha1 = dtp1.Value.Date;
                DateTime fecha2 = dtp2.Value.Date;
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
            else
            {
                IFiltroHora filtro;
                TimeSpan hora1 = dtp1.Value.TimeOfDay;
                TimeSpan hora2 = dtp2.Value.TimeOfDay;
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbTipoFiltro.SelectedIndex = 0;
            cargarEventos();
        }
    }
}
