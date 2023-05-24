using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;


namespace MedicalOffice
{
    public partial class DoctorF : Form
    {
        private string connectionString = "Data Source=doctordb.db;Version=3;";
        private DataSet dataSet;


        public class Doctor
        {
            public int DoctorId { get; set; }
            public string DoctorName { get; set; }
            public string WorkField { get; set; }
            public string DocPass { get; set; }
        }

        public DoctorF()
        {
            InitializeComponent();

            KeyPreview = true;
            KeyDown += DoctorF_KeyDown;

            ToolStripMenuItem fileToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItem printPreviewToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItem pageSetupToolStripMenuItem = new ToolStripMenuItem();

            fileToolStripMenuItem.Text = "Print";
            printPreviewToolStripMenuItem.Text = "Print Preview";
            pageSetupToolStripMenuItem.Text = "Page Setup";

            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { printPreviewToolStripMenuItem, pageSetupToolStripMenuItem });
            menuStrip1.Items.Add(fileToolStripMenuItem);

        }



        private void DoctorF_Load(object sender, EventArgs e)
        {
            lstvDoctors.View = View.Details;
            lstvDoctors.Columns.Add("Doctor ID");
            lstvDoctors.Columns.Add("Doctor Name");
            lstvDoctors.Columns.Add("Work Field");
            lstvDoctors.Columns.Add("Password");

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM Doctors", connection))
                {
                    dataSet = new DataSet();
                    adapter.Fill(dataSet, "Doctors");
                }

                connection.Close();
            }

            foreach (DataRow row in dataSet.Tables["Doctors"].Rows)
            {
                ListViewItem item = new ListViewItem(row["DoctorId"].ToString());
                item.SubItems.Add(row["DoctorName"].ToString());
                item.SubItems.Add(row["WorkField"].ToString());
                item.SubItems.Add(row["DocPass"].ToString());
                lstvDoctors.Items.Add(item);
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnAddDc_Click(object sender, EventArgs e)
        {
            int doctorId = Convert.ToInt32(textBox1DC.Text);
            string doctorName = textBox2DC.Text;
            string workField = textBox3DC.Text;
            string password = textBox4DC.Text;

            if (dataSet != null && dataSet.Tables.Contains("Doctors"))
            {
                DataRow newRow = dataSet.Tables["Doctors"].NewRow();
                newRow["DoctorId"] = doctorId;
                newRow["DoctorName"] = doctorName;
                newRow["WorkField"] = workField;
                newRow["DocPass"] = password;

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Doctors (DoctorId, DoctorName, WorkField, DocPass) " +
                                   "VALUES (@doctorId, @doctorName, @workField, @password)";

                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.Parameters.AddWithValue("@doctorId", doctorId);
                    command.Parameters.AddWithValue("@doctorName", doctorName);
                    command.Parameters.AddWithValue("@workField", workField);
                    command.Parameters.AddWithValue("@password", password);

                    command.ExecuteNonQuery();

                    connection.Close();
                }

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM Doctors", connection))
                    {
                        dataSet.Tables["Doctors"].Clear(); 

                        adapter.Fill(dataSet, "Doctors"); 
                    }

                    connection.Close();
                }


                textBox1DC.Clear();
                textBox2DC.Clear();
                textBox3DC.Clear();
                textBox4DC.Clear();
            }
        }


        private void btnUpdDc_Click(object sender, EventArgs e)
        {
            if (lstvDoctors.SelectedItems.Count > 0)
            {
                ListViewItem selectedDoctor = lstvDoctors.SelectedItems[0];

                int doctorId = Convert.ToInt32(selectedDoctor.SubItems[0].Text);
                string doctorName = textBox2DC.Text;
                string workField = textBox3DC.Text;
                string password = textBox4DC.Text;

                selectedDoctor.SubItems[1].Text = doctorName;
                selectedDoctor.SubItems[2].Text = workField;
                selectedDoctor.SubItems[3].Text = password;

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM Doctors", connection))
                    {
                        SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(adapter);
                        adapter.Update(dataSet, "Doctors");
                    }

                    connection.Close();
                }

                MessageBox.Show("Data updated successfully.");
            }
            else
            {
                MessageBox.Show("Please select a doctor to update.");
            }
        }

        private void btnDltDc_Click(object sender, EventArgs e)
        {
            if (lstvDoctors.SelectedItems.Count > 0)
            {
                ListViewItem selectedDoctor = lstvDoctors.SelectedItems[0];
                int doctorId = Convert.ToInt32(selectedDoctor.SubItems[0].Text);

                lstvDoctors.Items.Remove(selectedDoctor);

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM Doctors WHERE DoctorId = @doctorId";

                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.Parameters.AddWithValue("@doctorId", doctorId);
                    command.ExecuteNonQuery();

                    connection.Close();
                }

                MessageBox.Show("Data deleted successfully.");
            }
            else
            {
                MessageBox.Show("Please select a doctor to delete.");
            }
        }

        private void DoctorF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Home home = new Home();
                home.Show();
                Hide();
            }
        }

        private void textBox1DC_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void textBox1DC_DragDrop(object sender, DragEventArgs e)
        {
            string droppedText = e.Data.GetData(DataFormats.Text) as string;

            textBox1DC.Text = droppedText;
        }


        private void btnExportReport_Click(object sender, EventArgs e)
        {
            List<Doctor> doctors = new List<Doctor>();

            foreach (ListViewItem item in lstvDoctors.Items)
            {
                Doctor doctor = new Doctor
                {
                    DoctorId = Convert.ToInt32(item.SubItems[0].Text),
                    DoctorName = item.SubItems[1].Text,
                    WorkField = item.SubItems[2].Text,
                    DocPass = item.SubItems[3].Text
                };

                doctors.Add(doctor);
            }

            ExportReportToFile(doctors);
        }

        private void ExportReportToFile(List<Doctor> doctors)
        {
            StringBuilder reportContent = new StringBuilder();

            reportContent.AppendLine("Doctor ID\tDoctor Name\tWork Field\tPassword");

            foreach (Doctor doctor in doctors)
            {
                reportContent.AppendLine($"{doctor.DoctorId}\t{doctor.DoctorName}\t{doctor.WorkField}\t{doctor.DocPass}");
            }

            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text files (*.txt)|*.txt";
                saveFileDialog.Title = "Export Report";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    File.WriteAllText(saveFileDialog.FileName, reportContent.ToString());
                    MessageBox.Show("Report exported successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while exporting the report: " + ex.Message);
            }
        }



        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Microsoft Sans Serif", 10);

            var pageSettings = e.PageSettings;

            var printAreaHeight = e.MarginBounds.Height;
            var printAreaWidth = e.MarginBounds.Width;

            var marginLeft = e.MarginBounds.Left;
            var marginTop = e.MarginBounds.Top;

            const int rowHeight = 20;
            var columnWidth = printAreaWidth / 4;

            StringFormat fmt = new StringFormat(StringFormatFlags.LineLimit);
            fmt.Trimming = StringTrimming.EllipsisCharacter;

            var currentY = marginTop;
            var currentX = marginLeft;

            e.Graphics.DrawString("Doctor ID", font, Brushes.Black, currentX, currentY);
            currentX += columnWidth;

            e.Graphics.DrawString("Doctor Name", font, Brushes.Black, currentX, currentY);
            currentX += columnWidth;

            e.Graphics.DrawString("Work Field", font, Brushes.Black, currentX, currentY);
            currentX += columnWidth;

            e.Graphics.DrawString("Password", font, Brushes.Black, currentX, currentY);

            currentY += rowHeight;

            foreach (ListViewItem item in lstvDoctors.Items)
            {
                currentX = marginLeft;

                e.Graphics.DrawString(item.SubItems[0].Text, font, Brushes.Black, currentX, currentY);
                currentX += columnWidth;

                e.Graphics.DrawString(item.SubItems[1].Text, font, Brushes.Black, currentX, currentY);
                currentX += columnWidth;

                e.Graphics.DrawString(item.SubItems[2].Text, font, Brushes.Black, currentX, currentY);
                currentX += columnWidth;

                e.Graphics.DrawString(item.SubItems[3].Text, font, Brushes.Black, currentX, currentY);

                currentY += rowHeight;

                if (currentY + rowHeight > printAreaHeight)
                {
                    e.HasMorePages = true;
                    return; 
                }
            }
        }





    }

}
