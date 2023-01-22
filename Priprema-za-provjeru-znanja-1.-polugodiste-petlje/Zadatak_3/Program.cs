using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x11, y11, z11, max = 1;
            Console.WriteLine("Upišite prvi broj:");
            string s11 = Console.ReadLine();
            x11 = Convert.ToInt32(s11);
            Console.WriteLine("Upišite drugi broj:");
            s11 = Console.ReadLine();
            y11 = Convert.ToInt32(s11);
            z11 = x11 < y11 ? x11 : y11;
            for (int i = z11; i >= 1; i--)
                if (x11 % i == 0 && y11 % i == 0)
                {
                    max = i;
                    break;
                }
            Console.WriteLine(max);

            Console.ReadKey();
        }
    }
}