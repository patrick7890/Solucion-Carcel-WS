﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carcel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            preso.WSPresoClient p = new preso.WSPresoClient();
            p.AgregarPreso(txtID.Text, txtNombre.Text, ushort.Parse(cboSexo.SelectedIndex.ToString()), ushort.Parse(cboVisita.SelectedIndex.ToString()), cboPenal.SelectedIndex);


        }

        
    }
}
