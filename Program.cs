
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligon2026b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jovan Pantić
            /*
            tacka A = new tacka(2, 3);
            tacka B = new tacka(4, 5);
            tacka C = new tacka(6, 7);
            tacka D = new tacka(8, 9);
            vektor AB = new vektor(A, B);
            AB.stampaj();
            */

            /*
            Poligon prvi = Poligon.unos();
            prvi.stampa();
            prvi.snimi();
            */

            /*
            Poligon drugi = Poligon.ucitaj();
            drugi.stampa();
            Console.ReadKey();
            */
            /*
            tacka A = new tacka(1, 1);
            tacka B = new tacka(5, 1);
            tacka C = new tacka(2, 6);
            tacka D = new tacka(2, 0);
            vektor AB = new vektor(A, B);
            vektor CD = new vektor(C, D);
            Console.WriteLine(AB.sece(CD));
            */
            /*
           poligon prvi = poligon.unos();
           if (prvi.prost()) 
              Console.WriteLine(prvi.povrsina());
           else Console.WriteLine("nije prost");
           */
            tacka A = new tacka(1, 3);
            tacka B = new tacka(1, 1);
            tacka C = new tacka(4, 0);
            tacka D = new tacka(3, 3);
            vektor ab = new vektor(A, B);
            vektor bc = new vektor(B, C);
            vektor cd = new vektor(C, D);
            vektor da = new vektor(D, A);
            double ab_len = ab.duzina();
            double bc_len = bc.duzina();
            double cd_len = cd.duzina();
            double da_len = da.duzina();

            // kvadrat:
            // ab = bc = cd = da
            // ab L bc
            if ((ab_len == bc_len) && (bc_len == cd_len) && (cd_len == da_len))
                if (vektor.SP(ab, bc) == 0)
                    Console.WriteLine("jeste kvadrat");
                else Console.WriteLine("nije kvadrat");
            else Console.WriteLine("nije kvadrat");
            // pravougaonik:
            // ab = cd, bc = da
            // ab L bc
            if ((ab_len == cd_len) && (bc_len = da_len)) 
            
                if(vektor.SP(ab,bc)== 0) Console.WriteLine("jeste pravugaonik");
                else Console.WriteLine("nije pravougaonik");
            
            else Console.WriteLine("nije pravougaonik");
            // deltoid:
            // ab = ad & bc = cd
            // ab = bc & cd = da
            if ((ab_len == ad_len) && (bc_len = cd_len)) 
            
                if ((ab_len = bc_len)&&(cd_len == da_len)) Console.WriteLine("jeste deltoid");
                else Console.WriteLine("nije deltoid");
            
        }
    }
}