﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMINISTRADORES
{
    public partial class FmAdmin : Form
    {
        public FmAdmin()
        {
            InitializeComponent();
        }

        private void BtnAsignaciones_Click(object sender, EventArgs e)
        {
            FmAsignacion O = new FmAsignacion();
            O.ShowDialog();
        }

        private void BtnInscripciones_Click(object sender, EventArgs e)
        {
            FmInscripcion i = new FmInscripcion();
            i.ShowDialog();
         }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
