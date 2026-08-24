using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

namespace Mailapelistatistiikka
{
    // Vastaa ottelutietojen tallentamisesta ja lukemisesta JSON-tiedostoon.
    public static class TiedostoHallinta
    {
        private static readonly string tiedostonNimi = "ottelut.json";

        // Lisää uuden ottelun: lukee ensin olemassa olevat, lisää uuden ja kirjoittaa koko listan takaisin.
        public static void TallennaOttelu(Ottelu uusiOttelu)
        {
            List<Ottelu> ottelut = LueOttelut();
            ottelut.Add(uusiOttelu);

            var asetukset = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(ottelut, asetukset);
            File.WriteAllText(tiedostonNimi, json);
        }

        // Lukee kaikki tallennetut ottelut JSON-tiedostosta.
        public static List<Ottelu> LueOttelut()
        {
            if (!File.Exists(tiedostonNimi))
                return new List<Ottelu>();

            try
            {
                string json = File.ReadAllText(tiedostonNimi);

                if (string.IsNullOrWhiteSpace(json))
                    return new List<Ottelu>();

                List<Ottelu> ottelut = JsonSerializer.Deserialize<List<Ottelu>>(json);
                return ottelut ?? new List<Ottelu>();
            }
            catch
            {
                return new List<Ottelu>();
            }
        }
        public static void TyhjennaKaikki()
        {
            if (File.Exists(tiedostonNimi))
            {
                File.Delete(tiedostonNimi);
            }
        }

        // Poista ottelu
        public static void PoistaOttelu(int indeksi)
        {
            List<Ottelu> ottelut = LueOttelut();

            if (indeksi >= 0 && indeksi < ottelut.Count)
            {
                ottelut.RemoveAt(indeksi);

                var asetukset = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(ottelut, asetukset);
                File.WriteAllText(tiedostonNimi, json);
            }
        }
    }
}
            
       
    

            
        
    
