using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia7
{
    class Ksiazka : Pozycja
    {
        private int liczbaStron;
        public Autor autor;


        public Ksiazka() { }
        public Ksiazka(string tytul, int id, string wydawnictwo, int rokWydania, int liczbaStron)
        {
            this.tytul = tytul;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
            this.liczbaStron = liczbaStron;
            //this.autor = os;
        }
        override public void WypiszInfo()
        {
            Console.WriteLine("Ksiazka o tytule i id: {0} | {1}\nWydawnictwo: {2}\nRok wydania: {3}\nLiczba stron: {4}\n", tytul , id, wydawnictwo, rokWydania, liczbaStron);
        }


    }
}
