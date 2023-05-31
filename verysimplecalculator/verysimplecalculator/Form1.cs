using System.Data;

namespace verysimplecalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float num1 = Convert.ToSingle(textBox1.Text);
                float num2 = Convert.ToSingle(textBox2.Text);
                textBox3.Text = (num1 + num2).ToString();
            }
            catch
            {
                MessageBox.Show("Enter only numeric number");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                float num1 = Convert.ToSingle(textBox1.Text);
                float num2 = Convert.ToSingle(textBox2.Text);
                textBox3.Text = (num1 - num2).ToString();
            }
            catch
            {
                MessageBox.Show("Enter only numeric number");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                float num1 = Convert.ToSingle(textBox1.Text);
                float num2 = Convert.ToSingle(textBox2.Text);
                textBox3.Text = (num1 * num2).ToString();
            }
            catch 
            {
                MessageBox.Show("Enter only numeric number");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                float num1 = Convert.ToSingle(textBox1.Text);
                float num2 = Convert.ToSingle(textBox2.Text);
                textBox3.Text = (num1 / num2).ToString();
            }
            catch
            {
                MessageBox.Show("Enter only numeric number");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}