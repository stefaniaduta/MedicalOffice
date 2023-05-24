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

namespace MedicalOffice
{
    public partial class PatientF : Form
    {
        public PatientF()
        {
            InitializeComponent();
        }

        //public ListView PatientsListView
        //{
        //    get { return lstvPatients; }
        //}

        private void PatientF_Load(object sender, EventArgs e)
        {
            btnAddPt.Click += btnAddPt_Click;
            btnUpdPt.Click += btnUpdPt_Click;
            btnDltPt.Click += btnDltPt_Click;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnAddPt_Click(object sender, EventArgs e)
        {
            string value1 = textBox1.Text;
            string value2 = textBox2.Text;
            string value3 = textBox3.Text;
            string value4 = textBox4.Text;
            string value5 = textBox5.Text;
            string value6 = textBox6.Text;
            string value7 = comboBox1.Text;
            string value8 = comboBox2.Text;

            ListViewItem newItem = new ListViewItem(value1);
            newItem.SubItems.Add(value2);
            newItem.SubItems.Add(value3);
            newItem.SubItems.Add(value4);
            newItem.SubItems.Add(value5);
            newItem.SubItems.Add(value6);
            newItem.SubItems.Add(value7);
            newItem.SubItems.Add(value8);

            lstvPatients.Items.Add(newItem);

            ClearInputFields();
        }

        private void ClearInputFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }

        private void btnUpdPt_Click(object sender, EventArgs e)
        {
            if (lstvPatients.SelectedItems.Count > 0)
            {
                ListViewItem selectedPatient = lstvPatients.SelectedItems[0];

                string patientId = textBox1.Text;
                string patientName = textBox2.Text;
                string gender = comboBox1.SelectedItem.ToString();
                string age = textBox3.Text;
                string diagnosis = textBox4.Text;
                string medication = textBox5.Text;
                string doctor = comboBox2.SelectedItem.ToString();

                selectedPatient.SubItems[0].Text = patientId;
                selectedPatient.SubItems[1].Text = patientName;
                selectedPatient.SubItems[2].Text = gender;
                selectedPatient.SubItems[3].Text = age;
                selectedPatient.SubItems[4].Text = diagnosis;
                selectedPatient.SubItems[5].Text = medication;
                selectedPatient.SubItems[6].Text = doctor;

                ClearInputFields();

                MessageBox.Show("Data updated successfully.");
            }
            else
            {
                MessageBox.Show("Please select a patient to update.");
            }
        }

        private void btnDltPt_Click(object sender, EventArgs e)
        {
            if (lstvPatients.SelectedItems.Count > 0)
            {
                ListViewItem selectedPatient = lstvPatients.SelectedItems[0];

                lstvPatients.Items.Remove(selectedPatient);

                MessageBox.Show("Data deleted successfully.");
            }
            else
            {
                MessageBox.Show("Please select a patient to delete.");
            }
        }
    }
}
