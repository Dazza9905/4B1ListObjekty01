using System;
using System.Collections.Generic;

namespace _4B1ListObjekty01
{
    class Metody
    {
        public static void Pridanie(List<Osoba> osoby, int pocet ,int dV, int hV, int dB, int hB)
        {
            Random gen = new Random();
            for (int i = 0; i < pocet; i++)
            {
                osoby.Add(new Osoba(gen.Next(dB, hB+1), gen.Next(dV, hV+1)));
            }
        }

        public static void Vypis(List<Osoba> osoby)
        {
            foreach (Osoba osoba in osoby)
            {
                Console.WriteLine(osoba.GetPocet() + "\t" + osoba.GetVek());
            }
        }

        public static void Vlozenie(List<Osoba> osoby, int index, int pocet, int dV, int hV, int dB, int hB)
        {
            Random gen = new Random();
            for (int i = 0; i < pocet; i++)
            {
                osoby.Insert(index + 1, new Osoba(gen.Next(dB, hB+1), gen.Next(dV, hV+1)));
            }
            
        }

        public static int NajviacBodovInt(List<Osoba> osoby)
        {
            Osoba topOsoba = new Osoba(0, 0);
            int topIndex = 0;

            for (int i = 0; i < osoby.Count; i++)
            {
                if (osoby[i].GetPocet() > topOsoba.GetPocet())
                {
                    topOsoba = osoby[i];
                    topIndex = i;
                }
                
            }
            
            return topIndex;
        }
        
        public static Osoba NajviacBodovOsoba(List<Osoba> osoby)
        {
            Osoba topOsoba = new Osoba(0, 0);
            int topIndex = 0;

            for (int i = 0; i < osoby.Count; i++)
            {
                if (osoby[i].GetPocet() > topOsoba.GetPocet())
                {
                    topOsoba = osoby[i];
                    topIndex = i;
                }
                
            }
            
            return osoby[topIndex];
        }
    }
}