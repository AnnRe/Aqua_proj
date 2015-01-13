using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp;
using PdfSharp.Charting;
using PdfSharp.Pdf;
using PdfSharp.Fonts;
using PdfSharp.Internal;
using PdfSharp.Drawing;
using PdfSharp.Forms;
using PdfSharp.SharpZipLib;



namespace aquadrom
{
    public partial class GeneratorNotatek : Form
    {
        public static bool exist = false;
        public GeneratorNotatek()
        {
            InitializeComponent();
            exist = true;
        }

        private void GeneratorNotatek_Load(object sender, EventArgs e)
        {

        }

        private void GeneratorNotatek_FormClosing(object sender, FormClosingEventArgs e)
        {
            exist = false;
        }




        private void Generuj_Click(object sender, EventArgs e)
        {
            double x = 50, y = 100;
            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Verdana", 10, XFontStyle.Bold);
            string trescNotatki = TekstNotatki.Text.ToString();
            gfx.DrawString(trescNotatki, font, XBrushes.Black, x, y);
            string filename = "test.pdf";
            XPen pen = new XPen(Color.Black, 1);
            gfx.DrawLine(pen, 45, 250, 45, 1000);
            document.Save(filename);
            MessageBox.Show("Wygenerowano notatkę.");
            //MessageBox.Show(TekstNotatki.Text.ToString());
        }

        private void TekstNotatki_TextChanged(object sender, EventArgs e)
        {
        }

    }
}
