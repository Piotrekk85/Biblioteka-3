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



            List<Pozycja> po = new List<Pozycja>();
            po.Add(new Ksiazka( "Rzeznia", 1, "Ksiazkownia", 1996, 230));
            po.Add(new Ksiazka("Rower", 2, "Znafcy", 2005, 120));
            po.Add(new Ksiazka("Samochod", 3, "Znafcy", 2006, 280));
            po.Add(new Czasopismo("Swiat", 4, "Podroze", 2015, 1));
            po.Add(new Czasopismo("Swiat", 5, "Podroze", 2016, 2));
            po.Add(new Czasopismo("PRL", 6, "Ludzie", 1988, 1));
            po.Add(new Czasopismo("Zmierzch PRL", 7, "Ludzie", 1989, 2));

            foreach (var element in po)
            {
                element.WypiszInfo();
            }




            Console.ReadKey();
        }
    }
}
