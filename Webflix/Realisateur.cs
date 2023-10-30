using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webflix
{
     public class Realisateur : Artiste 
    {
        private List<Film> films;
        public Realisateur(string nom, string lieuNaissance, DateTime dateNaissance, string photo, string biographie, List<Film> films) : base(nom, lieuNaissance, dateNaissance, photo, biographie)
        {
            this.films = films;
        }
        public List<Film> getFilms() { return this.films; }
    }
}
