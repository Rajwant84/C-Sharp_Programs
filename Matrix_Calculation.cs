using System;
using System.IO;
using System.Linq;

namespace ConsoleApp4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char[] a = { ' ', ' ' };
            Console.WriteLine("Hello World!"+a[0]);
            int arrayValuesX = 0, arrayValuesY = 0;
            int[,] S = null;
            int N = 0;
            int nextWordPosition = 0;
            string line; //to hold one line of file
            string[] token; //to hold each token in line
            char[] separator = { ',' };
            //open file and read its ontents into a 2 dimensional array
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\MagicNumber\ms.txt"))
                {
                    line = sr.ReadLine();
                    token = line.Split(separator);
                    N = Convert.ToInt16(Math.Sqrt(token.Count()));
                    S = new int[N, N];

                    for (arrayValuesX = 0; arrayValuesX < N; arrayValuesX++)
                    {
                        for (arrayValuesY = 0; arrayValuesY < N; arrayValuesY++)
                        {
                            S[arrayValuesX, arrayValuesY] = Convert.ToInt32(token[nextWordPosition]);
                            nextWordPosition++;
                        }
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            int magicValue = GetSum(N * N) / N;

            bool isMagic = true;

            for(int counterY = 0; counterY < S.GetLength(1); counterY++)
            {
                int rowValue = 0;
                int columnValue = 0;
                for(int counterX = 0; counterX < S.GetLength(0); counterX++)
                {
                    rowValue += Convert.ToInt32(S[counterX, counterY]);
                    columnValue += Convert.ToInt32(S[counterX, counterY]);
                    Console.WriteLine(S[counterX, counterY] + " " + S[counterX, counterY]);
                }
                if (rowValue != magicValue)
                {
                    isMagic = false;
                    break;
                }
                if (columnValue != magicValue)
                {
                    isMagic = false;
                    break;
                }
                rowValue = 0;
                columnValue = 0;
            }
            if (isMagic)
            {
                Console.WriteLine("YES, it is Magic! :");
            }
            else
            {
                Console.WriteLine("No magic is in the air");
            }
            Console.ReadLine();
        }
        private static int GetSum(int maxValue)
        {
            if (maxValue < 1)
            {
                return 0;
            }
            return maxValue + GetSum(maxValue - 1);
        }
    }
}
