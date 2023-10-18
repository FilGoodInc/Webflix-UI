using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webflix
{
    internal class requestServer
    {
        public requestServer() { 
        }
        
        private ArrayList rechercheFilm(string nom, string dateMinimum, string dateMaximum, string nomPays,string langueOriginale, string genre, string realisateur, string acteur) {
            ArrayList filmsTrouves = new ArrayList();
            string stmt = "SELECT * FROM FILM ";
            if (nom != null)
            {

            }
            if (dateMinimum != null)
            {

            }
            if (dateMaximum != null)
            {
            }
            if (nomPays != null)
            {

            }
            if (langueOriginale != null)
            {

            }
            if (genre != null)
            {

            }
            if(realisateur != null)
            {

            }
            if (acteur != null)
            {

            }
            //HibernateUtil.session.executestmt(stmt);
            return filmsTrouves;
        }
        private char locationFilm(Film film)
        {
            char[] codes = {'S','I','U'};
            return codes[0];
        }


    }
}
