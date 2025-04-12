using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutorialConnectionMysql
{
    public partial class DeleteStudent : Form
    {
        private string connection = "server=localhost;database=librarymanagement;uid=root;pwd=programITnou24;";
        private StudentsForm studentsForm;
        public DeleteStudent(StudentsForm stdform)
        {
            InitializeComponent();
            studentsForm = stdform;
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(studenttextBox.Text);

            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();

                string query = "delete from student where StudentId=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", Id);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Student deleted succesfully!");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Faild to delete the student!");
                }
            }
            studentsForm.LoadDataTrue();

        }
    }
}
