using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double PI = Math.PI, perimeter, area;
            Console.WriteLine("rayon r d'un cercle");
            int r = int.Parse(Console.ReadLine());
            perimeter = 2 * PI * r;
            Console.WriteLine("le périmétre est "+perimeter);
            area = PI * (r*r);
            Console.WriteLine("La surface est "+area);



        }
    }
}
