using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apple", "orange", "grape", "peach", "mango" };
            Console.WriteLine("Reversed Array");
            for(int i = fruits.Length-1; i >= 0; i--)
            {
                Console.WriteLine(fruits[i]);
            }
        }
    }
}
