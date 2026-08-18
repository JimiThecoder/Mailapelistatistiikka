using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mailapelistatistiikka
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Sulkee Form2:n ja palaa Form1:een.
        private void btnTakaisin_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        // Ajetaan automaattisesti kun Form2 avautuu - hakee tuoreimmat tilastot näkyviin.
        private void Form2_Load(object sender, EventArgs e)
        {
            PaivitaTilastot();
        }

        // Lukee tallennetut ottelut tiedostosta ja päivittää otteluiden määrän,
        // voittoprosentin ja viimeisimpien otteluiden listan näkymään.
        private void PaivitaTilastot()
        {
            var ottelut = TiedostoHallinta.LueOttelut();

            // Otteluiden kokonaismäärä
            lblOtteluidenMaara.Text = "Otteluita pelattu: " + ottelut.Count;

            // Voittoprosentti - lasketaan vain jos otteluita on pelattu, ettei jaeta nollalla
            if (ottelut.Count > 0)
            {
                int voitot = ottelut.Count(o => o.OnVoitto());
                double voittoprosentti = (double)voitot / ottelut.Count * 100;
                lblVoittoprosentti.Text = "Voitto-% " + voittoprosentti.ToString("F1") + "%";
            }
            else
            {
                lblVoittoprosentti.Text = "Voitto-%: -";
            }

            // Viimeisimmät ottelut listana
            lstOttelut.Items.Clear();

            foreach (var ottelu in ottelut)
            {
                string rivi = ottelu.Paivamaara.ToString("dd.MM.yyyy") + " - " + ottelu.Laji + " vs. " + ottelu.Vastustaja;
                lstOttelut.Items.Add(rivi);
            }
        }

        // Päivitä-nappi: lukee tiedoston uudelleen, jos on tallennettu uusia otteluita
        // sen jälkeen kun Form2 avattiin.
        private void btnPaivita_Click(object sender, EventArgs e)
        {
            PaivitaTilastot();
        }
    }
}
