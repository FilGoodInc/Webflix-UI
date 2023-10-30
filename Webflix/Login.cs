using NHibernate;
using Webflix.src;
using Webflix.src.mappings;

namespace Webflix
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public ISession session { get; set; }

        //Fonction exécuté quand la page ouvre
        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = LBL_Email;

            //TODO: Instancier la connexion BD et/ou frameworks (Hibernate)
            session = NHibernateHelper.OpenSession();

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
            this.Login_Request(this.TB_Email.Text, this.TB_Password.Text);
        }

        //Requête qui lance la connexion
        private void Login_Request(string username, string password)
        {
            using (ITransaction transaction = session.BeginTransaction())
            {
                var utilisateur = session.Get<Utilisateur>("email", username);
            }

            if (TB_Password.Text == "temp") //TODO: Insérer condition si la connexion est un succès
            {
                //Open Main window & close login
                this.Hide();
                Main main = new Main();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                //Show error text
                Error_LBL.Visible = true;
                Error_LBL.Text = "Courriel ou Mot de passe incorrect";
            }
        }


    }
}