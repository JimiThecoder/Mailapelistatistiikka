using System;
using System.Collections.Generic;
using System.Linq;

namespace Mailapelistatistiikka
{
    public class Ottelu
    {
        public string Laji { get; set; }
        public string Vastustaja { get; set; }
        public DateTime Paivamaara { get; set; }
        public string Muistiinpanot { get; set; }
        public List<(int Oma, int Vastustaja)> Erat { get; set; } = new List<(int, int)>();

        public void LisaaEra(int oma, int vastustaja)
        {
            Erat.Add((oma, vastustaja));
        }

        public bool OnVoitto()
        {
            int voitot = Erat.Count(e => e.Oma > e.Vastustaja);  
            int haviot = Erat.Count(e => e.Oma < e.Vastustaja);
            return voitot > haviot;
        }
    }
}