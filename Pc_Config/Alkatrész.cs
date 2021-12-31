using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc_Config
{
    class Alkatrész : PC
    {
        readonly string megnevezes;
        readonly string gyarto;
        readonly int ar;
        int darab;

        public string Megnevezes => megnevezes;

        public string Gyarto => gyarto;

        public int Ar => ar;

        public int Darab { get => darab; set => darab = value; }

        public Alkatrész(string nev, string tulaj, bool gamer, OS rendszer, string megnevezes, string gyarto, int ar, int darab) :base ( nev, tulaj, gamer, rendszer)
        {
            this.megnevezes = megnevezes;
            this.gyarto = gyarto;
            this.ar = ar;
            Darab = darab;
        }
    }
}
