using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia7
{
    interface IZarzadzanieKatalogiem
    {
        //brak parametrów w dwóch pierwszy metodach
        void WyszukajPoTytule(string tytuł);
        void WyszukajPoId(int id);
        void WypiszWszystko();
    }
}
