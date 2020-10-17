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
            CsapatokPontszamanakAtlaga();
            LegtobbetJavitoCsapat();



            Console.ReadKey();

        }

        private static void LegtobbetJavitoCsapat()
        {

            Console.WriteLine("5. feladat : A legtobbet javito csapat:");

            Csapat legtobbetJavito = Csapatok[0];
            for (int i = 1; i < Csapatok.Count; i++)
            {

                if (Csapatok[i].Valtozas > legtobbetJavito.Valtozas )
                {
                    legtobbetJavito = Csapatok[i];
                }

            }

            //LINQ megoldas
            //legtobbetJavito = Csapatok.Find(y=>y.Valtozas == Csapatok.Max(x => x.Valtozas));

            Console.WriteLine($"\tHelyezes: {legtobbetJavito.Helyezes}\n\tCsapat : {legtobbetJavito.Nev}\n\tPontszam : {legtobbetJavito.Pontszam}");


        }

        private static void CsapatokPontszamanakAtlaga()
        {

            float osszesPontszam = 0;

            foreach (var cs in Csapatok)
            {
                osszesPontszam += cs.Pontszam;
            }

            Console.WriteLine($"4. feladat : A csapatok atlagos pontszama: {osszesPontszam/Csapatok.Count,0:N2}");
            //LINQ megoldas
            //Console.WriteLine($"4. feladat : A csapatok atlagos pontszama: {Csapatok.Sum(x=> x.Pontszam)/(float)Csapatok.Count,0:N2}");

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
