using System;
using System.Collections.Generic;
using System.Text.Json;

namespace JSON_Modern
{
    public class Kisiler
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Cinsiyeti { get; set; }
        public int Yasi { get; set; }
    }

    class Program
    {
        static string jsonMetni;

        static void Main(string[] args)
        {
            JsonOlustur();

            Console.WriteLine("--- Oluşturulan Modern JSON ---\n");
            Console.WriteLine(jsonMetni);

            Console.WriteLine("\n--- JSON'dan Nesneye Dönüşüm ---\n");
            JsonOku();

            Console.ReadLine();
        }

        static void JsonOlustur()
        {
            var liste = new List<Kisiler>
            {
                new Kisiler { Adi = "Deniz", Soyadi = "Katıkoğlu", Cinsiyeti = "Erkek", Yasi = 40 },
                new Kisiler { Adi = "Süheyla", Soyadi = "Katıkoğlu", Cinsiyeti = "Kadın", Yasi = 23 },
                new Kisiler { Adi = "Kemal", Soyadi = "Katıkoğlu", Cinsiyeti = "Erkek", Yasi = 26 }
            };

            var options = new JsonSerializerOptions { WriteIndented = true };

            jsonMetni = JsonSerializer.Serialize(liste, options);
        }

        static void JsonOku()
        {
            var okunanListe = JsonSerializer.Deserialize<List<Kisiler>>(jsonMetni);

            if (okunanListe != null)
            {
                foreach (var k in okunanListe)
                {
                    Console.WriteLine($"{k.Adi} {k.Soyadi} ({k.Yasi})");
                }
            }
        }
    }
}