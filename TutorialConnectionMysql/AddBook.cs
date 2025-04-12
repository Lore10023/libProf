using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace TutorialConnectionMysql
{
    public partial class AddBook : Form
    {
        private string connection = "server=localhost;database=librarymanagement;uid=root;pwd=programITnou24;";
        private HomeForm1 homedashboard;
        public AddBook(HomeForm1 home)
        {
            InitializeComponent();
            homedashboard = home;
        }

        public void btnAdding_Click(object sender, EventArgs e)
        {
            string title = titlutextbox.Text;
            string author = autortextBox.Text;
            string genre = gentextBox.Text;
            int public_year = int.Parse(yeartextBox.Text);
            int quantity = int.Parse(quantitytextBox.Text);

            using(MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();

                string query = "insert into book (title,author,genre,publicationYear,quantity) values (@title,@author,@genre,@public_year,@quantity)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@title",title);
                cmd.Parameters.AddWithValue("@author", author);
                cmd.Parameters.AddWithValue("@genre", genre);
                cmd.Parameters.AddWithValue("@public_year", public_year);
                cmd.Parameters.AddWithValue("@quantity", quantity);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Book added succesfully!");
                    this.Hide();
                }
                else {
                    MessageBox.Show("Faild to add book!");
                }

            }

            homedashboard.LoadData();
        } 
    }
}
