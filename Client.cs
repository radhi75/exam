using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Transport;

namespace Exam
{
    internal class Client
    {
        private List<Cargaison> cargaisons;

        public Client(string name)
        {
            Name = name;
            cargaisons = new List<Cargaison>();
        }

        public string Name { get; set; }

        public void AddCargaison(Cargaison cargaison)
        {
            cargaisons.Add(cargaison);
        }

        public void DisplayClientCargaisons()
        {
            Console.WriteLine($"{Name}'s Cargaisons:");
            foreach (var cargaison in cargaisons)
            {
                Console.WriteLine($"{cargaison.GetType().Name} - Prix Total: {cargaison.count()}");
            }
        }

        public double CalculateTotalCost()
        {
            double totalCost = 0.0;

            foreach (var cargaison in cargaisons)
            {
                totalCost += cargaison.count();
            }

            return totalCost;
        }
        public void SearchInCargaisons(int nch)
        {
            foreach (var cargaison in cargaisons)
            {
                if (cargaison.count() >= nch)
                {
                    Marchandise m = cargaison.getMarchandises(nch);
                    Console.WriteLine(m);
                    Console.ReadLine();
                    break;
                }
            }

            Console.WriteLine("cargaison n'existe pas ");
        }


    }
}
