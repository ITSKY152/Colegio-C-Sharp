﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;

namespace Presentacion
{
    public partial class Pnestudio : Form
    {
        public Pnestudio()
        {
            InitializeComponent();
        }

        private void btneps_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("espacio vacio", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Lgestionusuario nestudio = new Lgestionusuario();
                string respuesta = nestudio.rnestudio(textBox1.Text);

                if (respuesta == "1")
                {
                    MessageBox.Show("Eps registrada con exito", "registrar eps", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (respuesta == "2")
                {
                    MessageBox.Show("Eps no registrada", "registrar eps", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
