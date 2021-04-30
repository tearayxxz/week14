using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Check = false;
            while (Check != true)
            {
                int row = int.Parse(Console.ReadLine());
                if (row >= 0)
                {
                    Row(row);
                    Check = true;
                }
                else
                    Console.WriteLine("Invalid Pascal’s triangle row number.");
            }
        }
        static void Row(int row)
        {
            int x = 1, i, j;
            for (i = 0; i <= row; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                    {
                        x = 1;
                    }
                    else
                        x = x * (i - j + 1) / j;
                    Console.Write("{0}  ", x);
                }
                Console.WriteLine();
            }
        }
    }
}
