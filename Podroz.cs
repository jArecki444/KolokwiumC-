using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Podroz:IZarzadzaj,IData
    {
        private DateTime dataPodrozy;//a)
        private List<SrodekLokomocji> planPodrozy = new List<SrodekLokomocji>();//b)
        private double koszt = 0;//c

        //d)
        public void DodajAutobus(int iloscmiejsc)
        {
            planPodrozy.Add(new Autobus(iloscmiejsc));//spr ilosc miejsc z M
            foreach(var e in planPodrozy)
            {
                koszt += e.ZwrocCeneBiletu();
            }
        }
        public void DodajPociag(int iloscMiejsc, int dlugoscTrasy)
        {
            planPodrozy.Add(new Pociąg(iloscMiejsc,dlugoscTrasy));
            foreach (var e in planPodrozy)
            {
                koszt += e.ZwrocCeneBiletu();
            }
        }
        public void Wyczysc()
        {
            planPodrozy.Clear();
        }
        public void UsunOstatni()
        {
            planPodrozy.Remove(planPodrozy.Last());
        }

        public void UstawDate(DateTime dataPodrozy)
        {
            
                        
            Console.WriteLine("Rok: {0}, Miesiac: {1}, Dzien: {2}", dataPodrozy.Year, dataPodrozy.Month, dataPodrozy.Day);
            
            
        }
        public bool SprawdzDate()
        {
            if (dataPodrozy> DateTime.Now)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        
        public override string ToString()
        {
            string info = "Plan podrozy: ";
            foreach(var e in planPodrozy)
            {
                info += Environment.NewLine + e.ToString();
            }
            return info;
        }




    }
}
