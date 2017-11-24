using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static List<int> InitArray(int number, Predicate<int> predicate)
        {
            var numbers = new List<int>();
            for (var i = 1; i < number; i++)
            {
                if (predicate(i)) numbers.Add(i);
            }
            return numbers;
        }
        static void Main(string[] args)
        {
            var oddNumbers = InitArray(100, x => x % 2 == 1);
            oddNumbers.ForEach(Console.WriteLine);
            Console.ReadLine();
        }
    }
}
