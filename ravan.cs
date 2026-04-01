using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligon2026b
{
    class ravan
    {
        public static int SIS(vektor a, tacka b, tacka c) 
        {
            vektor AB = new vektor(a.pocetak, b);
            vektor AC = new vektor(a.pocetak, c);
            double aAB = vektor.VP(a, AB);
            double aAC = vektor.VP(a, AC);
            if (aAC * aAB > 0) return 1;
            if (aAC * aAB < 0) return 1;
            return 0;
        }

    }
}
