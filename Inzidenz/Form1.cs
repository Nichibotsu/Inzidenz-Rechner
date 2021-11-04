//Niclas Besecke
//11.2

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inzidenz
{
    public partial class Form1 : Form
    {
        class Bundesland
        {
            public double einwohner;
            public double Fläche;
            public double infizierte;

            public static double Rechner(Bundesland Ausgabe)//Inzidenz
            {
                return Math.Round((Ausgabe.infizierte * 100000) / Ausgabe.einwohner, 2);
            }
            public  static double Flaeche(Bundesland Ausgabe)//Flächenfaktor
            {
                return Math.Round(Ausgabe.infizierte / Ausgabe.Fläche, 2);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Inzidenz,Flächenfaktor;
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Infizierte eingeben");
            }
            else if (comboBox1.Text=="Auswählen")
            {
                MessageBox.Show("Bundesland auswählen");
            }
            else
            {
                Bundesland SachsenAnhalt = new Bundesland();
                Bundesland Sachsen = new Bundesland();
                Bundesland Thüringen = new Bundesland();

                if (comboBox1.Text == "Sachsen-Anahlt")
                {
                    SachsenAnhalt.einwohner = 2180684;
                    SachsenAnhalt.Fläche = 20456.51;
                    SachsenAnhalt.infizierte = Convert.ToDouble(textBox1.Text);
                    Inzidenz = Bundesland.Rechner(SachsenAnhalt);
                    Flächenfaktor = Bundesland.Flaeche(SachsenAnhalt);
                    label3.Text = "Inzidenz:" + Convert.ToString(Inzidenz);
                    label4.Text = "Flächenfaktor:" + Convert.ToString(Flächenfaktor) + " km²";
                }
                else if (comboBox1.Text == "Sachsen")
                {
                    Sachsen.einwohner = 4056941;
                    Sachsen.Fläche=18449.93;
                    Sachsen.infizierte = Convert.ToDouble(textBox1.Text);
                    Inzidenz = Bundesland.Rechner(Sachsen);
                    Flächenfaktor = Bundesland.Flaeche(Sachsen);
                    label3.Text = "Inzidenz:" + Convert.ToString(Inzidenz);
                    label4.Text = "Flächenfaktor:" + Convert.ToString(Flächenfaktor) + " km²";
                }
                else
                {
                    Thüringen.einwohner = 2120237;
                    Thüringen.Fläche = 16202.35;
                    Thüringen.infizierte = Convert.ToDouble(textBox1.Text);
                    Inzidenz= Bundesland.Rechner(Thüringen);
                    Flächenfaktor=Bundesland.Flaeche(Thüringen);
                    label3.Text = "Inzidenz:"+Convert.ToString(Inzidenz);
                    label4.Text = "Flächenfaktor:"+Convert.ToString(Flächenfaktor)+" km²";

                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
