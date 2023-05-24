namespace MedicalOffice
{
    partial class PatientF
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btnAddPt = new System.Windows.Forms.Button();
            this.btnUpdPt = new System.Windows.Forms.Button();
            this.btnDltPt = new System.Windows.Forms.Button();
            this.btnHmPt = new System.Windows.Forms.Button();
            this.lstvPatients = new System.Windows.Forms.ListView();
            this.PatientID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PatientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PatientAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PatientAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BloodType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Diagnosis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 113);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(392, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Patients";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Maroon;
            this.textBox1.Location = new System.Drawing.Point(56, 140);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 31);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Patient ID";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Maroon;
            this.textBox2.Location = new System.Drawing.Point(56, 179);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(226, 31);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Patient Name";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Maroon;
            this.textBox3.Location = new System.Drawing.Point(56, 218);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(226, 31);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Patient Address";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Maroon;
            this.textBox4.Location = new System.Drawing.Point(56, 257);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(226, 31);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "Patient Phone";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.Maroon;
            this.textBox5.Location = new System.Drawing.Point(56, 296);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(226, 31);
            this.textBox5.TabIndex = 8;
            this.textBox5.Text = "Patient Age";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.comboBox1.ForeColor = System.Drawing.Color.Maroon;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(56, 334);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 31);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "Gender";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.comboBox2.ForeColor = System.Drawing.Color.Maroon;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.comboBox2.Location = new System.Drawing.Point(56, 371);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(226, 31);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.Text = "Blood Type";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.Maroon;
            this.textBox6.Location = new System.Drawing.Point(56, 409);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(226, 31);
            this.textBox6.TabIndex = 11;
            this.textBox6.Text = "Diagnosis";
            // 
            // btnAddPt
            // 
            this.btnAddPt.BackColor = System.Drawing.Color.Maroon;
            this.btnAddPt.FlatAppearance.BorderSize = 0;
            this.btnAddPt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddPt.Location = new System.Drawing.Point(56, 457);
            this.btnAddPt.Name = "btnAddPt";
            this.btnAddPt.Size = new System.Drawing.Size(105, 42);
            this.btnAddPt.TabIndex = 12;
            this.btnAddPt.Text = "ADD";
            this.btnAddPt.UseVisualStyleBackColor = false;
            this.btnAddPt.Click += new System.EventHandler(this.btnAddPt_Click);
            // 
            // btnUpdPt
            // 
            this.btnUpdPt.BackColor = System.Drawing.Color.Maroon;
            this.btnUpdPt.FlatAppearance.BorderSize = 0;
            this.btnUpdPt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdPt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdPt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdPt.Location = new System.Drawing.Point(177, 457);
            this.btnUpdPt.Name = "btnUpdPt";
            this.btnUpdPt.Size = new System.Drawing.Size(105, 42);
            this.btnUpdPt.TabIndex = 13;
            this.btnUpdPt.Text = "UPDATE";
            this.btnUpdPt.UseVisualStyleBackColor = false;
            this.btnUpdPt.Click += new System.EventHandler(this.btnUpdPt_Click);
            // 
            // btnDltPt
            // 
            this.btnDltPt.BackColor = System.Drawing.Color.Maroon;
            this.btnDltPt.FlatAppearance.BorderSize = 0;
            this.btnDltPt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDltPt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDltPt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDltPt.Location = new System.Drawing.Point(56, 517);
            this.btnDltPt.Name = "btnDltPt";
            this.btnDltPt.Size = new System.Drawing.Size(105, 42);
            this.btnDltPt.TabIndex = 14;
            this.btnDltPt.Text = "DELETE";
            this.btnDltPt.UseVisualStyleBackColor = false;
            this.btnDltPt.Click += new System.EventHandler(this.btnDltPt_Click);
            // 
            // btnHmPt
            // 
            this.btnHmPt.BackColor = System.Drawing.Color.Maroon;
            this.btnHmPt.FlatAppearance.BorderSize = 0;
            this.btnHmPt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHmPt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHmPt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHmPt.Location = new System.Drawing.Point(177, 517);
            this.btnHmPt.Name = "btnHmPt";
            this.btnHmPt.Size = new System.Drawing.Size(105, 42);
            this.btnHmPt.TabIndex = 15;
            this.btnHmPt.Text = "Home";
            this.btnHmPt.UseVisualStyleBackColor = false;
            this.btnHmPt.Click += new System.EventHandler(this.button4_Click);
            // 
            // lstvPatients
            // 
            this.lstvPatients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PatientID,
            this.PatientName,
            this.PatientAddress,
            this.PatientAge,
            this.Gender,
            this.BloodType,
            this.Diagnosis});
            this.lstvPatients.HideSelection = false;
            this.lstvPatients.Location = new System.Drawing.Point(348, 140);
            this.lstvPatients.Name = "lstvPatients";
            this.lstvPatients.Size = new System.Drawing.Size(590, 419);
            this.lstvPatients.TabIndex = 16;
            this.lstvPatients.UseCompatibleStateImageBehavior = false;
            this.lstvPatients.View = System.Windows.Forms.View.Details;
            // 
            // PatientID
            // 
            this.PatientID.Width = 45;
            // 
            // PatientName
            // 
            this.PatientName.Width = 76;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(988, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeToolStripMenuItem,
            this.deserializeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // serializeToolStripMenuItem
            // 
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            this.serializeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.serializeToolStripMenuItem.Text = "Serialize";
            // 
            // deserializeToolStripMenuItem
            // 
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            this.deserializeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deserializeToolStripMenuItem.Text = "Deserialize";
            // 
            // PatientF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 611);
            this.Controls.Add(this.lstvPatients);
            this.Controls.Add(this.btnHmPt);
            this.Controls.Add(this.btnDltPt);
            this.Controls.Add(this.btnUpdPt);
            this.Controls.Add(this.btnAddPt);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PatientF";
            this.Text = "PatientF";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btnAddPt;
        private System.Windows.Forms.Button btnUpdPt;
        private System.Windows.Forms.Button btnDltPt;
        private System.Windows.Forms.Button btnHmPt;
        private System.Windows.Forms.ListView lstvPatients;
        private System.Windows.Forms.ColumnHeader PatientID;
        private System.Windows.Forms.ColumnHeader PatientName;
        private System.Windows.Forms.ColumnHeader PatientAddress;
        private System.Windows.Forms.ColumnHeader PatientAge;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader BloodType;
        private System.Windows.Forms.ColumnHeader Diagnosis;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializeToolStripMenuItem;
    }
}