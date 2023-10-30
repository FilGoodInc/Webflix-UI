using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webflix
{
     public class Film
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
        public Film(string titre, string anneeSortie, List<string> paysProduction,string langue, int duree, List<Genre> genres, List<Scenariste> scenaristes, List<Realisateur> realisateur, List<Acteur> acteurs, string resume, List<string> bandesAnnonce, List<Personnage> personnages, List<Exemplaire> exemplaires)
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

        public string getTitre() { return this.titre; }

        public string getAnneeSortie(){ return this.anneeSortie; }

        public List<string> getPaysProduction() { return this.paysProduction; }

        public string getLangue() { return this.langue; }
        
        public int getDenree() {  return this.duree; }
        
        public List<Genre> getGenres() { return  this.genres; }
        
        public List<Scenariste> getScenaristes() {  return this.scenaristes; }
        
        public List<Realisateur> getRealisateur() {  return this.realisateur; }
        
        public List<Acteur> getActeurs() {  return this.acteurs; }
        
        public string getResume() { return this.resume; }
        
        public List<string> getBandesAnnonce() {  return this.bandesAnnonce; }

        public List<Personnage> getPersonnages() { return this.personnages; }
        public List<Exemplaire> getExemplaires() { return this.exemplaires; }

    }
}
