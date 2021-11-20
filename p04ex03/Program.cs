using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            // vvod A B C
            Console.WriteLine("Введите длины сторон прямоугольника");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());
            // proverka na N>0
            if ((A < 0) || ((B < 0) || (C < 0)))
            {
                Console.WriteLine("Ошибка! Введенное число не подходит под условие");
                goto Finish;
            }
            Console.Write("В прямоугольник со сторонами {0} x {1} размещается ", A, B);
            int nA = 0, nB = 0, n = 0;  // 3.0 - vvod schetchikov
            while (A >= C)              // 3.1 - proschet vmestimosti A
            {
                A = A - C;
                nA++;
            }
            while (B >= C)              // 3.2 - proschet vmestimosti B
            {
                B = B - C;
                nB++;
            }
            while (nA > 0)              // 3.3 - summa kol-va kvadratov
            {
                n += nB;
                --nA;
            }
            Console.WriteLine("{0} квадратов со сторонами {1} ", n, C);
        Finish:
            Console.ReadKey();
        }
    }
}
