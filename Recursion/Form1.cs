using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recursion
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFibonacci_Click(object sender, EventArgs e)
        {
            int n, i = 1, c;
            n = Convert.ToInt16(txtBoxFibonacci.Text);
            
            for (c = 1; c <= n; c++)
            {
                int result = FibonacciFunction(i);
                lblResultFibonacci.Text = result.ToString();
                i++;
            }
        }
        public static int FibonacciFunction(int n)
        {
            if (n < 1)
            {
                return 0;
            }
            else if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return (FibonacciFunction(n - 2) + FibonacciFunction(n - 1));
            }
        }


        private void btnFactorial_Click(object sender, EventArgs e)
        {
            int n;
            n = int.Parse(txtBoxFactorial.Text);
            long fact = Factorial(n);
            lblResultFactorial.Text = Factorial(n).ToString();
        }
        public int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * Factorial(n - 1);

        }
    }
}
