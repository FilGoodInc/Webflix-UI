using Webflix.Models;

namespace Webflix
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //Fonction exécuté quand la page ouvre
        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = LBL_Email;

            //TODO: Instancier la connexion BD et/ou frameworks (Hibernate)

        }

        //Quand le user appuye sur une touche du clavier
        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            //Quand le user appuye sur Enter
            if (e.KeyCode == Keys.Enter)
            {
                this.Login_Request(this.TB_Email.Text, this.TB_Password.Text);
            }
        }

        //Quand le user clic sur le bouton Connexion
        private void Login_BTN_Click(object sender, EventArgs e)
        {
            this.Login_Request(this.TB_Email.Text.Trim(), this.TB_Password.Text.Trim());
        }

        //Requête qui lance la connexion
        private void Login_Request(string username, string password)
        {
            UTILISATEUR? utilisateur;
            using (var db = new DbWebflix())
            {
                utilisateur = db.UTILISATEUR.SingleOrDefault(u => u.ADRESSECOURRIEL == username);
            }

            if (utilisateur == null)
            {
                Error_LBL.Visible = true;
                Error_LBL.Text = "Utilisateur non trouvé";
            }
            else if (TB_Password.Text != utilisateur.MOTDEPASSE) //TODO: Insérer condition si la connexion est un succès
            {
                Error_LBL.Visible = true;
                Error_LBL.Text = "Mot de passe incorrect";
            }
            else
            {
                //Open Main window & close login
                this.Hide();
                Main main = new Main(utilisateur.IDUTILISATEUR);
                main.ShowDialog();
                this.Close();
            }
        }


    }
}