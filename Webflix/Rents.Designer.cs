namespace Webflix
{
    partial class Rents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rents));
            label4 = new Label();
            label2 = new Label();
            LBL_Search_Title = new Label();
            LBL_Search_Date = new Label();
            CB_Day = new ComboBox();
            CB_Month = new ComboBox();
            CB_Province = new ComboBox();
            DGV_RentList = new DataGridView();
            BTN_Search = new Button();
            CB_Age = new ComboBox();
            label1 = new Label();
            TB_RentCount = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DGV_RentList).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 101);
            label4.Name = "label4";
            label4.Size = new Size(44, 21);
            label4.TabIndex = 24;
            label4.Text = "Mois";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(40, 21);
            label2.TabIndex = 22;
            label2.Text = "Jour";
            // 
            // LBL_Search_Title
            // 
            LBL_Search_Title.AutoSize = true;
            LBL_Search_Title.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBL_Search_Title.Location = new Point(12, 14);
            LBL_Search_Title.Name = "LBL_Search_Title";
            LBL_Search_Title.Size = new Size(70, 21);
            LBL_Search_Title.TabIndex = 16;
            LBL_Search_Title.Text = "Province";
            // 
            // LBL_Search_Date
            // 
            LBL_Search_Date.AutoSize = true;
            LBL_Search_Date.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBL_Search_Date.Location = new Point(12, 43);
            LBL_Search_Date.Name = "LBL_Search_Date";
            LBL_Search_Date.Size = new Size(78, 21);
            LBL_Search_Date.TabIndex = 18;
            LBL_Search_Date.Text = "Age client";
            // 
            // CB_Day
            // 
            CB_Day.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_Day.FormattingEnabled = true;
            CB_Day.Items.AddRange(new object[] { "", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" });
            CB_Day.Location = new Point(96, 70);
            CB_Day.Name = "CB_Day";
            CB_Day.Size = new Size(164, 23);
            CB_Day.TabIndex = 34;
            // 
            // CB_Month
            // 
            CB_Month.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_Month.FormattingEnabled = true;
            CB_Month.Items.AddRange(new object[] { "", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            CB_Month.Location = new Point(96, 99);
            CB_Month.Name = "CB_Month";
            CB_Month.Size = new Size(164, 23);
            CB_Month.TabIndex = 35;
            // 
            // CB_Province
            // 
            CB_Province.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_Province.FormattingEnabled = true;
            CB_Province.Items.AddRange(new object[] { "", "QC", "ON", "MB", "SK", "NL", "BC", "PE", "NB", "NS", "NL", "NT", "NU", "YT" });
            CB_Province.Location = new Point(96, 12);
            CB_Province.Name = "CB_Province";
            CB_Province.Size = new Size(164, 23);
            CB_Province.TabIndex = 36;
            // 
            // DGV_RentList
            // 
            DGV_RentList.AllowUserToAddRows = false;
            DGV_RentList.AllowUserToDeleteRows = false;
            DGV_RentList.AllowUserToResizeColumns = false;
            DGV_RentList.AllowUserToResizeRows = false;
            DGV_RentList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGV_RentList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_RentList.BackgroundColor = Color.FromArgb(141, 153, 174);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(141, 153, 174);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(239, 35, 60);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGV_RentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGV_RentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_RentList.GridColor = Color.FromArgb(141, 153, 174);
            DGV_RentList.Location = new Point(266, 0);
            DGV_RentList.MultiSelect = false;
            DGV_RentList.Name = "DGV_RentList";
            DGV_RentList.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(141, 153, 174);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(239, 35, 60);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGV_RentList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGV_RentList.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(237, 242, 244);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(239, 35, 60);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            DGV_RentList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            DGV_RentList.RowTemplate.Height = 25;
            DGV_RentList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_RentList.Size = new Size(593, 220);
            DGV_RentList.TabIndex = 37;
            DGV_RentList.TabStop = false;
            DGV_RentList.SelectionChanged += DGV_RentList_SelectionChanged;
            // 
            // BTN_Search
            // 
            BTN_Search.BackColor = Color.FromArgb(141, 153, 174);
            BTN_Search.BackgroundImageLayout = ImageLayout.None;
            BTN_Search.Cursor = Cursors.Hand;
            BTN_Search.FlatAppearance.BorderColor = Color.FromArgb(43, 45, 66);
            BTN_Search.FlatStyle = FlatStyle.Flat;
            BTN_Search.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_Search.ForeColor = SystemColors.ControlLightLight;
            BTN_Search.Location = new Point(12, 142);
            BTN_Search.Name = "BTN_Search";
            BTN_Search.Size = new Size(248, 45);
            BTN_Search.TabIndex = 38;
            BTN_Search.Text = "Rechercher";
            BTN_Search.UseVisualStyleBackColor = false;
            BTN_Search.Click += BTN_Search_Click;
            // 
            // CB_Age
            // 
            CB_Age.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_Age.FormattingEnabled = true;
            CB_Age.Items.AddRange(new object[] { "", "0-5", "5-10", "10-15", "15-20", "20-25", "25-30", "30-35", "35-40", "40-45", "45-50", "50-55", "55-60", "60-65", "65-70", "70-75", "75-80", "80-85", "85-90", "90-95", "95+" });
            CB_Age.Location = new Point(96, 41);
            CB_Age.Name = "CB_Age";
            CB_Age.Size = new Size(164, 23);
            CB_Age.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 190);
            label1.Name = "label1";
            label1.Size = new Size(158, 21);
            label1.TabIndex = 40;
            label1.Text = "Nombre de locations:";
            // 
            // TB_RentCount
            // 
            TB_RentCount.Location = new Point(176, 192);
            TB_RentCount.Name = "TB_RentCount";
            TB_RentCount.ReadOnly = true;
            TB_RentCount.Size = new Size(84, 23);
            TB_RentCount.TabIndex = 41;
            // 
            // Rents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 220);
            Controls.Add(TB_RentCount);
            Controls.Add(label1);
            Controls.Add(CB_Age);
            Controls.Add(BTN_Search);
            Controls.Add(DGV_RentList);
            Controls.Add(CB_Province);
            Controls.Add(CB_Month);
            Controls.Add(CB_Day);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(LBL_Search_Date);
            Controls.Add(LBL_Search_Title);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Rents";
            Text = "Calcul des locations";
            ((System.ComponentModel.ISupportInitialize)DGV_RentList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private TextBox TB_LangueOriginale;
        private Label label2;
        private TextBox TB_Pays;
        private TextBox TB_Titre;
        private Label LBL_Search_Title;
        private Label LBL_Search_Date;
        private ComboBox CB_Day;
        private ComboBox CB_Month;
        private ComboBox CB_Province;
        private DataGridView DGV_RentList;
        private Button BTN_Search;
        private ComboBox CB_Age;
        private Label label1;
        private TextBox TB_RentCount;
    }
}