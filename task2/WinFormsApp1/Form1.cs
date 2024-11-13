namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string current = "";
        double result = 0;
        string operation = "";
        bool operation_pending = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (operation_pending)
            {
                evaluate();
            }
            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(current);
            current = "";
            operation_pending = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            current += button.Text;
            textBox1.Text = current;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            current += button.Text;
            textBox1.Text = current;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            current += button.Text;
            textBox1.Text = current;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            current += button.Text;
            textBox1.Text = current;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            current += button.Text;
            textBox1.Text = current;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            current += button.Text;
            textBox1.Text = current;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            current += button.Text;
            textBox1.Text = current;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            current += button.Text;
            textBox1.Text = current;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            current += button.Text;
            textBox1.Text = current;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            current += button.Text;
            textBox1.Text = current;
        }

        private void evaluate()
        {
            if (operation_pending)
            {
                double second_num = double.Parse(current);

                switch (operation)
                {
                    case "+":
                        result += second_num;
                        break;
                    case "-":
                        result -= second_num;
                        break;
                    case "*":
                        result *= second_num;
                        break;
                    case "/":
                        if (second_num != 0)
                        {
                            result /= second_num;
                        }
                        else
                        {
                            textBox1.Text = "Error";
                            return;
                        }
                        break;
                }
                textBox1.Text = result.ToString();
                current = "";
                operation_pending = false;

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (operation_pending)
            {
                evaluate();
            }
            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(current);
            current = "";
            operation_pending = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (operation_pending)
            {
                evaluate();
            }
            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(current);
            current = "";
            operation_pending = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (operation_pending)
            {
                evaluate();
            }
            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(current);
            current = "";
            operation_pending = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            evaluate();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            current = "";
            result = 0;
            operation = "";
            operation_pending = false;
            textBox1.Text = "";
        }
    }
}