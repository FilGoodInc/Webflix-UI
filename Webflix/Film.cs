using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webflix
{
    internal class Film
    {
        private string titre;
        private string anneeSortie;
        private ArrayList paysProduction;
        private string langue;
        private int duree;
        private ArrayList genres;
        private ArrayList scenaristes;
        private string realisateur;
        private ArrayList acteurs;
        private string resume;
        private ArrayList bandesAnnonce;

        public Film() {}
        public Film(string titre, string anneeSortie, ArrayList paysProduction,string langue, int duree, ArrayList genres, ArrayList scenaristes, string realisateur, ArrayList acteurs, string resume, ArrayList bandesAnnonce) {
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
        }

        public string getTitre() { return this.titre; }

        public string getAnneeSortie(){ return this.anneeSortie; }

        public ArrayList getPaysProduction() { return this.paysProduction; }

        public string getLangue() { return this.langue; }
        
        public int getDenree() {  return this.duree; }
        
        public ArrayList getGenres() { return  this.genres; }
        
        public ArrayList getScenaristes() {  return this.scenaristes; }
        
        public string getRealisateur() {  return this.realisateur; }
        
        public ArrayList getActeurs() {  return this.acteurs; }
        
        public string getResume() { return this.resume; }
        
        public ArrayList getBandesAnnonce() {  return this.bandesAnnonce; }
        

    }
}
