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
    public partial class Estudiante : Form
    {
        public Estudiante()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Horario horario = new Horario();
            horario.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void BtnHorario_Click(object sender, EventArgs e)
        {
            Horario horario = new Horario();
            horario.Show();
        }

        private void BtnNotas_Click(object sender, EventArgs e)
        {
            Notas notas = new Notas();
            notas.Show();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Login2 login2 = new Login2();
            login2.Show();
        }
    }
}
