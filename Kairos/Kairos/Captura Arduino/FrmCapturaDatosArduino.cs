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

namespace
 WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        SerialPort serialPort = new SerialPort();
        ClassEscrituraTxt escribirDistancias;

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            
            // Creamos el evento
            serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
            // Asignamos las propiedades ---- PARA LEER DESDE UN ARCHIVO DE CONFIGURACION -----
            serialPort.BaudRate = 9600;
            serialPort.PortName = "COM3";

          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            if (serialPort.IsOpen)
            {
                // Obtenemos el puerto serie que lanza el evento
                SerialPort currentSerialPort = (SerialPort)sender;

                // Leemos el dato recibido del puerto serie
                string inData = currentSerialPort.ReadLine();
                escribirDistancias.escribir(inData + ", ");

                if (escribirDistancias.estaAbierto())
                {
                    labelLectura.Text = inData;
                }
                
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            escribirDistancias.cerrarArchivo();
            try
            {
                // Cerramos el puerto serie
                serialPort.Close();
            }
            catch
            {

            }
        }

        private void buttonComenzar_Click(object sender, EventArgs e)
        {
            // Valida que se haya seleccionado algun archivo
            if (textBoxExplorar.Text == "")
            {
                // Set the error if the age is too young.
                errorProviderExplorar.SetError(textBoxExplorar, "Seleccione archivo donde se grabaran los datos");
            }
           
            // Instancio clase para controlar escritura de archivo
            escribirDistancias = new ClassEscrituraTxt(textBoxExplorar.Text);

            // Creamos el evento para manejo del puerto serial
            serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
            
            // Controlamos que el puerto indicado esté operativo y lo abrimos para la conexion
                // Sino mandamos mensaje de error ARDUINO y cerramos el Form
            try
            {
                serialPort.Open();
            }
            catch
            {
                MessageBox.Show("ERROR AL DETECTAR ARDUINO");
                this.Close();
            }

            // Cambiamos el label inferior de Estado
            labelEstado.Text = "Capturando Datos...";

        }


        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            // Cierro Archivo
            escribirDistancias.cerrarArchivo();
            
            // Limpiamos label de Estado y textBox
            labelEstado.Text = "Presione comenzar para capturar datos";
            labelLectura.Text = "";
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






