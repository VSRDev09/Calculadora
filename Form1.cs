namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int a;
        private int impares=1;
        private int cont;
        private int b;
        private int c;
        private decimal d = 0;
        private decimal f = 0;
        private string ope;

        private void button2_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "+" || resultado.Text == "-" || resultado.Text == "/" || resultado.Text == "x" || resultado.Text == "^")
            {
                resultado.Text = "2";
            }
            else
            {
                resultado.Text = resultado.Text + "2";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "+" || resultado.Text == "-" || resultado.Text == "/" || resultado.Text == "x" || resultado.Text == "^")
            {
                resultado.Text = "1";
            }
            else
            {
                resultado.Text = resultado.Text + "1";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "+" || resultado.Text == "-" || resultado.Text == "/" || resultado.Text == "x" || resultado.Text == "^")
            {
                resultado.Text = "3";
            }
            else
            {
                resultado.Text = resultado.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "+" || resultado.Text == "-" || resultado.Text == "/" || resultado.Text == "x" || resultado.Text == "^")
            {
                resultado.Text = "4";
            }
            else
            {
                resultado.Text = resultado.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "+" || resultado.Text == "-" || resultado.Text == "/" || resultado.Text == "x" || resultado.Text == "^")
            {
                resultado.Text = "5";
            }
            else
            {
                resultado.Text = resultado.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "+" || resultado.Text == "-" || resultado.Text == "/" || resultado.Text == "x" || resultado.Text == "^")
            {
                resultado.Text = "6";
            }
            else
            {
                resultado.Text = resultado.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "+" || resultado.Text == "-" || resultado.Text == "/" || resultado.Text == "x" || resultado.Text == "^")
            {
                resultado.Text = "7";
            }
            else
            {
                resultado.Text = resultado.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "+" || resultado.Text == "-" || resultado.Text == "/" || resultado.Text == "x" || resultado.Text == "^")
            {
                resultado.Text = "8";
            }
            else
            {
                resultado.Text = resultado.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "+" || resultado.Text == "-" || resultado.Text == "/" || resultado.Text == "x" || resultado.Text == "^")
            {
                resultado.Text = "9";
            }
            else
            {
                resultado.Text = resultado.Text + "9";
            }
        }

        private void buttonVirgul_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + ",";
            if (d == 0)
            {
                d = 1;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "+" || resultado.Text == "-" || resultado.Text == "/" || resultado.Text == "x" || resultado.Text == "^")
            {
                resultado.Text = "0";
            }
            else
            {
                resultado.Text = resultado.Text + "0";
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (d == 0)
            {
                b = int.Parse(resultado.Text);
            }
            else
            {
                f = decimal.Parse(resultado.Text);
            }


            switch (ope)
            {
                case "+":
                    if (d == 0)
                    {
                        c = a + b;
                        resultado.Text = c.ToString();

                    }
                    else if (f != 0)
                    {
                        d = d + f;
                        resultado.Text = d.ToString();

                    }
                    else if (f == 0)
                    {
                        d = d + b;
                    }
                    break;


                case "-":
                    if (d == 0)
                    {
                        c = a - b;
                        resultado.Text = c.ToString();
                    }
                    else if (f != 0)
                    {
                        d = d - f;
                        resultado.Text = d.ToString();
                    }
                    else if (f == 0)
                    {
                        d = d - b;
                    }
                    break;


                case "/":
                    if (d == 0)
                    {
                        c = a / b;
                        resultado.Text = c.ToString();
                    }
                    else if (f != 0)
                    {
                        d = d / f;
                        resultado.Text = d.ToString();
                    }
                    else if (f == 0)
                    {
                        d = d / b;
                    }
                    break;


                case "x":
                    if (d == 0)
                    {
                        c = a * b;
                        resultado.Text = c.ToString();
                    }
                    else if (f != 0)
                    {
                        d = d * f;
                        resultado.Text = d.ToString();
                    }
                    else if (f == 0)
                    {
                        d = d * b;
                    }
                    break;

                case "POW":
                    if (d == 0)
                    {
                        c = 1;
                        for (int i = 0; i<b; i++)
                        {
                            c*=a;
                            resultado.Text = c.ToString();
                        }
                       
                    }
                    
                    break;


            }

        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            if (d == 0)
            {
                a = int.Parse(resultado.Text);
                resultado.Text = "x";
                ope = "x";
            }
            else
            {
                d = decimal.Parse(resultado.Text);
                resultado.Text = "x";
                ope = "x";
            }

        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (d == 0)
            {
                a = int.Parse(resultado.Text);
                resultado.Text = "/";
                ope = "/";
            }
            else
            {
                d = decimal.Parse(resultado.Text);
                resultado.Text = "/";
                ope = "/";
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {

            if (d == 0)
            {
                a = int.Parse(resultado.Text);
                resultado.Text = "-";
                ope = "-";
            }
            else
            {
                d = decimal.Parse(resultado.Text);
                resultado.Text = "-";
                ope = "-";
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (d == 0)
            {
                a = int.Parse(resultado.Text);
                resultado.Text = "+";
                ope = "+";
            }
            else
            {
                d = decimal.Parse(resultado.Text);
                resultado.Text = "+";
                ope = "+";
            }
        }

        private void buttonErase_Click(object sender, EventArgs e)
        {
            resultado.Text = "";
            cont = 0;
            impares = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Raiz_Click(object sender, EventArgs e)
        {
            a = int.Parse(resultado.Text);
            
            while (a > 0)
            {
                a -= impares;
                impares += 2;
                cont++;
            }
            
            resultado.Text = cont.ToString();
        }

        private void Power_Click(object sender, EventArgs e)
        {   
                a = int.Parse(resultado.Text);
                resultado.Text = "^";
                ope = "POW";
        }
    }
}
