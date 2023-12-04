using Microsoft.EntityFrameworkCore;
using Oracle.ManagedDataAccess.Client;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using Webflix.Models;

namespace Webflix
{
    public partial class Movie : Form
    {
        decimal IDFILM;
        decimal IDCLIENT;
        public Movie(decimal IDFILM, decimal IDCLIENT)
        {
            InitializeComponent();
            this.IDFILM = IDFILM;
            this.IDCLIENT = IDCLIENT;
        }

        private void Movie_Load(object sender, EventArgs e)
        {
            using (var db = new DbWebflix())
            {
                var film = db.FILM
                    .Include(f => f.SCENARISTEFILM)
                    .Single(f => f.IDFILM == IDFILM);

                var personnages = db.PERSONNAGE
                    .Include(p => p.FK_IDACTEURNavigation)
                    .ThenInclude(a => a.IDARTISTENavigation)
                    .Where(p => p.FK_IDFILM == IDFILM)
                    .Select(p => new ActorDGV(p.FK_IDACTEUR, p.FK_IDACTEURNavigation.IDARTISTENavigation.NOM, p.NOM))
                    .ToList();

                var genres = db.GENRE
                    .Include(db => db.GENREFILM)
                    .Where(g => g.GENREFILM.Any(gf => gf.FK_IDFILM == IDFILM));

                var realisateur = db.ARTISTE.Single(a => a.IDARTISTE == film.FK_IDREALISATEUR);

                var scenaristes = db.SCENARISTE
                    .Include(s => s.SCENARISTEFILM)
                    .Where(s => s.SCENARISTEFILM.Any(sf => sf.FK_IDFILM == IDFILM));

                PB_AfficheFilm.ImageLocation = Helpers.HttpToHttps(film.AFFICHE ?? "");
                TB_Titre.Text = film.TITRE ?? "";
                TB_Annee.Text = film.ANNEE.ToString();
                TB_Pays.Text = film.PAYS ?? "";
                TB_LangueOriginale.Text = film.LANGUEORIGINALE ?? "";
                TB_Duree.Text = film.DUREE.ToString();
                TB_Genre.Text = genres.Select(g => g.NOM).ToList().Aggregate((a, b) => $"{a}, {b}");
                TB_Realisateur.Text = realisateur.NOM;
                TB_Scenariste.Text = scenaristes.Select(a => a.NOM).ToList().Aggregate((a, b) => $"{a}, {b}");
                DGV_Acteurs.DataSource = personnages;
                RTB_Resume.Text = film.RESUME ?? "";
                AddBandesAnnoncesToDGV(film.LIENSBANDEANNONCE ?? "");


                //Cote moyenne
                TB_Cote.Text = db.VUE_MAT_MOYENNE_COTE.Single(v => v.IDFILM == IDFILM).AVG_COTE.ToString();
            }
        }

        private void AddBandesAnnoncesToDGV(string liensString)
        {
            if (liensString == null || liensString == "") return;

            var liens = liensString.Split(',').Select(p => p.Trim()).ToList();

            foreach (var lien in liens)
            {
                DGV_BandesAnnonces.Rows.Add(lien);
            }
        }

        //Handle link clicks
        private void DGV_BandesAnnonces_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var url = DGV_BandesAnnonces.CurrentCell.EditedFormattedValue.ToString();
            if (!string.IsNullOrWhiteSpace(url))
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
        }

        //Movie borrowing
        private void BTN_Louer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous louer ce film ?", "Louer", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var db = new DbWebflix())
                {
                    var idClientParam = new OracleParameter("p_idClient", OracleDbType.Int64, IDCLIENT, ParameterDirection.Input);
                    var idFilmParam = new OracleParameter("p_idFilm", OracleDbType.Int64, IDFILM, ParameterDirection.Input);
                    var resultParam = new OracleParameter("p_result", OracleDbType.Varchar2, ParameterDirection.Output);
                    resultParam.Size = 100;

                    var sql = "BEGIN P_LOCATIONFILM(:p_idClient,:p_idFilm,:p_result); END;";

                    var rowsAffected = db.Database.ExecuteSqlRaw(sql, idClientParam, idFilmParam, resultParam);
                    var result = resultParam.Value;
                    MessageBox.Show(result.ToString(), "Location");
                }
            }
        }

        //Show actor details
        private void DGV_Acteurs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = DGV_Acteurs.SelectedRows[0];
            var actorDGV = (ActorDGV)selectedRow.DataBoundItem;
            var id = actorDGV.Id;
            //Open Movie window
            Actor actor = new Actor(id);
            actor.ShowDialog();
            actor.Dispose();
        }

        public class ActorDGV
        {
            public ActorDGV(decimal id, string acteur, string personnage)
            {
                Id = id;
                Acteur = acteur;
                Personnage = personnage;
            }

            [Browsable(false)]
            public decimal Id { get; set; }
            public string Acteur { get; set; }
            public string Personnage { get; set; }
        }
    }
}
