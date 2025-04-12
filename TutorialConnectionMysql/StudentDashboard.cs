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
    public partial class StudentDashboard : Form
    {
        public StudentDashboard(String name)
        {
            InitializeComponent();
            namelabel.Text = name;
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
        }

        private void Borrowbutton_Click(object sender, EventArgs e)
        {
            BorrowedBookscs borrowedBookscs = new BorrowedBookscs();
            borrowedBookscs.ShowDialog();
        }
    }
}
