using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webflix.src.mappings
{
    internal class Artiste
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
        public string getNom() { return nom; }
        public string getLieuNaissance() { return lieuNaissance; }
        public DateTime getDateNaissance() { return dateNaissance; }
        public string getPhoto() { return photo; }
        public string getBiographie() { return biographie; }


    }
}
