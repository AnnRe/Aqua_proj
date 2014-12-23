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
            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Verdana", 20, XFontStyle.Bold);
            gfx.DrawString("Hello, World!", font, XBrushes.Black,
            new XRect(0, 0, page.Width, page.Height), XStringFormat.Center);
            string filename = "HelloWorld.pdf";
            document.Save(filename);
        }
    }
}
