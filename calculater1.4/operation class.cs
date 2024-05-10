using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculater1._4
{
    internal class operation_class
    {
        // operations class code
        public class Calculator
        {
            public double Add(double a, double b)
            {
                return a + b;
            }

            public double Subtract(double a, double b)
            {
                return a - b;
            }

            public double Multiply(double a, double b)
            {
                return a * b;
            }

            public double Divide(double a, double b)
            {

                return a / b;
            }
            public double Percentage(double total, double part)
            {
                if (total == 0)
                {
                    MessageBox.Show("The percentage cannot be obtained from zeroThe percentage cannot be obtained from zero",
                        "ERROR" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }

                return (part / total) * 100;
            }
        }

    }
}