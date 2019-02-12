using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeMinister
{
    class Program
    {
        static void Main(string[] args)
            {
                Dictionary<int, string> PrimeMinisters = new Dictionary<int, string>();
                PrimeMinisters = new Dictionary<int, string>()
                {
                    { 1998 , "Atal Bihari Vajpayee" },
                    { 2014 , "Narendra Modi"},
                    { 2004 , "Manmohan Singh"}
                };
                if (PrimeMinisters.ContainsKey(2004))
                {
                    Console.WriteLine("The Prime Minister of 2004 is:" + PrimeMinisters[2004]);
                }

                PrimeMinisters.Add(2019, "Narendra Modi");
                Console.WriteLine("After adding the list is here:");
            foreach (var item in PrimeMinisters)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("After sorting the list is here:");
            var pm = PrimeMinisters.Keys.ToList();
            pm.Sort();
            foreach (var keys in pm)
            { 
                Console.WriteLine(keys + "\t" + PrimeMinisters[keys]);
            }


        }
        }
    }
