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
    public partial class frmCierreCaja : Form
    {
        public frmCierreCaja()
        {
            InitializeComponent();
        }

        private void btnCancelarCierreCaja_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBilletes500CierreCaja_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCancelarCerrarCaja_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}