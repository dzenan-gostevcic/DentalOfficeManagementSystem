namespace MedicoDent.WinForms.Forms
{
    partial class PatientAddEdit
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
            components = new System.ComponentModel.Container();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtPhone = new TextBox();
            chkAllergie = new CheckBox();
            chkBlackList = new CheckBox();
            btnSave = new Button();
            btnCancel = new Button();
            txtEmail1 = new TextBox();
            chkMuško = new CheckBox();
            chkŽensko = new CheckBox();
            dtpBirthDate = new DateTimePicker();
            txtMjestoRođenja = new TextBox();
            txtRodStar = new TextBox();
            txtLicna = new TextBox();
            txtJMBG = new TextBox();
            txtBrojZdr = new TextBox();
            txtBroDoOs = new TextBox();
            vScrollBar1 = new VScrollBar();
            cmbBrak = new ComboBox();
            cmbZan = new ComboBox();
            txtUlica = new TextBox();
            txtZip = new TextBox();
            txtBroUl = new TextBox();
            txtGrad = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label1 = new Label();
            label18 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(201, 70);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(201, 120);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(201, 172);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 2;
            // 
            // chkAllergie
            // 
            chkAllergie.AutoSize = true;
            chkAllergie.Location = new Point(615, 197);
            chkAllergie.Name = "chkAllergie";
            chkAllergie.Size = new Size(83, 24);
            chkAllergie.TabIndex = 3;
            chkAllergie.Text = "Alergija";
            chkAllergie.UseVisualStyleBackColor = true;
            // 
            // chkBlackList
            // 
            chkBlackList.AutoSize = true;
            chkBlackList.Location = new Point(454, 197);
            chkBlackList.Name = "chkBlackList";
            chkBlackList.Size = new Size(94, 26);
            chkBlackList.TabIndex = 4;
            chkBlackList.Text = "Crna Lista";
            chkBlackList.UseCompatibleTextRendering = true;
            chkBlackList.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(118, 1002);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(208, 29);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(485, 1002);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(229, 29);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtEmail1
            // 
            txtEmail1.Location = new Point(201, 222);
            txtEmail1.Name = "txtEmail1";
            txtEmail1.Size = new Size(125, 27);
            txtEmail1.TabIndex = 11;
            // 
            // chkMuško
            // 
            chkMuško.AutoSize = true;
            chkMuško.Location = new Point(184, 277);
            chkMuško.Name = "chkMuško";
            chkMuško.Size = new Size(74, 24);
            chkMuško.TabIndex = 13;
            chkMuško.Text = "Muško";
            chkMuško.UseVisualStyleBackColor = true;
            chkMuško.CheckedChanged += chkMuško_CheckedChanged_1;
            // 
            // chkŽensko
            // 
            chkŽensko.AutoSize = true;
            chkŽensko.Location = new Point(264, 278);
            chkŽensko.Name = "chkŽensko";
            chkŽensko.Size = new Size(78, 24);
            chkŽensko.TabIndex = 14;
            chkŽensko.Text = "Žensko";
            chkŽensko.UseVisualStyleBackColor = true;
            chkŽensko.CheckedChanged += chkŽensko_CheckedChanged_1;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(184, 326);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(251, 27);
            dtpBirthDate.TabIndex = 17;
            // 
            // txtMjestoRođenja
            // 
            txtMjestoRođenja.Location = new Point(201, 383);
            txtMjestoRođenja.Name = "txtMjestoRođenja";
            txtMjestoRođenja.Size = new Size(125, 27);
            txtMjestoRođenja.TabIndex = 19;
            // 
            // txtRodStar
            // 
            txtRodStar.Location = new Point(201, 438);
            txtRodStar.Name = "txtRodStar";
            txtRodStar.Size = new Size(125, 27);
            txtRodStar.TabIndex = 21;
            // 
            // txtLicna
            // 
            txtLicna.Location = new Point(201, 495);
            txtLicna.Name = "txtLicna";
            txtLicna.Size = new Size(125, 27);
            txtLicna.TabIndex = 23;
            // 
            // txtJMBG
            // 
            txtJMBG.Location = new Point(201, 556);
            txtJMBG.Name = "txtJMBG";
            txtJMBG.Size = new Size(125, 27);
            txtJMBG.TabIndex = 25;
            txtJMBG.KeyPress += txtJMBG_KeyPress;
            // 
            // txtBrojZdr
            // 
            txtBrojZdr.Location = new Point(235, 619);
            txtBrojZdr.Name = "txtBrojZdr";
            txtBrojZdr.Size = new Size(125, 27);
            txtBrojZdr.TabIndex = 27;
            // 
            // txtBroDoOs
            // 
            txtBroDoOs.Location = new Point(235, 679);
            txtBroDoOs.Name = "txtBroDoOs";
            txtBroDoOs.Size = new Size(125, 27);
            txtBroDoOs.TabIndex = 29;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(778, 209);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 125);
            vScrollBar1.TabIndex = 30;
            // 
            // cmbBrak
            // 
            cmbBrak.FormattingEnabled = true;
            cmbBrak.Location = new Point(615, 74);
            cmbBrak.Name = "cmbBrak";
            cmbBrak.Size = new Size(151, 28);
            cmbBrak.TabIndex = 32;
            cmbBrak.SelectedValueChanged += cmbBrak__SelectedValueChanged;
            // 
            // cmbZan
            // 
            cmbZan.FormattingEnabled = true;
            cmbZan.Items.AddRange(new object[] { "Varioc", "Lopov", "Skiper", "Konobar", "DIler" });
            cmbZan.Location = new Point(615, 133);
            cmbZan.Name = "cmbZan";
            cmbZan.Size = new Size(151, 28);
            cmbZan.TabIndex = 33;
            cmbZan.SelectedValueChanged += cmbZan_SelectedValueChanged;
            // 
            // txtUlica
            // 
            txtUlica.Location = new Point(184, 744);
            txtUlica.Name = "txtUlica";
            txtUlica.Size = new Size(125, 27);
            txtUlica.TabIndex = 36;
            // 
            // txtZip
            // 
            txtZip.Location = new Point(184, 865);
            txtZip.Name = "txtZip";
            txtZip.Size = new Size(125, 27);
            txtZip.TabIndex = 39;
            // 
            // txtBroUl
            // 
            txtBroUl.Location = new Point(184, 803);
            txtBroUl.Name = "txtBroUl";
            txtBroUl.Size = new Size(125, 27);
            txtBroUl.TabIndex = 40;
            // 
            // txtGrad
            // 
            txtGrad.Location = new Point(184, 923);
            txtGrad.Name = "txtGrad";
            txtGrad.Size = new Size(125, 27);
            txtGrad.TabIndex = 42;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(7, 70);
            label2.Name = "label2";
            label2.Size = new Size(46, 22);
            label2.TabIndex = 44;
            label2.Text = "Ime *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 120);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 45;
            label3.Text = "Prezime";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 172);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 46;
            label4.Text = "Telefon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 222);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 47;
            label5.Text = "E-Mail *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 277);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 48;
            label6.Text = "Spol";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 326);
            label7.Name = "label7";
            label7.Size = new Size(113, 20);
            label7.TabIndex = 49;
            label7.Text = "Datum Rođenja";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(-1, 383);
            label8.Name = "label8";
            label8.Size = new Size(113, 20);
            label8.TabIndex = 50;
            label8.Text = "Mjesto Rođenja";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 438);
            label9.Name = "label9";
            label9.Size = new Size(122, 20);
            label9.TabIndex = 51;
            label9.Text = "Roditelj/Staratelj";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 498);
            label10.Name = "label10";
            label10.Size = new Size(113, 20);
            label10.TabIndex = 52;
            label10.Text = "Broj Lične Karte";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(7, 556);
            label11.Name = "label11";
            label11.Size = new Size(56, 20);
            label11.TabIndex = 53;
            label11.Text = "JMBG *";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(7, 619);
            label12.Name = "label12";
            label12.Size = new Size(205, 20);
            label12.TabIndex = 54;
            label12.Text = "Broj Zdravstvenog Osiguranja";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(7, 682);
            label13.Name = "label13";
            label13.Size = new Size(191, 20);
            label13.TabIndex = 55;
            label13.Text = "Broj Dopunskog Osiguranja";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(7, 744);
            label14.Name = "label14";
            label14.Size = new Size(42, 20);
            label14.TabIndex = 56;
            label14.Text = "Ulica";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(7, 803);
            label15.Name = "label15";
            label15.Size = new Size(73, 20);
            label15.TabIndex = 57;
            label15.Text = "Broj Ulice";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(7, 865);
            label16.Name = "label16";
            label16.Size = new Size(100, 20);
            label16.TabIndex = 58;
            label16.Text = "Poštanski Broj";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(7, 923);
            label17.Name = "label17";
            label17.Size = new Size(41, 20);
            label17.TabIndex = 59;
            label17.Text = "Grad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(454, 77);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 60;
            label1.Text = "Bračno Stanje";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(454, 133);
            label18.Name = "label18";
            label18.Size = new Size(79, 20);
            label18.TabIndex = 61;
            label18.Text = "Zanimanje";
            // 
            // PatientAddEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 1055);
            Controls.Add(label18);
            Controls.Add(label1);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtGrad);
            Controls.Add(txtBroUl);
            Controls.Add(txtZip);
            Controls.Add(txtUlica);
            Controls.Add(cmbZan);
            Controls.Add(cmbBrak);
            Controls.Add(vScrollBar1);
            Controls.Add(txtBroDoOs);
            Controls.Add(txtBrojZdr);
            Controls.Add(txtJMBG);
            Controls.Add(txtLicna);
            Controls.Add(txtRodStar);
            Controls.Add(txtMjestoRođenja);
            Controls.Add(dtpBirthDate);
            Controls.Add(chkŽensko);
            Controls.Add(chkMuško);
            Controls.Add(txtEmail1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(chkBlackList);
            Controls.Add(chkAllergie);
            Controls.Add(txtPhone);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Name = "PatientAddEdit";
            Text = "PatientDetailForm";
            Load += PatientDetailForm_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtPhone;
        private CheckBox chkAllergie;
        private CheckBox chkBlackList;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtEmail1;
        private CheckBox chkMuško;
        private CheckBox chkŽensko;
        private DateTimePicker dtpBirthDate;
        private TextBox txtMjestoRođenja;
        private TextBox txtRodStar;
        private TextBox txtLicna;
        private TextBox txtJMBG;
        private TextBox txtBrojZdr;
        private TextBox txtBroDoOs;
        private VScrollBar vScrollBar1;
        private ComboBox cmbBrak;
        private ComboBox cmbZan;
        private TextBox txtUlica;
        private TextBox txtZip;
        private TextBox txtBroUl;
        private TextBox txtGrad;
        private ErrorProvider errorProvider1;
        private Label label2;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label18;
        private Label label1;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
    }
}