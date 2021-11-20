using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int pos = 0, neg = 0;
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                    pos++;
                if (n < 0)
                    neg++;
            } while (n != 0);
            if (pos > neg)
                Console.WriteLine("Количество положительных чисел больше, Nneg={0} < Npos={1}", neg, pos);
            if (neg > pos)
                Console.WriteLine("Количество отрицательных чисел больше, Nneg={0} > Npos={1}", neg, pos);
            Console.ReadKey();
        }
    }
}
