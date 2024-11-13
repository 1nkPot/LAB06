namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string CalculateSquares()
        {

            string results = "Number | Square\r\n";
            results += "------------------\r\n"; 

            
            for (int i = 1; i <= 10; i++)
            {
                int square = i * i;

                
                results += $"{i,6} | {square,6}\r\n"; 
            }

            return results;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = CalculateSquares();
        }
    }
}
