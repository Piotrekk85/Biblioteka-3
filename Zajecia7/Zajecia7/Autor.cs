using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia7
{
    class Autor : Osoba
    {
        private string narodowosc;

        public Autor(){ }
        public Autor(string imie, string nazwisko, string narodowosc)
            : base(imie, nazwisko) //tu mozna skrocic
        {
            this.narodowosc = narodowosc;
        }

        //konstruktor z 2 parametrami (bez narodowosci) 
        public Autor(string imie, string nazwisko)
            : base(imie, nazwisko)
        {
            narodowosc = "Polska";
        }

        public string PobierzAutora()
        {
            return imie + " " + nazwisko;
        }



    }
}
