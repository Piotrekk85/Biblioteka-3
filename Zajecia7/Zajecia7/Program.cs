using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia7
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Osoba> os = new List<Osoba>();
            os.Add(new Autor("Jan", "Kowalski", "pol"));
            os.Add(new Autor("Kurt", "Vonegout", "ger"));



            Katalog po = new Katalog();
            po.DodajPozycje(new Ksiazka( "Jan","Kowalski","Rzeznia", 1, "Ksiazkownia", 1996, 230));
            po.DodajPozycje(new Ksiazka("Kurt", "Vonegout", "Rower", 2, "Znafcy", 2005, 120));
            po.DodajPozycje(new Ksiazka("Jan", "Kowalski", "Samochod", 3, "Znafcy", 2006, 280));
            po.DodajPozycje(new Czasopismo("Swiat", 4, "Podroze", 2015, 1));
            po.DodajPozycje(new Czasopismo("Swiat", 5, "Podroze", 2016, 2));
            po.DodajPozycje(new Czasopismo("PRL", 6, "Ludzie", 1988, 1));
            po.DodajPozycje(new Czasopismo("Zmierzch PRL", 7, "Ludzie", 1989, 2));

            

            po.WypiszWszystko();

            Console.WriteLine("Wyszukiwanie po tytule");
            po.WyszukajPoTytule("Rower");

            Console.WriteLine("Wyszukiwanie po id");
            po.WyszukajPoId(5);


            Console.ReadKey();
        }
    }
}
