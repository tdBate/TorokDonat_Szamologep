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

        static void Indit(int a, int b, string muveleti_jel)
        {
            Console.Write("Az eredmény: ");
            switch (muveleti_jel)
            {
                case "+":
                    Console.WriteLine(Osszeadas(a, b));
                    break;
                case "-":
                    Console.WriteLine(Kivonas(a, b));
                    break;
                case "/":
                    Console.WriteLine(Osztas(a, b));
                    break;
                case "*":
                    Console.WriteLine(Szorzas(a, b));
                    break;
                case "%":
                    Console.WriteLine(Szazalek(a, b)+"%");
                    break;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Kérem adja meg az első számot: ");
            int a = int.Parse( Console.ReadLine());

            Console.Write("Kérem adja meg az második számot: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Az elvégzendő művelet jele: ");
            string muveleti_jel = Console.ReadLine();

            Indit(a,b,muveleti_jel);
            Console.ReadKey();
        }
    }
}
