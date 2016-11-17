using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia7
{
    class Katalog : IZarzadzanieKatalogiem
    {
        private string dzialTematyczny;
        public List<Pozycja> listaPozycji;
        public string tytul;

        public Katalog() { }
        public Katalog(string dzialTematyczny)
        {
            this.dzialTematyczny = dzialTematyczny;
        }
        public void DodajPozycje(string pozycja)
        {
        //?????
        }
        public void WyszukajPoTytule()
        {
            Console.WriteLine("Podaj tytul do wyszukania: ");
           
        }
        public void WyszukajPoId() 
        {
            Console.WriteLine("Podaj id do wyszukania: ");
        }
        public void WypiszWszystko()
        {
            Console.WriteLine("Wypisz wszystko: ");
        }


    }
}
