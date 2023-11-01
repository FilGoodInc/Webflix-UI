using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
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

                PB_AfficheFilm.ImageLocation = HttpToHttps(film.AFFICHE);
                TB_Titre.Text = film.TITRE;
                TB_Annee.Text = film.ANNEE.ToString();
                TB_Pays.Text = film.PAYS;
                TB_LangueOriginale.Text = film.LANGUEORIGINALE;
                TB_Duree.Text = film.DUREE.ToString();
                TB_Genre.Text = genres.Select(g => g.NOM).ToList().Aggregate((a, b) => $"{a}, {b}");
                TB_Realisateur.Text = realisateur.NOM;
                TB_Scenariste.Text = scenaristes.Select(a => a.NOM).ToList().Aggregate((a, b) => $"{a}, {b}");
                DGV_Acteurs.DataSource = personnages;
                RTB_Resume.Text = film.RESUME;
                AddBandesAnnoncesToDGV(film.LIENSBANDEANNONCE);
            }
        }

        private string HttpToHttps(string url)
        {
            return url.Replace("http://", "https://");
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

        //Handle link clicks
        private void DGV_BandesAnnonces_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var url = DGV_BandesAnnonces.CurrentCell.EditedFormattedValue.ToString();
            if (!string.IsNullOrWhiteSpace(url))
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
        }
    }
}
