namespace kalkulator_3
{
    public partial class Form1 : Form
    {
        private string firstValue;
        private string secondValue;
        private string operation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void numberClick(object sender, EventArgs e)
        {
            var clickedValue = (sender as Button).Text;
            textBox1.Text += clickedValue;
            if (operation!="")
            {
                secondValue += clickedValue;
            }
        }

        private void operationClick(object sender, EventArgs e)
        {
            operation = (sender as Button).Text;
            firstValue = textBox1.Text;
            textBox1.Text += operation;
        }

        private void clearClick(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            firstValue = string.Empty;
            secondValue = string.Empty;
            operation = "";
        }

        private void resultClick(object sender, EventArgs e)
        {
            var firstNumber = double.Parse(firstValue);
            var secondNumber = double.Parse(secondValue);

            var result = 0d;
            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("Nie dziel przez zero cholero");
                        result = 0;
                        break;
                    }
                    else
                    {
                        result = firstNumber / secondNumber;
                        break;
                    }
                   
            }
            textBox1.Text = result.ToString();
            firstValue = string.Empty;
            secondValue=string.Empty;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}