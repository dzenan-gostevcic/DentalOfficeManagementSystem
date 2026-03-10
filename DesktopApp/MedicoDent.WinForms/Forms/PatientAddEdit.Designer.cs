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
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtPhone = new TextBox();
            chkAllergie = new CheckBox();
            chkBlackList = new CheckBox();
            btnSave = new Button();
            btnCancel = new Button();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            txtEmail = new TextBox();
            txtEmail1 = new TextBox();
            txtSpol = new TextBox();
            chkMuško = new CheckBox();
            chkŽensko = new CheckBox();
            textBox2 = new TextBox();
            dtpBirthDate = new DateTimePicker();
            txtMjestoRodj = new TextBox();
            txtMjestoRođenja = new TextBox();
            textBox6 = new TextBox();
            txtRodStar = new TextBox();
            textBox3 = new TextBox();
            txtLicna = new TextBox();
            textBox7 = new TextBox();
            txtJMBG = new TextBox();
            textBox8 = new TextBox();
            txtBrojZdr = new TextBox();
            textBox9 = new TextBox();
            txtBroDoOs = new TextBox();
            vScrollBar1 = new VScrollBar();
            textBox10 = new TextBox();
            cmbBrak = new ComboBox();
            cmbZan = new ComboBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            txtUlica = new TextBox();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            txtZip = new TextBox();
            txtBroUl = new TextBox();
            textBox15 = new TextBox();
            txtGrad = new TextBox();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(201, 75);
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
            // textBox1
            // 
            textBox1.Location = new Point(3, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 7;
            textBox1.Text = "Ime";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(3, 120);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 8;
            textBox4.Text = "Prezime";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(3, 172);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 9;
            textBox5.Text = "Telefon";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(3, 222);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 10;
            txtEmail.Text = "E-Mail";
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEmail1
            // 
            txtEmail1.Location = new Point(201, 222);
            txtEmail1.Name = "txtEmail1";
            txtEmail1.Size = new Size(125, 27);
            txtEmail1.TabIndex = 11;
            // 
            // txtSpol
            // 
            txtSpol.Location = new Point(3, 275);
            txtSpol.Name = "txtSpol";
            txtSpol.Size = new Size(125, 27);
            txtSpol.TabIndex = 12;
            txtSpol.Text = "Spol";
            txtSpol.TextAlign = HorizontalAlignment.Center;
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
            // textBox2
            // 
            textBox2.Location = new Point(3, 328);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 15;
            textBox2.Text = "Datum Rođenja";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(184, 326);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(251, 27);
            dtpBirthDate.TabIndex = 17;
            // 
            // txtMjestoRodj
            // 
            txtMjestoRodj.Location = new Point(3, 383);
            txtMjestoRodj.Name = "txtMjestoRodj";
            txtMjestoRodj.Size = new Size(125, 27);
            txtMjestoRodj.TabIndex = 18;
            txtMjestoRodj.Text = "Mjesto Rođenja";
            txtMjestoRodj.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMjestoRođenja
            // 
            txtMjestoRođenja.Location = new Point(201, 383);
            txtMjestoRođenja.Name = "txtMjestoRođenja";
            txtMjestoRođenja.Size = new Size(125, 27);
            txtMjestoRođenja.TabIndex = 19;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(3, 438);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 20;
            textBox6.Text = "Roditelj/Staratelj";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // txtRodStar
            // 
            txtRodStar.Location = new Point(201, 438);
            txtRodStar.Name = "txtRodStar";
            txtRodStar.Size = new Size(125, 27);
            txtRodStar.TabIndex = 21;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(3, 495);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 22;
            textBox3.Text = "Broj Lične Karte";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLicna
            // 
            txtLicna.Location = new Point(201, 495);
            txtLicna.Name = "txtLicna";
            txtLicna.Size = new Size(125, 27);
            txtLicna.TabIndex = 23;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(3, 556);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 24;
            textBox7.Text = "JMBG";
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // txtJMBG
            // 
            txtJMBG.Location = new Point(201, 556);
            txtJMBG.Name = "txtJMBG";
            txtJMBG.Size = new Size(125, 27);
            txtJMBG.TabIndex = 25;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(3, 619);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(255, 27);
            textBox8.TabIndex = 26;
            textBox8.Text = "Broj Zdravstvenog Osiguranja";
            textBox8.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBrojZdr
            // 
            txtBrojZdr.Location = new Point(310, 619);
            txtBrojZdr.Name = "txtBrojZdr";
            txtBrojZdr.Size = new Size(125, 27);
            txtBrojZdr.TabIndex = 27;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(3, 682);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(255, 27);
            textBox9.TabIndex = 28;
            textBox9.Text = "Broj Dopunskog Osiguranja";
            textBox9.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBroDoOs
            // 
            txtBroDoOs.Location = new Point(310, 682);
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
            // textBox10
            // 
            textBox10.Location = new Point(454, 80);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(125, 27);
            textBox10.TabIndex = 31;
            textBox10.Text = "Bračno Stanje";
            textBox10.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbBrak
            // 
            cmbBrak.FormattingEnabled = true;
            cmbBrak.Location = new Point(615, 80);
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
            // textBox11
            // 
            textBox11.Location = new Point(454, 134);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(125, 27);
            textBox11.TabIndex = 34;
            textBox11.Text = "Zanimanje";
            textBox11.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(3, 744);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(125, 27);
            textBox12.TabIndex = 35;
            textBox12.Text = "Ulica";
            textBox12.TextAlign = HorizontalAlignment.Center;
            // 
            // txtUlica
            // 
            txtUlica.Location = new Point(184, 744);
            txtUlica.Name = "txtUlica";
            txtUlica.Size = new Size(125, 27);
            txtUlica.TabIndex = 36;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(3, 803);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(125, 27);
            textBox13.TabIndex = 37;
            textBox13.Text = "Broj Ulice";
            textBox13.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(3, 865);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(125, 27);
            textBox14.TabIndex = 38;
            textBox14.Text = "Poštanski Broj";
            textBox14.TextAlign = HorizontalAlignment.Center;
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
            // textBox15
            // 
            textBox15.Location = new Point(3, 923);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(125, 27);
            textBox15.TabIndex = 41;
            textBox15.Text = "Grad";
            textBox15.TextAlign = HorizontalAlignment.Center;
            // 
            // txtGrad
            // 
            txtGrad.Location = new Point(184, 923);
            txtGrad.Name = "txtGrad";
            txtGrad.Size = new Size(125, 27);
            txtGrad.TabIndex = 42;
            // 
            // PatientAddEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 1055);
            Controls.Add(txtGrad);
            Controls.Add(textBox15);
            Controls.Add(txtBroUl);
            Controls.Add(txtZip);
            Controls.Add(textBox14);
            Controls.Add(textBox13);
            Controls.Add(txtUlica);
            Controls.Add(textBox12);
            Controls.Add(textBox11);
            Controls.Add(cmbZan);
            Controls.Add(cmbBrak);
            Controls.Add(textBox10);
            Controls.Add(vScrollBar1);
            Controls.Add(txtBroDoOs);
            Controls.Add(textBox9);
            Controls.Add(txtBrojZdr);
            Controls.Add(textBox8);
            Controls.Add(txtJMBG);
            Controls.Add(textBox7);
            Controls.Add(txtLicna);
            Controls.Add(textBox3);
            Controls.Add(txtRodStar);
            Controls.Add(textBox6);
            Controls.Add(txtMjestoRođenja);
            Controls.Add(txtMjestoRodj);
            Controls.Add(dtpBirthDate);
            Controls.Add(textBox2);
            Controls.Add(chkŽensko);
            Controls.Add(chkMuško);
            Controls.Add(txtSpol);
            Controls.Add(txtEmail1);
            Controls.Add(txtEmail);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox txtEmail;
        private TextBox txtEmail1;
        private TextBox txtSpol;
        private CheckBox chkMuško;
        private CheckBox chkŽensko;
        private TextBox textBox2;
        private DateTimePicker dtpBirthDate;
        private TextBox txtMjestoRodj;
        private TextBox txtMjestoRođenja;
        private TextBox textBox6;
        private TextBox txtRodStar;
        private TextBox textBox3;
        private TextBox txtLicna;
        private TextBox textBox7;
        private TextBox txtJMBG;
        private TextBox textBox8;
        private TextBox txtBrojZdr;
        private TextBox textBox9;
        private TextBox txtBroDoOs;
        private VScrollBar vScrollBar1;
        private TextBox textBox10;
        private ComboBox cmbBrak;
        private ComboBox cmbZan;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox txtUlica;
        private TextBox textBox13;
        private TextBox textBox14;
        private TextBox txtZip;
        private TextBox txtBroUl;
        private TextBox textBox15;
        private TextBox txtGrad;
    }
}