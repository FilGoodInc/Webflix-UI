using NHibernate;
using System.Data;
using Webflix.src;

namespace Webflix
{
    public partial class Main : Form
    {
        public DataTable moviesDataTable { get; set; }

        public Main()
        {

            ISession session = NHibernateHelper.OpenSession();
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //Default fields values:
            DTP_AnneeDebut.Value = new DateTime(1900, 1, 1, 12, 0, 0);
            DTP_AnneeFin.Value = DateTime.Now;


            GetMovies();

            //Bind data to DGV
            DGV_MovieList.DataSource = moviesDataTable;
        }

        private void BTN_Search_Click(object sender, EventArgs e)
        {
            string[] titres = Serialize(TB_Titre.Text);
            int anneeDebut = DTP_AnneeDebut.Value.Year;
            int anneeFin = DTP_AnneeFin.Value.Year;
            string[] pays = Serialize(TB_Pays.Text);
            string[] languesOriginales = Serialize(TB_LangueOriginale.Text);
            string[] genres = Serialize(TB_Genre.Text);
            string[] realisateurs = Serialize(TB_Realisateur.Text);
            string[] acteurs = Serialize(TB_Acteur.Text);

            //TODO: Filter movies in BD or in C# ?
        }

        public void GetMovies()
        {
            //TODO: Fetch all movies from BD.

            //Data Temporaire
            moviesDataTable = new DataTable();


            List<string> moviesList = new List<string>
            {
                "Avatar: The Way of Water (2022)",
                "The Conjuring (2013)",
                "Furious 7 (2015)",
                "Solo: A Star Wars Story (2018)",
                "Thor (2011)",
                "Spider-Man: Into the Spider-Verse (2018)"
            };

            moviesDataTable.Columns.Add("Film");
            foreach (string row in moviesList)
            {
                moviesDataTable.Rows.Add(row);
            }
        }

        private string[] Serialize(string text)
        {
            return text.Split(';');
        }
    }
}
