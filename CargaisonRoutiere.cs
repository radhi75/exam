using Exam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    internal class CargaisonRoutiere : Cargaison
    {
        public CargaisonRoutiere(int d) : base(d) { }
        public override double count()
        {
            if (GetVolumeTotal() < 380000)
                return 4 * distance * GetVolumeTotal();
            else
                return 6 * distance * GetVolumeTotal();
        }
        public override string ToString()
        {
            return " Cargaison Routiere Distance = " + distance;
        }
    }
}
