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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            pictureBox1 = new PictureBox();
            TB_Search = new TextBox();
            LBL_Search = new Label();
            DGV_MovieList = new DataGridView();
            GB_Search = new GroupBox();
            LBL_NoResult = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_MovieList).BeginInit();
            GB_Search.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.FULL_LOGO;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(695, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // TB_Search
            // 
            TB_Search.Anchor = AnchorStyles.None;
            TB_Search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Search.Location = new Point(146, 22);
            TB_Search.Name = "TB_Search";
            TB_Search.PlaceholderText = "Recherche...";
            TB_Search.Size = new Size(537, 29);
            TB_Search.TabIndex = 7;
            TB_Search.TextChanged += TB_Search_TextChanged;
            // 
            // LBL_Search
            // 
            LBL_Search.Anchor = AnchorStyles.None;
            LBL_Search.AutoSize = true;
            LBL_Search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBL_Search.Location = new Point(6, 25);
            LBL_Search.Name = "LBL_Search";
            LBL_Search.Size = new Size(134, 21);
            LBL_Search.TabIndex = 8;
            LBL_Search.Text = "Recherche de film";
            // 
            // DGV_MovieList
            // 
            DGV_MovieList.AllowUserToAddRows = false;
            DGV_MovieList.AllowUserToDeleteRows = false;
            DGV_MovieList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGV_MovieList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_MovieList.BackgroundColor = Color.FromArgb(141, 153, 174);
            DGV_MovieList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_MovieList.GridColor = Color.FromArgb(141, 153, 174);
            DGV_MovieList.Location = new Point(0, 220);
            DGV_MovieList.MultiSelect = false;
            DGV_MovieList.Name = "DGV_MovieList";
            DGV_MovieList.ReadOnly = true;
            DGV_MovieList.RowTemplate.Height = 25;
            DGV_MovieList.Size = new Size(695, 565);
            DGV_MovieList.TabIndex = 9;
            // 
            // GB_Search
            // 
            GB_Search.Controls.Add(TB_Search);
            GB_Search.Controls.Add(LBL_Search);
            GB_Search.Dock = DockStyle.Top;
            GB_Search.Location = new Point(0, 147);
            GB_Search.Name = "GB_Search";
            GB_Search.Size = new Size(695, 67);
            GB_Search.TabIndex = 10;
            GB_Search.TabStop = false;
            // 
            // LBL_NoResult
            // 
            LBL_NoResult.Anchor = AnchorStyles.None;
            LBL_NoResult.BackColor = Color.FromArgb(141, 153, 174);
            LBL_NoResult.Enabled = false;
            LBL_NoResult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBL_NoResult.Location = new Point(12, 232);
            LBL_NoResult.Name = "LBL_NoResult";
            LBL_NoResult.Size = new Size(671, 544);
            LBL_NoResult.TabIndex = 11;
            LBL_NoResult.Text = "Aucun Résultat";
            LBL_NoResult.TextAlign = ContentAlignment.TopCenter;
            LBL_NoResult.Visible = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 242, 244);
            ClientSize = new Size(695, 785);
            Controls.Add(LBL_NoResult);
            Controls.Add(GB_Search);
            Controls.Add(DGV_MovieList);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(711, 529);
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
        private TextBox TB_Search;
        private Label LBL_Search;
        private DataGridView DGV_MovieList;
        private GroupBox GB_Search;
        private Label LBL_NoResult;
    }
}