namespace MedicalOffice
{
    partial class PrescriptionsForm
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
            this.PresID = new System.Windows.Forms.TextBox();
            this.PatID = new System.Windows.Forms.ComboBox();
            this.DocID = new System.Windows.Forms.ComboBox();
            this.PatName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PresSym = new System.Windows.Forms.TextBox();
            this.PresDiag = new System.Windows.Forms.TextBox();
            this.PresMed = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PRESCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pat_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doc_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sympt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Med = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(28, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 53);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prescriptions";
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
            this.label3.Location = new System.Drawing.Point(32, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID :";
            // 
            // PresID
            // 
            this.PresID.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PresID.Location = new System.Drawing.Point(111, 132);
            this.PresID.Name = "PresID";
            this.PresID.Size = new System.Drawing.Size(244, 33);
            this.PresID.TabIndex = 6;
            // 
            // PatID
            // 
            this.PatID.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.PatID.FormattingEnabled = true;
            this.PatID.Location = new System.Drawing.Point(37, 187);
            this.PatID.Name = "PatID";
            this.PatID.Size = new System.Drawing.Size(318, 33);
            this.PatID.TabIndex = 18;
            this.PatID.Text = "Patient ID";
            // 
            // DocID
            // 
            this.DocID.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.DocID.FormattingEnabled = true;
            this.DocID.Location = new System.Drawing.Point(37, 291);
            this.DocID.Name = "DocID";
            this.DocID.Size = new System.Drawing.Size(318, 33);
            this.DocID.TabIndex = 19;
            this.DocID.Text = "Doctor ID";
            // 
            // PatName
            // 
            this.PatName.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatName.Location = new System.Drawing.Point(185, 240);
            this.PatName.Name = "PatName";
            this.PatName.Size = new System.Drawing.Size(170, 33);
            this.PatName.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(32, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 26);
            this.label4.TabIndex = 21;
            this.label4.Text = "Patient Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(32, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 26);
            this.label5.TabIndex = 22;
            this.label5.Text = "Symptoms :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(32, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 26);
            this.label6.TabIndex = 23;
            this.label6.Text = "Diagnosis :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(32, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 26);
            this.label7.TabIndex = 24;
            this.label7.Text = "Medicine :";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Maroon;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(198, 538);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 59);
            this.button4.TabIndex = 29;
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
            this.button3.Location = new System.Drawing.Point(61, 538);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 59);
            this.button3.TabIndex = 28;
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
            this.button2.Location = new System.Drawing.Point(198, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 59);
            this.button2.TabIndex = 27;
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
            this.button1.Location = new System.Drawing.Point(61, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 59);
            this.button1.TabIndex = 26;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // PresSym
            // 
            this.PresSym.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PresSym.Location = new System.Drawing.Point(161, 339);
            this.PresSym.Name = "PresSym";
            this.PresSym.Size = new System.Drawing.Size(194, 33);
            this.PresSym.TabIndex = 30;
            // 
            // PresDiag
            // 
            this.PresDiag.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PresDiag.Location = new System.Drawing.Point(161, 380);
            this.PresDiag.Name = "PresDiag";
            this.PresDiag.Size = new System.Drawing.Size(194, 33);
            this.PresDiag.TabIndex = 31;
            // 
            // PresMed
            // 
            this.PresMed.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PresMed.Location = new System.Drawing.Point(161, 419);
            this.PresMed.Name = "PresMed";
            this.PresMed.Size = new System.Drawing.Size(194, 33);
            this.PresMed.TabIndex = 32;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRESCID,
            this.PAT_ID,
            this.Pat_Name,
            this.Doc_ID,
            this.Sympt,
            this.Diag,
            this.Med});
            this.dataGridView1.Location = new System.Drawing.Point(431, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(773, 468);
            this.dataGridView1.TabIndex = 33;
            // 
            // PRESCID
            // 
            this.PRESCID.HeaderText = "ID";
            this.PRESCID.MinimumWidth = 6;
            this.PRESCID.Name = "PRESCID";
            this.PRESCID.Width = 125;
            // 
            // PAT_ID
            // 
            this.PAT_ID.HeaderText = "Patient ID";
            this.PAT_ID.MinimumWidth = 6;
            this.PAT_ID.Name = "PAT_ID";
            this.PAT_ID.Width = 125;
            // 
            // Pat_Name
            // 
            this.Pat_Name.HeaderText = "Patient Name";
            this.Pat_Name.MinimumWidth = 6;
            this.Pat_Name.Name = "Pat_Name";
            this.Pat_Name.Width = 125;
            // 
            // Doc_ID
            // 
            this.Doc_ID.HeaderText = "Doctor ID";
            this.Doc_ID.MinimumWidth = 6;
            this.Doc_ID.Name = "Doc_ID";
            this.Doc_ID.Width = 125;
            // 
            // Sympt
            // 
            this.Sympt.HeaderText = "Symptoms";
            this.Sympt.MinimumWidth = 6;
            this.Sympt.Name = "Sympt";
            this.Sympt.Width = 125;
            // 
            // Diag
            // 
            this.Diag.HeaderText = "Diagnosis";
            this.Diag.MinimumWidth = 6;
            this.Diag.Name = "Diag";
            this.Diag.Width = 125;
            // 
            // Med
            // 
            this.Med.HeaderText = "Medicine";
            this.Med.MinimumWidth = 6;
            this.Med.Name = "Med";
            this.Med.Width = 125;
            // 
            // PrescriptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 632);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PresMed);
            this.Controls.Add(this.PresDiag);
            this.Controls.Add(this.PresSym);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PatName);
            this.Controls.Add(this.DocID);
            this.Controls.Add(this.PatID);
            this.Controls.Add(this.PresID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrescriptionsForm";
            this.Text = "PrescriptionsForm";
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
        private System.Windows.Forms.TextBox PresID;
        private System.Windows.Forms.ComboBox PatID;
        private System.Windows.Forms.ComboBox DocID;
        private System.Windows.Forms.TextBox PatName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PresSym;
        private System.Windows.Forms.TextBox PresDiag;
        private System.Windows.Forms.TextBox PresMed;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRESCID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pat_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doc_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sympt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Med;
    }
}