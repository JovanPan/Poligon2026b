using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligon2026b
{
    internal class poligon
    {
        int br_temena;
        tacka[] teme;
        public poligon(int n) 
        {
            br_temena = n;
            teme = new tacka[n];
        }
        public static poligon unos() 
        {
            Console.WriteLine("Unesite broj tacaka");
            int br = Convert.ToInt32(Console.Read());
            poligon novi = new poligon(br);
            for (int i = 0; i < br; i++) 
            {
                Console.WriteLine("Teme A({0}).x=", i + 1);
                double x=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Teme A({0}).y=", i + 1);
                double y = Convert.ToDouble(Console.ReadLine());
                novi.teme[i] = new tacka(x, y);
            }
            return novi;
        }
        public void stampa() 
        {
            Console.WriteLine("Poligon sa" + br_temena + "temena:");
            for (int i = 0;i< br_temena; i++) 
            {
                Console.WriteLine("x = {0} y={1}", teme[i].x, teme[i].y);
            }
        }
    }
}
