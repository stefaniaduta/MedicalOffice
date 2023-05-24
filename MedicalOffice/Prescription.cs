using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MedicalOffice
{
    public partial class Prescription : Form
    {
        private string connectionString = "Data Source=prescriptiondb.db;Version=3;";

        public Prescription()
        {
            InitializeComponent();
        }

        private void Prescription_Load(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home();
            homeForm.Show();
            this.Hide();
        }

        private void ClearInputFields()
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox2.Clear();

        }

        private void btnAddPr_Click(object sender, EventArgs e)
        {
            string value1 = textBox1.Text;
            string value2 = textBox3.Text;
            string value3 = textBox4.Text;
            string value4 = textBox5.Text;
            string value5 = textBox6.Text;
            string value6 = textBox2.Text;

            ListViewItem newItem = new ListViewItem(value1);
            newItem.SubItems.Add(value2);
            newItem.SubItems.Add(value3);
            newItem.SubItems.Add(value4);
            newItem.SubItems.Add(value5);
            newItem.SubItems.Add(value6);

            lstvPrescriptions.Items.Add(newItem);

            ClearInputFields();
        }



        private void btnUpdPr_Click(object sender, EventArgs e)
        {
            if (lstvPrescriptions.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstvPrescriptions.SelectedItems[0];

                selectedItem.SubItems[1].Text = textBox3.Text;
                selectedItem.SubItems[2].Text = textBox4.Text;
                selectedItem.SubItems[3].Text = textBox5.Text;
                selectedItem.SubItems[4].Text = textBox6.Text;
                selectedItem.SubItems[4].Text = textBox2.Text;


                ClearInputFields();
            }
        }


        private void btnDltPr_Click(object sender, EventArgs e)
        {
            if (lstvPrescriptions.SelectedItems.Count > 0)
            {
                lstvPrescriptions.Items.Remove(lstvPrescriptions.SelectedItems[0]);

                ClearInputFields();
            }
        }

    }
}
