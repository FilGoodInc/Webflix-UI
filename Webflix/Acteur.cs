using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webflix
{
    internal class Acteur : Artiste
    {
        private List<Personnage> personnages;
        private List<Film> films;
        public Acteur(string nom, string lieuNaissance, DateTime dateNaissance, string photo, string biographie) : base(nom, lieuNaissance, dateNaissance, photo, biographie)
        {
        }
        public Acteur(string nom, string lieuNaissance, DateTime dateNaissance, string photo, string biographie, List<Personnage> personnages, List<Film> films) : base(nom, lieuNaissance, dateNaissance, photo, biographie)
        {
            this.personnages = personnages;
            this.films = films;
        }
        public List<Personnage> getPersonnages() { return this.personnages; }
        public List<Film> getFilms() { return this.films; }
    }
}
