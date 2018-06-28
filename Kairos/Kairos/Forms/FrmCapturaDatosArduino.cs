using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using Kairos.Arduino;

namespace Kairos.Forms
{
    public partial class FrmCapturaDatosArduino : Form
    {
        SerialPort serialPort = new SerialPort();
        EscrituraTxt escribirDistancias;

        string estado = null;               //Estado del Form que puede ser "iniciado" o "finalizado"

        public FrmCapturaDatosArduino()
        {
            InitializeComponent();

            // Creamos el evento para leer datos desde puerto serial
            serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);

            // Inicializamos comboBox de lectura de puerto y parametro de velocidad de transmicion por puerto serial
            comboBoxPuerto.SelectedIndex = 2;
            serialPort.BaudRate = 9600;
            // Asignamos las propiedades ---- PARA LEER DESDE UN ARCHIVO DE CONFIGURACION probando branch1 -----
            serialPort.BaudRate = 9600;
            serialPort.PortName = "COM3";



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            string inData;
            //Si el puerto esta abierto
            if (serialPort.IsOpen)
            {
                //Si hay algun archivo de escritura abierto
                if (escribirDistancias.estaAbierto())
                {
                    // Obtenemos el puerto serie que lanza el evento
                    SerialPort currentSerialPort = (SerialPort)sender;

                    // Leemos el dato recibido del puerto serie
                    inData = currentSerialPort.ReadLine();
                    escribirDistancias.escribir(inData + ", ");

                    // Y lo escribimos en un label inferior del Form
                    labelLectura.Text = inData;
                }

            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (escribirDistancias != null)
            {
                escribirDistancias.cerrarArchivo();
                try
                {
                    // Cerramos el puerto serie
                    serialPort.Close();
                }
                catch
                {
                    MessageBox.Show("Error", "Error al cerrar el puerto serie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void buttonComenzar_Click(object sender, EventArgs e)
        {
            //Si no se inicio ya una grabacion
            if (estado != "iniciado")
            {
                //Seteo el puerto para la lectura del Puerto Serial
                if (comboBoxPuerto.Enabled == true)
                {
                    serialPort.PortName = comboBoxPuerto.Text;
                }

                // Valida que se haya seleccionado algun archivo
                if (textBoxExplorar.Text == "")
                {
                    // Set the error if the age is too young.
                    errorProviderExplorar.SetError(textBoxExplorar, "Seleccione archivo donde se grabaran los datos");
                    return;
                }

                // Instancio clase para controlar escritura de archivo
                escribirDistancias = new EscrituraTxt(textBoxExplorar.Text);

                // Creamos el evento para manejo del puerto serial
                serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);

                // Controlamos que el puerto indicado esté operativo y lo abrimos para la conexion
                // Sino mandamos mensaje de error ARDUINO y cerramos el Form
                try
                {
                    if (serialPort.IsOpen == false)
                    {
                        serialPort.Open();
                        DateTime localDate = DateTime.Now;
                        serialPort.Write(localDate.ToString());
                    }

                }
                catch
                {
                    MessageBox.Show("ERROR AL DETECTAR ARDUINO");
                    this.Close();
                }




                // Cambiamos el label inferior de Estado
                labelEstado.Text = "Capturando Datos...";

                //Deshabilito componentes del Form una vez iniciada la grabacion
                comboBoxPuerto.Enabled = false;
                textBoxExplorar.Enabled = false;
                buttonExplorar.Enabled = false;

                //Marco como iniciado el estado del form
                estado = "iniciado";
            }


        }


        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            if (estado == "iniciado")
            {
                // Cierro Archivo
                escribirDistancias.cerrarArchivo();

                // Limpiamos label de Estado y textBox
                labelEstado.Text = "Presione comenzar para capturar datos";
                labelLectura.Text = "";

                //Vuelvo a habilitar componentes del Form
                textBoxExplorar.Enabled = true;
                buttonExplorar.Enabled = true;

                //Marco como estado del form = finalizada la grabacion
                estado = "finalizado";

            }
        }



        private void buttonExplorar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Documento de texto|*.txt";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxExplorar.Text = ofd.FileName;
            }

        }

        private void textBoxExplorar_TextChanged(object sender, EventArgs e)
        {

        }

    }


}






