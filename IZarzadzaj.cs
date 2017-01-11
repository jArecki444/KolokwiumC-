using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    interface IZarzadzaj//4)
    {
        //a)
        void DodajAutobus(int iloscMiejsc);
        void DodajPociag(int iloscMiejsc, int dlugoscTrasy);
        void UsunOstatni();
        void Wyczysc();

    }
}
