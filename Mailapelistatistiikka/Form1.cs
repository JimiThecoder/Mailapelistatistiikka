using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mailapelistatistiikka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //tarkistaa ovatko numerot kelvollisia
        private void LisaaEraJosTaytetty(Ottelu ottelu, string omaTeksti, string vastustajanTeksti)
        {
            if (int.TryParse(omaTeksti, out int oma) && int.TryParse(vastustajanTeksti, out int vastustajan))
            {
                ottelu.LisaaEra(oma, vastustajan);
            }
        }

        //tarkistaa ennen tallennusta, että lomake on täytetty järkevästi
        private bool SyoteOnKelvollinen()
        {
            if (string.IsNullOrWhiteSpace(txtVastustaja.Text))
                return false;

            if (cmbLaji.SelectedItem == null)
                return false;

            bool eraLoytyi =
                (int.TryParse(txtOma1.Text, out _) && int.TryParse(txtVastustaja1.Text, out _)) ||
                (int.TryParse(txtOma2.Text, out _) && int.TryParse(txtVastustaja2.Text, out _)) ||
                (int.TryParse(txtOma3.Text, out _) && int.TryParse(txtVastustaja3.Text, out _));

            return eraLoytyi;
        }

        //Tyhjentää kaikki kentät onnistuneen tallennuksen jälkeen
        private void TyhjennaLomake()
        {
            txtVastustaja.Clear();
            txtOma1.Clear();
            txtVastustaja1.Clear();
            txtOma2.Clear();
            txtVastustaja2.Clear();
            txtOma3.Clear();
            txtVastustaja3.Clear();
            txtMuistiinpanot.Clear();
            cmbLaji.SelectedIndex = -1;
        }

        private void btnTallenna_Click(object sender, EventArgs e)
        {
            if (!SyoteOnKelvollinen())
            {
                lblViesti.Text = "Tarkista syötteet: pisteiden tulee olla kokonaislukuja ja vastustajan nimi ei voi olla tyhjä.";
                lblViesti.ForeColor = System.Drawing.Color.Red;
                return;
            }

            Ottelu uusiOttelu = new Ottelu();
            uusiOttelu.Laji = cmbLaji.SelectedItem?.ToString() ?? "";
            uusiOttelu.Vastustaja = txtVastustaja.Text.Trim();
            uusiOttelu.Paivamaara = dtpPaivamaara.Value;
            uusiOttelu.Muistiinpanot = txtMuistiinpanot.Text.Trim();

            LisaaEraJosTaytetty(uusiOttelu, txtOma1.Text, txtVastustaja1.Text);
            LisaaEraJosTaytetty(uusiOttelu, txtOma2.Text, txtVastustaja2.Text);
            LisaaEraJosTaytetty(uusiOttelu, txtOma3.Text, txtVastustaja3.Text);

            TiedostoHallinta.TallennaOttelu(uusiOttelu);

            string tulos = uusiOttelu.OnVoitto() ? "Voitto!" : "Häviö";
            lblViesti.Text = $"Ottelu tallennettu. Tulos: {tulos}";
            lblViesti.ForeColor = System.Drawing.Color.Green;

            TyhjennaLomake();
        }

        private void btnNaytaTilastot_Click(object sender, EventArgs e)
        {
            Form2 tilastoNakyma = new Form2();
            tilastoNakyma.Show();
        }
    }
}

    
    






