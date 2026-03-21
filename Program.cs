using System;
using System.Linq;
using System.Collections.Generic;

namespace Linq_GropuBy_Practise {
    public record Product(string Name, string Category, int Price);

    class Program {
        public static void Main(string[] args) {
            var numbers = new List<int> { 12, 5, 8, 21, 44, 7, 3, 10, 15, 20 };

            var groups = numbers.GroupBy(n => n % 2 == 0 ? "Even" : "Odd");

            foreach (var group in groups) {
                Console.WriteLine($"Catefory: {group.Key}: {group.Max()}");
            }

            /*
            foreach (var group in groups)
            {
                Console.Write($"{group.Key}: ");

                foreach (var item in group) {
                    Console.Write($"{item}; ");
                }

                Console.WriteLine();
            }
            */
        }
    }
}
