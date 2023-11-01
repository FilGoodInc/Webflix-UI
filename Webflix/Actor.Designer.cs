namespace Webflix
{
    partial class Actor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actor));
            lbl_scenariste = new Label();
            TB_LieuDeNaissance = new TextBox();
            label6 = new Label();
            TB_DateDeNaissance = new TextBox();
            TB_Nom = new TextBox();
            LBL_Search_Title = new Label();
            PB_AfficheFilm = new PictureBox();
            label3 = new Label();
            RTB_Biographie = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)PB_AfficheFilm).BeginInit();
            SuspendLayout();
            // 
            // lbl_scenariste
            // 
            lbl_scenariste.AutoSize = true;
            lbl_scenariste.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_scenariste.Location = new Point(218, 85);
            lbl_scenariste.Name = "lbl_scenariste";
            lbl_scenariste.Size = new Size(131, 21);
            lbl_scenariste.TabIndex = 49;
            lbl_scenariste.Text = "Lieu de naissance";
            // 
            // TB_LieuDeNaissance
            // 
            TB_LieuDeNaissance.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TB_LieuDeNaissance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TB_LieuDeNaissance.Location = new Point(366, 82);
            TB_LieuDeNaissance.Name = "TB_LieuDeNaissance";
            TB_LieuDeNaissance.ReadOnly = true;
            TB_LieuDeNaissance.Size = new Size(223, 29);
            TB_LieuDeNaissance.TabIndex = 50;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(218, 50);
            label6.Name = "label6";
            label6.Size = new Size(134, 21);
            label6.TabIndex = 45;
            label6.Text = "Date de naissance";
            // 
            // TB_DateDeNaissance
            // 
            TB_DateDeNaissance.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TB_DateDeNaissance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TB_DateDeNaissance.Location = new Point(366, 47);
            TB_DateDeNaissance.Name = "TB_DateDeNaissance";
            TB_DateDeNaissance.ReadOnly = true;
            TB_DateDeNaissance.Size = new Size(223, 29);
            TB_DateDeNaissance.TabIndex = 46;
            // 
            // TB_Nom
            // 
            TB_Nom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TB_Nom.AutoCompleteMode = AutoCompleteMode.Append;
            TB_Nom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Nom.Location = new Point(366, 12);
            TB_Nom.Name = "TB_Nom";
            TB_Nom.ReadOnly = true;
            TB_Nom.Size = new Size(223, 29);
            TB_Nom.TabIndex = 40;
            // 
            // LBL_Search_Title
            // 
            LBL_Search_Title.AutoSize = true;
            LBL_Search_Title.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBL_Search_Title.Location = new Point(218, 15);
            LBL_Search_Title.Name = "LBL_Search_Title";
            LBL_Search_Title.Size = new Size(45, 21);
            LBL_Search_Title.TabIndex = 39;
            LBL_Search_Title.Text = "Nom";
            // 
            // PB_AfficheFilm
            // 
            PB_AfficheFilm.BackColor = Color.FromArgb(141, 153, 174);
            PB_AfficheFilm.BackgroundImage = Properties.Resources.ACTOR_PLACEHOLDER;
            PB_AfficheFilm.BackgroundImageLayout = ImageLayout.Zoom;
            PB_AfficheFilm.BorderStyle = BorderStyle.FixedSingle;
            PB_AfficheFilm.Location = new Point(12, 12);
            PB_AfficheFilm.Name = "PB_AfficheFilm";
            PB_AfficheFilm.Size = new Size(200, 300);
            PB_AfficheFilm.SizeMode = PictureBoxSizeMode.Zoom;
            PB_AfficheFilm.TabIndex = 38;
            PB_AfficheFilm.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(218, 121);
            label3.Name = "label3";
            label3.Size = new Size(85, 21);
            label3.TabIndex = 52;
            label3.Text = "Biographie";
            // 
            // RTB_Biographie
            // 
            RTB_Biographie.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RTB_Biographie.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RTB_Biographie.Location = new Point(218, 145);
            RTB_Biographie.Name = "RTB_Biographie";
            RTB_Biographie.ReadOnly = true;
            RTB_Biographie.Size = new Size(371, 355);
            RTB_Biographie.TabIndex = 51;
            RTB_Biographie.Text = "";
            // 
            // Actor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 512);
            Controls.Add(label3);
            Controls.Add(RTB_Biographie);
            Controls.Add(lbl_scenariste);
            Controls.Add(TB_LieuDeNaissance);
            Controls.Add(label6);
            Controls.Add(TB_DateDeNaissance);
            Controls.Add(TB_Nom);
            Controls.Add(LBL_Search_Title);
            Controls.Add(PB_AfficheFilm);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(618, 360);
            Name = "Actor";
            Text = "Détails Acteur";
            Load += Actor_Load;
            ((System.ComponentModel.ISupportInitialize)PB_AfficheFilm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_scenariste;
        private TextBox TB_LieuDeNaissance;
        private Label label6;
        private TextBox TB_DateDeNaissance;
        private TextBox TB_Nom;
        private Label LBL_Search_Title;
        private PictureBox PB_AfficheFilm;
        private Label label3;
        private RichTextBox RTB_Biographie;
    }
}