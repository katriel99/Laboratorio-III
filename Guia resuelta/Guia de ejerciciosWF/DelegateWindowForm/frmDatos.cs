﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace DelegateWindowForm
{
   
    public partial class frmDatos : Form
    {
        public frmDatos()
        {
            InitializeComponent();
        }

        public void ActualizarNombre(string nombre)
        {
            this.lblNombre.Text = nombre;
        }
        
        public void ActualizarFoto(string rutaDeFoto)
        {
            this.pictureBox1.ImageLocation = rutaDeFoto;
        }
    }
}
