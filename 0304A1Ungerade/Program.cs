using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0304A1Ungerade
{
    class Program
    {
        static void Main(string[] args)
        {
            int z;

            Console.Write("Bitte erfassen Sie eine Zahl im Bereich von 1 und 100 : ");
            z = int.Parse(Console.ReadLine());

            if (z < 1 || z > 100)
            {
                Console.WriteLine("Zahl {0} nicht im Bereich von 1 bis 100", z);
            }
            else
            {
                if (z % 2 == 0)
                    Console.WriteLine("Zahl {0} ist gerade", z);
                else
                    Console.WriteLine("Zahl {0} ist ungerade", z);
            }
        }
    }
}
