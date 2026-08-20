using System;
using System.Collections.Generic;
using System.Linq;

namespace Mailapelistatistiikka
{
    // Kuvaa yhden erän pisteet (omat ja vastustajan).
    public class Era
    {
        public int Oma { get; set; }
        public int Vastustaja { get; set; }
    }

    // Kuvaa yhden pelatun ottelun tiedot: lajin, vastustajan, päivämäärän,
    // muistiinpanot ja jokaisen erän pisteet.
    public class Ottelu
    {
        public string Laji { get; set; }
        public string Vastustaja { get; set; }
        public DateTime Paivamaara { get; set; }
        public string Muistiinpanot { get; set; }
        public List<Era> Erat { get; set; } = new List<Era>();

        // Lisää yhden erän tulokset ottelun erälistaan.
        public void LisaaEra(int oma, int vastustaja)
        {
            Erat.Add(new Era { Oma = oma, Vastustaja = vastustaja });
        }

        // Laskee, voititko ottelun: verrataan montako ottelua voitit
        // (omat pisteet suuremmat) verrattuna hävittyihin eriin.
        public bool OnVoitto()
        {
            int voitot = Erat.Count(e => e.Oma > e.Vastustaja);
            int haviot = Erat.Count(e => e.Oma < e.Vastustaja);
            return voitot > haviot;
        }

        // Laskee, päättyikö ottelu tasapeliin.
        public bool OnTasapeli()
        {
            int voitot = Erat.Count(e => e.Oma > e.Vastustaja);
            int haviot = Erat.Count(e => e.Oma < e.Vastustaja);
            return voitot == haviot;
        }
    }
}