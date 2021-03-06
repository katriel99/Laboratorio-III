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
    
    public partial class frmTestDelegados : Form
    {
        public string NombreActualizado;
        private string rutaDeArchivo;
        public frmTestDelegados()
        {
            InitializeComponent();
            this.ConfigurarOpenSaveFileDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ((Form1)this.Owner).objDelegado(this.txtNombre.Text);
            ((Form1)this.Owner).objDelegado2(this.rutaDeArchivo);

        }

        private void ConfigurarOpenSaveFileDialog()
        {
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog1.DefaultExt = ".jpg";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.Multiselect = false;
            openFileDialog1.Title = "Seleccione una foto...";
        }

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
                this.rutaDeArchivo = this.openFileDialog1.FileName;
            
        }
    }
}
