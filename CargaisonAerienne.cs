using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    internal class CargaisonAerienne : Cargaison
    {
        public CargaisonAerienne(int d) : base(d) { }
        public override double count()
        {
            if (GetPoidsTotal() > 80000)
                return 10 * distance * GetPoidsTotal();
            else
                return 12 * distance * GetPoidsTotal();
        }
        public override string ToString()
        {
            return "Cargaison Aérienne  Distance = " + distance;

        }

    }
}
