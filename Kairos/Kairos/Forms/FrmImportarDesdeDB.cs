using Kairos.Entidades;
using Kairos.Services;
using Kairos.Services.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Kairos.Forms
{
    public partial class FrmImportarDesdeDB : Form
    {
        private static readonly IImportarDesdeDB importador = new ImportarDesdeDBImpl();

        private Origen proyecto = null;

        public FrmImportarDesdeDB()
        {
            InitializeComponent();
        }

        public FrmImportarDesdeDB(Origen proyecto)
        {
            InitializeComponent();
            this.proyecto = proyecto;
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            string connectionString = txtConnectionString.Text;
            string database = txtNombreDB.Text;
            string nombreTabla = txtNombreTabla.Text;
            string nombreColumna = txtNombreColumna.Text;
            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("Debe completar el campo connection string", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(database))
            {
                MessageBox.Show("Debe completar el base de datps", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(nombreTabla))
            {
                MessageBox.Show("Debe completar el campo nombre de tabla", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(nombreColumna))
            {
                MessageBox.Show("Debe completar el campo connection string", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            List<DateTime> dates = importador.ObtenerColumnaDesdeDB(connectionString, database, nombreTabla, nombreColumna);
            if (dates != null)
            {
                EventoService.agregarTodos(dates.Select(x =>
                {
                    Evento aux = new Evento();
                    aux.activo = true;
                    aux.fecha = x;
                    aux.idOrigen = proyecto.Id;
                    return aux;
                }).ToList());
                MessageBox.Show("Importacion exitosa!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("No se ha podido extraer la informacion solicitada. Por favor revise los datos", "Error de importacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
