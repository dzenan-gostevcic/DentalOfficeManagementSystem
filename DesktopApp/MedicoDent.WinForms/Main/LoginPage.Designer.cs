namespace MedicoDent.WinForms
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            pictureBox1 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            LoginButton = new Button();
            PasswordTxt = new TextBox();
            PasswordLabel = new Label();
            UsernameTxt = new TextBox();
            UsernameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(58, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(846, 212);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(335, 308);
            pictureBox5.Margin = new Padding(4, 3, 4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(16, 16);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 40;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(335, 394);
            pictureBox6.Margin = new Padding(4, 3, 4, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(16, 16);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 39;
            pictureBox6.TabStop = false;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.Green;
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = SystemColors.ButtonFace;
            LoginButton.Location = new Point(430, 506);
            LoginButton.Margin = new Padding(4, 3, 4, 3);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(96, 43);
            LoginButton.TabIndex = 38;
            LoginButton.Text = "Prijava";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_ClickAsync;
            // 
            // PasswordTxt
            // 
            PasswordTxt.BackColor = SystemColors.ControlLightLight;
            PasswordTxt.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTxt.Location = new Point(342, 431);
            PasswordTxt.Margin = new Padding(4, 3, 4, 3);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.PasswordChar = '*';
            PasswordTxt.Size = new Size(280, 22);
            PasswordTxt.TabIndex = 37;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordLabel.Location = new Point(369, 394);
            PasswordLabel.Margin = new Padding(4, 0, 4, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(53, 16);
            PasswordLabel.TabIndex = 36;
            PasswordLabel.Text = "Lozinka";
            // 
            // UsernameTxt
            // 
            UsernameTxt.BackColor = SystemColors.ControlLightLight;
            UsernameTxt.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameTxt.Location = new Point(342, 342);
            UsernameTxt.Margin = new Padding(4, 3, 4, 3);
            UsernameTxt.Name = "UsernameTxt";
            UsernameTxt.Size = new Size(280, 22);
            UsernameTxt.TabIndex = 35;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameLabel.ForeColor = SystemColors.ControlText;
            UsernameLabel.Location = new Point(369, 308);
            UsernameLabel.Margin = new Padding(4, 0, 4, 0);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(94, 16);
            UsernameLabel.TabIndex = 34;
            UsernameLabel.Text = "Korisničko ime";
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 621);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox6);
            Controls.Add(LoginButton);
            Controls.Add(PasswordTxt);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameTxt);
            Controls.Add(UsernameLabel);
            Controls.Add(pictureBox1);
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MedicoDent";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Button LoginButton;
        private TextBox PasswordTxt;
        private Label PasswordLabel;
        private TextBox UsernameTxt;
        private Label UsernameLabel;
    }
}
