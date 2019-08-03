using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace ADMINISTRADORES
{
    public partial class FmBoletaInscripcion : Form
    {
        public FmBoletaInscripcion()
        {
            InitializeComponent();
        }

        

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void FmBoletaInscripcion_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Document boleta = new Document();
            PdfWriter.GetInstance(boleta, new FileStream("E:/CreateBoleta.pdf", FileMode.Create));
            boleta.Open();
           /* boleta.Add(l);*/
            boleta.Close();
            MessageBox.Show("BOLETA LISTA");

        }
    }
}
