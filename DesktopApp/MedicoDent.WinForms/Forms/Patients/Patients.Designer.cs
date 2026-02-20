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
            ColPhone = new DataGridViewTextBoxColumn();
            button3 = new Button();
            btnDelete = new Button();
            button5 = new Button();
            button6 = new Button();
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
            dgvPatients.Columns.AddRange(new DataGridViewColumn[] { colID, ColFullName, ColPhone });
            dgvPatients.Location = new Point(212, 120);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.RowHeadersWidth = 51;
            dgvPatients.Size = new Size(457, 188);
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
            colID.Width = 125;
            // 
            // ColFullName
            // 
            ColFullName.DataPropertyName = "FullName";
            ColFullName.HeaderText = "Full Name";
            ColFullName.MinimumWidth = 6;
            ColFullName.Name = "ColFullName";
            ColFullName.Width = 200;
            // 
            // ColPhone
            // 
            ColPhone.DataPropertyName = "Phone";
            ColPhone.HeaderText = "Full Name";
            ColPhone.MinimumWidth = 6;
            ColPhone.Name = "ColPhone";
            ColPhone.Width = 150;
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
            btnDelete.Location = new Point(278, 434);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "bttnDelete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // button5
            // 
            button5.Location = new Point(443, 441);
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
            // Patients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
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
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn ColFullName;
        private DataGridViewTextBoxColumn ColPhone;
    }
}