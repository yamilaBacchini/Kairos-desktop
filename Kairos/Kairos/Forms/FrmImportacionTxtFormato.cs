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
    public partial class FrmImportacionTxtFormato : Form
    {
        private List<string> valoresNoPermitidos = new List<string>();
        public string delimitador = "";
        public FrmImportacionTxtFormato()
        {
            InitializeComponent();
            this.valoresNoPermitidos.Add(" ");
            this.valoresNoPermitidos.Add(".");
            this.valoresNoPermitidos.Add(":");
            this.valoresNoPermitidos.Add("-");
            this.valoresNoPermitidos.Add("");
        }

        private void rbOtro_CheckedChanged(object sender, EventArgs e)
        {
            if(rbOtro.Checked==true)
            {
                btnAceptar.BackColor = Color.LightGray;
                btnAceptar.Enabled = false;
                txtOtro.BackColor = Color.White;
                txtOtro.Enabled = true;
            }
            else
            {
                btnAceptar.BackColor = Color.FromArgb(255, 128, 128);
                btnAceptar.Enabled = true;
                txtOtro.BackColor = Color.LightGray;
                txtOtro.Enabled = false;
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
           this.DialogResult=  DialogResult.No;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.delimitador=buscarSeleccionado();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private string buscarSeleccionado()
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

        private void txtOtro_TextChanged(object sender, EventArgs e)
        {
            if(esValorPermitido(txtOtro.Text))
            {
                btnAceptar.Enabled = true;
                btnAceptar.BackColor = Color.FromArgb(255, 128, 128);
            }
            else
            {
                btnAceptar.Enabled = false;
                btnAceptar.BackColor = Color.LightGray;
            }
        }

        private bool esValorPermitido(string valor)
        {
            if (this.valoresNoPermitidos.Contains(valor))
                return false;
            else
                return true;
        }
    }
}
