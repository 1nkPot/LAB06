namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double fahrenheit;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             fahrenheit = double.Parse(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            textBox2.Text = celsius.ToString("F2");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
