using Poligon2026b;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon2026b
{
    internal class vektor
    {
        public tacka pocetak;
        public tacka kraj;
        public tacka centriraj()
        {
            double x = kraj.x - pocetak.x;
            double y = kraj.y - pocetak.y;
            return new tacka(x, y);
        }
        public void stampaj()
        {
            Console.WriteLine("Od x1={0}, y1={1} Do x2={2}, y2={3}", pocetak.x, pocetak.y, kraj.x, kraj.y);
        }
        public vektor(tacka a, tacka b)
        {
            pocetak = a;
            kraj = b;
        }
        public static double SP(vektor a, vektor b)
        {
            tacka a1 = a.centriraj();
            tacka b1 = b.centriraj();
            return a1.x * b1.x + a1.y * b1.y;
        }
        public static double VP(vektor a, vektor b)
        {
            tacka a1 = a.centriraj();
            tacka b1 = b.centriraj();
            return a1.x * b1.y - a1.y * b1.x; ;
        }
        public double duzina() 
        {
            tacka druga = this.centriraj();
            return druga.d();
        }

    }
}