using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kairos.Forms
{
    public partial class FrmImportacionExcelFormato : Form
    {
        public int hoja = -1;
        public int columna = -1;
        public int filaIncial = -1;
        
        public FrmImportacionExcelFormato()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.hoja = Convert.ToInt32(nudHoja.Value);
            this.columna = Convert.ToInt32(nudColumna.Value);
            this.filaIncial = Convert.ToInt32(nudFilaInicial.Value);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private void btncancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }
    }
}
