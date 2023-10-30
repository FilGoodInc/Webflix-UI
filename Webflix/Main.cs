using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate.Cfg;
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
            GetMovies();

            //Bind data to DGV
            DGV_MovieList.DataSource = moviesDataTable;
        }

        //Code executé quand la boite de recherche change (Attention ca refresh souvent)
        private void TB_Search_TextChanged(object sender, EventArgs e)
        {
            //TODO: Filter movies in BD or in C# ?
            ((DataTable)DGV_MovieList.DataSource).DefaultView.RowFilter = $"[Film] LIKE '%{TB_Search.Text}%'";
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
    }
}
