using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webflix.src.mappings
{
    internal class Utilisateur
    {
        private string nom;
        private string email;
        private string noTelephone;
        private DateTime dateNaissance;
        private string motDePasse;
        public Utilisateur(string nom, string email, string noTelephone, DateTime dateNaissance, string motDePasse)
        {
            this.nom = nom;
            this.email = email;
            this.noTelephone = noTelephone;
            this.dateNaissance = dateNaissance;
            this.motDePasse = motDePasse;
        }
        public string getNom() { return nom; }
        public string getEmail() { return email; }
        public string getNoTelephone() { return noTelephone; }
        public DateTime getDateNaissance() { return dateNaissance; }
        public string getMotDePasse() { return motDePasse; }

    }
}
