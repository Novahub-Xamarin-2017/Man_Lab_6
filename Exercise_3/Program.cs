using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static int Sum(int number, Func<int, int> func)
        {
            var sum = 0;
            for (var i = 1; i <= number; i++)
            {
                sum += func(i);
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Sum(number, x => (int)Math.Pow(x, x)));
            Console.WriteLine(Sum(number, x => x * (x + 1)));
            Console.ReadKey();
        }
    }
}
