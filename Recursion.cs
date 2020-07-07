using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Tangerine().iAmRecursive(5));
        }
    }
    class Tangerine
    {
        int i = 0;
        public int iAmRecursive(int fact)
        {
            if (fact == 1)
            {
                return (1);
            }
            return(fact * iAmRecursive(fact - 1));
        }ons
    }
}
