namespace MedicoDent.WinForms.Forms.Patients
{
    partial class PatientDetailForms
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
            tabMain = new TabControl();
            tabPage1 = new TabPage();
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            txtAdditionalHealthInsuranceNumber = new TextBox();
            txtHealthInsuranceNumber = new TextBox();
            brojzdravstvenogosiguranja = new Label();
            txtSocialSecurityNumber = new TextBox();
            jmbg = new Label();
            txtIdCardNumber = new TextBox();
            idcardnum = new Label();
            btnSaveBasicInfo = new Button();
            txtParent = new TextBox();
            txtBirthPlace = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            parent = new Label();
            birthplace = new Label();
            txtBirthDate = new Label();
            chkZensko = new CheckBox();
            chkMusko = new CheckBox();
            txtGender = new Label();
            lastname = new Label();
            firstname = new Label();
            label5 = new Label();
            GroupComboBox = new ComboBox();
            SixMonthCheckupCheckBox = new CheckBox();
            HappyBirthdayEmailCheckBox = new CheckBox();
            reminder = new Label();
            blacklist = new Label();
            BlackListCheckBox = new CheckBox();
            occupationComboBox = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            marriageStatusComboBox = new ComboBox();
            tabPage2 = new TabPage();
            btnSaveContact = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            streetname = new Label();
            txtStreetName = new TextBox();
            streetnumber = new Label();
            txtStreetNumber = new TextBox();
            zipcode = new Label();
            txtZipCode = new TextBox();
            txtCity = new TextBox();
            txtPhoneNumber = new TextBox();
            txtEmail = new TextBox();
            city = new Label();
            phonenumber = new Label();
            email = new Label();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            allergiesGroupBox = new GroupBox();
            selectedAllergieNote = new TextBox();
            allergieDeleteBtn = new Button();
            alergies = new Label();
            button1 = new Button();
            allergiesListBox = new ListBox();
            alarmComboBox = new ComboBox();
            btnActivateAlarm = new Button();
            txtAdditionalNote = new TextBox();
            label4 = new Label();
            tabPage5 = new TabPage();
            tabMain.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabPage4.SuspendLayout();
            allergiesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabPage1);
            tabMain.Controls.Add(tabPage2);
            tabMain.Controls.Add(tabPage3);
            tabMain.Controls.Add(tabPage4);
            tabMain.Controls.Add(tabPage5);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Location = new Point(0, 0);
            tabMain.Margin = new Padding(3, 2, 3, 2);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(868, 386);
            tabMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(860, 358);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Basic Information";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 2);
            splitContainer1.Margin = new Padding(3, 2, 3, 2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(txtAdditionalHealthInsuranceNumber);
            splitContainer1.Panel1.Controls.Add(txtHealthInsuranceNumber);
            splitContainer1.Panel1.Controls.Add(brojzdravstvenogosiguranja);
            splitContainer1.Panel1.Controls.Add(txtSocialSecurityNumber);
            splitContainer1.Panel1.Controls.Add(jmbg);
            splitContainer1.Panel1.Controls.Add(txtIdCardNumber);
            splitContainer1.Panel1.Controls.Add(idcardnum);
            splitContainer1.Panel1.Controls.Add(btnSaveBasicInfo);
            splitContainer1.Panel1.Controls.Add(txtParent);
            splitContainer1.Panel1.Controls.Add(txtBirthPlace);
            splitContainer1.Panel1.Controls.Add(txtLastName);
            splitContainer1.Panel1.Controls.Add(txtFirstName);
            splitContainer1.Panel1.Controls.Add(parent);
            splitContainer1.Panel1.Controls.Add(birthplace);
            splitContainer1.Panel1.Controls.Add(txtBirthDate);
            splitContainer1.Panel1.Controls.Add(chkZensko);
            splitContainer1.Panel1.Controls.Add(chkMusko);
            splitContainer1.Panel1.Controls.Add(txtGender);
            splitContainer1.Panel1.Controls.Add(lastname);
            splitContainer1.Panel1.Controls.Add(firstname);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(GroupComboBox);
            splitContainer1.Panel2.Controls.Add(SixMonthCheckupCheckBox);
            splitContainer1.Panel2.Controls.Add(HappyBirthdayEmailCheckBox);
            splitContainer1.Panel2.Controls.Add(reminder);
            splitContainer1.Panel2.Controls.Add(blacklist);
            splitContainer1.Panel2.Controls.Add(BlackListCheckBox);
            splitContainer1.Panel2.Controls.Add(occupationComboBox);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(marriageStatusComboBox);
            splitContainer1.Size = new Size(854, 354);
            splitContainer1.SplitterDistance = 405;
            splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 230);
            label1.Name = "label1";
            label1.Size = new Size(149, 15);
            label1.TabIndex = 21;
            label1.Text = "Broj dopunskog osiguranja";
            // 
            // txtAdditionalHealthInsuranceNumber
            // 
            txtAdditionalHealthInsuranceNumber.Location = new Point(173, 230);
            txtAdditionalHealthInsuranceNumber.Margin = new Padding(3, 2, 3, 2);
            txtAdditionalHealthInsuranceNumber.Name = "txtAdditionalHealthInsuranceNumber";
            txtAdditionalHealthInsuranceNumber.Size = new Size(139, 23);
            txtAdditionalHealthInsuranceNumber.TabIndex = 20;
            // 
            // txtHealthInsuranceNumber
            // 
            txtHealthInsuranceNumber.Location = new Point(186, 206);
            txtHealthInsuranceNumber.Margin = new Padding(3, 2, 3, 2);
            txtHealthInsuranceNumber.Name = "txtHealthInsuranceNumber";
            txtHealthInsuranceNumber.Size = new Size(126, 23);
            txtHealthInsuranceNumber.TabIndex = 19;
            // 
            // brojzdravstvenogosiguranja
            // 
            brojzdravstvenogosiguranja.AutoSize = true;
            brojzdravstvenogosiguranja.Location = new Point(4, 206);
            brojzdravstvenogosiguranja.Name = "brojzdravstvenogosiguranja";
            brojzdravstvenogosiguranja.Size = new Size(159, 15);
            brojzdravstvenogosiguranja.TabIndex = 18;
            brojzdravstvenogosiguranja.Text = "Broj zdravstvenog osiguranja";
            // 
            // txtSocialSecurityNumber
            // 
            txtSocialSecurityNumber.Location = new Point(50, 183);
            txtSocialSecurityNumber.Margin = new Padding(3, 2, 3, 2);
            txtSocialSecurityNumber.Name = "txtSocialSecurityNumber";
            txtSocialSecurityNumber.Size = new Size(262, 23);
            txtSocialSecurityNumber.TabIndex = 17;
            // 
            // jmbg
            // 
            jmbg.AutoSize = true;
            jmbg.Location = new Point(4, 185);
            jmbg.Name = "jmbg";
            jmbg.Size = new Size(37, 15);
            jmbg.TabIndex = 16;
            jmbg.Text = "JMBG";
            // 
            // txtIdCardNumber
            // 
            txtIdCardNumber.Location = new Point(105, 159);
            txtIdCardNumber.Margin = new Padding(3, 2, 3, 2);
            txtIdCardNumber.Name = "txtIdCardNumber";
            txtIdCardNumber.Size = new Size(207, 23);
            txtIdCardNumber.TabIndex = 15;
            // 
            // idcardnum
            // 
            idcardnum.AutoSize = true;
            idcardnum.Location = new Point(4, 161);
            idcardnum.Name = "idcardnum";
            idcardnum.Size = new Size(85, 15);
            idcardnum.TabIndex = 14;
            idcardnum.Text = "Broj lične karte";
            
            // 
            // btnSaveBasicInfo
            // 
            btnSaveBasicInfo.Location = new Point(4, 285);
            btnSaveBasicInfo.Margin = new Padding(3, 2, 3, 2);
            btnSaveBasicInfo.Name = "btnSaveBasicInfo";
            btnSaveBasicInfo.Size = new Size(82, 22);
            btnSaveBasicInfo.TabIndex = 12;
            btnSaveBasicInfo.Text = "Save";
            btnSaveBasicInfo.UseVisualStyleBackColor = true;
            btnSaveBasicInfo.Click += btnSaveClick;
            // 
            // txtParent
            // 
            txtParent.Location = new Point(116, 133);
            txtParent.Margin = new Padding(3, 2, 3, 2);
            txtParent.Name = "txtParent";
            txtParent.Size = new Size(196, 23);
            txtParent.TabIndex = 11;
            // 
            // txtBirthPlace
            // 
            txtBirthPlace.Location = new Point(105, 106);
            txtBirthPlace.Margin = new Padding(3, 2, 3, 2);
            txtBirthPlace.Name = "txtBirthPlace";
            txtBirthPlace.Size = new Size(207, 23);
            txtBirthPlace.TabIndex = 10;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(64, 31);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(248, 23);
            txtLastName.TabIndex = 9;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(53, 6);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(259, 23);
            txtFirstName.TabIndex = 8;
            // 
            // parent
            // 
            parent.AutoSize = true;
            parent.Location = new Point(4, 135);
            parent.Name = "parent";
            parent.Size = new Size(94, 15);
            parent.TabIndex = 7;
            parent.Text = "Roditelj/Staratelj";
            // 
            // birthplace
            // 
            birthplace.AutoSize = true;
            birthplace.Location = new Point(4, 109);
            birthplace.Name = "birthplace";
            birthplace.Size = new Size(86, 15);
            birthplace.TabIndex = 6;
            birthplace.Text = "Mjesto rođenja";
            // 
            // txtBirthDate
            // 
            txtBirthDate.AutoSize = true;
            txtBirthDate.Location = new Point(4, 82);
            txtBirthDate.Name = "txtBirthDate";
            txtBirthDate.Size = new Size(86, 15);
            txtBirthDate.TabIndex = 5;
            txtBirthDate.Text = "Datum rođenja";
            // 
            // chkZensko
            // 
            chkZensko.AutoSize = true;
            chkZensko.Location = new Point(179, 55);
            chkZensko.Margin = new Padding(3, 2, 3, 2);
            chkZensko.Name = "chkZensko";
            chkZensko.Size = new Size(60, 19);
            chkZensko.TabIndex = 4;
            chkZensko.Text = "Ženski";
            chkZensko.UseVisualStyleBackColor = true;
            // 
            // chkMusko
            // 
            chkMusko.AutoSize = true;
            chkMusko.Location = new Point(66, 54);
            chkMusko.Margin = new Padding(3, 2, 3, 2);
            chkMusko.Name = "chkMusko";
            chkMusko.Size = new Size(58, 19);
            chkMusko.TabIndex = 3;
            chkMusko.Text = "Muški";
            chkMusko.UseVisualStyleBackColor = true;
            // 
            // txtGender
            // 
            txtGender.AutoSize = true;
            txtGender.Location = new Point(4, 55);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(30, 15);
            txtGender.TabIndex = 2;
            txtGender.Text = "Spol";
            // 
            // lastname
            // 
            lastname.AutoSize = true;
            lastname.Location = new Point(4, 31);
            lastname.Name = "lastname";
            lastname.Size = new Size(49, 15);
            lastname.TabIndex = 1;
            lastname.Text = "Prezime";
            // 
            // firstname
            // 
            firstname.AutoSize = true;
            firstname.Location = new Point(4, 8);
            firstname.Name = "firstname";
            firstname.Size = new Size(27, 15);
            firstname.TabIndex = 0;
            firstname.Text = "Ime";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 58);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 23;
            label5.Text = "Group";
            // 
            // GroupComboBox
            // 
            GroupComboBox.FormattingEnabled = true;
            GroupComboBox.Location = new Point(102, 56);
            GroupComboBox.Margin = new Padding(3, 2, 3, 2);
            GroupComboBox.Name = "GroupComboBox";
            GroupComboBox.Size = new Size(133, 23);
            GroupComboBox.TabIndex = 22;
            GroupComboBox.SelectedIndexChanged += GroupComboBox_SelectedIndexChanged;
            // 
            // SixMonthCheckupCheckBox
            // 
            SixMonthCheckupCheckBox.AutoSize = true;
            SixMonthCheckupCheckBox.Location = new Point(283, 152);
            SixMonthCheckupCheckBox.Margin = new Padding(3, 2, 3, 2);
            SixMonthCheckupCheckBox.Name = "SixMonthCheckupCheckBox";
            SixMonthCheckupCheckBox.Size = new Size(124, 19);
            SixMonthCheckupCheckBox.TabIndex = 21;
            SixMonthCheckupCheckBox.Text = "6 months checkup";
            SixMonthCheckupCheckBox.UseVisualStyleBackColor = true;
            // 
            // HappyBirthdayEmailCheckBox
            // 
            HappyBirthdayEmailCheckBox.AutoSize = true;
            HappyBirthdayEmailCheckBox.Location = new Point(102, 152);
            HappyBirthdayEmailCheckBox.Margin = new Padding(3, 2, 3, 2);
            HappyBirthdayEmailCheckBox.Name = "HappyBirthdayEmailCheckBox";
            HappyBirthdayEmailCheckBox.Size = new Size(161, 19);
            HappyBirthdayEmailCheckBox.TabIndex = 20;
            HappyBirthdayEmailCheckBox.Text = "E-mail for happy birthday";
            HappyBirthdayEmailCheckBox.UseVisualStyleBackColor = true;
            // 
            // reminder
            // 
            reminder.AutoSize = true;
            reminder.Location = new Point(10, 152);
            reminder.Name = "reminder";
            reminder.Size = new Size(63, 15);
            reminder.TabIndex = 19;
            reminder.Text = "Reminders";
            // 
            // blacklist
            // 
            blacklist.AutoSize = true;
            blacklist.Location = new Point(10, 110);
            blacklist.Name = "blacklist";
            blacklist.Size = new Size(56, 15);
            blacklist.TabIndex = 18;
            blacklist.Text = "Black List";
            // 
            // BlackListCheckBox
            // 
            BlackListCheckBox.AutoSize = true;
            BlackListCheckBox.Location = new Point(102, 109);
            BlackListCheckBox.Margin = new Padding(3, 2, 3, 2);
            BlackListCheckBox.Name = "BlackListCheckBox";
            BlackListCheckBox.Size = new Size(194, 19);
            BlackListCheckBox.TabIndex = 17;
            BlackListCheckBox.Text = "Add the patient to the Black List";
            BlackListCheckBox.UseVisualStyleBackColor = true;
            // 
            // occupationComboBox
            // 
            occupationComboBox.FormattingEnabled = true;
            occupationComboBox.Location = new Point(102, 30);
            occupationComboBox.Margin = new Padding(3, 2, 3, 2);
            occupationComboBox.Name = "occupationComboBox";
            occupationComboBox.Size = new Size(133, 23);
            occupationComboBox.TabIndex = 16;
            occupationComboBox.SelectedValueChanged += occupationComboBox_SelectedValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 31);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 15;
            label3.Text = "Zanimanje";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 6);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 14;
            label2.Text = "Bračno stanje";
            // 
            // marriageStatusComboBox
            // 
            marriageStatusComboBox.FormattingEnabled = true;
            marriageStatusComboBox.Location = new Point(102, 4);
            marriageStatusComboBox.Margin = new Padding(3, 2, 3, 2);
            marriageStatusComboBox.Name = "marriageStatusComboBox";
            marriageStatusComboBox.Size = new Size(133, 23);
            marriageStatusComboBox.TabIndex = 13;
            marriageStatusComboBox.SelectedValueChanged += marriageStatusComboBox_SelectedValueChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnSaveContact);
            tabPage2.Controls.Add(tableLayoutPanel1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(860, 358);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Contact";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSaveContact
            // 
            btnSaveContact.Location = new Point(20, 110);
            btnSaveContact.Margin = new Padding(3, 2, 3, 2);
            btnSaveContact.Name = "btnSaveContact";
            btnSaveContact.Size = new Size(82, 22);
            btnSaveContact.TabIndex = 1;
            btnSaveContact.Text = "Save";
            btnSaveContact.UseVisualStyleBackColor = true;
            btnSaveContact.Click += btnSaveClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(streetname, 0, 0);
            tableLayoutPanel1.Controls.Add(txtStreetName, 1, 0);
            tableLayoutPanel1.Controls.Add(streetnumber, 0, 1);
            tableLayoutPanel1.Controls.Add(txtStreetNumber, 1, 1);
            tableLayoutPanel1.Controls.Add(zipcode, 0, 2);
            tableLayoutPanel1.Controls.Add(txtZipCode, 1, 2);
            tableLayoutPanel1.Controls.Add(txtCity, 1, 3);
            tableLayoutPanel1.Controls.Add(txtPhoneNumber, 1, 4);
            tableLayoutPanel1.Controls.Add(txtEmail, 1, 5);
            tableLayoutPanel1.Controls.Add(city, 0, 3);
            tableLayoutPanel1.Controls.Add(phonenumber, 0, 4);
            tableLayoutPanel1.Controls.Add(email, 0, 5);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 2);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.Size = new Size(854, 94);
            tableLayoutPanel1.TabIndex = 0;
            
            // 
            // streetname
            // 
            streetname.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            streetname.AutoSize = true;
            streetname.Location = new Point(22, 2);
            streetname.Name = "streetname";
            streetname.Size = new Size(72, 15);
            streetname.TabIndex = 0;
            streetname.Text = "Street Name";
            streetname.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtStreetName
            // 
            txtStreetName.Dock = DockStyle.Fill;
            txtStreetName.Location = new Point(100, 2);
            txtStreetName.Margin = new Padding(3, 0, 3, 2);
            txtStreetName.Name = "txtStreetName";
            txtStreetName.Size = new Size(764, 23);
            txtStreetName.TabIndex = 1;
            // 
            // streetnumber
            // 
            streetnumber.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            streetnumber.AutoSize = true;
            streetnumber.Location = new Point(10, 17);
            streetnumber.Name = "streetnumber";
            streetnumber.Size = new Size(84, 15);
            streetnumber.TabIndex = 2;
            streetnumber.Text = "Street Number";
            streetnumber.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtStreetNumber
            // 
            txtStreetNumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtStreetNumber.Location = new Point(100, 17);
            txtStreetNumber.Margin = new Padding(3, 0, 3, 2);
            txtStreetNumber.Name = "txtStreetNumber";
            txtStreetNumber.Size = new Size(764, 23);
            txtStreetNumber.TabIndex = 3;
            // 
            // zipcode
            // 
            zipcode.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            zipcode.AutoSize = true;
            zipcode.Location = new Point(39, 32);
            zipcode.Name = "zipcode";
            zipcode.Size = new Size(55, 15);
            zipcode.TabIndex = 4;
            zipcode.Text = "Zip Code";
            zipcode.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtZipCode
            // 
            txtZipCode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtZipCode.Location = new Point(100, 32);
            txtZipCode.Margin = new Padding(3, 0, 3, 2);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(764, 23);
            txtZipCode.TabIndex = 5;
            // 
            // txtCity
            // 
            txtCity.Dock = DockStyle.Fill;
            txtCity.Location = new Point(100, 47);
            txtCity.Margin = new Padding(3, 0, 3, 2);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(764, 23);
            txtCity.TabIndex = 6;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPhoneNumber.Location = new Point(100, 62);
            txtPhoneNumber.Margin = new Padding(3, 0, 3, 2);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(764, 23);
            txtPhoneNumber.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(100, 79);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(764, 23);
            txtEmail.TabIndex = 8;
            // 
            // city
            // 
            city.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            city.AutoSize = true;
            city.Location = new Point(66, 47);
            city.Name = "city";
            city.Size = new Size(28, 15);
            city.TabIndex = 9;
            city.Text = "City";
            city.TextAlign = ContentAlignment.MiddleRight;
            // 
            // phonenumber
            // 
            phonenumber.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            phonenumber.AutoSize = true;
            phonenumber.Location = new Point(6, 62);
            phonenumber.Name = "phonenumber";
            phonenumber.Size = new Size(88, 15);
            phonenumber.TabIndex = 10;
            phonenumber.Text = "Phone Number";
            phonenumber.TextAlign = ContentAlignment.MiddleRight;
            // 
            // email
            // 
            email.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            email.AutoSize = true;
            email.Location = new Point(58, 77);
            email.Name = "email";
            email.Size = new Size(36, 15);
            email.TabIndex = 11;
            email.Text = "Email";
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 2, 3, 2);
            tabPage3.Size = new Size(860, 358);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Treatments";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(allergiesGroupBox);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Margin = new Padding(3, 2, 3, 2);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 2, 3, 2);
            tabPage4.Size = new Size(860, 358);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Alarms";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // allergiesGroupBox
            // 
            allergiesGroupBox.Controls.Add(selectedAllergieNote);
            allergiesGroupBox.Controls.Add(allergieDeleteBtn);
            allergiesGroupBox.Controls.Add(alergies);
            allergiesGroupBox.Controls.Add(button1);
            allergiesGroupBox.Controls.Add(allergiesListBox);
            allergiesGroupBox.Controls.Add(alarmComboBox);
            allergiesGroupBox.Controls.Add(btnActivateAlarm);
            allergiesGroupBox.Controls.Add(txtAdditionalNote);
            allergiesGroupBox.Controls.Add(label4);
            allergiesGroupBox.Location = new Point(18, 15);
            allergiesGroupBox.Name = "allergiesGroupBox";
            allergiesGroupBox.Size = new Size(821, 325);
            allergiesGroupBox.TabIndex = 8;
            allergiesGroupBox.TabStop = false;
            allergiesGroupBox.Text = "Alergije pacijenta";
            // 
            // selectedAllergieNote
            // 
            selectedAllergieNote.Location = new Point(462, 122);
            selectedAllergieNote.Multiline = true;
            selectedAllergieNote.Name = "selectedAllergieNote";
            selectedAllergieNote.ReadOnly = true;
            selectedAllergieNote.ScrollBars = ScrollBars.Vertical;
            selectedAllergieNote.Size = new Size(312, 109);
            selectedAllergieNote.TabIndex = 9;
            // 
            // allergieDeleteBtn
            // 
            allergieDeleteBtn.Location = new Point(462, 237);
            allergieDeleteBtn.Name = "allergieDeleteBtn";
            allergieDeleteBtn.Size = new Size(169, 23);
            allergieDeleteBtn.TabIndex = 8;
            allergieDeleteBtn.Text = "Izbriši odabranu alergiju";
            allergieDeleteBtn.UseVisualStyleBackColor = true;
            allergieDeleteBtn.Click += btnRemoveAllergy_Click;
            // 
            // alergies
            // 
            alergies.AutoSize = true;
            alergies.Location = new Point(16, 26);
            alergies.Name = "alergies";
            alergies.Size = new Size(47, 15);
            alergies.TabIndex = 0;
            alergies.Text = "Alergije";
            // 
            // button1
            // 
            button1.Location = new Point(16, 278);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 5;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnSaveClick;
            // 
            // allergiesListBox
            // 
            allergiesListBox.DisplayMember = "Name";
            allergiesListBox.Font = new Font("Segoe UI", 10F);
            allergiesListBox.FormattingEnabled = true;
            allergiesListBox.IntegralHeight = false;
            allergiesListBox.ItemHeight = 17;
            allergiesListBox.Location = new Point(462, 22);
            allergiesListBox.Name = "allergiesListBox";
            allergiesListBox.Size = new Size(120, 94);
            allergiesListBox.TabIndex = 7;
            allergiesListBox.SelectedIndexChanged += allergiesListBox_SelectedIndexChanged;
            // 
            // alarmComboBox
            // 
            alarmComboBox.FormattingEnabled = true;
            alarmComboBox.Location = new Point(75, 24);
            alarmComboBox.Margin = new Padding(3, 2, 3, 2);
            alarmComboBox.Name = "alarmComboBox";
            alarmComboBox.Size = new Size(133, 23);
            alarmComboBox.TabIndex = 1;
           
            // 
            // btnActivateAlarm
            // 
            btnActivateAlarm.Location = new Point(224, 18);
            btnActivateAlarm.Margin = new Padding(3, 2, 3, 2);
            btnActivateAlarm.Name = "btnActivateAlarm";
            btnActivateAlarm.Size = new Size(99, 29);
            btnActivateAlarm.TabIndex = 2;
            btnActivateAlarm.Text = "Aktiviraj alarm";
            btnActivateAlarm.UseVisualStyleBackColor = true;
            btnActivateAlarm.Click += btnAddAllergy_Click;
            // 
            // txtAdditionalNote
            // 
            txtAdditionalNote.Location = new Point(16, 122);
            txtAdditionalNote.Margin = new Padding(3, 2, 3, 2);
            txtAdditionalNote.Multiline = true;
            txtAdditionalNote.Name = "txtAdditionalNote";
            txtAdditionalNote.Size = new Size(307, 109);
            txtAdditionalNote.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 105);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 3;
            label4.Text = "Napomena";
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 24);
            tabPage5.Margin = new Padding(3, 2, 3, 2);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3, 2, 3, 2);
            tabPage5.Size = new Size(860, 358);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Corresponding";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // PatientDetailForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 386);
            Controls.Add(tabMain);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PatientDetailForms";
            Text = "PatientDetailForms";
            tabMain.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tabPage4.ResumeLayout(false);
            allergiesGroupBox.ResumeLayout(false);
            allergiesGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabMain;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TableLayoutPanel tableLayoutPanel1;
        private Label streetname;
        private TextBox txtStreetName;
        private Label streetnumber;
        private TextBox txtStreetNumber;
        private Label zipcode;
        private TextBox txtZipCode;
        private TextBox txtCity;
        private TextBox txtPhoneNumber;
        private TextBox txtEmail;
        private Label city;
        private Label phonenumber;
        private Label email;
        private Button btnSaveContact;
        private SplitContainer splitContainer1;
        private Label txtBirthDate;
        private CheckBox chkZensko;
        private CheckBox chkMusko;
        private Label txtGender;
        private Label lastname;
        private Label firstname;
        private Label parent;
        private Label birthplace;
        private TextBox txtParent;
        private TextBox txtBirthPlace;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Button btnSaveBasicInfo;
        private ComboBox marriageStatusComboBox;
        private Label idcardnum;
        private TextBox txtIdCardNumber;
        private TextBox txtSocialSecurityNumber;
        private Label jmbg;
        private Label label1;
        private TextBox txtAdditionalHealthInsuranceNumber;
        private TextBox txtHealthInsuranceNumber;
        private Label brojzdravstvenogosiguranja;
        private ComboBox occupationComboBox;
        private Label label3;
        private Label label2;
        private Label alergies;
        private ComboBox alarmComboBox;
        private TextBox txtAdditionalNote;
        private Label label4;
        private Button btnActivateAlarm;
        private Label blacklist;
        private CheckBox BlackListCheckBox;
        private CheckBox SixMonthCheckupCheckBox;
        private CheckBox HappyBirthdayEmailCheckBox;
        private Label reminder;
        private Label label5;
        private ComboBox GroupComboBox;
        private Button button1;
        private ListBox allergiesListBox;
        private GroupBox allergiesGroupBox;
        private Button allergieDeleteBtn;
        private TextBox selectedAllergieNote;
    }
}