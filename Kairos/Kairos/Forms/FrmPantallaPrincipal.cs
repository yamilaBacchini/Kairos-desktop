using Kairos.Arduino;
using Kairos.Entidades;
using Kairos.Services;
using Kairos.Services.Implementaciones;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kairos.Forms
{
    public partial class FrmPantallaPrincipal : Form
    {

        public FrmPantallaPrincipal()
        {
            InitializeComponent();

            using (var db = new EventoContexto())
            {
                db.Database.EnsureCreated();
                cargarLista();
            }
        }

        private void cargarLista()
        {
            var resultado = (from o in new EventoContexto().Origenes select new { o.nombreOrigen, o.Id }).ToList();
            lbProyectosRecientes.ValueMember = "nombreOrigen";
            lbProyectosRecientes.Items.Clear();
            lbProyectosRecientes.Items.AddRange(resultado.ToArray());
        }

        private void btnProcesarDatos_Click(object sender, EventArgs e)
        {
            if (lbProyectosRecientes.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un proyecto de la lista", "Falta selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var seleccionado = lbProyectosRecientes.SelectedItem;
                var a = new { nombreOrigen = "", Id = 0 };
                a = Cast(a, seleccionado);
                FrmProcesmientoDatos frm = new FrmProcesmientoDatos(a.nombreOrigen, a.Id);
                Visible = false;
                frm.ShowDialog();
                Visible = true;
            }
        }

        private static T Cast<T>(T typeHolder, Object x)
        {
            // typeHolder above is just for compiler magic
            // to infer the type to cast x to
            return (T)x;
        }

        private List<string> valoresNoPermitidos = new List<string>() { " ", ".", ":", "-", "" };
        private OpenFileDialog openFileDialog1 = new OpenFileDialog();
        private string extencion = "";

        private void btnImportarProyecto_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "All supported files (*.txt, *.xls, *xlsx)|*.txt;*.xls;*.xlsx|Text files (*.txt)|*.txt|Excel files (*.xls,*.xlsx)|*.xls; *.xlsx*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pnlImportacion.Visible = true;
                int indice = openFileDialog1.FileName.LastIndexOf(".");
                extencion = openFileDialog1.FileName.Substring(indice + 1);
                switch (extencion)
                {
                    case "txt":
                        lblTituloImportacion.Text = "Indique el delimitador";
                        pnlImportacionTxt.Visible = true;
                        pnlImportacionExcel.Visible = false;
                        break;
                    case "xls":
                    case "xlsx":
                        lblTituloImportacion.Text = "Indique la ubicación de los datos";
                        pnlImportacionExcel.Visible = true;
                        pnlImportacionTxt.Visible = false;
                        break;
                    default:
                        break;
                }
            }
        }

        private void txtNombreModificado_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreProyecto.Text != "")
                btnAceptarModificar.Visible = true;
            else
                btnAceptarModificar.Visible = false;
        }

        private void btnCancelarModificacion_Click(object sender, EventArgs e)
        {
            modificacionInvisible();
        }

        private void btnAceptarModificacion_Click(object sender, EventArgs e)
        {
            if (btnAceptarModificar.Text != "Crear")
            {
                var seleccionado = lbProyectosRecientes.SelectedItem;
                var a = new { nombreOrigen = "", Id = 0 };
                a = Cast(a, seleccionado);
                ProyectoService.modificarProyecto(a.Id, txtNombreProyecto.Text);

                lblMensaje.Text = "Se modifico el proyecto " + txtNombreProyecto.Text + "correctamente";
                panelNotificaciones.Visible = true;
                timerMensaje.Start();
            }
            else
            {
                ProyectoService.nuevoProyecto(txtNombreProyecto.Text + ".prk");//le agrega la extension

                lblMensaje.Text = "Se creo el proyecto " + txtNombreProyecto.Text + ".prk correctamente";
                panelNotificaciones.Visible = true;
                timerMensaje.Start();
            }

            btnImportarProyecto.Enabled = false;
            btnProcesarDatos.Enabled = false;
            btnArduino.Enabled = false;
            modificacionInvisible();
            cargarLista();
        }

        private void imgAgregar_Click(object sender, EventArgs e)
        {
            txtNombreProyecto.Clear();
            txtNombreProyecto.Focus();
            btnAceptarModificar.Text = "Crear";
            panelNombreProyecto.Visible = true;
        }

        private void imgBorrar_Click(object sender, EventArgs e)
        {
            var seleccionado = lbProyectosRecientes.SelectedItem;
            if (seleccionado != null)
            {
                var a = new { nombreOrigen = "", Id = 0 };
                a = Cast(a, seleccionado);
                ProyectoService.borrarProyecto(a.Id);

                lblMensaje.Text = "Se elimino el proyecto " + a.nombreOrigen + " correctamente";
                panelNotificaciones.Visible = true;
                timerMensaje.Start();
                lbProyectosRecientes.ClearSelected();

                pnlImportacion.Visible = false;
                modificacionInvisible();
                cargarLista();
            }
        }

        private void imgEditar_Click(object sender, EventArgs e)
        {
            var seleccionado = lbProyectosRecientes.SelectedItem;

            if (seleccionado != null)
            {
                var a = new { nombreOrigen = "", Id = 0 };
                a = Cast(a, seleccionado);
                txtNombreProyecto.Text = a.nombreOrigen.Substring(0, a.nombreOrigen.Length - 4); //le saco la extension

                txtNombreProyecto.Focus();
                btnAceptarModificar.Text = "Modificar";
                btnAceptarModificar.Visible = true;
                panelNombreProyecto.Visible = true;
            }
        }

        private void modificacionInvisible()
        {
            panelNombreProyecto.Visible = false;
            btnAceptarModificar.Visible = false;
        }

        private void timerMensaje_Tick(object sender, EventArgs e)
        {
            panelNotificaciones.Visible = false;
            timerMensaje.Stop();
        }

        private void imgAgregar_MouseHover(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pb.BackColor = Color.LavenderBlush;
            pb.BorderStyle = BorderStyle.FixedSingle;
        }

        private void imgAgregar_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pb.BackColor = Color.FromArgb(255, 192, 192);
            pb.BorderStyle = BorderStyle.None;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnArduino_Click(object sender, EventArgs e)
        {
            var selectedItem = Cast(new { nombreOrigen = "", Id = 0 }, lbProyectosRecientes.SelectedItem);
            FrmCapturaDatosArduino frm = new FrmCapturaDatosArduino(new Origen {nombreOrigen=selectedItem.nombreOrigen,Id=selectedItem.Id });
            Visible = false;
            frm.ShowDialog();
            Visible = true;
        }

        private void rbOtro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOtro.Checked == true)
            {
                btnAceptarImportacion.BackColor = Color.LightGray;
                btnAceptarImportacion.Enabled = false;
                txtOtro.BackColor = Color.White;
                txtOtro.Enabled = true;
            }
            else
            {
                btnAceptarImportacion.BackColor = Color.FromArgb(240, 100, 100);
                btnAceptarImportacion.Enabled = true;
                txtOtro.BackColor = Color.LightGray;
                txtOtro.Enabled = false;
            }
        }

        private string BuscarSeleccionado()
        {
            string resultado = "";
            if (rbComa.Checked == true)
                resultado = ",";
            else if (rbEnter.Checked == true)
                resultado = "enter";
            else if (rbPipe.Checked == true)
                resultado = "|";
            else if (rbTab.Checked == true)
                resultado = "\t";
            else if (rbOtro.Checked == true)
                resultado = txtOtro.Text;
            return resultado;
        }

        private bool EsValorPermitido(string valor)
        {
            if (this.valoresNoPermitidos.Contains(valor))
                return false;
            else
                return true;
        }

        private void btnAceptarImportacion_Click(object sender, EventArgs e)
        {
            IImportarService importador = null;
            switch (extencion)
            {
                case "txt":
                    string delimitador = BuscarSeleccionado();
                    importador = new ImportarTxtFile(delimitador);
                    break;
                case "xls":
                case "xlsx":
                    int hoja = Convert.ToInt32(nudHoja.Value);
                    int columna = Convert.ToInt32(nudColumna.Value);
                    int filaIncial = Convert.ToInt32(nudFilaInicial.Value);
                    importador = new ImportarExcelFile(hoja, columna, filaIncial);
                    break;
                default:
                    break;
            }
            pnlImportacionTxt.Visible = false;
            pnlImportacionExcel.Visible = false;
            if (importador != null)
            {
                bool resultado = false;
                string fileName = openFileDialog1.FileName;
                var seleccionado = lbProyectosRecientes.SelectedItem;
                var a = new { nombreOrigen = "", Id = 0 };
                a = Cast(a, seleccionado);
                resultado = importador.importarArchivoEnProyectoExistente(fileName, a.Id);
                if (resultado) {
                    lblMensaje.Text = "El archivo se importó correctamente";
                    panelNotificaciones.Visible = true;
                    timerMensaje.Start();
                    cargarLista();
                    lbProyectosRecientes.SelectedItem = seleccionado;
                } else {
                    MessageBox.Show(" No se puede abrir el archivo", "Error de importación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            pnlImportacion.Visible = false;
        }

        private void btncancelarImportacion_Click(object sender, EventArgs e)
        {
            pnlImportacion.Visible = false;
        }

        private void txtOtro_TextChanged(object sender, EventArgs e)
        {
            bool mostrar = false;
            if (EsValorPermitido(txtOtro.Text))
                mostrar = true;
            EsconderOMostrarBotonAceptarImportacion(mostrar);
        }

        private void EsconderOMostrarBotonAceptarImportacion(bool mostrar)
        {
            if (mostrar)
            {
                btnAceptarImportacion.BackColor = Color.FromArgb(255, 128, 128);
                btnAceptarImportacion.Enabled = true;
            }
            else
            {
                btnAceptarImportacion.BackColor = Color.LightGray;
                btnAceptarImportacion.Enabled = false;
            }
        }

        private void btnProyectos_Click(object sender, EventArgs e)
        {
            pnlImportacion.Visible = false;
            pnlProyectos.Visible = true;
        }

        private void lbProyectosRecientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbProyectosRecientes.SelectedItem != null )
            {
                btnImportarProyecto.Enabled = true;
                btnProcesarDatos.Enabled = true;
                btnArduino.Enabled = true;

                if (btnAceptarModificar.Text != "Crear")
                {
                    var selectedItem = Cast(new { nombreOrigen = "", Id = 0 }, lbProyectosRecientes.SelectedItem);
                    txtNombreProyecto.Text = selectedItem.nombreOrigen.Substring(0, selectedItem.nombreOrigen.Length - 4);
                }
            } else
            {
                btnImportarProyecto.Enabled = false;
                btnProcesarDatos.Enabled = false;
                btnArduino.Enabled = false;
            }
            
        }
    }
}
