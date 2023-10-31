namespace Webflix
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            pictureBox1 = new PictureBox();
            TB_Titre = new TextBox();
            LBL_Search_Title = new Label();
            DGV_MovieList = new DataGridView();
            GB_Search = new GroupBox();
            LBL_Error = new Label();
            BTN_Search = new Button();
            label7 = new Label();
            label6 = new Label();
            TB_Acteur = new TextBox();
            TB_Realisateur = new TextBox();
            TB_Genre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            TB_LangueOriginale = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            DTP_AnneeDebut = new DateTimePicker();
            DTP_AnneeFin = new DateTimePicker();
            TB_Pays = new TextBox();
            LBL_Search_Date = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_MovieList).BeginInit();
            GB_Search.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.FULL_LOGO;
            pictureBox1.Location = new Point(6, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(431, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // TB_Titre
            // 
            TB_Titre.AutoCompleteMode = AutoCompleteMode.Append;
            TB_Titre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Titre.Location = new Point(182, 38);
            TB_Titre.Name = "TB_Titre";
            TB_Titre.Size = new Size(249, 29);
            TB_Titre.TabIndex = 1;
            // 
            // LBL_Search_Title
            // 
            LBL_Search_Title.AutoSize = true;
            LBL_Search_Title.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBL_Search_Title.Location = new Point(18, 41);
            LBL_Search_Title.Name = "LBL_Search_Title";
            LBL_Search_Title.Size = new Size(94, 21);
            LBL_Search_Title.TabIndex = 0;
            LBL_Search_Title.Text = "Titre du film";
            // 
            // DGV_MovieList
            // 
            DGV_MovieList.AllowUserToAddRows = false;
            DGV_MovieList.AllowUserToDeleteRows = false;
            DGV_MovieList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGV_MovieList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_MovieList.BackgroundColor = Color.FromArgb(141, 153, 174);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(141, 153, 174);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(239, 35, 60);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGV_MovieList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGV_MovieList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_MovieList.GridColor = Color.FromArgb(141, 153, 174);
            DGV_MovieList.Location = new Point(443, 0);
            DGV_MovieList.MultiSelect = false;
            DGV_MovieList.Name = "DGV_MovieList";
            DGV_MovieList.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(141, 153, 174);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(239, 35, 60);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGV_MovieList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGV_MovieList.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(237, 242, 244);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(239, 35, 60);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            DGV_MovieList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            DGV_MovieList.RowTemplate.Height = 25;
            DGV_MovieList.Size = new Size(543, 621);
            DGV_MovieList.TabIndex = 1;
            DGV_MovieList.TabStop = false;
            // 
            // GB_Search
            // 
            GB_Search.Controls.Add(LBL_Error);
            GB_Search.Controls.Add(BTN_Search);
            GB_Search.Controls.Add(label7);
            GB_Search.Controls.Add(label6);
            GB_Search.Controls.Add(TB_Acteur);
            GB_Search.Controls.Add(TB_Realisateur);
            GB_Search.Controls.Add(TB_Genre);
            GB_Search.Controls.Add(label5);
            GB_Search.Controls.Add(label4);
            GB_Search.Controls.Add(TB_LangueOriginale);
            GB_Search.Controls.Add(label3);
            GB_Search.Controls.Add(label2);
            GB_Search.Controls.Add(label1);
            GB_Search.Controls.Add(DTP_AnneeDebut);
            GB_Search.Controls.Add(DTP_AnneeFin);
            GB_Search.Controls.Add(TB_Pays);
            GB_Search.Controls.Add(LBL_Search_Date);
            GB_Search.Controls.Add(TB_Titre);
            GB_Search.Controls.Add(LBL_Search_Title);
            GB_Search.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            GB_Search.Location = new Point(0, 147);
            GB_Search.Name = "GB_Search";
            GB_Search.Size = new Size(437, 468);
            GB_Search.TabIndex = 0;
            GB_Search.TabStop = false;
            GB_Search.Text = "Recherche de Film";
            // 
            // LBL_Error
            // 
            LBL_Error.Anchor = AnchorStyles.Top;
            LBL_Error.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBL_Error.ForeColor = Color.FromArgb(217, 4, 41);
            LBL_Error.Location = new Point(12, 294);
            LBL_Error.Name = "LBL_Error";
            LBL_Error.Size = new Size(419, 21);
            LBL_Error.TabIndex = 18;
            LBL_Error.Text = "Aucun film trouvé.";
            LBL_Error.TextAlign = ContentAlignment.TopCenter;
            LBL_Error.Visible = false;
            // 
            // BTN_Search
            // 
            BTN_Search.Anchor = AnchorStyles.Top;
            BTN_Search.BackColor = Color.FromArgb(141, 153, 174);
            BTN_Search.BackgroundImageLayout = ImageLayout.None;
            BTN_Search.Cursor = Cursors.Hand;
            BTN_Search.FlatAppearance.BorderColor = Color.FromArgb(43, 45, 66);
            BTN_Search.FlatStyle = FlatStyle.Flat;
            BTN_Search.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_Search.ForeColor = SystemColors.ControlLightLight;
            BTN_Search.Location = new Point(12, 318);
            BTN_Search.Name = "BTN_Search";
            BTN_Search.Size = new Size(419, 45);
            BTN_Search.TabIndex = 16;
            BTN_Search.Text = "Rechercher";
            BTN_Search.UseVisualStyleBackColor = false;
            BTN_Search.Click += BTN_Search_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(18, 251);
            label7.Name = "label7";
            label7.Size = new Size(55, 21);
            label7.TabIndex = 14;
            label7.Text = "Acteur";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(18, 216);
            label6.Name = "label6";
            label6.Size = new Size(87, 21);
            label6.TabIndex = 12;
            label6.Text = "Réalisateur";
            // 
            // TB_Acteur
            // 
            TB_Acteur.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Acteur.Location = new Point(182, 248);
            TB_Acteur.Name = "TB_Acteur";
            TB_Acteur.Size = new Size(249, 29);
            TB_Acteur.TabIndex = 15;
            // 
            // TB_Realisateur
            // 
            TB_Realisateur.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Realisateur.Location = new Point(182, 213);
            TB_Realisateur.Name = "TB_Realisateur";
            TB_Realisateur.Size = new Size(249, 29);
            TB_Realisateur.TabIndex = 13;
            // 
            // TB_Genre
            // 
            TB_Genre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Genre.Location = new Point(182, 178);
            TB_Genre.Name = "TB_Genre";
            TB_Genre.Size = new Size(249, 29);
            TB_Genre.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(18, 181);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 10;
            label5.Text = "Genre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(18, 146);
            label4.Name = "label4";
            label4.Size = new Size(126, 21);
            label4.TabIndex = 8;
            label4.Text = "Langue originale";
            // 
            // TB_LangueOriginale
            // 
            TB_LangueOriginale.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TB_LangueOriginale.Location = new Point(182, 143);
            TB_LangueOriginale.Name = "TB_LangueOriginale";
            TB_LangueOriginale.Size = new Size(249, 29);
            TB_LangueOriginale.TabIndex = 9;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(6, 377);
            label3.Name = "label3";
            label3.Size = new Size(425, 96);
            label3.TabIndex = 17;
            label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(18, 111);
            label2.Name = "label2";
            label2.Size = new Size(142, 21);
            label2.TabIndex = 6;
            label2.Text = "Pays de production";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(263, 79);
            label1.Name = "label1";
            label1.Size = new Size(23, 21);
            label1.TabIndex = 4;
            label1.Text = "et";
            // 
            // DTP_AnneeDebut
            // 
            DTP_AnneeDebut.CustomFormat = "yyyy";
            DTP_AnneeDebut.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DTP_AnneeDebut.Format = DateTimePickerFormat.Custom;
            DTP_AnneeDebut.Location = new Point(182, 73);
            DTP_AnneeDebut.Name = "DTP_AnneeDebut";
            DTP_AnneeDebut.ShowUpDown = true;
            DTP_AnneeDebut.Size = new Size(75, 29);
            DTP_AnneeDebut.TabIndex = 3;
            DTP_AnneeDebut.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // DTP_AnneeFin
            // 
            DTP_AnneeFin.CustomFormat = "yyyy";
            DTP_AnneeFin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DTP_AnneeFin.Format = DateTimePickerFormat.Custom;
            DTP_AnneeFin.Location = new Point(292, 73);
            DTP_AnneeFin.Name = "DTP_AnneeFin";
            DTP_AnneeFin.ShowUpDown = true;
            DTP_AnneeFin.Size = new Size(75, 29);
            DTP_AnneeFin.TabIndex = 5;
            // 
            // TB_Pays
            // 
            TB_Pays.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Pays.Location = new Point(182, 108);
            TB_Pays.Name = "TB_Pays";
            TB_Pays.Size = new Size(249, 29);
            TB_Pays.TabIndex = 7;
            // 
            // LBL_Search_Date
            // 
            LBL_Search_Date.AutoSize = true;
            LBL_Search_Date.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBL_Search_Date.Location = new Point(18, 79);
            LBL_Search_Date.Name = "LBL_Search_Date";
            LBL_Search_Date.Size = new Size(158, 21);
            LBL_Search_Date.TabIndex = 2;
            LBL_Search_Date.Text = "Année de sortie entre";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 242, 244);
            ClientSize = new Size(984, 621);
            Controls.Add(GB_Search);
            Controls.Add(DGV_MovieList);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1000, 660);
            Name = "Main";
            Text = "Webflix";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_MovieList).EndInit();
            GB_Search.ResumeLayout(false);
            GB_Search.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox TB_Titre;
        private Label LBL_Search_Title;
        private DataGridView DGV_MovieList;
        private GroupBox GB_Search;
        private DateTimePicker DTP_AnneeFin;
        private TextBox TB_Pays;
        private Label LBL_Search_Date;
        private Label label1;
        private DateTimePicker DTP_AnneeDebut;
        private Label label2;
        private Label label3;
        private Label label7;
        private Label label6;
        private TextBox TB_Acteur;
        private TextBox TB_Realisateur;
        private TextBox TB_Genre;
        private Label label5;
        private Label label4;
        private TextBox TB_LangueOriginale;
        private Button BTN_Search;
        private Label LBL_Error;
    }
}