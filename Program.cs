using System;
using System.Linq;
using System.Collections.Generic;

namespace Linq_GropuBy_Practise {
    public static class IEnumerableExtension {
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source) {
            List<T> list = new List<T>(source);

            Random rand = new Random();

            for (int i = list.Count - 1; i > 0; i--) {
                int j = rand.Next(i + 1);
                T temp = list[j];
                list[j] = list[i];
                list[i] = temp;
            }

            return list;
        }
    }

    class Program {
        public static void Main(string[] args) {
            List<int> ourList = new List<int>() {1, 3, 15, 4, 56, 3};

            List<int> result = ourList.Shuffle() as List<int>;

            foreach (var item in result) {
                Console.WriteLine(item);
            }
        }
    }
}
