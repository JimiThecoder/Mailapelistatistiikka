using System;
using System.Collections.Generic;
using System.Linq;

namespace Mailapelistatistiikka
{
    public class Era
    {
        public int Oma { get; set; }
        public int Vastustaja { get; set; }
    }

    public class Ottelu
    {
        public string Laji { get; set; }
        public string Vastustaja { get; set; }
        public DateTime Paivamaara { get; set; }
        public string Muistiinpanot { get; set; }
        public List<Era> Erat { get; set; } = new List<Era>();

        public void LisaaEra(int oma, int vastustaja)
        {
            Erat.Add(new Era { Oma = oma, Vastustaja = vastustaja });
        }

        public bool OnVoitto()
        {
            int voitot = Erat.Count(e => e.Oma > e.Vastustaja);
            int haviot = Erat.Count(e => e.Oma < e.Vastustaja);
            return voitot > haviot;
        }
    }
}

    
