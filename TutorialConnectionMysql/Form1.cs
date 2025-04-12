using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace TutorialConnectionMysql
{
    public partial class Form1 : Form
    {
        private string connection = "server=localhost;database=librarymanagement;uid=root;pwd=programITnou24;";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string email = textBox2.Text;
            string password = textBox3.Text;

            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                // Open the connection to the MySQL database
                conn.Open();
                string user=VerifyUser(conn,name,email,password);

                if(user == "admin")
                {
                    AdminDasboard dasboard = new AdminDasboard(name);
                    this.Hide();
                    dasboard.Show();
                }else if(user == "studAuthentification")
                {
                    StudentDashboard dashboard = new StudentDashboard(name);
                    this.Hide();
                    dashboard.Show();
                }else if(user == "studNeedsApprovement")
                {
                    MessageBox.Show("You need an approvement from the librarian!\nPlease try again after you receive it:)");
                }   
                
            }
        }

        static string VerifyUser(MySqlConnection conn, string name, string email, string password)
        {
            string adminQuery = "Select * From adminuser WHERE Username=@name AND PasswordAdmin=@password AND Email=@email";
            using (MySqlCommand admincmd = new MySqlCommand(adminQuery, conn))
            {
                admincmd.Parameters.AddWithValue("@name", name);
                admincmd.Parameters.AddWithValue("@password", password);
                admincmd.Parameters.AddWithValue("@email", email);

                using (MySqlDataReader adminreader = admincmd.ExecuteReader())
                {
                    if (adminreader.HasRows)
                    {
                        return "admin";
                    }
                }
            }

            

            string stdExist = "Select * from student where Name=@name and Email=@email and PasswordStudent=@password";
            using(MySqlCommand stdcomd = new MySqlCommand(stdExist, conn))
            {
                stdcomd.Parameters.AddWithValue("@name", name);
                stdcomd.Parameters.AddWithValue("@email", email);
                stdcomd.Parameters.AddWithValue("@password", password);
                using (MySqlDataReader stdreader = stdcomd.ExecuteReader()) {
                    if (!stdreader.HasRows)
                    {
                        stdreader.Close();
                        AddStudents(conn, name, password, email);
                    }
                }
            }

            string studentQuery = "Select IsApproved from student where Name=@name and Email=@email and PasswordStudent=@password";
            using (MySqlCommand studentcmd = new MySqlCommand(studentQuery, conn))
            {
                studentcmd.Parameters.AddWithValue("@name", name);
                studentcmd.Parameters.AddWithValue("@email", email);
                studentcmd.Parameters.AddWithValue("@password", password);

                using (MySqlDataReader studentreader = studentcmd.ExecuteReader())
                {
                    if (studentreader.Read())
                    {
                        bool status = studentreader.GetBoolean(0);
                        return status ? "studAuthentification" : "studNeedsApprovement";
                    }
                }
            }
            return "notFound";
        }

        static void AddStudents(MySqlConnection con, string name, string password, string email)
        {
            string query = "Insert into student (name,email,passwordstudent) values (@name,@email,@password)";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);

            cmd.ExecuteNonQuery();
        }

        private void UseSystemPasswordChar_CheckedChange(object sender, EventArgs e)
        {
            //textBox3.UseSystemPasswordChar= checkBox1.Checked;
            textBox3.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }
    }

   
    }
