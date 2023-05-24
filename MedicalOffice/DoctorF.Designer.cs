namespace MedicalOffice
{
    partial class DoctorF
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
            this.textBox1DC = new System.Windows.Forms.TextBox();
            this.textBox2DC = new System.Windows.Forms.TextBox();
            this.textBox3DC = new System.Windows.Forms.TextBox();
            this.textBox4DC = new System.Windows.Forms.TextBox();
            this.btnAddDc = new System.Windows.Forms.Button();
            this.btnUpdDc = new System.Windows.Forms.Button();
            this.btnDltDc = new System.Windows.Forms.Button();
            this.btnHmDc = new System.Windows.Forms.Button();
            this.lstvDoctors = new System.Windows.Forms.ListView();
            this.btnExportReport = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
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
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(392, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Doctors";
            // 
            // textBox1DC
            // 
            this.textBox1DC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1DC.ForeColor = System.Drawing.Color.Maroon;
            this.textBox1DC.Location = new System.Drawing.Point(56, 139);
            this.textBox1DC.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1DC.Name = "textBox1DC";
            this.textBox1DC.Size = new System.Drawing.Size(226, 31);
            this.textBox1DC.TabIndex = 3;
            this.textBox1DC.Text = "Doctor ID";
            // 
            // textBox2DC
            // 
            this.textBox2DC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2DC.ForeColor = System.Drawing.Color.Maroon;
            this.textBox2DC.Location = new System.Drawing.Point(54, 189);
            this.textBox2DC.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2DC.Name = "textBox2DC";
            this.textBox2DC.Size = new System.Drawing.Size(226, 31);
            this.textBox2DC.TabIndex = 4;
            this.textBox2DC.Text = "Doctor Name";
            // 
            // textBox3DC
            // 
            this.textBox3DC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3DC.ForeColor = System.Drawing.Color.Maroon;
            this.textBox3DC.Location = new System.Drawing.Point(54, 238);
            this.textBox3DC.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3DC.Name = "textBox3DC";
            this.textBox3DC.Size = new System.Drawing.Size(226, 31);
            this.textBox3DC.TabIndex = 5;
            this.textBox3DC.Text = "Work Field";
            // 
            // textBox4DC
            // 
            this.textBox4DC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4DC.ForeColor = System.Drawing.Color.Maroon;
            this.textBox4DC.Location = new System.Drawing.Point(54, 319);
            this.textBox4DC.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4DC.Name = "textBox4DC";
            this.textBox4DC.Size = new System.Drawing.Size(226, 31);
            this.textBox4DC.TabIndex = 6;
            this.textBox4DC.Text = "Password";
            // 
            // btnAddDc
            // 
            this.btnAddDc.BackColor = System.Drawing.Color.Maroon;
            this.btnAddDc.FlatAppearance.BorderSize = 0;
            this.btnAddDc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDc.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddDc.Location = new System.Drawing.Point(54, 383);
            this.btnAddDc.Name = "btnAddDc";
            this.btnAddDc.Size = new System.Drawing.Size(105, 42);
            this.btnAddDc.TabIndex = 8;
            this.btnAddDc.Text = "ADD";
            this.btnAddDc.UseVisualStyleBackColor = false;
            this.btnAddDc.Click += new System.EventHandler(this.btnAddDc_Click);
            // 
            // btnUpdDc
            // 
            this.btnUpdDc.BackColor = System.Drawing.Color.Maroon;
            this.btnUpdDc.FlatAppearance.BorderSize = 0;
            this.btnUpdDc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdDc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdDc.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdDc.Location = new System.Drawing.Point(175, 383);
            this.btnUpdDc.Name = "btnUpdDc";
            this.btnUpdDc.Size = new System.Drawing.Size(105, 42);
            this.btnUpdDc.TabIndex = 9;
            this.btnUpdDc.Text = "UPDATE";
            this.btnUpdDc.UseVisualStyleBackColor = false;
            this.btnUpdDc.Click += new System.EventHandler(this.btnUpdDc_Click);
            // 
            // btnDltDc
            // 
            this.btnDltDc.BackColor = System.Drawing.Color.Maroon;
            this.btnDltDc.FlatAppearance.BorderSize = 0;
            this.btnDltDc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDltDc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDltDc.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDltDc.Location = new System.Drawing.Point(56, 449);
            this.btnDltDc.Name = "btnDltDc";
            this.btnDltDc.Size = new System.Drawing.Size(105, 42);
            this.btnDltDc.TabIndex = 10;
            this.btnDltDc.Text = "DELETE";
            this.btnDltDc.UseVisualStyleBackColor = false;
            this.btnDltDc.Click += new System.EventHandler(this.btnDltDc_Click);
            // 
            // btnHmDc
            // 
            this.btnHmDc.BackColor = System.Drawing.Color.Maroon;
            this.btnHmDc.FlatAppearance.BorderSize = 0;
            this.btnHmDc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHmDc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHmDc.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHmDc.Location = new System.Drawing.Point(175, 449);
            this.btnHmDc.Name = "btnHmDc";
            this.btnHmDc.Size = new System.Drawing.Size(105, 42);
            this.btnHmDc.TabIndex = 11;
            this.btnHmDc.Text = "Home";
            this.btnHmDc.UseVisualStyleBackColor = false;
            this.btnHmDc.Click += new System.EventHandler(this.button4_Click);
            // 
            // lstvDoctors
            // 
            this.lstvDoctors.HideSelection = false;
            this.lstvDoctors.Location = new System.Drawing.Point(357, 139);
            this.lstvDoctors.Name = "lstvDoctors";
            this.lstvDoctors.Size = new System.Drawing.Size(569, 420);
            this.lstvDoctors.TabIndex = 12;
            this.lstvDoctors.UseCompatibleStateImageBehavior = false;
            this.lstvDoctors.View = System.Windows.Forms.View.Details;
            // 
            // btnExportReport
            // 
            this.btnExportReport.BackColor = System.Drawing.Color.Maroon;
            this.btnExportReport.FlatAppearance.BorderSize = 0;
            this.btnExportReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportReport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportReport.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExportReport.Location = new System.Drawing.Point(116, 517);
            this.btnExportReport.Name = "btnExportReport";
            this.btnExportReport.Size = new System.Drawing.Size(105, 42);
            this.btnExportReport.TabIndex = 13;
            this.btnExportReport.Text = "EXPORT";
            this.btnExportReport.UseVisualStyleBackColor = false;
            this.btnExportReport.Click += new System.EventHandler(this.btnExportReport_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(988, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printPreviewToolStripMenuItem,
            this.pageSetupToolStripMenuItem});
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            // 
            // pageSetupToolStripMenuItem
            // 
            this.pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
            this.pageSetupToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pageSetupToolStripMenuItem.Text = "Page Setup";
            // 
            // pageSetupDialog
            // 
            this.pageSetupDialog.Document = this.printDocument;
            // 
            // DoctorF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 611);
            this.Controls.Add(this.btnExportReport);
            this.Controls.Add(this.lstvDoctors);
            this.Controls.Add(this.btnHmDc);
            this.Controls.Add(this.btnDltDc);
            this.Controls.Add(this.btnUpdDc);
            this.Controls.Add(this.btnAddDc);
            this.Controls.Add(this.textBox4DC);
            this.Controls.Add(this.textBox3DC);
            this.Controls.Add(this.textBox2DC);
            this.Controls.Add(this.textBox1DC);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DoctorF";
            this.Text = "DoctorF";
            this.Load += new System.EventHandler(this.DoctorF_Load);
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
        private System.Windows.Forms.TextBox textBox1DC;
        private System.Windows.Forms.TextBox textBox2DC;
        private System.Windows.Forms.TextBox textBox3DC;
        private System.Windows.Forms.TextBox textBox4DC;
        private System.Windows.Forms.Button btnAddDc;
        private System.Windows.Forms.Button btnUpdDc;
        private System.Windows.Forms.Button btnDltDc;
        private System.Windows.Forms.Button btnHmDc;
        private System.Windows.Forms.ListView lstvDoctors;
        private System.Windows.Forms.Button btnExportReport;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageSetupToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
    }
}