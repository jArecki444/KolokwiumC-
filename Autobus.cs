using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Autobus:SrodekLokomocji //2)
    {
        //a)
        public Autobus(int iloscMiejscAutobusu)
        {
            this.iloscMiejsc = iloscMiejscAutobusu;
            ObliczCene();
        }
        //b)
        public override string ToString()
        {
            return "Autobus: ilość miejsc: " + this.iloscMiejsc + " ,cena biletu: " + ZwrocCeneBiletu();
        }

    }
}
