using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Transport
{
    public abstract class Cargaison
    {
        protected int distance;

        public List<Marchandise> marchandises = new List<Marchandise>();
        public List<Marchandise> GetMarchandises() { return marchandises; }
        public Cargaison(int d) { this.distance = d; }
        public void Ajouter(Marchandise m) {
            marchandises.Add(new Marchandise(m.Numero,m.Poids,m.Volume));
        }
        public void afficher()
        {
            foreach (Marchandise m in marchandises)
            {
                Console.WriteLine(m.ToString());
            }

        }
        public Marchandise getMarchandises(int num)
        {
            foreach (Marchandise m in marchandises)
            {
                if (m.Numero == num) return m;
            }
            return null;
        }
        public double GetPoidsTotal()
        {
            double P = 0;
            foreach (Marchandise m in marchandises)
            {
                P += m.Poids;
            }
            return P;
        }
        public double GetVolumeTotal()
        {
            double v = 0;
            foreach (Marchandise m in marchandises)
            {
                v += m.Volume;
            }
            return v;
        }
        public abstract double count();
    }
}
