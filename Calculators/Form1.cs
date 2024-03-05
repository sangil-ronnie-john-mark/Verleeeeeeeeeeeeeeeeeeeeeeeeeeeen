using System.Security.Cryptography.X509Certificates;

namespace Calculators
{

    public partial class Form1 : Form
    {


        public Form1()
        {


            InitializeComponent();
        }
        private double fnum;
        private String ope;
        private void operators(String op)
        {
            lblNumber.Text = string.Empty;
            ope = op;
        }
        private void number(String number)
        {
            lblNumber.Text = lblNumber.Text + number;
        }
        private void guna2CircleButton16_Click(object sender, EventArgs e)
        {
            number("1");
        }

        private void guna2CircleButton15_Click(object sender, EventArgs e)
        {
            number("2");
        }

        private void guna2CircleButton14_Click(object sender, EventArgs e)
        {
            number("3");
        }

        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            number("4");
        }

        private void guna2CircleButton6_Click(object sender, EventArgs e)
        {
            number("5");
        }

        private void guna2CircleButton7_Click(object sender, EventArgs e)
        {
            number("6");
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            number("7");
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            number("8");
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            number("9");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            number("0");
        }

        private void guna2CircleButton11_Click(object sender, EventArgs e)
        {
            fnum = double.Parse(lblNumber.Text);
            operators("+");

        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            switch (ope)
            {
                case "+":
                    lblNumber.Text = (double.Parse(lblNumber.Text) + fnum).ToString();
                    break;
                case "-":
                    lblNumber.Text = (fnum - double.Parse(lblNumber.Text)).ToString();
                    break;

                case "*":
                    lblNumber.Text = (double.Parse(lblNumber.Text) * fnum).ToString();
                    break;

                case "/":
                    lblNumber.Text = (fnum / double.Parse(lblNumber.Text)).ToString();
                    break;

            }
        }

        private void guna2CircleButton9_Click(object sender, EventArgs e)
        {
            fnum = double.Parse(lblNumber.Text);
            operators("-");
        }

        private void guna2CircleButton8_Click(object sender, EventArgs e)
        {
            fnum = double.Parse(lblNumber.Text);
            operators("*");
        }

        private void guna2CircleButton12_Click(object sender, EventArgs e)
        {
            fnum = double.Parse(lblNumber.Text);
            operators("/");
        }

        private void guna2CircleButton18_Click(object sender, EventArgs e)
        {
            lblNumber.Text = null;
            ope = "";
            fnum = 0;
        }

        private void guna2CircleButton17_Click(object sender, EventArgs e)
        {
            if (lblNumber.Text.Contains("-"))
            {
                double num = double.Parse(lblNumber.Text);
                num = num * -1;
                lblNumber.Text = num.ToString();
            }
            else
            {
                lblNumber.Text = "-" + lblNumber.Text;
            }

        }

        private void guna2CircleButton13_Click(object sender, EventArgs e)
        {
            double num = double.Parse(lblNumber.Text);
            num = num / 100;
            lblNumber.Text = num.ToString();
        }
    }
}
