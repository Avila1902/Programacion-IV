﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2_Concatenar_texto
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            lblPalabra.Text = txtPal1.Text + " " + txtPal2.Text;
            txtPal1.Text = " ";
            txtPal2.Text = " ";
        }
    }
}
