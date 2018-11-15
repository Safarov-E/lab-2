using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number;
            int Counter = 0;
            do
            {
                while (!(int.TryParse(Console.ReadLine(), out Counter)))
                {
                    Console.WriteLine("Введите число");
                }
                Number = Int32.Parse(Console.ReadLine());
                if (Number % 2 != 0)
                    Counter += Number;
            } while (Number != 0);
            Console.WriteLine(Counter);
        }
    }
}