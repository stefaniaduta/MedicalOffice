namespace MedicalOffice
{
    partial class PatientsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PatID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PatName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PatAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PatPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PatAge = new System.Windows.Forms.TextBox();
            this.PatGender = new System.Windows.Forms.ComboBox();
            this.PatBlood = new System.Windows.Forms.ComboBox();
            this.PatDisease = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Pat_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pat_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pat_A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatAg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PBT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientDisease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 103);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(28, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 53);
            this.label2.TabIndex = 2;
            this.label2.Text = "Patients";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(883, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Medical Office";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(32, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID :";
            // 
            // PatID
            // 
            this.PatID.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatID.Location = new System.Drawing.Point(125, 133);
            this.PatID.Name = "PatID";
            this.PatID.Size = new System.Drawing.Size(244, 33);
            this.PatID.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(32, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name :";
            // 
            // PatName
            // 
            this.PatName.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatName.Location = new System.Drawing.Point(125, 193);
            this.PatName.Name = "PatName";
            this.PatName.Size = new System.Drawing.Size(244, 33);
            this.PatName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(32, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Adress :";
            // 
            // PatAddress
            // 
            this.PatAddress.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatAddress.Location = new System.Drawing.Point(125, 245);
            this.PatAddress.Name = "PatAddress";
            this.PatAddress.Size = new System.Drawing.Size(244, 33);
            this.PatAddress.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(32, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "Phone :";
            // 
            // PatPhone
            // 
            this.PatPhone.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatPhone.Location = new System.Drawing.Point(125, 295);
            this.PatPhone.Name = "PatPhone";
            this.PatPhone.Size = new System.Drawing.Size(244, 33);
            this.PatPhone.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(32, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Age :";
            // 
            // PatAge
            // 
            this.PatAge.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatAge.Location = new System.Drawing.Point(125, 348);
            this.PatAge.Name = "PatAge";
            this.PatAge.Size = new System.Drawing.Size(60, 33);
            this.PatAge.TabIndex = 16;
            // 
            // PatGender
            // 
            this.PatGender.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.PatGender.FormattingEnabled = true;
            this.PatGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.PatGender.Location = new System.Drawing.Point(37, 399);
            this.PatGender.Name = "PatGender";
            this.PatGender.Size = new System.Drawing.Size(148, 33);
            this.PatGender.TabIndex = 17;
            this.PatGender.Text = "Gender";
            // 
            // PatBlood
            // 
            this.PatBlood.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.PatBlood.FormattingEnabled = true;
            this.PatBlood.Items.AddRange(new object[] {
            "O -",
            "O + ",
            "A - ",
            "A +",
            "B -",
            "B +",
            "AB -",
            "AB +"});
            this.PatBlood.Location = new System.Drawing.Point(213, 399);
            this.PatBlood.Name = "PatBlood";
            this.PatBlood.Size = new System.Drawing.Size(156, 33);
            this.PatBlood.TabIndex = 18;
            this.PatBlood.Text = "Blood Type";
            // 
            // PatDisease
            // 
            this.PatDisease.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatDisease.Location = new System.Drawing.Point(125, 451);
            this.PatDisease.Name = "PatDisease";
            this.PatDisease.Size = new System.Drawing.Size(244, 33);
            this.PatDisease.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(32, 454);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 26);
            this.label8.TabIndex = 20;
            this.label8.Text = "Disease :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pat_ID,
            this.Pat_Name,
            this.Pat_A,
            this.PatP,
            this.PatAg,
            this.PGender,
            this.PBT,
            this.PatientDisease});
            this.dataGridView1.Location = new System.Drawing.Point(431, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(773, 468);
            this.dataGridView1.TabIndex = 21;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Maroon;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(213, 561);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 59);
            this.button4.TabIndex = 25;
            this.button4.Text = "HOME";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Maroon;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(76, 561);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 59);
            this.button3.TabIndex = 24;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(213, 496);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 59);
            this.button2.TabIndex = 23;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(76, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 59);
            this.button1.TabIndex = 22;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(426, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 26);
            this.label9.TabIndex = 26;
            this.label9.Text = "Patient List";
            // 
            // Pat_ID
            // 
            this.Pat_ID.HeaderText = "ID";
            this.Pat_ID.MinimumWidth = 6;
            this.Pat_ID.Name = "Pat_ID";
            this.Pat_ID.Width = 125;
            // 
            // Pat_Name
            // 
            this.Pat_Name.HeaderText = "Name";
            this.Pat_Name.MinimumWidth = 6;
            this.Pat_Name.Name = "Pat_Name";
            this.Pat_Name.Width = 125;
            // 
            // Pat_A
            // 
            this.Pat_A.HeaderText = "Address";
            this.Pat_A.MinimumWidth = 6;
            this.Pat_A.Name = "Pat_A";
            this.Pat_A.Width = 125;
            // 
            // PatP
            // 
            this.PatP.HeaderText = "Phone";
            this.PatP.MinimumWidth = 6;
            this.PatP.Name = "PatP";
            this.PatP.Width = 125;
            // 
            // PatAg
            // 
            this.PatAg.HeaderText = "Age";
            this.PatAg.MinimumWidth = 6;
            this.PatAg.Name = "PatAg";
            this.PatAg.Width = 125;
            // 
            // PGender
            // 
            this.PGender.HeaderText = "Gender";
            this.PGender.MinimumWidth = 6;
            this.PGender.Name = "PGender";
            this.PGender.Width = 125;
            // 
            // PBT
            // 
            this.PBT.HeaderText = "Blood Typer";
            this.PBT.MinimumWidth = 6;
            this.PBT.Name = "PBT";
            this.PBT.Width = 125;
            // 
            // PatientDisease
            // 
            this.PatientDisease.HeaderText = "Disease";
            this.PatientDisease.MinimumWidth = 6;
            this.PatientDisease.Name = "PatientDisease";
            this.PatientDisease.Width = 125;
            // 
            // PatientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 632);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PatDisease);
            this.Controls.Add(this.PatBlood);
            this.Controls.Add(this.PatGender);
            this.Controls.Add(this.PatAge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PatPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PatAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PatName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PatID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientsForm";
            this.Text = "PatientsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PatID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PatName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PatAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PatPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PatAge;
        private System.Windows.Forms.ComboBox PatGender;
        private System.Windows.Forms.ComboBox PatBlood;
        private System.Windows.Forms.TextBox PatDisease;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pat_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pat_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pat_A;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatP;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatAg;
        private System.Windows.Forms.DataGridViewTextBoxColumn PGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn PBT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientDisease;
    }
}