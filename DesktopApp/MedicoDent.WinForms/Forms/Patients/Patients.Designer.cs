namespace MedicoDent.WinForms.Forms.Patients
{
    partial class Patients
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
            txtSearch = new TextBox();
            btnSearch = new Button();
            button2 = new Button();
            dgvPatients = new DataGridView();
            bttnadd = new Button();
            btnDelete = new Button();
            button5 = new Button();
            button6 = new Button();
            cmbPages = new ComboBox();
            txtPageNumber = new TextBox();
            bttnNext = new Button();
            bttnPrevious = new Button();
            colID = new DataGridViewTextBoxColumn();
            ColFullName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            ColPhone = new DataGridViewTextBoxColumn();
            BirthDate = new DataGridViewTextBoxColumn();
            Blacklist = new DataGridViewCheckBoxColumn();
            Allergy = new DataGridViewCheckBoxColumn();
            CreatedDate = new DataGridViewTextBoxColumn();
            DateModified = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.LawnGreen;
            txtSearch.Location = new Point(454, 397);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Filter";
            txtSearch.Size = new Size(74, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextAlign = HorizontalAlignment.Center;
            txtSearch.TextChanged += textBox1_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.AccessibleName = "btnSearch";
            btnSearch.Location = new Point(326, 395);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Pretraži";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // button2
            // 
            button2.Location = new Point(555, 397);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Očisti";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnClear;
            // 
            // dgvPatients
            // 
            dgvPatients.AccessibleName = "dgvPatients";
            dgvPatients.BackgroundColor = SystemColors.Window;
            dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatients.Columns.AddRange(new DataGridViewColumn[] { colID, ColFullName, LastName, ColPhone, BirthDate, Blacklist, Allergy, CreatedDate, DateModified, Email });
            dgvPatients.GridColor = SystemColors.Desktop;
            dgvPatients.Location = new Point(12, 2);
            dgvPatients.Margin = new Padding(3, 4, 3, 4);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.RowHeadersWidth = 51;
            dgvPatients.Size = new Size(1164, 369);
            dgvPatients.TabIndex = 3;
            dgvPatients.CellContentClick += dataGridView1_CellContentClick;
            dgvPatients.CellDoubleClick += dataGridViewPatients_CellDoubleClick;
            // 
            // bttnadd
            // 
            bttnadd.Location = new Point(24, 436);
            bttnadd.Margin = new Padding(3, 4, 3, 4);
            bttnadd.Name = "bttnadd";
            bttnadd.Size = new Size(94, 29);
            bttnadd.TabIndex = 4;
            bttnadd.Text = "Dodaj";
            bttnadd.UseVisualStyleBackColor = true;
            bttnadd.Click += btnAdd;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(24, 559);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Izbriši";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // button5
            // 
            button5.Location = new Point(24, 499);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 6;
            button5.Text = "Izmjeni";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnEdit;
            // 
            // button6
            // 
            button6.Location = new Point(454, 499);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(74, 39);
            button6.TabIndex = 7;
            button6.Text = "Osvježi";
            button6.UseVisualStyleBackColor = true;
            button6.Click += btnRefresh;
            // 
            // cmbPages
            // 
            cmbPages.AccessibleName = "cmbPages";
            cmbPages.AllowDrop = true;
            cmbPages.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPages.FormattingEnabled = true;
            cmbPages.Location = new Point(555, 446);
            cmbPages.Margin = new Padding(3, 4, 3, 4);
            cmbPages.MaxDropDownItems = 4;
            cmbPages.Name = "cmbPages";
            cmbPages.Size = new Size(41, 28);
            cmbPages.TabIndex = 8;
            cmbPages.SelectedIndexChanged += PageNumber_SelectedIndexChanged;
            // 
            // txtPageNumber
            // 
            txtPageNumber.Location = new Point(459, 447);
            txtPageNumber.Margin = new Padding(3, 4, 3, 4);
            txtPageNumber.Name = "txtPageNumber";
            txtPageNumber.ReadOnly = true;
            txtPageNumber.Size = new Size(69, 27);
            txtPageNumber.TabIndex = 9;
            txtPageNumber.Text = "Stranica";
            txtPageNumber.TextChanged += txtPageNumber_TextChanged;
            // 
            // bttnNext
            // 
            bttnNext.Location = new Point(615, 439);
            bttnNext.Margin = new Padding(3, 4, 3, 4);
            bttnNext.Name = "bttnNext";
            bttnNext.Size = new Size(59, 43);
            bttnNext.TabIndex = 10;
            bttnNext.Text = ">>";
            bttnNext.UseVisualStyleBackColor = true;
            bttnNext.Click += bttnNext_Click;
            // 
            // bttnPrevious
            // 
            bttnPrevious.Location = new Point(378, 440);
            bttnPrevious.Margin = new Padding(3, 4, 3, 4);
            bttnPrevious.Name = "bttnPrevious";
            bttnPrevious.Size = new Size(55, 40);
            bttnPrevious.TabIndex = 11;
            bttnPrevious.Text = "<<";
            bttnPrevious.UseVisualStyleBackColor = true;
            bttnPrevious.Click += bttnPrevious_Click;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.Visible = false;
            colID.Width = 50;
            // 
            // ColFullName
            // 
            ColFullName.DataPropertyName = "FirstName";
            ColFullName.HeaderText = "Ime";
            ColFullName.MinimumWidth = 6;
            ColFullName.Name = "ColFullName";
            ColFullName.Width = 150;
            // 
            // LastName
            // 
            LastName.DataPropertyName = "LastName";
            LastName.HeaderText = "Prezime";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            LastName.Width = 150;
            // 
            // ColPhone
            // 
            ColPhone.DataPropertyName = "Phone";
            ColPhone.HeaderText = "Telefon";
            ColPhone.MinimumWidth = 6;
            ColPhone.Name = "ColPhone";
            ColPhone.Width = 120;
            // 
            // BirthDate
            // 
            BirthDate.DataPropertyName = "BirthDate";
            BirthDate.HeaderText = "Datum Rođenja";
            BirthDate.MinimumWidth = 6;
            BirthDate.Name = "BirthDate";
            BirthDate.ReadOnly = true;
            BirthDate.Width = 125;
            // 
            // Blacklist
            // 
            Blacklist.DataPropertyName = "IsBlackListed=\"IsBlackListed\"";
            Blacklist.HeaderText = "Crna Lista";
            Blacklist.MinimumWidth = 6;
            Blacklist.Name = "Blacklist";
            Blacklist.Width = 80;
            // 
            // Allergy
            // 
            Allergy.DataPropertyName = "HasAllergie=\"HasAllergie\"";
            Allergy.HeaderText = "Alergija";
            Allergy.MinimumWidth = 6;
            Allergy.Name = "Allergy";
            Allergy.Width = 80;
            // 
            // CreatedDate
            // 
            CreatedDate.DataPropertyName = "CreatedDate";
            CreatedDate.HeaderText = "Date-Created";
            CreatedDate.MinimumWidth = 6;
            CreatedDate.Name = "CreatedDate";
            CreatedDate.Width = 120;
            // 
            // DateModified
            // 
            DateModified.DataPropertyName = "ModifiedDate";
            DateModified.HeaderText = "Date-Modified";
            DateModified.MinimumWidth = 6;
            DateModified.Name = "DateModified";
            DateModified.Width = 120;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "E-Mail";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // Patients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 600);
            Controls.Add(bttnPrevious);
            Controls.Add(bttnNext);
            Controls.Add(txtPageNumber);
            Controls.Add(cmbPages);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(btnDelete);
            Controls.Add(bttnadd);
            Controls.Add(dgvPatients);
            Controls.Add(button2);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Patients";
            Text = "Patients";
            Load += Patients_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Button btnSearch;
        private Button button2;
        private DataGridView dgvPatients;
        private Button bttnadd;
        private Button btnDelete;
        private Button button5;
        private Button button6;
        private ComboBox cmbPages;
        private TextBox txtPageNumber;
        private Button bttnNext;
        private Button bttnPrevious;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn ColFullName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn ColPhone;
        private DataGridViewTextBoxColumn BirthDate;
        private DataGridViewCheckBoxColumn Blacklist;
        private DataGridViewCheckBoxColumn Allergy;
        private DataGridViewTextBoxColumn CreatedDate;
        private DataGridViewTextBoxColumn DateModified;
        private DataGridViewTextBoxColumn Email;
    }
}