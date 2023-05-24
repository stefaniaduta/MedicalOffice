namespace MedicalOffice
{
    partial class Prescription
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btnHmPr = new System.Windows.Forms.Button();
            this.btnDltPr = new System.Windows.Forms.Button();
            this.btnUpdPr = new System.Windows.Forms.Button();
            this.btnAddPr = new System.Windows.Forms.Button();
            this.lstvPrescriptions = new System.Windows.Forms.ListView();
            this.PrescriptionID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PatientID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sYMPTOMS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Diagnosis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Medicine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 113);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(331, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prescriptions";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Maroon;
            this.textBox1.Location = new System.Drawing.Point(41, 140);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 31);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Prescription ID";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Maroon;
            this.textBox3.Location = new System.Drawing.Point(40, 361);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(226, 31);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Medicine";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Maroon;
            this.textBox4.Location = new System.Drawing.Point(40, 318);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(226, 31);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "Diagnosis";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.Maroon;
            this.textBox5.Location = new System.Drawing.Point(42, 272);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(226, 31);
            this.textBox5.TabIndex = 8;
            this.textBox5.Text = "Symptoms";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.Maroon;
            this.textBox6.Location = new System.Drawing.Point(41, 232);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(226, 31);
            this.textBox6.TabIndex = 9;
            this.textBox6.Text = "Patient Name";
            // 
            // btnHmPr
            // 
            this.btnHmPr.BackColor = System.Drawing.Color.Maroon;
            this.btnHmPr.FlatAppearance.BorderSize = 0;
            this.btnHmPr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHmPr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHmPr.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHmPr.Location = new System.Drawing.Point(162, 509);
            this.btnHmPr.Name = "btnHmPr";
            this.btnHmPr.Size = new System.Drawing.Size(105, 42);
            this.btnHmPr.TabIndex = 19;
            this.btnHmPr.Text = "Home";
            this.btnHmPr.UseVisualStyleBackColor = false;
            this.btnHmPr.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDltPr
            // 
            this.btnDltPr.BackColor = System.Drawing.Color.Maroon;
            this.btnDltPr.FlatAppearance.BorderSize = 0;
            this.btnDltPr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDltPr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDltPr.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDltPr.Location = new System.Drawing.Point(41, 509);
            this.btnDltPr.Name = "btnDltPr";
            this.btnDltPr.Size = new System.Drawing.Size(105, 42);
            this.btnDltPr.TabIndex = 18;
            this.btnDltPr.Text = "DELETE";
            this.btnDltPr.UseVisualStyleBackColor = false;
            this.btnDltPr.Click += new System.EventHandler(this.btnDltPr_Click);
            // 
            // btnUpdPr
            // 
            this.btnUpdPr.BackColor = System.Drawing.Color.Maroon;
            this.btnUpdPr.FlatAppearance.BorderSize = 0;
            this.btnUpdPr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdPr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdPr.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdPr.Location = new System.Drawing.Point(162, 449);
            this.btnUpdPr.Name = "btnUpdPr";
            this.btnUpdPr.Size = new System.Drawing.Size(105, 42);
            this.btnUpdPr.TabIndex = 17;
            this.btnUpdPr.Text = "UPDATE";
            this.btnUpdPr.UseVisualStyleBackColor = false;
            this.btnUpdPr.Click += new System.EventHandler(this.btnUpdPr_Click);
            // 
            // btnAddPr
            // 
            this.btnAddPr.BackColor = System.Drawing.Color.Maroon;
            this.btnAddPr.FlatAppearance.BorderSize = 0;
            this.btnAddPr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPr.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddPr.Location = new System.Drawing.Point(41, 449);
            this.btnAddPr.Name = "btnAddPr";
            this.btnAddPr.Size = new System.Drawing.Size(105, 42);
            this.btnAddPr.TabIndex = 16;
            this.btnAddPr.Text = "ADD";
            this.btnAddPr.UseVisualStyleBackColor = false;
            this.btnAddPr.Click += new System.EventHandler(this.btnAddPr_Click);
            // 
            // lstvPrescriptions
            // 
            this.lstvPrescriptions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PrescriptionID,
            this.PatientID,
            this.sYMPTOMS,
            this.Diagnosis,
            this.Medicine});
            this.lstvPrescriptions.HideSelection = false;
            this.lstvPrescriptions.Location = new System.Drawing.Point(340, 140);
            this.lstvPrescriptions.Name = "lstvPrescriptions";
            this.lstvPrescriptions.Size = new System.Drawing.Size(585, 411);
            this.lstvPrescriptions.TabIndex = 20;
            this.lstvPrescriptions.UseCompatibleStateImageBehavior = false;
            this.lstvPrescriptions.View = System.Windows.Forms.View.Details;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Maroon;
            this.textBox2.Location = new System.Drawing.Point(42, 185);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(226, 31);
            this.textBox2.TabIndex = 21;
            this.textBox2.Text = "Patient ID";
            // 
            // Prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 611);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lstvPrescriptions);
            this.Controls.Add(this.btnHmPr);
            this.Controls.Add(this.btnDltPr);
            this.Controls.Add(this.btnUpdPr);
            this.Controls.Add(this.btnAddPr);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Prescription";
            this.Text = "Prescription";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btnHmPr;
        private System.Windows.Forms.Button btnDltPr;
        private System.Windows.Forms.Button btnUpdPr;
        private System.Windows.Forms.Button btnAddPr;
        private System.Windows.Forms.ListView lstvPrescriptions;
        private System.Windows.Forms.ColumnHeader PrescriptionID;
        private System.Windows.Forms.ColumnHeader PatientID;
        private System.Windows.Forms.ColumnHeader sYMPTOMS;
        private System.Windows.Forms.ColumnHeader Diagnosis;
        private System.Windows.Forms.ColumnHeader Medicine;
        private System.Windows.Forms.TextBox textBox2;
    }
}