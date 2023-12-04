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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Movie));
            PB_AfficheFilm = new PictureBox();
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
            DGV_Acteurs = new DataGridView();
            TB_Duree = new TextBox();
            label1 = new Label();
            lbl_scenariste = new Label();
            TB_Scenariste = new TextBox();
            RTB_Resume = new RichTextBox();
            label3 = new Label();
            DGV_BandesAnnonces = new DataGridView();
            BandesAnnonces = new DataGridViewLinkColumn();
            BTN_Louer = new Button();
            label8 = new Label();
            label9 = new Label();
            TB_Cote = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PB_AfficheFilm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Acteurs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_BandesAnnonces).BeginInit();
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
            PB_AfficheFilm.SizeMode = PictureBoxSizeMode.Zoom;
            PB_AfficheFilm.TabIndex = 0;
            PB_AfficheFilm.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(218, 47);
            label6.Name = "label6";
            label6.Size = new Size(87, 21);
            label6.TabIndex = 27;
            label6.Text = "Réalisateur";
            // 
            // TB_Realisateur
            // 
            TB_Realisateur.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Realisateur.Location = new Point(318, 44);
            TB_Realisateur.Name = "TB_Realisateur";
            TB_Realisateur.ReadOnly = true;
            TB_Realisateur.Size = new Size(271, 29);
            TB_Realisateur.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(594, 152);
            label5.Name = "label5";
            label5.Size = new Size(59, 21);
            label5.TabIndex = 25;
            label5.Text = "Genres";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(594, 82);
            label4.Name = "label4";
            label4.Size = new Size(126, 21);
            label4.TabIndex = 23;
            label4.Text = "Langue originale";
            // 
            // TB_LangueOriginale
            // 
            TB_LangueOriginale.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TB_LangueOriginale.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TB_LangueOriginale.Location = new Point(742, 79);
            TB_LangueOriginale.Name = "TB_LangueOriginale";
            TB_LangueOriginale.ReadOnly = true;
            TB_LangueOriginale.Size = new Size(223, 29);
            TB_LangueOriginale.TabIndex = 24;
            // 
            // TB_Titre
            // 
            TB_Titre.AutoCompleteMode = AutoCompleteMode.Append;
            TB_Titre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Titre.Location = new Point(318, 9);
            TB_Titre.Name = "TB_Titre";
            TB_Titre.ReadOnly = true;
            TB_Titre.Size = new Size(271, 29);
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
            LBL_Search_Date.Location = new Point(594, 12);
            LBL_Search_Date.Name = "LBL_Search_Date";
            LBL_Search_Date.Size = new Size(118, 21);
            LBL_Search_Date.TabIndex = 18;
            LBL_Search_Date.Text = "Année de sortie";
            // 
            // TB_Annee
            // 
            TB_Annee.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TB_Annee.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Annee.Location = new Point(742, 6);
            TB_Annee.Name = "TB_Annee";
            TB_Annee.ReadOnly = true;
            TB_Annee.Size = new Size(223, 29);
            TB_Annee.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(594, 44);
            label2.Name = "label2";
            label2.Size = new Size(142, 21);
            label2.TabIndex = 21;
            label2.Text = "Pays de production";
            // 
            // TB_Genre
            // 
            TB_Genre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TB_Genre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Genre.Location = new Point(659, 149);
            TB_Genre.Name = "TB_Genre";
            TB_Genre.ReadOnly = true;
            TB_Genre.Size = new Size(306, 29);
            TB_Genre.TabIndex = 26;
            // 
            // TB_Pays
            // 
            TB_Pays.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TB_Pays.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Pays.Location = new Point(742, 44);
            TB_Pays.Name = "TB_Pays";
            TB_Pays.ReadOnly = true;
            TB_Pays.Size = new Size(223, 29);
            TB_Pays.TabIndex = 32;
            // 
            // DGV_Acteurs
            // 
            DGV_Acteurs.AllowUserToAddRows = false;
            DGV_Acteurs.AllowUserToDeleteRows = false;
            DGV_Acteurs.AllowUserToResizeRows = false;
            DGV_Acteurs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Acteurs.BackgroundColor = Color.FromArgb(141, 153, 174);
            DGV_Acteurs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(237, 242, 244);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(239, 35, 60);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DGV_Acteurs.DefaultCellStyle = dataGridViewCellStyle1;
            DGV_Acteurs.GridColor = Color.FromArgb(237, 242, 244);
            DGV_Acteurs.Location = new Point(218, 149);
            DGV_Acteurs.MultiSelect = false;
            DGV_Acteurs.Name = "DGV_Acteurs";
            DGV_Acteurs.ReadOnly = true;
            DGV_Acteurs.RowHeadersVisible = false;
            DGV_Acteurs.RowTemplate.Height = 25;
            DGV_Acteurs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Acteurs.Size = new Size(371, 163);
            DGV_Acteurs.TabIndex = 33;
            DGV_Acteurs.CellDoubleClick += DGV_Acteurs_CellDoubleClick;
            // 
            // TB_Duree
            // 
            TB_Duree.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TB_Duree.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Duree.Location = new Point(742, 114);
            TB_Duree.Name = "TB_Duree";
            TB_Duree.ReadOnly = true;
            TB_Duree.Size = new Size(223, 29);
            TB_Duree.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(594, 117);
            label1.Name = "label1";
            label1.Size = new Size(122, 21);
            label1.TabIndex = 34;
            label1.Text = "Durée (Minutes)";
            // 
            // lbl_scenariste
            // 
            lbl_scenariste.AutoSize = true;
            lbl_scenariste.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_scenariste.Location = new Point(218, 82);
            lbl_scenariste.Name = "lbl_scenariste";
            lbl_scenariste.Size = new Size(88, 21);
            lbl_scenariste.TabIndex = 36;
            lbl_scenariste.Text = "Scénaristes";
            // 
            // TB_Scenariste
            // 
            TB_Scenariste.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Scenariste.Location = new Point(318, 79);
            TB_Scenariste.Name = "TB_Scenariste";
            TB_Scenariste.ReadOnly = true;
            TB_Scenariste.Size = new Size(271, 29);
            TB_Scenariste.TabIndex = 37;
            // 
            // RTB_Resume
            // 
            RTB_Resume.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RTB_Resume.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RTB_Resume.Location = new Point(84, 318);
            RTB_Resume.Name = "RTB_Resume";
            RTB_Resume.ReadOnly = true;
            RTB_Resume.Size = new Size(877, 150);
            RTB_Resume.TabIndex = 38;
            RTB_Resume.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 321);
            label3.Name = "label3";
            label3.Size = new Size(66, 21);
            label3.TabIndex = 39;
            label3.Text = "Résumé";
            // 
            // DGV_BandesAnnonces
            // 
            DGV_BandesAnnonces.AllowUserToAddRows = false;
            DGV_BandesAnnonces.AllowUserToDeleteRows = false;
            DGV_BandesAnnonces.AllowUserToResizeRows = false;
            DGV_BandesAnnonces.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DGV_BandesAnnonces.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_BandesAnnonces.BackgroundColor = Color.FromArgb(141, 153, 174);
            DGV_BandesAnnonces.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_BandesAnnonces.Columns.AddRange(new DataGridViewColumn[] { BandesAnnonces });
            DGV_BandesAnnonces.GridColor = Color.FromArgb(237, 242, 244);
            DGV_BandesAnnonces.Location = new Point(595, 184);
            DGV_BandesAnnonces.MultiSelect = false;
            DGV_BandesAnnonces.Name = "DGV_BandesAnnonces";
            DGV_BandesAnnonces.ReadOnly = true;
            DGV_BandesAnnonces.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(237, 242, 244);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(237, 242, 244);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            DGV_BandesAnnonces.RowsDefaultCellStyle = dataGridViewCellStyle2;
            DGV_BandesAnnonces.RowTemplate.Height = 25;
            DGV_BandesAnnonces.ScrollBars = ScrollBars.Vertical;
            DGV_BandesAnnonces.Size = new Size(366, 128);
            DGV_BandesAnnonces.TabIndex = 40;
            DGV_BandesAnnonces.CellContentClick += DGV_BandesAnnonces_CellContentClick;
            // 
            // BandesAnnonces
            // 
            BandesAnnonces.HeaderText = "Liens vers Bandes Annonces";
            BandesAnnonces.Name = "BandesAnnonces";
            BandesAnnonces.ReadOnly = true;
            BandesAnnonces.Resizable = DataGridViewTriState.True;
            BandesAnnonces.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // BTN_Louer
            // 
            BTN_Louer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BTN_Louer.BackColor = Color.FromArgb(239, 35, 60);
            BTN_Louer.BackgroundImageLayout = ImageLayout.None;
            BTN_Louer.Cursor = Cursors.Hand;
            BTN_Louer.FlatAppearance.BorderColor = Color.FromArgb(43, 45, 66);
            BTN_Louer.FlatStyle = FlatStyle.Flat;
            BTN_Louer.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_Louer.ForeColor = SystemColors.ControlLightLight;
            BTN_Louer.Location = new Point(770, 568);
            BTN_Louer.Name = "BTN_Louer";
            BTN_Louer.Size = new Size(191, 90);
            BTN_Louer.TabIndex = 41;
            BTN_Louer.Text = "Louer le Film";
            BTN_Louer.UseVisualStyleBackColor = false;
            BTN_Louer.Click += BTN_Louer_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(12, 471);
            label8.Name = "label8";
            label8.Size = new Size(406, 21);
            label8.TabIndex = 42;
            label8.Text = "Films ayant le plus haut indice de corrélation avec ce film:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(424, 495);
            label9.Name = "label9";
            label9.Size = new Size(111, 21);
            label9.TabIndex = 43;
            label9.Text = "Cote Moyenne";
            // 
            // TB_Cote
            // 
            TB_Cote.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Cote.Location = new Point(424, 519);
            TB_Cote.Name = "TB_Cote";
            TB_Cote.ReadOnly = true;
            TB_Cote.Size = new Size(111, 29);
            TB_Cote.TabIndex = 44;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(141, 153, 174);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(237, 242, 244);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(239, 35, 60);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.GridColor = Color.FromArgb(237, 242, 244);
            dataGridView1.Location = new Point(12, 495);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(406, 163);
            dataGridView1.TabIndex = 45;
            // 
            // Movie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 242, 244);
            ClientSize = new Size(973, 670);
            Controls.Add(dataGridView1);
            Controls.Add(TB_Cote);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(BTN_Louer);
            Controls.Add(DGV_BandesAnnonces);
            Controls.Add(label3);
            Controls.Add(RTB_Resume);
            Controls.Add(lbl_scenariste);
            Controls.Add(TB_Scenariste);
            Controls.Add(TB_Duree);
            Controls.Add(label1);
            Controls.Add(DGV_Acteurs);
            Controls.Add(TB_Pays);
            Controls.Add(TB_Annee);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Movie";
            Text = "Film";
            Load += Movie_Load;
            ((System.ComponentModel.ISupportInitialize)PB_AfficheFilm).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Acteurs).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_BandesAnnonces).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PB_AfficheFilm;
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
        private DataGridView DGV_Acteurs;
        private TextBox TB_Duree;
        private Label label1;
        private Label lbl_scenariste;
        private TextBox TB_Scenariste;
        private RichTextBox RTB_Resume;
        private Label label3;
        private Label label7;
        private DataGridView DGV_BandesAnnonces;
        private DataGridViewLinkColumn BandesAnnonces;
        private Button BTN_Louer;
        private Label label8;
        private Label label9;
        private TextBox TB_Cote;
        private DataGridView dataGridView1;
    }
}