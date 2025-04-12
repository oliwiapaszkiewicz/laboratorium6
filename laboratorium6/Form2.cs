using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace laboratorium6
{

    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();
            this.Load += Form2_Load;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = 3;
            numericUpDown1.Maximum = 10;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown2.Minimum = 3;
            numericUpDown2.Maximum = 10;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

            numericUpDown3.Minimum = 1;
            numericUpDown3.Maximum = 5;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {


            numericUpDown4.Minimum = 1;
            numericUpDown4.Maximum = 3;
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

            numericUpDown5.Minimum = 0;
            numericUpDown5.Maximum = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = (int)numericUpDown1.Value;
            int y = (int)numericUpDown2.Value;
            int czas = (int)numericUpDown6.Value;
            int dydelfy = (int)numericUpDown3.Value;
            int szopy = (int)numericUpDown4.Value;
            int krokodyle = (int)numericUpDown5.Value;         
            Form3 gra = new Form3(x, y, dydelfy, krokodyle, szopy, czas);
            gra.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown5.Minimum = 10;
            numericUpDown5.Maximum = 60;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
