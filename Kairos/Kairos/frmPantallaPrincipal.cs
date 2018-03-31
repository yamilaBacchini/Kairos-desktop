using Kairos.Entidades;
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

                var resultado = (from o in db.Origenes select new { o.nombreOrigen, o.Id }).ToList();
                lbProyectosRecientes.ValueMember = "nombreOrigen";
                lbProyectosRecientes.Items.AddRange(resultado.ToArray());
            }
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

        private void btnImportarProyecto_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            this.leerArchivo(openFileDialog1.FileName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: No se puede abrir el archivo " + ex.Message);
                }
            }
        }

        private void leerArchivo(string fileName)
        {
            StreamReader objReader = new StreamReader(fileName);
            string sLine = "";
            ArrayList arrText = new ArrayList();

            while (sLine != null)
            {
                sLine = objReader.ReadLine();
                if (sLine != null)
                    arrText.Add(sLine);
            }
            objReader.Close();
            //creo el proyecto en la tabla origenes
            //checkear que no exista el nombre que se desea ingresar
            using (var db = new EventoContexto())
            {
                db.Origenes.Add(new Entidades.Origen { fechaCreacion = DateTime.Now, nombreOrigen = "nombre automatico", activo = true });
                db.SaveChanges();

                var idOrigenes = (from o in db.Origenes
                                  where o.nombreOrigen == "nombre automatico"
                                  select o.Id).ToList();
                int idOrigenInsertado = idOrigenes.First();

                foreach (string item in arrText)
                {
                    db.Eventos.Add(new Entidades.Evento { fecha =Convert.ToDateTime(item), idOrigen = idOrigenInsertado, activo = true });

                }
            }
            //busco el id origen por el nombre unico

        }

    }
}
