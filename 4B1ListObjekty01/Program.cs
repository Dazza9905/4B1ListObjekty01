using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4B1ListObjekty01
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba sportovec = new Osoba();

            List<Osoba> sportovci = new List<Osoba>();
            sportovci.Add(sportovec);

            foreach (Osoba osoba in sportovci)
            {
                Console.Write(osoba.GetPocet());
            }
            //ALEBO
            for (int i = 0; i < sportovci.Count; i++)
            {
                Console.Write(sportovci[i].GetPocet());
            }

            sportovci[0].SetPocet(70);

            Console.WriteLine(sportovci[0].GetPocet());

            sportovci[0].SetVek(18);
            Console.WriteLine(sportovci[0].GetVek());

            Osoba sportovec2 = new Osoba();
            sportovci.Add(sportovec2);
            sportovci[1].SetPocet(100);
            sportovci[1].SetVek(22);
            Console.WriteLine(sportovci[1].GetPocet());
            Console.WriteLine(sportovci[1].GetVek());

            //zapis 20 objektov do sportovci
            Random gen = new Random();
            for (int i = 0; i < 20; i++)
            {
                sportovci.Add(new Osoba(gen.Next(50, 201), gen.Next(16, 26)));
            }

            Metody.Vypis(sportovci);
            
            Metody.Pridanie(sportovci, 3, 1, 3, 1000, 1010);
            
            Metody.Vypis(sportovci);
            
            Metody.Vlozenie(sportovci, 15,3, 1, 3, 8000, 8008);
            
            Metody.Vypis(sportovci);
            
            Osoba topOsoba = sportovci[Metody.NajviacBodovInt(sportovci)];
            Console.WriteLine($"TOP SPORTOVEC MA: {topOsoba.GetPocet()} BODOV A VEK {topOsoba.GetVek()}");
            
            Console.Read();
        }
    }
}
