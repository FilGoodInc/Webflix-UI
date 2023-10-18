namespace Webflix
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
            TB_Email = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            LBL_Email = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // TB_Email
            // 
            TB_Email.Location = new Point(405, 201);
            TB_Email.Name = "TB_Email";
            TB_Email.PlaceholderText = "example@gmail.com";
            TB_Email.Size = new Size(211, 23);
            TB_Email.TabIndex = 0;
            TB_Email.TextChanged += TB_Email_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(409, 305);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(409, 422);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LBL_Email
            // 
            LBL_Email.AutoSize = true;
            LBL_Email.Location = new Point(405, 174);
            LBL_Email.Name = "LBL_Email";
            LBL_Email.Size = new Size(36, 15);
            LBL_Email.TabIndex = 3;
            LBL_Email.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(409, 279);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 667);
            Controls.Add(label2);
            Controls.Add(LBL_Email);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(TB_Email);
            Name = "Login";
            Text = "Form1";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TB_Email;
        private TextBox textBox2;
        private Button button1;
        private Label LBL_Email;
        private Label label2;
    }
}