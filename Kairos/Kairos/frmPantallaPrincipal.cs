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

namespace Kairos
{
    public partial class frmPantallaPrincipal : Form
    {

        public frmPantallaPrincipal()
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
                frmProcesamiento frm = new frmProcesamiento(a.Id, a.nombreOrigen);
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

        private void btnNuevoProyecto_Click(object sender, EventArgs e)
        {
            frmAgregarProyecto frm = new frmAgregarProyecto();
            Visible = false;
            frm.ShowDialog();
            Visible = true;
            cargarLista();
        }

        private void btnImportarProyecto_Click(object sender, EventArgs e)
        {
           // Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "All supported files (*.txt, *.xls, *xlsx)|*.txt;*.xls;*.xlsx|Text files (*.txt)|*.txt|Excel files (*.xls,*.xlsx)|*.xls; *.xlsx*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                int indice = openFileDialog1.FileName.LastIndexOf(".");
                string extencion = openFileDialog1.FileName.Substring(indice + 1);
                IImportarService importador = null;
                switch (extencion)
                {
                    case "txt":
                        formImportacionTxtFormato frmtxt = new formImportacionTxtFormato();
                        if (frmtxt.ShowDialog() == DialogResult.OK)
                        {
                            importador = new ImportarTxtFile(frmtxt.delimitador);
                        }
                        break;
                    case "xls":
                    case "xlsx":
                        formImportacionExcelFormato frmxls = new formImportacionExcelFormato();
                        if (frmxls.ShowDialog() == DialogResult.OK)
                        {
                            importador = new ImportarExcelFile(frmxls.hoja,frmxls.columna,frmxls.filaIncial);
                        }
                        break;
                    default:
                        break;
                }
                if (importador != null)
                {
                    bool resultado = importador.importarArchivo(openFileDialog1.FileName);
                    if (resultado == true)
                    {
                        MessageBox.Show("El archivo se importó correctamente", "Importar Archivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarLista();
                    }
                    else
                    {
                        MessageBox.Show(" No se puede abrir el archivo", "Error de importación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               
            }
        }




        private void btnAdministrarProyectos_Click(object sender, EventArgs e)
        {
            var seleccionado = lbProyectosRecientes.SelectedItem;
            var a = new { nombreOrigen = "", Id = 0 };
            a = Cast(a, seleccionado);
            frmAdministrarProyecto frm = new frmAdministrarProyecto(a.Id, a.nombreOrigen);
            Visible = false;
            frm.ShowDialog();
            Visible = true;
            cargarLista();
        }
    }
}
