using System;

namespace Ultimo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci il costo del primo prodotto:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("inserisci il costo del secondo prodotto");
            double b = double.Parse(Console.ReadLine());
            if (a < b)
            {
                double max = b;
                double min = a;
                min = min / 2;
                double prezzo = min + max;
                Console.WriteLine($"il costo finale è di {prezzo:c}");
            }
            else
            {
                double max = a;
                double min = b;
                min = min / 2;
                double prezzo = min + max;
                Console.WriteLine($"il costo finale è di {prezzo:c}");
            }
            Console.ReadLine();
        }
    }
}

        