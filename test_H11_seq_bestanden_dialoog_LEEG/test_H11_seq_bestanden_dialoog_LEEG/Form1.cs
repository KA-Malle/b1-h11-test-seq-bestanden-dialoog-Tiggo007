using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_H11_seq_bestanden_dialoog_LEEG
{
    public partial class Form1 : Form
    {
        private new string[] _asteden;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Declaratie
            _asteden = new string[7];            

            // Vullen van de array _steden
            for (int i = 0; i < _asteden.GetUpperBound(0); i++)
            {
                switch (i)
                {
                    case 0:
                        _asteden[i] = "Lille";
                        break;
                    case 1:
                        _asteden[i] = "Schilde";
                        break;
                    case 2:
                        _asteden[i] = "Turnhout";
                        break;
                    case 3:
                        _asteden[i] = "Geel";
                        break;
                    case 4:
                        _asteden[i] = "Mol";
                        break;
                    case 5:
                        _asteden[i] = "Deurne";
                        break;
                    case 6:
                        _asteden[i] = "Wilrijk";
                        break;
                    case 7:
                        _asteden[i] = "Herentals";
                        break;
                    default:
                        break;
                }//switch
            }// for lus
        }

        private void btnGenereer_Click(object sender, EventArgs e)
        {
            // Declaratie
            double[,] aOutputarray = new double[8, 5];
            Random willekeurig = new Random();


            // Array vullen
            for (int tr = 0; tr <= aOutputarray.GetUpperBound(1); tr++)
            {
                for (int tk = 0; tk < _asteden.Length; tk++)
                {
                    // Array eerst vullen met de stad
                    aOutputarray[tr, tk] = Convert.ToInt32(_asteden[tk]);
                    // Array vullen met random getallen voor de temperatuur
                    aOutputarray[tr, tk] = willekeurig.Next(14, 26);
                }
            }

        }

        private void btnSluiten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVerwerken_Click(object sender, EventArgs e)
        {
            // Declaratie
            double[,] outputarray = new double[8, 5];
            double gemiddedle;
            int min = 30, max = 0;
            string volledigelijn, stad, temp;

            // Bestand Inlezen
            StreamReader streamLees = new StreamReader("zonnedagen.txt");

            // Lijn per lijn verwerken
            volledigelijn = streamLees.ReadLine();
            stad = volledigelijn.Substring(1, 9);
            for (int tr = 0; tr < outputarray.GetUpperBound(0); tr++)
            {
                for (int tk = 0; tk < outputarray.GetUpperBound(1); tk++)
                {
                    temp = volledigelijn.Substring(9, 2);
                    // De array eerste vullen met de stand
                    outputarray[tr, tk] = Convert.ToInt32(stad);

                    // De array vullen met de temperaturen
                    outputarray[tr, tk] = Convert.ToInt32(temp);
                   
                }
            }
            for (int tr = 0; tr < outputarray.GetUpperBound(0); tr++)
            {
                for (int tk = 0; tk < outputarray.GetUpperBound(1); tk++)
                {
                    // gemiddelde berekenen
                    gemiddedle = Math.Round(outputarray[tr, tk], 0, MidpointRounding.AwayFromZero);
                    // Zien of het een maximum is
                    if (outputarray[tr, tk] > max)
                    {
                        outputarray[tr, tk] = max;
                    }
                    //Zien of het een minimum is
                    if (outputarray[tr, tk] < min)
                    {
                        outputarray[tr, tk] = min;
                    }



                    // Resultaat tonen op het scherm
                    txtResultaat.Text = Convert.ToString(outputarray[tr, tk]) + "\r" + gemiddedle + "°C";
                }
                // for lus tk
                // Een nieuwe regel
                txtResultaat.Text = "\t";
            }

            // De hoogste en de laagste temperatuur schrijven
            txtResultaat.Text = "De laagste temperatuur was " + min + "°C in --- .\t";
            txtResultaat.Text = "De hoogtse temperatuur was " + max + "°C in --- .";


            // Instellen dialoogvenster Openen
            OpenFileDialog dlgOpen = new OpenFileDialog();
            // Eigenschappen instellen
            dlgOpen.Title = "Openen";
            dlgOpen.FileName = "";
            dlgOpen.DefaultExt = ".txt";
            dlgOpen.InitialDirectory = Application.StartupPath;
            dlgOpen.Filter = "Tekstbestanden (.txt)|*.txt|Alle bestanden (*.*)|*.*";

            using (StreamWriter streamschrijf = new StreamWriter("verwerkt.txt", false))
            {

                // Niet vergeten
                streamLees.Close();
                streamLees.Dispose();
            }
        }
    }
}
