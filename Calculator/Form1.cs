

using Microsoft.VisualBasic;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char ch;
        double firstNumber, SecoundNumber;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)

        {


            textBox1.Text += "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            textBox1.Font = new System.Drawing.Font("Arial Unicode MS", 12f);
            string s = "√";
            textBox1.Text = s + x + " =" + Math.Sqrt(x) + "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text += "^";
            ch = '^';

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
            ch = '+';

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (ch == '+')
            {

                string[] s = textBox1.Text.Split('+');
                firstNumber = double.Parse(s[0]);

                SecoundNumber = double.Parse(s[1]);
                textBox1.Text = (firstNumber + SecoundNumber) + "";
            }
            else if (ch == '-')
            {

                string[] s = textBox1.Text.Split('-');
                firstNumber = double.Parse(s[0]);

                SecoundNumber = double.Parse(s[1]);
                textBox1.Text = (firstNumber - SecoundNumber) + "";
            }
            else if (ch == '*')
            {

                string[] s = textBox1.Text.Split('*');
                firstNumber = double.Parse(s[0]);

                SecoundNumber = double.Parse(s[1]);
                textBox1.Text = (firstNumber * SecoundNumber) + "";
            }
            else if (ch == '/')
            {

                string[] s = textBox1.Text.Split('/');
                firstNumber = double.Parse(s[0]);

                SecoundNumber = double.Parse(s[1]);
                textBox1.Text = (firstNumber / SecoundNumber) + "";
            }
            else if (ch == '^')
            {

                string[] s = textBox1.Text.Split('^');
                firstNumber = double.Parse(s[0]);

                SecoundNumber = double.Parse(s[1]);
                double x = Math.Pow(firstNumber, SecoundNumber);
                textBox1.Text = x + "";
            }

            else if (textBox1.Text.StartsWith('s'))
            { 
                int startIndex = textBox1.Text.IndexOf('(') + 1;
                int endIndex = textBox1.Text.IndexOf(')', startIndex);

                string numberStr = textBox1.Text.Substring(startIndex, endIndex - startIndex);

               
                double number = double.Parse(numberStr);
                double radians = number * Math.PI / 180;

                textBox1.Text = "" + Math.Sin(radians);

            }

            else if (textBox1.Text.StartsWith('c'))
            {
                int startIndex = textBox1.Text.IndexOf('(') + 1;
                int endIndex = textBox1.Text.IndexOf(')', startIndex);

                string numberStr = textBox1.Text.Substring(startIndex, endIndex - startIndex);


                double number = double.Parse(numberStr);
                

                textBox1.Text = "" + Math.Cos(number);

            }
            else if (textBox1.Text.StartsWith('t'))
            {
                int startIndex = textBox1.Text.IndexOf('(') + 1;
                int endIndex = textBox1.Text.IndexOf(')', startIndex);

                string numberStr = textBox1.Text.Substring(startIndex, endIndex - startIndex);


                double number = double.Parse(numberStr);
              

                textBox1.Text = "" + Math.Tan(number);

            }

            else
            {
                textBox1.Text = string.Empty;
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
            ch = '-';
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
            ch = '*';
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
            ch = '/';
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3.14159265";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);

            if (x < 0)
            {
                textBox1.Text = "0";
            }
            else if (x == 1 || x == 0)
            {
                textBox1.Text = "1";
            }
            else
            {
                double fac = 1;
                for (int i = 2; i < x + 1; i++)
                {
                    fac *= i;
                }
                textBox1.Text = fac + "";

            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double y = Convert.ToDouble(textBox1.Text);
            double resultlog = Math.Log10((double)y);
            textBox1.Text = resultlog.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double ex = Math.E;
            textBox1.Text = ex.ToString();

        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text += "%";
            string[] s = textBox1.Text.Split('%');
            double x = Convert.ToDouble(s[0]);
            textBox1.Text = (x / 100f) + "";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "sin(";
            }
            else
            {
                textBox1.Text += "sin(";
            }
            

         
            
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "cos(";
            }
            else
            {
                textBox1.Text += "cos(";
            }

        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "tan(";
            }
            else
            {
                textBox1.Text += "tan(";
            }

        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox1.Text += ")";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            double ln = Convert.ToDouble(textBox1.Text);
            textBox1.Text = (Math.Log(ln)) + "";
        }
    
    }
}
