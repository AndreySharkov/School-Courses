using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.button1.Click += new System.EventHandler(this.button1_Click); // Dec to Bin
            this.button2.Click += new System.EventHandler(this.button2_Click); // Dec to Hex

            this.button4.Click += new System.EventHandler(this.button4_Click); // Bin to Dec
            this.button3.Click += new System.EventHandler(this.button3_Click); // Bin to Hex

            this.button6.Click += new System.EventHandler(this.button6_Click); // Hex to Dec
            this.button5.Click += new System.EventHandler(this.button5_Click); // Hex to Bin
        }


        private string ConvertFromBaseTen(long number, int toBase)
        {
            if (number == 0) return "0";
            var digits = new Stack<char>();
            while (number > 0)
            {
                long digit = number % toBase;
                digits.Push(digit < 10 ? (char)('0' + digit) : (char)('A' + digit - 10));
                number /= toBase;
            }
            return new string(digits.ToArray());
        }

        private long ConvertToBaseTen(string number, int fromBase)
        {
            long result = 0;
            long power = 1;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                int digit;
                char currentChar = char.ToUpper(number[i]);
                if (currentChar >= '0' && currentChar <= '9')
                    digit = currentChar - '0';
                else
                    digit = currentChar - 'A' + 10;

                if (digit >= fromBase)
                    throw new ArgumentException("Ivalid Number");

                result += digit * power;
                power *= fromBase;
            }
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (long.TryParse(textBox1.Text, out long decimalNumber))
            {
                DecimalToBinaryLabel.Text = ConvertFromBaseTen(decimalNumber, 2);
            }
            else
            {
                DecimalToBinaryLabel.Text = "Invalid Input";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (long.TryParse(textBox1.Text, out long decimalNumber))
            {
                DecimalToHexLabel.Text = ConvertFromBaseTen(decimalNumber, 16);
            }
            else
            {
                DecimalToHexLabel.Text = "Invalid Input";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                BinaryToDecimalLebel.Text = ConvertToBaseTen(textBox2.Text, 2).ToString();
            }
            catch
            {
                BinaryToDecimalLebel.Text = "Invalid Input";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                long decimalNumber = ConvertToBaseTen(textBox2.Text, 2);
                BinaryToHexLabel.Text = ConvertFromBaseTen(decimalNumber, 16);
            }
            catch
            {
                BinaryToHexLabel.Text = "Invalid Input";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                HexToDecimalLabel.Text = ConvertToBaseTen(textBox3.Text, 16).ToString();
            }
            catch
            {
                HexToDecimalLabel.Text = "Invalid Input";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                long decimalNumber = ConvertToBaseTen(textBox3.Text, 16);
                HexToBinaryLabel.Text = ConvertFromBaseTen(decimalNumber, 2);
            }
            catch
            {
                HexToBinaryLabel.Text = "Invalid Input";
            }
        }
    }
}