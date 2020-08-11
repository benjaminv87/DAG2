using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form4
{
    public class Notitie
    {
        public string Naam, Inhoud;
        public Notitie(string naam, string inhoud)
        {
            Naam = naam;
            Inhoud = inhoud;
        }
        public override string ToString()
        {
            return Naam;
        }
    }
}
