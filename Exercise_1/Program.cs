using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static List<int> PrimeNumbersSmallerThanN(int number)
        {
            bool IsPrime(int x)
            {
                if (x < 2) return false;
                for (var i = (int) Math.Sqrt(x); i >= 2; i--)
                {
                    if (x % i == 0) return false;
                }
                return true;
            }

            var primeNumbersSmallerThanN = new List<int>();
            for (var i = 2; i < number; i++)
            {
                if (IsPrime(i)) primeNumbersSmallerThanN.Add(i);
            }
            return primeNumbersSmallerThanN;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("List prime numbers smaller than number: ");
            PrimeNumbersSmallerThanN(number).ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}
