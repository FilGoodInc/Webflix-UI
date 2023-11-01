using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using Webflix.Models;

namespace Webflix
{
    public partial class Movie : Form
    {
        decimal IDFILM;
        public Movie(decimal IDFILM)
        {
            InitializeComponent();
            this.IDFILM = IDFILM;
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
                string result = "";
                using (var db = new DbWebflix())
                {
                    //db.Database.SqlQuery<YourEntityType>("p_locationFilm @p_idClient, @p_idFilm, @p_dateDebut, @p_dateFin, @p_ligneAdresse, @p_ville, @p_province, @p_codePostal", new SqlParameter("@p_idClient", 1), new SqlParameter("@p_idFilm", 1), new SqlParameter("@p_dateDebut", DateTime.Now), new SqlParameter("@p_dateFin", DateTime.Now), new SqlParameter("@p_ligneAdresse", "test"), new SqlParameter("@p_ville", "test"), new SqlParameter("@p_province", "test"), new SqlParameter("@p_codePostal", "test")).ToList();
                    //TODO: Procédure location film
                }

                MessageBox.Show(result, "Location");
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
