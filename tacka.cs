
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligon2026b
{
    internal class tacka
    {
       public double x;
       public double y;
        public double d()
        {
            return Math.Sqrt(x * x + y * y);
        }
        public tacka(double a, double b) 
        {
            x = a;
            y = b;
        }
        public static bool iste(tacka a, tacka b) 
        {
            if ((a.x == b.x) && (a.y == b.y)) return true;
            else return false;
        }
    }
}
