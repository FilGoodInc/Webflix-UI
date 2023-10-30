using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webflix
{
     public class Exemplaire
    {
        private int codeExemplaire;
        private Film film;

        public Exemplaire(int codeExemplaire, Film film)
        {
            this.codeExemplaire = codeExemplaire;
            this.film = film;
        }

        public int getcodeExemplaire() { return this.codeExemplaire; }
        public Film getFilm() { return this.film; }
    }
}
