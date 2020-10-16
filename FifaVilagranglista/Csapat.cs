using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaVilagranglista
{
    class Csapat
    {

        public string Nev { get; set; }
        public int Helyezes { get; set; }
        public int Valtozas { get; set; }
        public int Pontszam { get; set; }


       public static List<Csapat> Beolvasas()
        {

            var sr = new StreamReader("../../fifa.txt", Encoding.UTF8);
            var outputList = new List<Csapat>();
            string[] tempTomb;

            while (!sr.EndOfStream)
            {
                tempTomb = sr.ReadLine().Split(';');
                outputList.Add(new Csapat() { Nev = tempTomb[0], Helyezes=int.Parse(tempTomb[1]), Valtozas= int.Parse(tempTomb[2]), Pontszam= int.Parse(tempTomb[3]) });

            }

            sr.Close();
            return outputList;

        }

    }
}
