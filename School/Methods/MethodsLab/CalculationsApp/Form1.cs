namespace CalculationsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedItem = "add";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Evaluate();
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Evaluate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Evaluate();
        }
        private void Evaluate()
        {

            string selectedItem = comboBox1.SelectedItem.ToString();
            decimal value1 = numericUpDown1.Value;
            decimal value2 = numericUpDown2.Value;
            if (selectedItem == "add")
            {
                label4.Text = (value1 + value2).ToString();
            }
            else if (selectedItem == "subtrack")
            {
                label4.Text = (value1 - value2).ToString();
            }
            else if (selectedItem == "multiply")
            {
                label4.Text = (value1 * value2).ToString();
            }
            else if (selectedItem == "divide")
            {
                label4.Text = (value1 / value2).ToString();
            }
        }


    }
}
