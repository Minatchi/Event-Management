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
    public partial class fam_reunion : Form
    {
        public fam_reunion()
        {
            InitializeComponent();
        }

        private void fam_reunion_Load(object sender, EventArgs e)
        {
            label12.Text = DateTime.Now.ToLongTimeString();
            label13.Text = DateTime.Now.ToLongDateString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-85FCCNA\MINU; Integrated Security=true; Initial Catalog=event_management");
            Con.Open();
            if (textBox1.Text != "" && textBox1.Text != "" && textBox2.Text != "" && dateTimePicker1.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && comboBox1.Text != "")
            {
                SqlCommand cmd4 = new SqlCommand(@"insert into fam_reunion values('" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + comboBox1.Text + "')", Con);
                int x = cmd4.ExecuteNonQuery();
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
