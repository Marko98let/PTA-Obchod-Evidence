using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabázeObchod
{
    public class Zbozi
    {
        public string Nazev {  get; set; }
        public string Pocet { get; set; }
        public int ID { get; set; }
        public string Cena { get; set; }

        public Zbozi(string nazev, string pocet, int iD, string cena)
        {
            Nazev = nazev;
            Pocet = pocet;
            ID = iD;
            Cena = cena;
        }

        public override string? ToString()
        {
            return $"ID: {ID} Název:{Nazev} Pocet: {Pocet} Cena: {Cena} ";
        }
    }
}
