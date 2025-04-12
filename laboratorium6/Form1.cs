namespace laboratorium6
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 start = new Form2();
            start.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 start = new Form2();
            start.Show();
        }
    }
}
