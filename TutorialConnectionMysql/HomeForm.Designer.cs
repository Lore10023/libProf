namespace TutorialConnectionMysql
{
    partial class HomeForm1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label5 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            adaugare = new Button();
            search = new Button();
            delete = new Button();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(21, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 156);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(507, 44);
            label5.Name = "label5";
            label5.Size = new Size(121, 43);
            label5.TabIndex = 3;
            label5.Text = "HOME";
            // 
            // panel3
            // 
            panel3.BackColor = Color.RosyBrown;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(844, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(206, 121);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(89, 75);
            label3.Name = "label3";
            label3.Size = new Size(21, 23);
            label3.TabIndex = 1;
            label3.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(37, 29);
            label4.Name = "label4";
            label4.Size = new Size(141, 23);
            label4.TabIndex = 0;
            label4.Text = "Books Number";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RosyBrown;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(92, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(206, 121);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(89, 75);
            label2.Name = "label2";
            label2.Size = new Size(21, 23);
            label2.TabIndex = 1;
            label2.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 29);
            label1.Name = "label1";
            label1.Size = new Size(168, 23);
            label1.TabIndex = 0;
            label1.Text = "Enrolled Students";
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridView1);
            panel4.Location = new Point(21, 207);
            panel4.Name = "panel4";
            panel4.Size = new Size(1100, 454);
            panel4.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.RosyBrown;
            dataGridViewCellStyle4.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.GridColor = Color.DarkGray;
            dataGridView1.Location = new Point(15, 15);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.RosyBrown;
            dataGridViewCellStyle6.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1059, 417);
            dataGridView1.TabIndex = 0;
            // 
            // adaugare
            // 
            adaugare.BackColor = Color.RosyBrown;
            adaugare.Cursor = Cursors.Hand;
            adaugare.FlatStyle = FlatStyle.Popup;
            adaugare.Font = new Font("Cambria", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            adaugare.ForeColor = Color.White;
            adaugare.Location = new Point(21, 683);
            adaugare.Name = "adaugare";
            adaugare.Size = new Size(298, 71);
            adaugare.TabIndex = 5;
            adaugare.Text = "Add Book";
            adaugare.UseVisualStyleBackColor = false;
            adaugare.Click += btnAdd_Click;
            // 
            // search
            // 
            search.BackColor = Color.RosyBrown;
            search.Cursor = Cursors.Hand;
            search.FlatStyle = FlatStyle.Popup;
            search.Font = new Font("Cambria", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            search.ForeColor = Color.White;
            search.Location = new Point(426, 683);
            search.Name = "search";
            search.Size = new Size(298, 71);
            search.TabIndex = 6;
            search.Text = "Search Book";
            search.UseVisualStyleBackColor = false;
            search.Click += btnSearch_Click;
            // 
            // delete
            // 
            delete.BackColor = Color.RosyBrown;
            delete.Cursor = Cursors.Hand;
            delete.FlatStyle = FlatStyle.Popup;
            delete.Font = new Font("Cambria", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            delete.ForeColor = Color.White;
            delete.Location = new Point(823, 683);
            delete.Name = "delete";
            delete.Size = new Size(298, 71);
            delete.TabIndex = 7;
            delete.Text = "Delete Book";
            delete.UseVisualStyleBackColor = false;
            delete.Click += btnDelete_Click;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // HomeForm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(delete);
            Controls.Add(search);
            Controls.Add(adaugare);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "HomeForm1";
            Size = new Size(1155, 770);
            Load += HomeForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label5;
        private Panel panel3;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private Panel panel4;
        private Button adaugare;
        private Button search;
        private Button delete;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private DataGridView dataGridView1;
    }
}
