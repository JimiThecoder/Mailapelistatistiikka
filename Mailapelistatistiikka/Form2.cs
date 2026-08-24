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
        private List<Ottelu> nykyisetOttelut = new List<Ottelu>();

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
            nykyisetOttelut = TiedostoHallinta.LueOttelut();
            var ottelut = TiedostoHallinta.LueOttelut();

            // Otteluiden kokonaismäärä
            lblOtteluidenMaara.Text = "Otteluita pelattu: " + ottelut.Count;

            // Voittoprosentti - lasketaan vain jos otteluita on pelattu, ettei jaeta nollalla
            if (ottelut.Count > 0)
            {
                int voitot = ottelut.Count(o => o.OnVoitto());
                int tasapelit = ottelut.Count(o => o.OnTasapeli());
                double voittoprosentti = (double)voitot / ottelut.Count * 100;
                lblVoittoprosentti.Text = "Voitto-% " + voittoprosentti.ToString("F1") + "% (tasapelejä: " + tasapelit + ")";
            }
            else
            {
                lblVoittoprosentti.Text = "Voitto-%: -";
            }

            // Viimeisimmät ottelut listana
            lstOttelut.Items.Clear();

            if (ottelut.Count == 0)
            {
                lstOttelut.Items.Add("Ei vielä pelattuja otteluita.");
            }
            else
            {
                foreach (var ottelu in ottelut)
                {
                    string rivi = ottelu.Paivamaara.ToString("dd.MM.yyyy") + " - " + ottelu.Laji + " vs. " + ottelu.Vastustaja;
                    if (!string.IsNullOrWhiteSpace(ottelu.Muistiinpanot))
                    {
                        string muistiinpano = ottelu.Muistiinpanot;
                        if (muistiinpano.Length > 30)
                        {
                            muistiinpano = muistiinpano.Substring(0, 30) + "...";
                        }
                        rivi += " (" + muistiinpano + ")";
                    }
                    lstOttelut.Items.Add(rivi);

                }
            }
        }

        // Päivitä-nappi: lukee tiedoston uudelleen, jos on tallennettu uusia otteluita
        // sen jälkeen kun Form2 avattiin.
        private void btnPaivita_Click(object sender, EventArgs e)
        {
            PaivitaTilastot();
        }

        // Tyhjennä-nappi
        private void btnTyhjenna_Click(object sender, EventArgs e)
        {
            DialogResult vastaus = MessageBox.Show(
                "Haluatko varmasti poistaa KAIKKI tallennetut ottelut? Tätä ei voi perua.",
                "Vahvista poisto",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (vastaus == DialogResult.Yes)
            {
                TiedostoHallinta.TyhjennaKaikki();
                PaivitaTilastot();
            }
        }

        // Poista valittu ottelu-nappi
        private void btnPoistaValittu_Click(object sender, EventArgs e)
        {
            int valittuIndeksi = lstOttelut.SelectedIndex;

            if (valittuIndeksi == -1 || valittuIndeksi >= nykyisetOttelut.Count)
            {
                MessageBox.Show("Valitse ensin ottelun listasta.");
                return;
            }

            Ottelu valittuOttelu = nykyisetOttelut[valittuIndeksi];

            DialogResult vastaus = MessageBox.Show(
                "Haluatko varmasti poistaa tämän ottelun?\n" +
                valittuOttelu.Paivamaara.ToString("dd.MM.yyyy") + " - " + valittuOttelu.Laji + " vs. " + valittuOttelu.Vastustaja,
                "Vahvista poisto",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (vastaus == DialogResult.Yes)
            {
                TiedostoHallinta.PoistaOttelu(valittuIndeksi);
                PaivitaTilastot();
            }
        }
    }
}
        
    

