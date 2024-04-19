using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace megaCalculator
{
    public partial class mainWnd : Form
    {
        double a, b, c, d, f;
        char znak;
        double power;

        public mainWnd()
        {
            InitializeComponent();
        }

        private void mainWnd_Load(object sender, EventArgs e)
        {
            this.AcceptButton = ravno;
        }

        private void tBox_TextChanged(object sender, EventArgs e)
        {
            tBox.Focus();
            tBox.SelectionStart = tBox.Text.Length;

            if (tBox.Text == "" && line.Text != "")
            {
                tBox.Text = line.Text;
                line.Text = "";

            }
            //пиздец...

            if (tBox.Text == "0-")
            {
                tBox.Text = "-";
            }

            else if (tBox.Text == "0√")
            {
                tBox.Text = "√";
            }

            else if(tBox.Text == "0")
            {
                tBox.Text += "!";
            } 

            if (tBox.Text == "0+" || tBox.Text == "0/" || tBox.Text == "0*" || tBox.Text == "0^" || tBox.Text == "!") // этот кейс не оптимизируй умник
            {
                tBox.Text = "";
            }
        }


        void calculations()
        {
            if (znak == '!' || znak == '√')
            {
                tBox.Text = tBox.Text + znak;
            }
            else
            {
                try
                {
                    a = Convert.ToInt32(tBox.Text);
                }
                catch (Exception ex) {}
                tBox.Text = a.ToString() + znak;
            }
        }


        private void clean_Click(object sender, EventArgs e)
        {
            line.Text = "";
            tBox.Text = "";
            c = b = a = d = f = 0;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            znak = '+';
            calculations();
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            znak = '*';
            calculations();
        }

        private void factorial_Click(object sender, EventArgs e)
        {
            znak = '!';
            calculations();
        }

        private void degree_Click(object sender, EventArgs e)
        {
            znak = '^';
            calculations();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            znak = '/';
            calculations();
        }

        private void root_Click(object sender, EventArgs e)
        {
            znak = '√';
            calculations();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (tBox == null)
            {
                tBox.Text = "-";
            }

            znak = '-';
            calculations();
        }


        private void ravno_Click(object sender, EventArgs e)
        {
            int factorial = 1;
            string numStr;

            if(tBox.Text == "")
            {
                return;
            }

            string expression = tBox.Text; //получаю выражение из tBox
            int _znak = expression.IndexOf(znak); //ищу индекс знака


            if (znak == '!' )
            {
                numStr = expression.Substring(0, _znak).Trim();
            }
            else
            {
                numStr = expression.Substring(_znak + 1).Trim();
            }

            double value = int.Parse(numStr); //присваиваю число переменной

            if (znak == '√' || znak == '!')
            {
                d = value;
            }
            else if(znak == '^')
            {
                power = value;
            }
            else b = value;

            switch (znak)
            {
                case '+': c = a + b; break;
                case '-': c = a - b; break;
                case '*': c = a * b; break;
                case '/': c = a / b; break;

                case '√':
                    f = Math.Sqrt(d);
                break;

                case '!':
                    for (int i = 1; i <= d; i++)
                    {
                        factorial *= i;
                    }
                break;

                case '^':
                    d = Math.Pow(a, power);
                break;
            }


            if (znak == '!')
            {
                line.Text = d.ToString() + znak;
                tBox.Text = factorial.ToString();
            }
            else if (znak == '√')
            {
                line.Text = znak + d.ToString();
                tBox.Text = f.ToString();
            }
            else if(znak == '^')
            {
                line.Text = a.ToString() + znak + power;
                tBox.Text = d.ToString();
            }
            else
            {
                line.Text = a.ToString() + znak + b.ToString();
                tBox.Text = c.ToString();
            }
        }
    }
}