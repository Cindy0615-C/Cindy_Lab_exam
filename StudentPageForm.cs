using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Lab_exam_IPT_Cindy
{
    public partial class StudentPageForm : Form
    {
        private string connectionString = "server=localhost;uid=root;pwd=;database=studentdb";

        public StudentPageForm()
        {
            InitializeComponent();
            LoadStudentData();
        }

        private void LoadStudentData()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT studentId, CONCAT(firstName, ' ', lastName) AS fullName FROM StudentRecordTB";
                var command = new MySqlCommand(query, connection);
                var reader = command.ExecuteReader();

                // Clear existing rows
                dataGridView1.Rows.Clear();

                while (reader.Read())
                {
                    var studentId = reader["studentId"].ToString();
                    var fullName = reader["fullName"].ToString();

                    // Add data to DataGridView
                    dataGridView1.Rows.Add(studentId, fullName, "VIEW");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2) // VIEW button clicked
            {
                var studentIdCell = dataGridView1.Rows[e.RowIndex].Cells[0].Value;

                if (studentIdCell != null) // Check if studentIdCell is not null
                {
                    var studentId = studentIdCell.ToString();
                    var individualPage = new StudentPageIndividualForm(studentId);
                    individualPage.Show();
                }
                else
                {
                    MessageBox.Show("Student ID is missing in this row.");
                }
            }
        }
    }
}
