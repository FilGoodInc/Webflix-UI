using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webflix.src.mappings
{
    internal class Genre
    {
        private string nom;
        private List<Film> films;
        public Genre(string nom)
        {
            this.nom = nom;
        }
        public Genre(string nom, List<Film> films)
        {
            this.nom = nom;
            this.films = films;
        }
        public string getNom() { return nom; }
        public List<Film> getFilms() { return films; }

    }
}
