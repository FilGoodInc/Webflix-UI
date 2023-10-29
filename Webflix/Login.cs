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
            //TODO: Instancier la connexion BD et/ou frameworks (Hibernate)
        }

        //Quand le user appuye sur Enter n'importe ou dans la page Connexion
        private void KeyPress_Enter(object sender, KeyPressEventArgs e)
        {
            this.Login_Request(this.TB_Email.Text, this.TB_Password.Text);
        }

        //Quand le user appuye sur le bouton Connexion
        private void Login_BTN_Click(object sender, EventArgs e)
        {
            this.Login_Request(this.TB_Email.Text, this.TB_Password.Text);
        }

        //Requête qui lance la connexion
        private void Login_Request(string username, string password)
        {
            //TODO: Connexion à la BD ici

            if (TB_Password.Text == "temp") //TODO: Insérer condition si la connexion est un succès
            {
                //Hide Login & Open Main window
                Hide();
                Main main = new Main();
                main.Show();
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