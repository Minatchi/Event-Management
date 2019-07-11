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
    public partial class user_login : Form
    {
        public user_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-85FCCNA\MINU; Integrated Security=true; Initial Catalog=event_management");
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select * from reg WHERE uname='"+textBox1.Text+"' and pass='"+textBox2.Text+"' ",Con);
            SqlDataReader dr = cmd.ExecuteReader();
            //String a = textBox1.Text;
            //String b = textBox2.Text;
            if (dr.HasRows)
            {
                MessageBox.Show("Success");
                main m = new main();
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Failed");
            }
                    

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register reg = new register();
            reg.Show();
            this.Hide();
        }
    }
}
