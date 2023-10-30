using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webflix.src.mappings
{
    internal class Film
    {
        private string titre;
        private string anneeSortie;
        private List<string> paysProduction;
        private string langue;
        private int duree;
        private List<Genre> genres;
        private List<Scenariste> scenaristes;
        private List<Realisateur> realisateur;
        private List<Acteur> acteurs;
        private string resume;
        private List<string> bandesAnnonce;
        private List<Personnage> personnages;
        private List<Exemplaire> exemplaires;
        public Film(string titre, string anneeSortie, List<string> paysProduction, string langue, int duree, List<Genre> genres, List<Scenariste> scenaristes, List<Realisateur> realisateur, List<Acteur> acteurs, string resume, List<string> bandesAnnonce, List<Personnage> personnages, List<Exemplaire> exemplaires)
        {
            this.titre = titre;
            this.anneeSortie = anneeSortie;
            this.paysProduction = paysProduction;
            this.langue = langue;
            this.duree = duree;
            this.genres = genres;
            this.scenaristes = scenaristes;
            this.realisateur = realisateur;
            this.acteurs = acteurs;
            this.resume = resume;
            this.bandesAnnonce = bandesAnnonce;
            this.personnages = personnages;
            this.exemplaires = exemplaires;

        }

        public string getTitre() { return titre; }

        public string getAnneeSortie() { return anneeSortie; }

        public List<string> getPaysProduction() { return paysProduction; }

        public string getLangue() { return langue; }

        public int getDenree() { return duree; }

        public List<Genre> getGenres() { return genres; }

        public List<Scenariste> getScenaristes() { return scenaristes; }

        public List<Realisateur> getRealisateur() { return realisateur; }

        public List<Acteur> getActeurs() { return acteurs; }

        public string getResume() { return resume; }

        public List<string> getBandesAnnonce() { return bandesAnnonce; }

        public List<Personnage> getPersonnages() { return personnages; }
        public List<Exemplaire> getExemplaires() { return exemplaires; }

    }
}
