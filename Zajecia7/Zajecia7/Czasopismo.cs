using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia7
{
    class Czasopismo : Pozycja
    {
        private int numer;

        public Czasopismo() { }
        public Czasopismo(string tytul, int id, string wydawnictwo, int rokWydania, int numer)
            : base(tytul, id, wydawnictwo, rokWydania)//krócej z base
        {
            this.numer = numer;
        }


        override public void WypiszInfo()
        {
            Console.WriteLine("Czasopismo o tytule i id: {0} | {1}\nWydawnictwo: {2}\nRok wydania: {3}\nNumer: {4}\n", tytul , id, wydawnictwo, rokWydania, numer);
        }





    }
}
