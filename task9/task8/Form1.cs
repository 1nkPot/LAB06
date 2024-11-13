namespace task8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.MaxLength = 160;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int maxLength = textBox1.MaxLength;
            int currentLength = textBox1.Text.Length;
            int charactersLeft = maxLength - currentLength;

            MessageBox.Show($"You entered: {textBox1.Text}\nCharacters left: {charactersLeft}", "Input Text");
        }
    }
}
