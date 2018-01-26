﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            using (var db = new EventoContexto())
            {
                db.Database.EnsureCreated();

                var resultado = (from datos in db.Origenes select new { datos.nombreOrigen }).ToList();

                foreach (var item in resultado)
                {
                    lbOrigenes.Items.Add(item.nombreOrigen);
                }
             
            }

        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            using (var db = new EventoContexto())
            {
                db.Origenes.Add(new Entidades.Origen { fechaCreacion = DateTime.Now , nombreOrigen= "test", activo = true });
                db.SaveChanges();
            }
        }


    }
}
