using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1900; i <= 2100; i++)
            {
                if (i % 400 == 0 || i % 4 == 0 & i % 100 != 0)
                {
                    Console.WriteLine(i + " je prijestupna godina.");
                }
            }

            Console.ReadKey();
        }
    }
}