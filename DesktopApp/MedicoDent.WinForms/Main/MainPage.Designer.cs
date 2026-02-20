namespace MedicoDent.WinForms.Main
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            pictureBox1 = new PictureBox();
            PatientsButton = new Button();
            NewTreatmantButton = new Button();
            AdministrationButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(70, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(846, 212);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // PatientsButton
            // 
            PatientsButton.BackColor = Color.FromArgb(0, 192, 0);
            PatientsButton.ForeColor = Color.White;
            PatientsButton.Location = new Point(159, 379);
            PatientsButton.Name = "PatientsButton";
            PatientsButton.Size = new Size(113, 67);
            PatientsButton.TabIndex = 3;
            PatientsButton.Text = "Pacijenti";
            PatientsButton.UseVisualStyleBackColor = false;
            PatientsButton.Click += PatientsButton_Click;
            // 
            // NewTreatmantButton
            // 
            NewTreatmantButton.BackColor = Color.FromArgb(0, 192, 0);
            NewTreatmantButton.ForeColor = Color.White;
            NewTreatmantButton.Location = new Point(459, 379);
            NewTreatmantButton.Name = "NewTreatmantButton";
            NewTreatmantButton.Size = new Size(108, 67);
            NewTreatmantButton.TabIndex = 4;
            NewTreatmantButton.Text = "Novi termin";
            NewTreatmantButton.UseVisualStyleBackColor = false;
            // 
            // AdministrationButton
            // 
            AdministrationButton.BackColor = Color.FromArgb(0, 192, 0);
            AdministrationButton.ForeColor = Color.White;
            AdministrationButton.Location = new Point(763, 379);
            AdministrationButton.Name = "AdministrationButton";
            AdministrationButton.Size = new Size(108, 67);
            AdministrationButton.TabIndex = 5;
            AdministrationButton.Text = "Administracija";
            AdministrationButton.UseVisualStyleBackColor = false;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 624);
            Controls.Add(AdministrationButton);
            Controls.Add(NewTreatmantButton);
            Controls.Add(PatientsButton);
            Controls.Add(pictureBox1);
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button PatientsButton;
        private Button NewTreatmantButton;
        private Button AdministrationButton;
    }
}