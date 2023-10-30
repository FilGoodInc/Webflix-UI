using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webflix.src.mappings
{
    internal class Realisateur : Artiste
    {
        private List<Film> films;
        public Realisateur(string nom, string lieuNaissance, DateTime dateNaissance, string photo, string biographie, List<Film> films) : base(nom, lieuNaissance, dateNaissance, photo, biographie)
        {
            this.films = films;
        }
        public List<Film> getFilms() { return films; }
    }
}
