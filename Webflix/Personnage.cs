using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webflix
{
    internal class Personnage
    {
        private string nom;
        private Acteur acteur;
        private Film film;

        public Personnage(string nom, Acteur acteur, Film film) { 
            this.nom = nom;
            this.acteur = acteur;
            this.film = film;
        }
        
        public string getNom() { return this.nom; }
        public Acteur getActeur() { return this.acteur; }
        public Film getFilm() { return this.film; }
    }
}
