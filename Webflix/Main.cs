using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Runtime.CompilerServices;
using Webflix.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Webflix
{
    public partial class Main : Form
    {
        private DataTable moviesDataTable { get; set; }
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //Default fields values:
            DTP_AnneeDebut.Value = new DateTime(1900, 1, 1, 12, 0, 0);
            DTP_AnneeFin.Value = DateTime.Now;

            InitializeMovies();

            //Bind data to DGV
            DGV_MovieList.DataSource = moviesDataTable;
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

            var query = @"SELECT FILM.IDFILM
                            FROM FILM
                            LEFT OUTER JOIN     ACTEURFILM      ON  FILM.IDFILM              = ACTEURFILM.FK_IDFILM 
                            LEFT OUTER JOIN     ACTEUR          ON  ACTEURFILM.FK_IDACTEUR   = ACTEUR.IDARTISTE 
                            LEFT OUTER JOIN     GENREFILM       ON  FILM.IDFILM              = GENREFILM.FK_IDFILM 
                            LEFT OUTER JOIN     GENRE           ON  GENREFILM.FK_IDGENRE     = GENRE.IDGENRE 
                            LEFT OUTER JOIN     REALISATEUR     ON  FILM.FK_IDREALISATEUR    = REALISATEUR.IDARTISTE 
                            LEFT OUTER JOIN     ARTISTE AR      ON  REALISATEUR.IDARTISTE    = AR.IDARTISTE 
                            LEFT OUTER JOIN     ARTISTE AA      ON  ACTEUR.IDARTISTE         = AA.IDARTISTE
                            WHERE 1 = 1"; //The WHERE 1 = 1 is to avoid having to check if the next condition is the first one or not.

            query += GetFilterQuery("FILM.TITRE", titres);                                  //Filter Titre
            query += $"\nAND ((FILM.ANNEE >= {anneeDebut}) AND (FILM.ANNEE <= {anneeFin}))";//Filter Année
            query += GetFilterQuery("FILM.PAYS", pays);                                     //Filter Pays
            query += GetFilterQuery("FILM.LANGUEORIGINALE", languesOriginales);             //Filter Langue Originale
            query += GetFilterQuery("GENRE.NOM", genres);                                   //Filter Genre
            query += GetFilterQuery("AR.NOM", realisateurs);                                //Filter Réalisateur
            query += GetFilterQuery("AA.NOM", acteurs);                                     //Filter Acteur

            using (var db = new DbWebflix())
            {
                //Run filter query
                var filteredMoviesIds = db.Database.SqlQueryRaw<decimal>(query).ToList();
                var filteredMovies = db.FILM.Where(f => filteredMoviesIds.Contains(f.IDFILM)).ToList();

                //Display error if no movies found.
                if (filteredMovies.Count == 0) LBL_Error.Text = "Aucun film trouvé.";
                else LBL_Error.Visible = false;

                //Update DGV
                RefreshMovies(filteredMovies.Select(f => f.TITRE + " (" + f.ANNEE + ")").ToList());
            }
        }

        //Loading all movies when window is opened
        private void InitializeMovies()
        {
            //Fetch all movies from DB.
            moviesDataTable = new DataTable();

            List<string> movies;
            using (var db = new DbWebflix())
            {
                movies = db.FILM.Select(f => f.TITRE + " (" + f.ANNEE + ")").ToList();
            }
            moviesDataTable.Columns.Add("Nom du Film (Année)");
            RefreshMovies(movies);
        }

        //Refresh DGV with a list of movies
        private void RefreshMovies(List<string> movies)
        {
            moviesDataTable.Clear();
            foreach (string movie in movies)
            {
                moviesDataTable.Rows.Add(movie);
            }
        }

        //Serialize a string into a list of strings
        private List<string> Serialize(string text)
        {
            if (text == null || text == "") return new List<string>();
            return text.Split(';').ToList();
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
    }
}
