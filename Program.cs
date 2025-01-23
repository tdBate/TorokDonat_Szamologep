using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorokDonat_Szamologep
{
    internal class Program
    {
        static double Osszeadas(double a, double b)
        {
            return a + b;
        }

        static double Kivonas(double a, double b)
        {
            return a - b;
        }

        static double Osztas(double a, double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            return double.NaN;
        }

        static double Szorzas(double a, double b)
        {
            return a * b;
        }

        static double Szazalek(double a, double b)
        {
            if (b != 0)
            {
                return (a / b) * 100;
            }
            return double.NaN;
        }

        static void Indit(double a, double b, string muveleti_jel)
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
            double a = double.Parse( Console.ReadLine());

            Console.Write("Kérem adja meg az második számot: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Az elvégzendő művelet jele: ");
            string muveleti_jel = Console.ReadLine();

            Indit(a,b,muveleti_jel);
            Console.ReadKey();
        }
    }
}
