namespace Webflix
{
    partial class Movie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Movie));
            PB_AfficheFilm = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            TB_Realisateur = new TextBox();
            label5 = new Label();
            label4 = new Label();
            TB_LangueOriginale = new TextBox();
            TB_Titre = new TextBox();
            LBL_Search_Title = new Label();
            LBL_Search_Date = new Label();
            TB_Annee = new TextBox();
            label2 = new Label();
            TB_Genre = new TextBox();
            TB_Pays = new TextBox();
            dataGridView1 = new DataGridView();
            Nom = new DataGridViewTextBoxColumn();
            Personnage = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)PB_AfficheFilm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // PB_AfficheFilm
            // 
            PB_AfficheFilm.BackColor = Color.FromArgb(141, 153, 174);
            PB_AfficheFilm.BackgroundImage = Properties.Resources.POSTER_PLACEHOLDER;
            PB_AfficheFilm.BackgroundImageLayout = ImageLayout.Zoom;
            PB_AfficheFilm.BorderStyle = BorderStyle.FixedSingle;
            PB_AfficheFilm.Location = new Point(12, 12);
            PB_AfficheFilm.Name = "PB_AfficheFilm";
            PB_AfficheFilm.Size = new Size(200, 300);
            PB_AfficheFilm.TabIndex = 0;
            PB_AfficheFilm.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 315);
            label7.Name = "label7";
            label7.Size = new Size(62, 21);
            label7.TabIndex = 29;
            label7.Text = "Acteurs";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(218, 190);
            label6.Name = "label6";
            label6.Size = new Size(87, 21);
            label6.TabIndex = 27;
            label6.Text = "Réalisateur";
            // 
            // TB_Realisateur
            // 
            TB_Realisateur.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Realisateur.Location = new Point(366, 187);
            TB_Realisateur.Name = "TB_Realisateur";
            TB_Realisateur.Size = new Size(223, 29);
            TB_Realisateur.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(218, 155);
            label5.Name = "label5";
            label5.Size = new Size(59, 21);
            label5.TabIndex = 25;
            label5.Text = "Genres";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(218, 120);
            label4.Name = "label4";
            label4.Size = new Size(126, 21);
            label4.TabIndex = 23;
            label4.Text = "Langue originale";
            // 
            // TB_LangueOriginale
            // 
            TB_LangueOriginale.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TB_LangueOriginale.Location = new Point(366, 117);
            TB_LangueOriginale.Name = "TB_LangueOriginale";
            TB_LangueOriginale.Size = new Size(223, 29);
            TB_LangueOriginale.TabIndex = 24;
            // 
            // TB_Titre
            // 
            TB_Titre.AutoCompleteMode = AutoCompleteMode.Append;
            TB_Titre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Titre.Location = new Point(366, 9);
            TB_Titre.Name = "TB_Titre";
            TB_Titre.Size = new Size(223, 29);
            TB_Titre.TabIndex = 17;
            // 
            // LBL_Search_Title
            // 
            LBL_Search_Title.AutoSize = true;
            LBL_Search_Title.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBL_Search_Title.Location = new Point(218, 12);
            LBL_Search_Title.Name = "LBL_Search_Title";
            LBL_Search_Title.Size = new Size(94, 21);
            LBL_Search_Title.TabIndex = 16;
            LBL_Search_Title.Text = "Titre du film";
            // 
            // LBL_Search_Date
            // 
            LBL_Search_Date.AutoSize = true;
            LBL_Search_Date.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBL_Search_Date.Location = new Point(218, 50);
            LBL_Search_Date.Name = "LBL_Search_Date";
            LBL_Search_Date.Size = new Size(118, 21);
            LBL_Search_Date.TabIndex = 18;
            LBL_Search_Date.Text = "Année de sortie";
            // 
            // TB_Annee
            // 
            TB_Annee.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Annee.Location = new Point(366, 44);
            TB_Annee.Name = "TB_Annee";
            TB_Annee.Size = new Size(223, 29);
            TB_Annee.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(218, 82);
            label2.Name = "label2";
            label2.Size = new Size(142, 21);
            label2.TabIndex = 21;
            label2.Text = "Pays de production";
            // 
            // TB_Genre
            // 
            TB_Genre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Genre.Location = new Point(366, 152);
            TB_Genre.Name = "TB_Genre";
            TB_Genre.Size = new Size(223, 29);
            TB_Genre.TabIndex = 26;
            // 
            // TB_Pays
            // 
            TB_Pays.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Pays.Location = new Point(366, 82);
            TB_Pays.Name = "TB_Pays";
            TB_Pays.Size = new Size(223, 29);
            TB_Pays.TabIndex = 32;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(141, 153, 174);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(141, 153, 174);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(43, 45, 66);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nom, Personnage });
            dataGridView1.GridColor = Color.FromArgb(237, 242, 244);
            dataGridView1.Location = new Point(12, 339);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(141, 153, 174);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(43, 45, 66);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(237, 242, 244);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(43, 45, 66);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(230, 150);
            dataGridView1.TabIndex = 33;
            // 
            // Nom
            // 
            dataGridViewCellStyle2.BackColor = Color.FromArgb(237, 242, 244);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(43, 45, 66);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            Nom.DefaultCellStyle = dataGridViewCellStyle2;
            Nom.HeaderText = "Nom Acteur";
            Nom.Name = "Nom";
            Nom.ReadOnly = true;
            // 
            // Personnage
            // 
            dataGridViewCellStyle3.BackColor = Color.FromArgb(141, 153, 174);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(239, 35, 60);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            Personnage.DefaultCellStyle = dataGridViewCellStyle3;
            Personnage.HeaderText = "Personnage";
            Personnage.Name = "Personnage";
            Personnage.ReadOnly = true;
            // 
            // Movie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 242, 244);
            ClientSize = new Size(881, 665);
            Controls.Add(dataGridView1);
            Controls.Add(TB_Pays);
            Controls.Add(TB_Annee);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(TB_Realisateur);
            Controls.Add(TB_Genre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TB_LangueOriginale);
            Controls.Add(label2);
            Controls.Add(LBL_Search_Date);
            Controls.Add(TB_Titre);
            Controls.Add(LBL_Search_Title);
            Controls.Add(PB_AfficheFilm);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Movie";
            Text = "Movie";
            ((System.ComponentModel.ISupportInitialize)PB_AfficheFilm).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PB_AfficheFilm;
        private Label label7;
        private Label label6;
        private TextBox TB_Realisateur;
        private Label label5;
        private Label label4;
        private TextBox TB_LangueOriginale;
        private TextBox TB_Titre;
        private Label LBL_Search_Title;
        private Label LBL_Search_Date;
        private TextBox TB_Annee;
        private Label label2;
        private TextBox TB_Genre;
        private TextBox TB_Pays;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nom;
        private DataGridViewTextBoxColumn Personnage;
    }
}