﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class frmSalidasCaja : Form
    {
        public frmSalidasCaja()
        {
            InitializeComponent();
        }

        private void btnSalirPagosCaja_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalirAperturarCaja_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
