using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class admin_login : Form
    {
        public admin_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String a = textBox1.Text;
            String b = textBox2.Text;
            if ((a == "admin") && (b == "dotnet"))
            {
                MessageBox.Show("Success");
                data_view data = new data_view();
                data.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }
    }
}
