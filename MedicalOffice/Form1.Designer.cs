namespace MedicalOffice
{
    partial class Form1
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
            this.btnLogIn = new System.Windows.Forms.Button();
            this.doctorPass = new System.Windows.Forms.TextBox();
            this.clearF = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.doctorName = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 158);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(213, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Medical Clinic";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Maroon;
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            this.btnLogIn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogIn.Location = new System.Drawing.Point(222, 365);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(329, 84);
            this.btnLogIn.TabIndex = 1;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // doctorPass
            // 
            this.doctorPass.ForeColor = System.Drawing.Color.Maroon;
            this.doctorPass.Location = new System.Drawing.Point(200, 279);
            this.doctorPass.Margin = new System.Windows.Forms.Padding(4);
            this.doctorPass.Name = "doctorPass";
            this.doctorPass.Size = new System.Drawing.Size(380, 31);
            this.doctorPass.TabIndex = 3;
            this.doctorPass.Text = "Doctor Password";
            // 
            // clearF
            // 
            this.clearF.BackColor = System.Drawing.Color.Transparent;
            this.clearF.FlatAppearance.BorderSize = 0;
            this.clearF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearF.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.clearF.ForeColor = System.Drawing.Color.Maroon;
            this.clearF.Location = new System.Drawing.Point(12, 443);
            this.clearF.Name = "clearF";
            this.clearF.Size = new System.Drawing.Size(195, 81);
            this.clearF.TabIndex = 6;
            this.clearF.Text = "Clear Fields";
            this.clearF.UseVisualStyleBackColor = false;
            this.clearF.Click += new System.EventHandler(this.clearF_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.btnExit.ForeColor = System.Drawing.Color.Maroon;
            this.btnExit.Location = new System.Drawing.Point(645, 443);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 81);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // doctorName
            // 
            this.doctorName.ForeColor = System.Drawing.Color.Maroon;
            this.doctorName.Location = new System.Drawing.Point(200, 219);
            this.doctorName.Name = "doctorName";
            this.doctorName.Size = new System.Drawing.Size(380, 31);
            this.doctorName.TabIndex = 8;
            this.doctorName.Text = "Doctor Name";
            this.doctorName.TextChanged += new System.EventHandler(this.doctorName_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 536);
            this.Controls.Add(this.doctorName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.clearF);
            this.Controls.Add(this.doctorPass);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox doctorPass;
        private System.Windows.Forms.Button clearF;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox doctorName;
    }
}

