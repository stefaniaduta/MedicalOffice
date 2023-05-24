using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalOffice
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            doctorName.AllowDrop = true;
            doctorName.DragEnter += doctorName_DragEnter;
            doctorName.DragDrop += doctorName_DragDrop;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string doctorNameInput = doctorName.Text;
            string doctorPassInput = doctorPass.Text;

            if (doctorNameInput == "Duta Stefania" && doctorPassInput == "123456")
            {
                Home home = new Home();
                home.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.");
                doctorName.Clear();
                doctorPass.Clear();
                doctorName.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearF_Click(object sender, EventArgs e)
        {
            doctorName.Text = string.Empty;
            doctorPass.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void doctorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void doctorName_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void doctorName_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                string droppedText = e.Data.GetData(DataFormats.Text) as string;
                doctorName.Text = droppedText;
            }
        }
    }
}
