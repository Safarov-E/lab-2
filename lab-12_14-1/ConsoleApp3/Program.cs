using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int summ = 0;
            int k;
            int t;
            Console.Write($"Введите число: ");
            while (!(int.TryParse(Console.ReadLine(), out t)))
            {
                Console.Write($"Введите число: ");

            }
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите {i + 1}-й элемент: ");
                while (!(int.TryParse(Console.ReadLine(), out k)))
                {
                    Console.Write($"Введите {i + 1}-й элемент: ");
                }
                
                if (k % t == 0)
                {
                    summ += k;
                }
            }
            Console.WriteLine("Сумма чисел кратных {0} = {1}",t, summ);
            Console.ReadLine();
        }
    }
}