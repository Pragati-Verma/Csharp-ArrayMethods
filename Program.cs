using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] pallets = { "B14", "A11", "B12", "A13" };
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }
            Console.WriteLine("Sorted...");
            // SORT
            Array.Sort(pallets); 
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }
            // REVERSE
            Array.Reverse(pallets); 
            Console.WriteLine("Reverse...");
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }
            // CLEARS VALUES STARTING FROM 0 INDEX AND CLEARS 2 ELEMENTS
            Array.Clear(pallets, 0, 2); 
            Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Array.Resize(ref pallets, 6);
            Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

            pallets[4] = "C01";
            pallets[5] = "C02";

            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }


            Console.ReadLine();
        }
    }
}
