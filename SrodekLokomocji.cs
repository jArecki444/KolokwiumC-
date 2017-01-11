using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    abstract class SrodekLokomocji//zad1
    {//a)
        //public SrodekLokomocji();

        protected int iloscMiejsc;
        protected double cenaBiletu;
        public virtual void ObliczCene()
        {
            cenaBiletu = 50;
        }
        public double ZwrocCeneBiletu()
        {
            return cenaBiletu;
        }
        
    }
    
    
    
    

}
