using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine(Calculator.Addition(17, 3));
             Console.WriteLine(Calculator.Sub(17, 3));
             Console.WriteLine(Calculator.Mul(17, 3));
             Console.WriteLine(Calculator.Divide(17, 3));
             */
            Calculator cal = new Calculator();
            cal.petMethod();
        }
    }

    class Calculator
    {
        String[] pets = { "cat", "dog", "bird", "Bear" };
        public void petMethod()
        {
            for(int i=0; i < pets.Length; i++)
            {
                Console.WriteLine(pets[i]);
            }
        }
        public static float Addition(float input1, float input2)
        {
            return input1 + input2;
        }
        public static float Sub(float input1, float input2)
        {
            return input1 - input2;
        }
        public static float Mul(float input1, float input2)
        {
            return input1 * input2;
        }
        public static float Divide(float input1, float input2)
        {
            float x=0;
            if(input2 != 0)
            {
                x = input1 / input2;
            }
            return x;
        }
    }
}
