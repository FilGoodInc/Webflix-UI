using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webflix.src.mappings
{
    internal class Exemplaire
    {
        private int codeExemplaire;
        private Film film;

        public Exemplaire(int codeExemplaire, Film film)
        {
            this.codeExemplaire = codeExemplaire;
            this.film = film;
        }

        public int getcodeExemplaire() { return codeExemplaire; }
        public Film getFilm() { return film; }
    }
}
