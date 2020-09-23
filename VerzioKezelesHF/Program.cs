using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerzioKezelesHF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hány számot szeretne megadni?");
            int db = int.Parse(Console.ReadLine());
            int osszeg = 0;
            for(int i =0;i<db;i++)
            {
                Console.WriteLine("Adja meg a(z) {0}. számot:",i+1);
                osszeg += int.Parse(Console.ReadLine());
            }
            int atlag = osszeg / db;
            Console.WriteLine("A számok átlaga: {0}",atlag);


            Console.ReadLine();
        }
    }
}
