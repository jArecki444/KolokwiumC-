using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Pociąg:SrodekLokomocji//3)
    {
        private int dlugoscTrasy;//a)
        public override void  ObliczCene()//b)
        {
            if (dlugoscTrasy>=100)
            {
                cenaBiletu=dlugoscTrasy*1.43;
            }
            else
            {
                ObliczCene();
            }
        }

        public Pociąg(int iloscMiejsPociagu, int dlugoscTrasyPociagu)
        {
            this.iloscMiejsc=iloscMiejsPociagu;
            this.dlugoscTrasy=dlugoscTrasyPociagu;//c)
            ObliczCene();
        }
        public override string ToString()//d)
        {
            return "Pociąg: ilość miejsc: " + this.iloscMiejsc + " ,dlugosc trasy: " + this.dlugoscTrasy + ",cena biletu: " + cenaBiletu;
        }

    }
}
