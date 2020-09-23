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
            List<int> szamok = new List<int>();
            for(int i =0;i<db;i++)
            {
                Console.WriteLine("Adja meg a(z) {0}. számot:",i+1);
                int szam= int.Parse(Console.ReadLine());
                osszeg += szam;
                szamok.Add(szam);
            }
            int atlag = osszeg / db;
            Console.WriteLine("A számok átlaga: {0}",atlag);
            int legnagyobb=szamok[0];
            int legkisebb=szamok[0];
            for(int i =0;i<db;i++)
            {
                if (szamok[i] > legnagyobb)
                {
                    legnagyobb = szamok[i];
                }
                if (szamok[i] < legkisebb)
                {
                    legkisebb = szamok[i];
                }
            }
            Console.WriteLine("A legnagyobb szam: {0}\n" +
                "A legkisebb szám: {1}",legnagyobb,legkisebb);

            Console.ReadLine();
        }
    }
}
