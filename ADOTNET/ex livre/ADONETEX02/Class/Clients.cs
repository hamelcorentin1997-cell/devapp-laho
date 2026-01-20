using Org.BouncyCastle.Crypto.Digests;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADONETEX02.Class
{
    internal class Clients
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string NumeroTelephone { get; set; }
        public List<Commandes> commandes = new List<Commandes>();

        public Clients() { }
        public Clients(string nom, string prenom, string adresse, string codePostal, string ville, string numeroTelephone)
        {
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            CodePostal = codePostal;
            Ville = ville;
            NumeroTelephone = numeroTelephone;
        }
        public Clients(int id, string nom, string prenom, string adresse, string codePostal, string ville, string numeroTelephone) : this(nom, prenom, adresse, codePostal, ville, numeroTelephone )
        {
            Id = id;
        }

        public override string ToString()
        {
            return $@"id: {Id} || nom: {Nom}, {Prenom} || adresse: {Adresse}, {CodePostal} ({Ville}) || téléphone: {NumeroTelephone} ";
        }

    }
}
