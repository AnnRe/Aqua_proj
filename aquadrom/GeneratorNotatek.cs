using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Globalization;
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
using DB;
using Objects;
using aquadrom.Utilities;
using aquadrom.Objects;
using System.Text.RegularExpressions;
//using MigraDoc;



namespace aquadrom
{
    public partial class GeneratorNotatek : Form
    {
        DBAdapter adapter = new DBAdapter();
        DBConnector polaczenie = new DBConnector();
        Validations blokady = new Validations();
        Validations walidacja = new Validations();
        public static bool exist = false;
        public string getName = Constants.PracownikImie + " from Pracownik WHERE " + Constants.PracownikLogin + "='";
        public string getSurname = Constants.PracownikNazwisko + " from Pracownik WHERE " + Constants.PracownikLogin + "='";
        public string getStanowisko = Constants.PracownikStanowisko + " from Pracownik WHERE " + Constants.PracownikLogin + "='";
        public string getMiasto = Constants.PracownikMiasto + " from Pracownik WHERE " + Constants.PracownikLogin + "='";
        public string getUlica = Constants.PracownikUlica + " from Pracownik WHERE " + Constants.PracownikLogin + "='";
        public string getNrDomu = Constants.PracownikNrDom + " from Pracownik WHERE " + Constants.PracownikLogin + "='";
        public string getNrMieszkania = Constants.PracownikNrMieszkania + " from Pracownik WHERE " + Constants.PracownikLogin + "='";
        public string getNrTel = Constants.PracownikTel + " from Pracownik WHERE " + Constants.PracownikLogin + "='";
        public string getMail = Constants.PracownikMail + " from Pracownik WHERE " + Constants.PracownikLogin + "='";
        public string getID = Constants.PracownikID + " from Pracownik WHERE " + Constants.PracownikLogin + "='";
        public GeneratorNotatek(string login)
        {
            getName += login;
            getName += "'";
            getSurname += login;
            getSurname += "'";
            getStanowisko += login;
            getStanowisko += "'";
            getMiasto += login;
            getMiasto += "'";
            getUlica += login;
            getUlica += "'";
            getNrDomu += login;
            getNrDomu += "'";
            getNrMieszkania += login;
            getNrMieszkania += "'";
            getNrTel += login;
            getNrTel += "'";
            getMail += login;
            getMail += "'";
            getID += login;
            getID += "'";


            InitializeComponent();
            exist = true;
        }

        private void GeneratorNotatek_Load(object sender, EventArgs e)
        {
            imieWzywajacego.Text = "brak";
            nazwiskoWzywajacego.Text = "brak";
            imieFunkc.Text = "brak";
            nazwiskoFunkc.Text = "brak";
            imieWzywajacego.Enabled = false;
            nazwiskoWzywajacego.Enabled = false;
            imieFunkc.Enabled = false;
            nazwiskoFunkc.Enabled = false;
        }

        private void GeneratorNotatek_FormClosing(object sender, FormClosingEventArgs e)
        {
            exist = false;
        }

        public void generujNotatke()
        {
            double x = 54, y = 350;
            PdfDocument document = new PdfDocument();
            DataTable ids2 = polaczenie.Select(getName);
            string name = ids2.Rows[0][0].ToString();
            DataTable ids3 = polaczenie.Select(getSurname);
            string surname = ids3.Rows[0][0].ToString();
            DataTable ids4 = polaczenie.Select(getStanowisko);
            string sanowisko= ids4.Rows[0][0].ToString();
            DataTable ids5 = polaczenie.Select(getMiasto);
            string miasto = ids5.Rows[0][0].ToString();
            DataTable ids6 = polaczenie.Select(getUlica);
            string ulica = ids6.Rows[0][0].ToString();
            DataTable ids7 = polaczenie.Select(getNrDomu);
            string nrDomu = ids7.Rows[0][0].ToString();
            DataTable ids8 = polaczenie.Select(getNrMieszkania);
            string nrMieszkania = ids8.Rows[0][0].ToString();
            DataTable ids9 = polaczenie.Select(getNrTel);
            string tel = ids9.Rows[0][0].ToString();
            DataTable ids10 = polaczenie.Select(getMail);
            string mail = ids10.Rows[0][0].ToString();
            DataTable ids11 = polaczenie.Select(getID);
            string id = ids11.Rows[0][0].ToString();
            XPdfFontOptions opcja = new XPdfFontOptions(PdfFontEncoding.Unicode, PdfFontEmbedding.Always);
            XFont font = new XFont("Times New Roman", 10, XFontStyle.Regular, opcja);
            XFont font2 = new XFont("Times New Roman", 12, XFontStyle.Bold,opcja);
            XFont font3 = new XFont("Times New Roman", 15, XFontStyle.Bold,opcja);
            XFont font4 = new XFont("Times New Roman", 10, XFontStyle.Bold,opcja);
            XFont font5 = new XFont("Times New Roman", 7, XFontStyle.Bold,opcja);
            PdfPage page = document.AddPage();
            XStringFormat format = new XStringFormat();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XPen pen = new XPen(XColors.Black, 0);
            string trescNotatki = TekstNotatki.Text.ToString();
            int dlugosc = trescNotatki.Length;
            string piece="";
            string piece2="";
            string nowy = "";
            if (trescNotatki.Length <= 88)
            {
                gfx.DrawString(trescNotatki, font2, XBrushes.Black, x, y);
            }
            else if ((trescNotatki.Length > 88 )&&(trescNotatki.Length <=178))
            {
                piece = trescNotatki.Substring(0, 88);
                nowy = trescNotatki.Substring(88, dlugosc - 88);
                gfx.DrawString(piece, font2, XBrushes.Black, x, y);
                gfx.DrawString(nowy, font2, XBrushes.Black, x, Convert.ToDouble(368));
            }
            else if (trescNotatki.Length > 178)
            {
                piece = trescNotatki.Substring(0, 88);
                nowy = trescNotatki.Substring(88, 88);
                piece2= trescNotatki.Substring(178, dlugosc - 178);
                gfx.DrawString(piece, font2, XBrushes.Black, x, y);
                gfx.DrawString(nowy, font2, XBrushes.Black, x, Convert.ToDouble(368));
                gfx.DrawString(piece2, font2, XBrushes.Black, x, Convert.ToDouble(386));
            }


            format.Alignment = XStringAlignment.Center;
//            XImage image = XImage.FromFile("logo.png");
 //           gfx.DrawImage(image, 410, 30, 171, 34);
            gfx.DrawString("AQUADROM Ruda Śląska", font2, XBrushes.Black, new XRect(100, 60, page.Width - 200, 5), XStringFormats.Center);
            gfx.DrawString("Notatka - Zdarzenie", font3, XBrushes.Black, new XRect(100, 75, page.Width - 200, 20), XStringFormats.Center);
            gfx.DrawLine(pen,50,100,540,100); //poziome
            gfx.DrawLine(pen, 50,155, 540, 155); //ppozioma

            gfx.DrawLine(pen, 50, 800, 50, 100); //pionowa
            gfx.DrawLine(pen, 540, 800, 540, 100); //pionowa
            Notatka notatka = new Notatka()
            {
                opis = trescNotatki,
                czasZdarzenia= DateTime.Parse(kiedyZdarzenie.Text),
                rodzajZdarzenia=rodzajZdarzenia.Text,
                uwagi="Wyjaśnienie składane jest później.",
                akceptacjaKZ=true,
                akceptacjaKSR=true,
                ID_R=Convert.ToInt32(id),
                ID_KZ=1,
                ID_KSR=1,         
            };
            if (adapter.Insert(notatka))
            {

                gfx.DrawString("Rodzaj zdarzenia: " + rodzajZdarzenia.Text, font4, XBrushes.Black, Convert.ToDouble(54), Convert.ToDouble(115));
                gfx.DrawString("Data: " + kiedyZdarzenie.Value.ToString("dd-MM-yyyy") + " " + godzinaZdarzenia.Text, font4, XBrushes.Black, Convert.ToDouble(54), Convert.ToDouble(130));
                gfx.DrawString("Strefa/miejsce: " + strefaMiejsce.Text, font4, XBrushes.Black, Convert.ToDouble(54), Convert.ToDouble(145));
                gfx.DrawString("Osoba informująca o zdarzeniu", font3, XBrushes.Black, new XRect(100, 155, page.Width - 200, 20), XStringFormats.Center);
                gfx.DrawString("Imię i Nazwisko: " + name + " " + surname, font4, XBrushes.Black, Convert.ToDouble(54), Convert.ToDouble(190));
                gfx.DrawString("Stanowisko: " + sanowisko, font4, XBrushes.Black, Convert.ToDouble(54), Convert.ToDouble(205));
                gfx.DrawString("Adres: " + miasto + ", ul." + ulica + " " + nrDomu + "/" + nrMieszkania, font4, XBrushes.Black, Convert.ToDouble(54), Convert.ToDouble(220));
                gfx.DrawString("Numer telefonu: " + tel, font4, XBrushes.Black, Convert.ToDouble(54), Convert.ToDouble(235));
                gfx.DrawString("Adres e-mail: " + mail, font4, XBrushes.Black, Convert.ToDouble(54), Convert.ToDouble(250));
                gfx.DrawLine(pen, 50, 260, 540, 260); //ppozioma
                gfx.DrawString("Policja/Straż Miejska: " + walidacja.ResztaZnakowNaMale(imieWzywajacego.Text) + " " + walidacja.PoMyslnikuLubSpacji(nazwiskoWzywajacego.Text, "-", CultureInfo.InvariantCulture), font4, XBrushes.Black, Convert.ToDouble(54), Convert.ToDouble(275));
                gfx.DrawString("(imię, nazwisko osoby wzywającej i podpis) ", font5, XBrushes.Black, Convert.ToDouble(54), Convert.ToDouble(283));
                gfx.DrawString("Policja/Straż Miejska: " + walidacja.ResztaZnakowNaMale(imieFunkc.Text) + " " + walidacja.PoMyslnikuLubSpacji(nazwiskoFunkc.Text, "-", CultureInfo.InvariantCulture), font4, XBrushes.Black, Convert.ToDouble(54), Convert.ToDouble(296));
                gfx.DrawString("(imię, nazwisko i podpis funkcjonariusza) ", font5, XBrushes.Black, Convert.ToDouble(54), Convert.ToDouble(304));
                gfx.DrawLine(pen, 50, 314, 540, 314); //ppozioma
                gfx.DrawString("Szczegółowy opis zdarzenia", font3, XBrushes.Black, new XRect(100, 314, page.Width - 200, 20), XStringFormats.Center);

                gfx.DrawLine(pen, 50, 600, 540, 600); //ppozioma
                gfx.DrawString("Uwagi: ", font4, XBrushes.Black, Convert.ToDouble(54), Convert.ToDouble(615));
                gfx.DrawLine(pen, 50, 700, 540, 700); //ppozioma
                gfx.DrawLine(pen, 50, 800, 540, 800); //ppozioma
                gfx.DrawString("Podpis kierownika zmiany: ", font4, XBrushes.Black, Convert.ToDouble(54), Convert.ToDouble(765));
                gfx.DrawString("Podpis koordynatora ratowników: ", font4, XBrushes.Black, Convert.ToDouble(54), Convert.ToDouble(790));
                string filename = "Notatki/"+ kiedyZdarzenie.Value.ToString("dd-MM-yyyy") +name + "" + surname+strefaMiejsce.Text+  ".pdf";
                document.Save(filename);
                MessageBox.Show("Wygenerowano notatkę.");
            }
            else if (adapter.Insert(notatka) == false)
            {
                MessageBox.Show("Błąd!");
            }
            //MessageBox.Show(TekstNotatki.Text.ToString());
        }

        private void Generuj_Click(object sender, EventArgs e)
        {
            walidacja.deleteNumbers(imieWzywajacego);
            walidacja.deleteNumbers(nazwiskoWzywajacego);
            walidacja.deleteNumbers(imieFunkc);
            walidacja.deleteNumbers(nazwiskoFunkc);
            walidacja.deleteNumbers(rodzajZdarzenia);
            walidacja.deleteNumbers(strefaMiejsce);
            if (walidacja.isNullOrNot(rodzajZdarzenia, "Rodzaj zdarzenia") || walidacja.isNullOrNot(strefaMiejsce, "Strefa/Miejsce"))
            {
            }
            else if (funkcjonariusze.Checked == true)
            {
                if (walidacja.isNullOrNot(imieWzywajacego, "Imię wzywającego") || walidacja.isNullOrNot(nazwiskoWzywajacego, "Nazwisko wzywającego")
                || walidacja.isNullOrNot(imieFunkc, "Imię funkcjonariusza") || walidacja.isNullOrNot(nazwiskoFunkc, "Nazwisko funkcjonariusza"))
                {
                }
                else
                {
                    generujNotatke();
                }
            }
            else
            {
                generujNotatke();
            }
        }

        private void TekstNotatki_TextChanged(object sender, EventArgs e)
        {
            znaki2.Text = TekstNotatki.Text.Length.ToString();
        }

        private void AnulujNotatke_Click(object sender, EventArgs e)
        {
            this.Close();
            exist = false;
        }

        private void funkcjonariusze_CheckedChanged(object sender, EventArgs e)
        {
            if (funkcjonariusze.Checked==true)
            {
                imieWzywajacego.Enabled = true;
                nazwiskoWzywajacego.Enabled = true;
                imieFunkc.Enabled = true;
                nazwiskoFunkc.Enabled = true;
                imieWzywajacego.Text = "";
                nazwiskoWzywajacego.Text = "";
                imieFunkc.Text = "";
                nazwiskoFunkc.Text = "";
            }
            else if (funkcjonariusze.Checked == false)
            {
                imieWzywajacego.Enabled = false;
                nazwiskoWzywajacego.Enabled = false;
                imieFunkc.Enabled = false;
                nazwiskoFunkc.Enabled = false;
                imieWzywajacego.Text = "brak";
                nazwiskoWzywajacego.Text = "brak";
                imieFunkc.Text = "brak";
                nazwiskoFunkc.Text = "brak";
            }

        }

        private void imieWzywajacego_KeyPress(object sender, KeyPressEventArgs e)
        {
            blokady.tylkoLitery(e);
        }

        private void imieFunkc_KeyPress(object sender, KeyPressEventArgs e)
        {
            blokady.tylkoLitery(e);
        }

        private void rodzajZdarzenia_TextChanged(object sender, EventArgs e)
        {

        }

        private void rodzajZdarzenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            blokady.tylkoLiteryMyslnikSpacja(e);
        }

        private void strefaMiejsce_KeyPress(object sender, KeyPressEventArgs e)
        {
            blokady.tylkoLiteryMyslnikSpacja(e);
        }

        private void nazwiskoWzywajacego_KeyPress(object sender, KeyPressEventArgs e)
        {
            blokady.tylkoLiteryMyslnik(e);
        }

        private void nazwiskoFunkc_KeyPress(object sender, KeyPressEventArgs e)
        {
            blokady.tylkoLiteryMyslnik(e);
        }

        private void TekstNotatki_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }
    

    }
}
