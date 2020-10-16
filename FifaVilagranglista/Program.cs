using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaVilagranglista
{
    class Program
    {

        static public List<Csapat> Csapatok;

        static void Main(string[] args)
        {

            Csapatok = Csapat.Beolvasas();

            OsszesCsapat();
           

        }

        private static void OsszesCsapat()
        {

            int csapatokSzama = 0;

            // Megoldas iteracioval
            //foreach (var cs in Csapatok)
            //{
            //    csapatokSzama++;
            //}

            csapatokSzama = Csapatok.Count();


            Console.WriteLine($"3. feladat: A vilagranglistan {csapatokSzama} csapat szerepel" );


        }
    }
}
