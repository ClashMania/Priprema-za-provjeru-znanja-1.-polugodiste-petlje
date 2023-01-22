using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char znak = ' ';
            int br, brMax = 0;

            Console.WriteLine("Unesite riječ: ");
            string rijec = Console.ReadLine();

            for (int i = 0; i < rijec.Length; i++)
            {
                br = 0;
                for (int j = 0; j < rijec.Length; j++)
                {
                    if (rijec[i] == rijec[j])
                    {
                        br++;
                    }
                }
                if (br > brMax)
                {
                    znak = rijec[i];
                    brMax = br;
                }
            }

            Console.WriteLine("Najkorišteniji znak je " + znak + ", " + brMax + " puta.");

            Console.ReadKey();
        }
    }
}
