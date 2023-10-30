using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webflix
{
     public class Scenariste
    {
        private string nom;
        private List<Film> films;
        public Scenariste(string nom)
        {
            this.nom = nom;
        }
        public Scenariste(string nom, List<Film> films)
        {
            this.nom = nom;
            this.films = films;
        }
        public string getNom() { return this.nom; }
        public List<Film> getFilms() { return this.films; }
    }
}
