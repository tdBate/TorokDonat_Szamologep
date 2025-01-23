using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorokDonat_Szamologep
{
    internal class Program
    {
        static int Osszeadas(int a, int b)
        {
            return a + b;
        }

        static int Kivonas(int a, int b)
        {
            return a - b;
        }

        static int Osztas(int a, int b)
        {
            return a / b;
        }

        static int Szorzas(int a, int b)
        {
            return a * b;
        }

        static int Szazalek(int a, int b)
        {
            return (a/b)*100;
        }

        static void Main(string[] args)
        {
            Console.Write("Kérem adja meg az első számot: ");
            int a = int.Parse( Console.ReadLine());

            Console.Write("Kérem adja meg az második számot: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Az elvégzendő művelet jele: ");
            string muveleti_jel = Console.ReadLine();
        }
    }
}
