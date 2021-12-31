using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc_Config
{
    enum OS
    {
        Windows, Linux, MacOS
    }
    class PC
    {
        readonly string nev;
        OS rendszer;
        string tulaj;
        bool gamer;

        public string Nev => nev;

        public string Tulaj { get => tulaj; set => tulaj = value; }
        public bool Gamer { get => gamer; set => gamer = value; }
        internal OS Rendszer { get => rendszer; set => rendszer = value; }

        public PC(string nev, string tulaj, bool gamer, OS rendszer)
        {
            this.nev = nev;
            Tulaj = tulaj;
            Gamer = gamer;
            Rendszer = rendszer;
        }
    }
}
