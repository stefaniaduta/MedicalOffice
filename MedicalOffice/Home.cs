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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 home = new Form1();
            home.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            DoctorF doctorForm = new DoctorF();
            doctorForm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            PatientF patientForm = new PatientF();
            patientForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Prescription prescriptionForm = new Prescription();
            prescriptionForm.Show();
        }
    }
}
