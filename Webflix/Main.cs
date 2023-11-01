using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;
using Webflix.Models;

namespace Webflix
{
    public partial class Main : Form
    {
        decimal IDCLIENT;
        public Main(decimal iDCLIENT)
        {
            InitializeComponent();
            IDCLIENT = iDCLIENT;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //Default fields values:
            DTP_AnneeDebut.Value = new DateTime(1900, 1, 1, 12, 0, 0);
            DTP_AnneeFin.Value = DateTime.Now;

            InitializeMovies();
        }

        //Movies filtering when clicking on the search button
        private void BTN_Search_Click(object sender, EventArgs e)
        {
            //Serialize all fields
            var titres = Serialize(TB_Titre.Text);
            int anneeDebut = DTP_AnneeDebut.Value.Year;
            int anneeFin = DTP_AnneeFin.Value.Year;
            var pays = Serialize(TB_Pays.Text);
            var languesOriginales = Serialize(TB_LangueOriginale.Text);
            var genres = Serialize(TB_Genre.Text);
            var realisateurs = Serialize(TB_Realisateur.Text);
            var acteurs = Serialize(TB_Acteur.Text);

            using (var db = new DbWebflix())
            {
                var test = $"^(?=.*[{Regex.Escape("kg")}]).*$";

                var movies = (from film in db.FILM
                                         join acteurFilm in db.ACTEURFILM on film.IDFILM equals acteurFilm.FK_IDFILM
                                         join acteur in db.ACTEUR on acteurFilm.FK_IDACTEUR equals acteur.IDARTISTE
                                         join genreFilm in db.GENREFILM on film.IDFILM equals genreFilm.FK_IDFILM
                                         join genre in db.GENRE on genreFilm.FK_IDGENRE equals genre.IDGENRE
                                         join realisateur in db.REALISATEUR on film.FK_IDREALISATEUR equals realisateur.IDARTISTE
                                         join artisteRealisateur in db.ARTISTE on realisateur.IDARTISTE equals artisteRealisateur.IDARTISTE
                                         join artisteActeur in db.ARTISTE on acteur.IDARTISTE equals artisteActeur.IDARTISTE
                                         select new FilmDTO(film.IDFILM, film.TITRE, film.ANNEE, film.PAYS, film.LANGUEORIGINALE, genre.NOM, artisteRealisateur.NOM, artisteActeur.NOM))
                                        .ToList();


                var filteredMovies = movies.
                    Where(f =>
                            (titres.Count == 0 || titres.Any(t => t.All(f.Titre.ToLower().Contains))) &&
                            (f.Annee >= anneeDebut && f.Annee <= anneeFin) &&
                            (pays.Count == 0 || pays.Any(p => f.Pays.ToLower().Contains(p))) &&
                            (languesOriginales.Count == 0 || languesOriginales.Any(p => f.LangueOriginale.ToLower().Contains(p))) &&
                            (genres.Count == 0 || genres.Any(g => f.Genre.ToLower().Contains(g))) &&
                            (realisateurs.Count == 0 || realisateurs.Any(r => r.All(f.Realisateur.ToLower().Contains))) &&
                            (acteurs.Count == 0 || acteurs.Any(a => a.All(f.Acteur.ToLower().Contains))))
                    .GroupBy(f => f.IdFilm)
                    .Select(f => new FilmDGV(f.First().IdFilm, f.First().Titre + " (" + f.First().Annee + ")"))
                    .ToList();

                //Update DGV
                DGV_MovieList.DataSource = filteredMovies;
            }
        }

        //Loading all movies when window is opened
        private void InitializeMovies()
        {
            //Fetch all movies from DB.
            using (var db = new DbWebflix())
            {
                DGV_MovieList.DataSource = db.FILM.Select(f => new FilmDGV(f.IDFILM, f.TITRE + " (" + f.ANNEE + ")")).ToList();
            }
        }

        //Serialize a string into a list of strings
        private List<string> Serialize(string text)
        {
            if (text == null || text == "") return new List<string>();
            return text.Split(';').Select(p => p.Trim().ToLower()).ToList();
        }

        //Generate the SQL query for a filter
        private string GetFilterQuery(string column, List<string> values)
        {
            var query = "\n";
            if (values.Count > 0)
            {
                //COLLATE BINARY_AI is to make the search case and accent insensitive.
                query += $"AND (({column} LIKE '%{values.First()}%' COLLATE BINARY_AI)";
                for (int i = 1; i < values.Count; i++)
                {
                    query += $" OR ({column} LIKE '%{values.ElementAt(i)}%' COLLATE BINARY_AI)";
                }
                query += ")";
            }
            return query;
        }

        private void DGV_MovieList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = DGV_MovieList.SelectedRows[0];
            var filmDGV = (FilmDGV)selectedRow.DataBoundItem;
            var id = filmDGV.Id;
            //Open Movie window
            Movie movie = new Movie(id, IDCLIENT);
            movie.ShowDialog();
            movie.Dispose();
        }

        public class FilmDGV
        {
            public FilmDGV(decimal id, string film)
            {
                Id = id;
                Film = film;
            }

            [Browsable(false)]
            public decimal Id { get; set; }

            [DisplayName("Titre du Film (Année)")]
            public string Film { get; set; }
        }

        public class FilmDTO
        {
            public FilmDTO(decimal idFilm, string titre, decimal annee,string pays, string langueOriginale, string genre, string realisateur, string acteur)
            {
                IdFilm = idFilm;
                Titre = titre;
                Annee = annee;
                Pays = pays;
                LangueOriginale = langueOriginale;
                Genre = genre;
                Realisateur = realisateur;
                Acteur = acteur;
            }

            public decimal IdFilm { get; }
            public string Titre { get; }
            public decimal Annee { get; }
            public string Pays { get; }
            public string LangueOriginale { get; }
            public string Genre { get; }
            public string Realisateur { get; }
            public string Acteur { get; }
        }
    }
}
