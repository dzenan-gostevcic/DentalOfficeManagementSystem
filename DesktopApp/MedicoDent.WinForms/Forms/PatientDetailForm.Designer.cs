namespace MedicoDent.WinForms.Forms
{
    partial class PatientDetailForm
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
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(201, 74);
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
            chkAllergie.Location = new Point(568, 81);
            chkAllergie.Name = "chkAllergie";
            chkAllergie.Size = new Size(83, 24);
            chkAllergie.TabIndex = 3;
            chkAllergie.Text = "Alergija";
            chkAllergie.UseVisualStyleBackColor = true;
            // 
            // chkBlackList
            // 
            chkBlackList.AutoSize = true;
            chkBlackList.Location = new Point(567, 150);
            chkBlackList.Name = "chkBlackList";
            chkBlackList.Size = new Size(94, 26);
            chkBlackList.TabIndex = 4;
            chkBlackList.Text = "Crna Lista";
            chkBlackList.UseCompatibleTextRendering = true;
            chkBlackList.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(201, 313);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(447, 313);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 74);
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
            // PatientDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "PatientDetailForm";
            Text = "PatientDetailForm";
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
    }
}