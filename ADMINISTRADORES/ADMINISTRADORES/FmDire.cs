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
    public partial class FmDire : Form
    {
        public FmDire()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Document boleta = new Document();
            PdfWriter.GetInstance(boleta, new FileStream("E:/Crear Dire.pdf", FileMode.Create));
            boleta.Open();
            /* boleta.Add(l);*/
            boleta.Close();
            MessageBox.Show("DIRE LISTO");
        }

        private void TxtFecha_TextChanged(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            TxtFecha.Text = dateTime.ToShortDateString();
        }
    }
}
