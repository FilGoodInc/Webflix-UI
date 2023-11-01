using Microsoft.EntityFrameworkCore;
using System.Data;
using Webflix.Models;

namespace Webflix
{
    public partial class Actor : Form
    {
        private decimal IDACTEUR { get; set; }

        public Actor(decimal iDACTEUR)
        {
            InitializeComponent();
            IDACTEUR = iDACTEUR;
        }

        private void Actor_Load(object sender, EventArgs e)
        {
            using (var db = new DbWebflix())
            {
                var acteur = db.ARTISTE.Single(a => a.IDARTISTE == IDACTEUR);

                PB_AfficheFilm.ImageLocation = Helpers.HttpToHttps(acteur.PHOTO ?? "");
                TB_Nom.Text = acteur.NOM ?? "";
                TB_DateDeNaissance.Text = acteur.DATENAISSANCE.HasValue ? acteur.DATENAISSANCE.Value.ToString("dd MMMM yyyy") : "";
                TB_LieuDeNaissance.Text = acteur.LIEUNAISSANCE ?? "";
                RTB_Biographie.Text = acteur.BIOGRAPHIE ?? "";
            }
        }
    }
}
