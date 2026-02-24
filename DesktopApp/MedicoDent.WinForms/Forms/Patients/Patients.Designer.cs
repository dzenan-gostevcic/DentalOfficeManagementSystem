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
            colID = new DataGridViewTextBoxColumn();
            ColFullName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            ColPhone = new DataGridViewTextBoxColumn();
            Blacklist = new DataGridViewCheckBoxColumn();
            Allergy = new DataGridViewCheckBoxColumn();
            CreatedDate = new DataGridViewTextBoxColumn();
            DateModified = new DataGridViewTextBoxColumn();
            button3 = new Button();
            btnDelete = new Button();
            button5 = new Button();
            button6 = new Button();
            comboBox1 = new ComboBox();
            txtPageNumber = new TextBox();
            bttnNext = new Button();
            bttnPrevious = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.LawnGreen;
            txtSearch.Location = new Point(571, 23);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 27);
            txtSearch.TabIndex = 0;
            txtSearch.Text = "Search";
            txtSearch.TextAlign = HorizontalAlignment.Center;
            txtSearch.TextChanged += textBox1_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.AccessibleName = "btnSearch";
            btnSearch.Location = new Point(722, 21);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "bttnSearch";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // button2
            // 
            button2.Location = new Point(822, 23);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "bttnClear";
            button2.UseVisualStyleBackColor = true;
            // 
            // dgvPatients
            // 
            dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatients.Columns.AddRange(new DataGridViewColumn[] { colID, ColFullName, LastName, ColPhone, Blacklist, Allergy, CreatedDate, DateModified });
            dgvPatients.Location = new Point(49, 120);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.RowHeadersWidth = 51;
            dgvPatients.Size = new Size(818, 278);
            dgvPatients.TabIndex = 3;
            dgvPatients.CellContentClick += dataGridView1_CellContentClick;
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
            ColFullName.DataPropertyName = "PatientBasicInfoFirstName.FirstName";
            ColFullName.HeaderText = "First Name";
            ColFullName.MinimumWidth = 6;
            ColFullName.Name = "ColFullName";
            ColFullName.Width = 150;
            // 
            // LastName
            // 
            LastName.DataPropertyName = "PatientBasicInfo.LastName";
            LastName.HeaderText = "Last Name";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            LastName.Width = 150;
            // 
            // ColPhone
            // 
            ColPhone.DataPropertyName = "PatientBasicInfo.PhoneNumber";
            ColPhone.HeaderText = "Phone";
            ColPhone.MinimumWidth = 6;
            ColPhone.Name = "ColPhone";
            ColPhone.Width = 120;
            // 
            // Blacklist
            // 
            Blacklist.DataPropertyName = "IsOnBlackList = \"IsOnBlackList\"";
            Blacklist.HeaderText = "Blacklist";
            Blacklist.MinimumWidth = 6;
            Blacklist.Name = "Blacklist";
            Blacklist.Width = 80;
            // 
            // Allergy
            // 
            Allergy.DataPropertyName = "HasAllergie=\"HasAllergie\"";
            Allergy.HeaderText = "Allergy";
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
            // button3
            // 
            button3.Location = new Point(135, 426);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "bttnAdd";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(270, 475);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "bttnDelete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // button5
            // 
            button5.Location = new Point(486, 475);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 6;
            button5.Text = "bttnEdit";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(644, 447);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 7;
            button6.Text = "bttnRefresh";
            button6.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(386, 404);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 8;
            // 
            // txtPageNumber
            // 
            txtPageNumber.Location = new Point(326, 404);
            txtPageNumber.Name = "txtPageNumber";
            txtPageNumber.ReadOnly = true;
            txtPageNumber.Size = new Size(38, 27);
            txtPageNumber.TabIndex = 9;
            txtPageNumber.Text = "Page Number";
            // 
            // bttnNext
            // 
            bttnNext.Location = new Point(585, 416);
            bttnNext.Name = "bttnNext";
            bttnNext.Size = new Size(94, 29);
            bttnNext.TabIndex = 10;
            bttnNext.Text = "Next >>";
            bttnNext.UseVisualStyleBackColor = true;
            bttnNext.Click += bttnNext_Click;
            // 
            // bttnPrevious
            // 
            bttnPrevious.Location = new Point(773, 416);
            bttnPrevious.Name = "bttnPrevious";
            bttnPrevious.Size = new Size(94, 29);
            bttnPrevious.TabIndex = 11;
            bttnPrevious.Text = "<< Previous";
            bttnPrevious.UseVisualStyleBackColor = true;
            bttnPrevious.Click += bttnPrevious_Click;
            // 
            // Patients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(bttnPrevious);
            Controls.Add(bttnNext);
            Controls.Add(txtPageNumber);
            Controls.Add(comboBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(btnDelete);
            Controls.Add(button3);
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
        private Button button3;
        private Button btnDelete;
        private Button button5;
        private Button button6;
        private ComboBox comboBox1;
        private TextBox txtPageNumber;
        private Button bttnNext;
        private Button bttnPrevious;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn ColFullName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn ColPhone;
        private DataGridViewCheckBoxColumn Blacklist;
        private DataGridViewCheckBoxColumn Allergy;
        private DataGridViewTextBoxColumn CreatedDate;
        private DataGridViewTextBoxColumn DateModified;
    }
}