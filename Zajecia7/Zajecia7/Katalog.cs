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

        public Katalog()
        {
            listaPozycji = new List<Pozycja>();//warto stworzyc liste
        }

        public Katalog(string dzialTematyczny)
        {
            this.dzialTematyczny = dzialTematyczny;
            listaPozycji = new List<Pozycja>();//warto stworzyc liste
        }
        public void DodajPozycje(Pozycja pozycja)
        {
            listaPozycji.Add(pozycja);
        }

        //metoda na dodanie ksiązki z parametrami
        public void DodajPozycje(string imie, string nazwisko, string tytul, int id, string wydawnictwo, int rokWydania, int liczbaStron)
        {
            listaPozycji.Add(new Ksiazka(imie,nazwisko,tytul,id,wydawnictwo,rokWydania,liczbaStron));
        }

        //metoda na dodanie czasopisma z parametrami
        public void DodajPozycje(string tytuł, int id, string wydawnictwo, int rokWydania,int numer)
        {
            listaPozycji.Add(new Czasopismo(tytuł, id, wydawnictwo, rokWydania,numer));
        }

        //metoda wyszukiwania po tytule (teoretycznie możemy otrzymac kilka rzeczy więc wracamy listę)
        public void WyszukajPoTytule(string tytuł)
        {
            List<Pozycja> wysz = listaPozycji.FindAll(x => x.PobierzTytuł() == tytuł);
            foreach (var element in wysz)
            {
                element.WypiszInfo();
                for (int i = 0; i < 55; i++) Console.Write("*");
                Console.WriteLine("*");
            }
        }

        //metoda wyszukiwania po id, tu wynik mamy jeden po id zwykle jest unikalne
        public void WyszukajPoId(int id)
        {
            Pozycja wyszuk = listaPozycji.Find(x => x.PobierzId() == id);
            wyszuk.WypiszInfo();
        }

        public void WypiszWszystko()
        {
            foreach (var element in listaPozycji)
            {
                element.WypiszInfo();
                for (int i = 0; i < 55; i++) Console.Write("*");
                Console.WriteLine("*");
            }
        }


    }
}
