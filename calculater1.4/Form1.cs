using static calculater1._4.operation_class;
using static System.Object;

namespace calculater1._4
{
    public partial class Form1 : Form
    {
        
        //Call the class and define the variables we will need
        Calculator calculator = new Calculator();
        double firstNumber;
        double secondNumber;
        string operation;

        //minimaized and close buttons
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimaized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Delete previous operation button
        private void clear_Click(object sender, EventArgs e)
        {
            label1.Text = null;
            label2.Text = null;
        }
        //Buttons for mathematical operationsButtons for mathematical operations
        private void divesion_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(label1.Text);
            operation = "Divide";
            label2.Text = label1.Text + "/";
            label1.Text = "";
        }
        private void add_Click(object sender, EventArgs e)
        {

            firstNumber = Convert.ToDouble(label1.Text);
            operation = "Add";
            label2.Text = label1.Text + "+";
            label1.Text = "";

        }

        private void multiply_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(label1.Text);
            operation = "Multiply";
            label2.Text = label1.Text + "x";
            label1.Text = "";
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(label1.Text);
            operation = "Subtract";
            label2.Text = label1.Text + "-";
            label1.Text = "";
        }

        private void percent_Click(object sender, EventArgs e)
        {
             firstNumber = Convert.ToDouble(label1.Text);
            operation = "Percentage";
            label2.Text = label1.Text + "%";
            label1.Text = "";
        }

        private void equel_Click(object sender, EventArgs e)
        {
            secondNumber = Convert.ToDouble(label1.Text);
            label2.Text = label2.Text + label1.Text;

            label1.Text = "";

            switch (operation)
            {
                case "Add":
                    label1.Text = Convert.ToString(calculator.Add(firstNumber, secondNumber));
                    break;
                case "Subtract":
                    label1.Text = Convert.ToString(calculator.Subtract(firstNumber, secondNumber));

                    break;
                case "Multiply":
                    label1.Text = Convert.ToString(calculator.Multiply(firstNumber, secondNumber));

                    break;
                case "Divide":
                    label1.Text = Convert.ToString(calculator.Divide(firstNumber, secondNumber));

                    break;
                case "Percentage":
                    label1.Text = Convert.ToString(calculator.Percentage(firstNumber, secondNumber));

                    break;

                   

            }
        }

        //Number entry buttons
        private void number1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + 1;
        }

        private void number2_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + 2;
        }

        private void number3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + 3;
        }

        private void number4_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + 4;
        }

        private void number5_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + 5;
        }

        private void number6_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + 6;
        }

        private void number7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + 7;
        }

        private void number8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + 8;
        }

        private void number9_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + 9;
        }

        private void number0_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + 0;
        }

        private void doted_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + ".";
        }
        //Side additions
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = null;
            label2.Text = null;
            MessageBox.Show("Thank you for your efforts in educating us on this article I hope that this work will please you and will please you", "welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
