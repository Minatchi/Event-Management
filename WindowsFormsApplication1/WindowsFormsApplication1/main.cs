using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            birthday bd = new birthday();
            bd.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fam_reunion fam = new fam_reunion();
            fam.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new_year nw = new new_year();
            nw.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            musical_concert mc = new musical_concert();
            mc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            wedding wd = new wedding();
            wd.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            baby_shower bs = new baby_shower();
            bs.Show();
        }
    }
}
