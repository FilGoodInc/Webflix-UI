using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webflix
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
        public string getNom() { return this.nom; }
        public string getEmail() { return this.email; }
        public string getNoTelephone() { return this.noTelephone; }
        public DateTime getDateNaissance() { return this.dateNaissance; }
        public string getMotDePasse() { return this.motDePasse; }
        
    }
}
