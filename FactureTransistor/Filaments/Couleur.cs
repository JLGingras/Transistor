using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactureTransistor.Filaments
{
    public class Couleur
    {
        public string Nom {  get; set; }
        public string Quantite { get; set; }

        public Couleur(string nom, string quantite) 
        { 
            Nom = nom;
            Quantite = quantite;
        }
    }
}
