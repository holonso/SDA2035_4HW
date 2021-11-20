using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA2035_4HW
{
    class Program
    {
        static void Main(string[] args)
        {
            int q, Sum = 0;
            // 1 - vvod chisla N
            Console.WriteLine("Введите целое число N > 0");
            int N = Convert.ToInt32(Console.ReadLine());
            // 2 - proverka na N>0
            if (N < 1)
            {
                Console.WriteLine("Ошибка! Введенное число не подходит под условие");
                goto Finish;
            }
            // 3 - sama formula
            for (int i = 1; Sum < N * N; i++)
            {
                q = 2 * i - 1;
                Console.WriteLine("{0} ", q);
                Sum += q;
            }
            Console.WriteLine("Квадрат числа N = {0}", Sum);
        Finish:
            Console.ReadKey();
        }
    }
}
