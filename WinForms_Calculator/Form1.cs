namespace WinForms_Calculator
{
    public partial class Form1 : Form
    {

        string currentInput = "";
        double result = 0;
        string operation = "";
        bool operationPending = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput = button.Text;
            textBox1.Text = currentInput;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput = button.Text;
            textBox1.Text = currentInput;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput = button.Text;
            textBox1.Text = currentInput;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput = button.Text;
            textBox1.Text = currentInput;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput = button.Text;
            textBox1.Text = currentInput;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput = button.Text;
            textBox1.Text = currentInput;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput = button.Text;
            textBox1.Text = currentInput;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput = button.Text;
            textBox1.Text = currentInput;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput = button.Text;
            textBox1.Text = currentInput;
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput = button.Text;
            textBox1.Text = currentInput;
        }

        private void Evaluate()
        {
            if (operationPending)
            {
                double secondNumber = double.Parse(currentInput);

                switch (operation)
                {
                    case "+":
                        result += secondNumber;
                        break;
                    case "-":
                        result -= secondNumber;
                        result += secondNumber;
                        break;
                    case "*":
                        result *= secondNumber;
                        break;
                    case "/":
                        if (secondNumber != 0)
                        {
                            result /= secondNumber;
                        }
                        else
                        {
                            textBox1.Text = "Error";
                            return;
                        }
                        break;
                }

                textBox1.Text = result.ToString();
                currentInput = "";
                operationPending = false;
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Evaluate();
            }
            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Evaluate();
            }
            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Evaluate();
            }
            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Evaluate();
            }
            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
                Evaluate();
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            currentInput = "";
            result = 0;
            operation = "";
            operationPending = false;
            textBox1.Text = "";
        }
    }
}
