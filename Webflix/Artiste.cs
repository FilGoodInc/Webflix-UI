using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webflix
{
     public class Artiste
    {
        private string nom;
        private string lieuNaissance;
        private DateTime dateNaissance;
        private string photo;
        private string biographie;

        public Artiste(string nom, string lieuNaissance, DateTime dateNaissance, string photo, string biographie)
        {
            this.nom = nom;
            this.lieuNaissance = lieuNaissance;
            this.dateNaissance = dateNaissance;
            this.photo = photo;
            this.biographie = biographie;

        }
        public string getNom() { return this.nom; }
        public string getLieuNaissance() { return this.lieuNaissance; }
        public DateTime getDateNaissance() { return this.dateNaissance; }
        public string getPhoto() { return this.photo; }
        public string getBiographie() { return this.biographie; }

        
    }
}
