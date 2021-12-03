using System;

namespace _03._12._21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[10];
            Random r = new Random();
            for (int i = 0; i <= 9; i++)
            {
                mas[i] = r.Next(-10, 10);
                Console.WriteLine(mas[i]);
            }
            int max = 0;
            for (int i = 0; i <= 9; i++)
            {
                if (max<mas[i])
                {
                    max = mas[i];
                }
            }
            mas[8] = max;
            Console.WriteLine();
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine(mas[i]);
            }
        }
    }
}
