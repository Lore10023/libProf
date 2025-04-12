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
    public partial class HomeForm1 : UserControl
    {
        private string connection = "server=localhost;database=librarymanagement;uid=root;pwd=programITnou24;";

        public HomeForm1()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    string query = "select * from book";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                    string query2 = "select count(*) from book";
                    using(MySqlCommand cmd = new MySqlCommand(query2, conn))
                    {
                        int nrinregistrari = Convert.ToInt32(cmd.ExecuteScalar());
                        label3.Text = nrinregistrari.ToString();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBook dashboard = new AddBook(this);
            dashboard.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteBook dashboard = new DeleteBook(this);
            dashboard.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchBook dashboard = new SearchBook();
            dashboard.Show();
        }

    }
}
