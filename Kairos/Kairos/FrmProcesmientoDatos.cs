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
        private bool timerActivo = false;
        private List<Filtro> filtros = null;
        private readonly INuevoFiltro filtrador = new FiltroImpl();

        public FrmProcesmientoDatos(string nombreProyecto, int idOrigen)
        {
            InitializeComponent();
            this.idOrigen = idOrigen;
            this.nombreProyecto = nombreProyecto;
            //lblNombreProyecto.Text = nombreProyecto;
            filtros = new List<Filtro>();
            setupFiltrosCheckboxList();
            cargarFiltros();
            cambiarFiltros(0);
            cargarEventos();
        }

        private void setupFiltrosCheckboxList()
        {
            ((ListBox)this.chlFiltros).DisplayMember = "Name";
            ((ListBox)this.chlFiltros).ValueMember = "IsChecked";
            for (int i = 0; i < this.filtros.Count; i++)
            {
                if (!chlFiltros.Items.Contains(filtros[i]))
                {
                    chlFiltros.Items.Add(filtros[i]);
                    Filtro obj = (Filtro)chlFiltros.Items[i];
                    chlFiltros.SetItemChecked(i, obj.IsChecked);
                }
            }
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

            if (eventos != null && tipoAccion == TipoAccionProcesamiento.FILTRAR)
                filtrar();
        }

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            tipoAccion = TipoAccionProcesamiento.AGREGAR_REGISTRO;
            modificarLayout(tipoAccion);
            botonSeleccionado(btnAgregarRegistro);
        }

        private void btnModificarRegistro_Click(object sender, EventArgs e)
        {
            tipoAccion = TipoAccionProcesamiento.MODIFICAR_REGISTRO;
            modificarLayout(tipoAccion);
            botonSeleccionado(btnModificarRegistro);
        }

        private void btnBorrarSeleccionados_Click(object sender, EventArgs e)
        {
            tipoAccion = TipoAccionProcesamiento.BORRAR_SELECCIONADOS;
            modificarLayout(tipoAccion);
            botonSeleccionado(btnBorrarSeleccionados);
            int cant = eventosSeleccionados.Count;

            foreach (var item in eventosSeleccionados)
            {
                EventoService.borrar(item.Id);
            }
            cargarEventos();

            if (eventosSeleccionados.Count > 1)
                mostrarMensaje("Registros eliminados correctamente", Color.FromArgb(128, 255, 128));
            else if (eventosSeleccionados.Count == 1)
                mostrarMensaje("Registro eliminado correctamente", Color.FromArgb(128, 255, 128));
        }

        private void btnSeleccionarTodos_Click(object sender, EventArgs e)
        {
            tipoAccion = TipoAccionProcesamiento.SELECCIONAR_TODOS;
            modificarLayout(tipoAccion);
            dgwEventos.SelectAll();
            botonSeleccionado(btnSeleccionarTodos);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            tipoAccion = TipoAccionProcesamiento.FILTRAR;
            modificarLayout(tipoAccion);
            botonSeleccionado(btnFiltrar);
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
                        control.Visible = true;
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
                        control.Visible = true;
                    }
                    lblTipoFiltro.Visible = true;
                    cmbTipoFiltro.Visible = true;
                    btnLimpiar.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void botonSeleccionado(Control boton)
        {
            btnBorrarSeleccionados.BackColor = Color.FromArgb(187, 0, 4);
            foreach (Control control in pnlAcciones.Controls)
            {
                if (control != btnBorrarSeleccionados)
                {
                    control.BackColor = Color.Black;
                    control.ForeColor = Color.White;
                }


            }

            if (boton != btnBorrarSeleccionados)
            {
                boton.BackColor = Color.FromArgb(38, 38, 38);
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
                    mostrarMensaje("Registro agregado correctamente", Color.FromArgb(128, 255, 128));
                    cargarEventos();
                    break;
                case TipoAccionProcesamiento.MODIFICAR_REGISTRO:
                    fecha = new DateTime(dtp1.Value.Year, dtp1.Value.Month, dtp1.Value.Day, dtp2.Value.Hour, dtp2.Value.Minute, dtp2.Value.Second);
                    if (eventosSeleccionados.Count == 1)
                    {
                        EventoService.modificar(eventosSeleccionados[0].Id, fecha);
                        cargarEventos();
                        mostrarMensaje("Registro modificado correctamente", Color.FromArgb(128, 255, 128));
                    }
                    else
                        mostrarMensaje("Seleccione solo un registro", Color.FromArgb(255, 89, 89));
                    break;
                case TipoAccionProcesamiento.FILTRAR:
                    agregarFiltro();
                    filtrar();
                    mostrarMensaje("Filtro aplicado correctamente", Color.FromArgb(128, 255, 128));
                    break;
                default:
                    break;
            }
        }

        private void mostrarMensaje(string mensaje, Color color)
        {
            lblMensaje.Text = mensaje;
            lblMensaje.Visible = true;
            pnlMensaje.Visible = true;
            pnlMensaje.BackColor = color;
            if (this.timerActivo)
                timerMensaje.Stop();

            timerMensaje.Start();
            this.timerActivo = true;
        }

        private void timerMensaje_Tick(object sender, EventArgs e)
        {
            pnlMensaje.Visible = false;
            timerMensaje.Stop();
            this.timerActivo = false;
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
            List<ComboItem> tipos = new List<ComboItem> { new ComboItem(0, "Fecha menor a"), new ComboItem(1, "Fecha mayor a"), new ComboItem(2, "Hora menor a"), new ComboItem(3, "Hora mayor a") };
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
            if (tipoAccion == TipoAccionProcesamiento.FILTRAR)
            {
                if (valorSeleccionado > 1)
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
                    case 1:
                        btnAceptar.Visible = true;
                        lblTituloAccion.Visible = true;
                        lblTituloAccion.Text = "Filtar";
                        lblAccion1.Text = "Fecha hasta";
                        dtp1.Visible = true;
                        lblAccion2.Visible = false;
                        dtp2.Visible = false;
                        btnLimpiar.Visible = true;
                        break;
                    case 2:
                        btnAceptar.Visible = true;
                        lblTituloAccion.Visible = true;
                        lblTituloAccion.Text = "Filtar";
                        lblAccion1.Text = "Hora desde";
                        dtp1.Visible = true;
                        lblAccion2.Visible = false;
                        dtp2.Visible = false;
                        btnLimpiar.Visible = true;
                        break;
                    case 3:
                        btnAceptar.Visible = true;
                        lblTituloAccion.Visible = true;
                        lblTituloAccion.Text = "Filtar";
                        lblAccion1.Text = "Hora hasta";
                        dtp1.Visible = true;
                        lblAccion2.Visible = false;
                        dtp2.Visible = false;
                        btnLimpiar.Visible = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void agregarFiltro()
        {
            int selectedValue = Convert.ToInt32(cmbTipoFiltro.SelectedValue);
            Filtro auxFiltro = null;
            DateTime fecha = dtp1.Value.Date;
            switch (selectedValue)
            {
                case 0:
                    auxFiltro = new Filtro(TipoFiltro.FECHA_MENOR, fecha);
                    break;
                case 1:
                    auxFiltro = new Filtro(TipoFiltro.FECHA_MAYOR, fecha);
                    break;
                case 2:
                    auxFiltro = new Filtro(TipoFiltro.HORA_MENOR, fecha);
                    break;
                case 3:
                    auxFiltro = new Filtro(TipoFiltro.HORA_MAYOR, fecha);
                    break;
                default:
                    auxFiltro = null;
                    break;
            }
            filtros.Add(auxFiltro);
            setupFiltrosCheckboxList();
        }

        private void filtrar()
        {
            List<Evento> filtrado = filtrador.Filtrar(idOrigen, filtros);
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
            filtros.Clear();
            cargarEventos();
        }

        private bool _updatingCheckList = false;

        private void chlFiltros_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (_updatingCheckList) return;
            _updatingCheckList = true;
            CheckState state = e.CurrentValue;
            if (state == CheckState.Checked)
                this.filtros[e.Index].IsChecked = true;
            else
                this.filtros[e.Index].IsChecked = false;
            filtrar();
            _updatingCheckList = false;
        }
    }
}
