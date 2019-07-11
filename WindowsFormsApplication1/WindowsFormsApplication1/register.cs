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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-85FCCNA\MINU; Integrated Security=true; Initial Catalog=event_management");
            Con.Open();
            if (textBox1.Text != "" && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != "")
            {
                SqlCommand cmd6 = new SqlCommand(@"insert into reg values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "')", Con);
                int x = cmd6.ExecuteNonQuery();
                if (x > 0)
                {
                    MessageBox.Show("Registered Successfully");
                    main m = new main();
                    m.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Not Registered");
                }
            }

            else
            {
                MessageBox.Show("Please fill all the details");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            user_login log = new user_login();
            log.Show();
            this.Hide();
        }
    }
}
