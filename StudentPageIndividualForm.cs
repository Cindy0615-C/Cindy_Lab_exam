using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Lab_exam_IPT_Cindy
{
    public partial class StudentPageIndividualForm : Form
    {
        private string connectionString = "server=localhost;uid=root;pwd=;database=studentdb";
        private string studentId;

        public StudentPageIndividualForm(string studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            LoadStudentDetails();
        }

        private void LoadStudentDetails()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT s.studentId, s.firstName, s.lastName, s.middleName, s.houseNo, s.brgyName, s.municipality, s.province, s.region, s.country, s.birthdate, s.age, s.studContactNo, s.emailAddress, s.guardianFirstName, s.guardianLastName, s.hobbies, s.nickname, c.courseName, y.yearLvl " +
                            "FROM StudentRecordTB s " +
                            "JOIN CourseTB c ON s.courseId = c.courseId " +
                            "JOIN YearTB y ON s.yearId = y.yearId " +
                            "WHERE s.studentId = @studentId";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@studentId", studentId);

                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    labelStudentId.Text = "Student ID: " + reader["studentId"].ToString();
                    labelFullName.Text = "Name: " + reader["firstName"].ToString() + " " + reader["lastName"].ToString();
                    labelAddress.Text = "Address: " + reader["houseNo"].ToString() + " " + reader["brgyName"].ToString() + ", " + reader["municipality"].ToString() + ", " + reader["province"].ToString() + ", " + reader["region"].ToString() + ", " + reader["country"].ToString();
                    labelContact.Text = "Contact: " + reader["studContactNo"].ToString();
                    labelEmail.Text = "Email: " + reader["emailAddress"].ToString();
                    labelGuardian.Text = "Guardian: " + reader["guardianFirstName"].ToString() + " " + reader["guardianLastName"].ToString();
                    labelHobbies.Text = "Hobbies: " + reader["hobbies"].ToString();
                    labelNickname.Text = "Nickname: " + reader["nickname"].ToString();
                    labelCourse.Text = "Course: " + reader["courseName"].ToString();
                    labelYearLevel.Text = "Year Level: " + reader["yearLvl"].ToString();
                }
                else
                {
                    MessageBox.Show("Student details not found.");
                }
            }
        }
    }
}
