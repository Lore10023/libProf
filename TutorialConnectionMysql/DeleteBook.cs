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
    public partial class DeleteBook : Form
    {
        private string connection = "server=localhost;database=librarymanagement;uid=root;pwd=programITnou24;";
        private HomeForm1 homedashboard;
        public DeleteBook(HomeForm1 home)
        {
            InitializeComponent();
            homedashboard = home;
        }

        private void btnDelete_Click(object sender, EventArgs e) { 

            int Id = int.Parse(bookIdtextBox.Text);

            using (MySqlConnection conn = new MySqlConnection(connection)) {
                conn.Open();

                string query = "delete from book where bookId=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", Id);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Book deleted succesfully!");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Faild to delete the book!");
                }
            }
            homedashboard.LoadData();
            
        }
    }
}
