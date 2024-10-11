using System;

namespace FactureTransistor.Clients
{
    public class Client
    {
        public string Numero { get; set; }
        public string Pronoms { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string Rue { get; set; }
        public string Ville { get; set; }
        public string CodePostale { get; set; }
        public string Region { get; set; }
        public string Province { get; set; }
        public string Pays { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }

        public Client(string numero,string pronoms, string prenom, string nom, string rue, string ville, string codePostale, string region, string province, string pays, string adresse, string telephone)
        {
            Numero = numero;
            Pronoms = pronoms;
            Prenom = prenom;
            Nom = nom;
            Rue = rue;
            Ville = ville;
            CodePostale = codePostale;
            Region = region;
            Province = province;
            Pays = pays;
            Adresse = adresse;
            Telephone = telephone;
        }

    }
}
