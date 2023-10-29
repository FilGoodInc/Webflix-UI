﻿namespace Webflix
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            TB_Email = new TextBox();
            TB_Password = new TextBox();
            Login_BTN = new Button();
            LBL_Email = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            Error_LBL = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TB_Email
            // 
            TB_Email.Anchor = AnchorStyles.Top;
            TB_Email.Cursor = Cursors.IBeam;
            TB_Email.Location = new Point(152, 153);
            TB_Email.MaximumSize = new Size(219, 23);
            TB_Email.Name = "TB_Email";
            TB_Email.PlaceholderText = "exemple@gmail.com";
            TB_Email.Size = new Size(219, 23);
            TB_Email.TabIndex = 0;
            // 
            // TB_Password
            // 
            TB_Password.Anchor = AnchorStyles.Top;
            TB_Password.Cursor = Cursors.IBeam;
            TB_Password.Location = new Point(152, 182);
            TB_Password.MaximumSize = new Size(219, 23);
            TB_Password.Name = "TB_Password";
            TB_Password.PlaceholderText = "*****";
            TB_Password.Size = new Size(219, 23);
            TB_Password.TabIndex = 1;
            // 
            // Login_BTN
            // 
            Login_BTN.Anchor = AnchorStyles.Top;
            Login_BTN.BackColor = Color.FromArgb(141, 153, 174);
            Login_BTN.BackgroundImageLayout = ImageLayout.None;
            Login_BTN.Cursor = Cursors.Hand;
            Login_BTN.FlatAppearance.BorderColor = Color.FromArgb(43, 45, 66);
            Login_BTN.FlatStyle = FlatStyle.Flat;
            Login_BTN.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Login_BTN.ForeColor = SystemColors.ControlLightLight;
            Login_BTN.Location = new Point(12, 232);
            Login_BTN.Name = "Login_BTN";
            Login_BTN.Size = new Size(359, 45);
            Login_BTN.TabIndex = 2;
            Login_BTN.Text = "Connexion";
            Login_BTN.UseVisualStyleBackColor = false;
            Login_BTN.Click += Login_BTN_Click;
            // 
            // LBL_Email
            // 
            LBL_Email.Anchor = AnchorStyles.Top;
            LBL_Email.AutoSize = true;
            LBL_Email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBL_Email.Location = new Point(12, 155);
            LBL_Email.Name = "LBL_Email";
            LBL_Email.Size = new Size(134, 21);
            LBL_Email.TabIndex = 3;
            LBL_Email.Text = "Addresse Courriel";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.FULL_LOGO;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(383, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 184);
            label1.Name = "label1";
            label1.Size = new Size(102, 21);
            label1.TabIndex = 6;
            label1.Text = "Mot de passe";
            // 
            // Error_LBL
            // 
            Error_LBL.Anchor = AnchorStyles.Top;
            Error_LBL.AutoSize = true;
            Error_LBL.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Error_LBL.ForeColor = Color.FromArgb(217, 4, 41);
            Error_LBL.Location = new Point(161, 208);
            Error_LBL.Name = "Error_LBL";
            Error_LBL.Size = new Size(55, 21);
            Error_LBL.TabIndex = 7;
            Error_LBL.Text = "{Error}";
            Error_LBL.TextAlign = ContentAlignment.TopCenter;
            Error_LBL.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 242, 244);
            ClientSize = new Size(383, 285);
            Controls.Add(Error_LBL);
            Controls.Add(label1);
            Controls.Add(TB_Email);
            Controls.Add(LBL_Email);
            Controls.Add(pictureBox1);
            Controls.Add(Login_BTN);
            Controls.Add(TB_Password);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Login";
            Text = "Webflix - Connexion";
            Load += Login_Load;
            KeyPress += KeyPress_Enter;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TB_Email;
        private TextBox TB_Password;
        private Button Login_BTN;
        private Label LBL_Email;
        private PictureBox pictureBox1;
        private Label label1;
        private Label Error_LBL;
    }
}