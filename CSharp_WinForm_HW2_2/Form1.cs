
namespace CSharp_WinForm_HW2_2
{
    public partial class Form1 : Form
    {
        static double number1;
        static double number2;
        static double sum;
        static string? sum2;
        static string? c;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Num0_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
                label1.Text += "0";
        }

        private void Num1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = "";
            label1.Text += "1";
        }
        private void Num2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = "";
            label1.Text += "2";
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = "";
            label1.Text += "3";
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = "";
            label1.Text += "4";
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = "";
            label1.Text += "5";
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = "";
            label1.Text += "6";
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = "";
            label1.Text += "7";
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = "";
            label1.Text += "8";
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = "";
            label1.Text += "9";
        }
        private void Point_Click(object sender, EventArgs e)
        {
            var count = label1.Text.Count(s => s == '.');
            if (count != 1)
                label1.Text += ".";
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "0";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Plus_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = label1.Text;
                number1 = Convert.ToDouble(label2.Text);
                label1.Text = null;
                c = "+";
            }
            catch
            {
                MessageBox.Show("Wrong");
                label1.Text = "0";
                label2.Text = "0";
            }
        }
        private void Minus_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = label1.Text;
                number1 = Convert.ToDouble(label2.Text);
                label1.Text = null;
                c = "-";
            }
            catch
            {
                MessageBox.Show("Wrong");
                label1.Text = "0";
                label2.Text = "0";
            }
        }
        private void Times_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = label1.Text;
                number1 = Convert.ToDouble(label2.Text);
                label1.Text = null;
                c = "*";
            }
            catch
            {
                MessageBox.Show("Wrong");
                label1.Text = "0";
                label2.Text = "0";
            }
        }
        private void Divide_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = label1.Text;
                number1 = Convert.ToDouble(label2.Text);
                label1.Text = null;
                c = "/";
            }
            catch
            {
                MessageBox.Show("Wrong");
                label1.Text = "0";
                label2.Text = "0";
            }
        }
        private void Equal_Click(object sender, EventArgs e)
        {
            if (c == "+")
            {
                number2 = Convert.ToDouble(label1.Text);
                sum = number1 + number2;
            }
            else if (c == "-")
            {
                number2 = Convert.ToDouble(label1.Text);
                sum = number1 - number2;
            }
            else if (c == "*")
            {
                number2 = Convert.ToDouble(label1.Text);
                sum = number1 * number2;
            }
            else if (c == "/")
            {
                number2 = Convert.ToDouble(label1.Text);
                sum = number1 / number2;
            }
            sum2 = Convert.ToString(sum);
            label1.Text = null;
            label1.Text = sum2;
        }
    }
}