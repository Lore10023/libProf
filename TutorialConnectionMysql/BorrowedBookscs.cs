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
    public partial class BorrowedBookscs : Form
    {
        private string connection = "server=localhost;database=librarymanagement;uid=root;pwd=programITnou24;";
        public BorrowedBookscs()
        {
            InitializeComponent();
        }

        //public void LoadBooksAvailable()
        //{
        //    using (MySqlConnection conn = new MySqlConnection(connection))
        //    {
        //        conn.Open();
        //        if(comboBox1.Text == "All")
        //        {
        //            string query = "select * from book";
        //            using(MySqlCommand cmd = new MySqlCommand(query,conn))
        //            {

        //            }
        //        }
        //    }
        //}

        private void previousbutton_Click(object sender, EventArgs e)
        {
            //StudentDashboard dashboard = new StudentDashboard();
            this.Hide();
            //dashboard.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadData()
        {

        }

        private void BorrowedBookscs_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
