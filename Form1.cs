using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KT_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "";
            label5.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "*";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "-";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "/";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "";
            label5.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string s = label3.Text;
            switch (s)
                {
                case "+":
                    {
                        if (textBox1.Text=="" || textBox2.Text=="")
                        {
                            MessageBox.Show("не заполненно A или B");
                        }
                        else
                        {
                            label5.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)).ToString();
                        }
                        break;
                    }
                case "-":
                    {
                        if (textBox1.Text == "" || textBox2.Text == "")
                        {
                            MessageBox.Show("не заполненно A или B");
                        }
                        else
                        {
                            label5.Text = (Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)).ToString();
                        }
                        break;
                    }
                case "*":
                    {
                        if (textBox1.Text == "" || textBox2.Text == "")
                        {
                            MessageBox.Show("не заполненно A или B");
                        }
                        else
                        {
                            label5.Text = (Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)).ToString();
                        }
                        break;
                    }
                case "/":
                    {
                        if (textBox1.Text == "" || textBox2.Text == "")
                        {
                            MessageBox.Show("не заполненно A или B");
                        }
                        else
                        {
                            if (textBox2.Text == "0")
                            {
                                MessageBox.Show("делить на 0 нельзя");
                                textBox2.Text = "";
                                textBox2.Focus();
                            }
                            else
                            {
                                label5.Text = (Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text)).ToString();
                            }
                        }
                        break;
                    }
                case "√":
                    {
                        if (textBox2.Text == "")
                        {
                            MessageBox.Show("не заполненно B");
                        }
                        else
                        {
                            textBox1.ReadOnly = true;
                            label5.Text = (Math.Sqrt(Convert.ToInt32(textBox2.Text))).ToString();
                        }
                        break;
                    }
                case "округлить":
                    {
                        if (textBox1.Text == "" || textBox2.Text == "")
                        {
                            MessageBox.Show("не заполненно A или B");
                        }
                        else
                        {
                            label5.Text = Convert.ToString(Math.Round(Convert.ToDouble(textBox2.Text),Convert.ToInt32(textBox1.Text)));
                        }
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Выберите операцию");
                        button1.Focus();
                        break;
                    }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label3.Text = "√";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label3.Text = "округлить";
        }
    }
}
