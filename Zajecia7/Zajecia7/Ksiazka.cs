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


        public Ksiazka() 
        {
            autor = new Autor(); //wypada stworzyć obiekt na pole autor
        }

        public Ksiazka(string imie, string nazwisko,string tytul, int id, string wydawnictwo, int rokWydania,int liczbaStron)
            :base(tytul,id,wydawnictwo,rokWydania) //brakuje imienie i nazwiska
        {
            this.liczbaStron = liczbaStron;
            autor = new Autor(imie,nazwisko); //tworzenie obiektu na dane autora
        }

        public override void WypiszInfo() //estetyka, najpierw modyfikator
        {
            Console.WriteLine("Ksiazka o tytule i id: {0} | {1}\nWydawnictwo: {2}\nRok wydania: {3}\nLiczba stron: {4}\n Autor: {5}\n", tytul, id, wydawnictwo, rokWydania, liczbaStron, autor.PobierzAutora());
        }


    }
}
