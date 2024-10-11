using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactureTransistor.Filaments
{
    public class Filament
    {
        public string Numero { get; set; }
        public string Identifiant { get; set; }
        public string Type { get; set; }
        public string Marque { get; set; }
        public string Description { get; set; }
        public List<Couleur> couleurs { get; set; }
        public Filament(string numero, string identifiant, string type, string marque, string description) 
        {
            Numero = numero;
            Identifiant = identifiant;
            Type = type;
            Marque = marque;
            Description = description;
            couleurs = new List<Couleur>();
        }
    }
}
