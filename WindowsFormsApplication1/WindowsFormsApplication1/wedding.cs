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
    public partial class wedding : Form
    {
        public wedding()
        {
            InitializeComponent();
        }

        private void wedding_Load(object sender, EventArgs e)
        {
            label12.Text = DateTime.Now.ToLongTimeString();
            label13.Text = DateTime.Now.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-85FCCNA\MINU; Integrated Security=true; Initial Catalog=event_management");
            Con.Open();
            if (textBox1.Text != "" && textBox1.Text != "" && textBox2.Text != "" && dateTimePicker1.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && comboBox1.Text != "")
            {
                SqlCommand cmd1 = new SqlCommand(@"insert into wedding values('" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + comboBox1.Text + "')", Con);
                int x = cmd1.ExecuteNonQuery();
                if (x > 0)
                {
                    MessageBox.Show("Registered Successfully");

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

        private void button2_Click(object sender, EventArgs e)
        {
            main m = new main();
            m.Show();
            this.Hide();
        }
}
}
    
