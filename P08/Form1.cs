using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string chain = textBox1.Text;
                chain = chain.TrimEnd();
                string[] slova = chain.Split(' ');

                if (checkBox1.Checked)
                {
                    label1.Text = (slova.Length.ToString());
                }
                if (checkBox2.Checked)
                { 
                    int delka = 0;
                    string dd = "";
                    string slovicko = "";
                    for (int i = 0; i < slova.Length; i++)
                    {
                        slovicko = slova[i];
                        if (slovicko.Length > delka)
                        {
                            delka = slovicko.Length;
                            dd = slovicko;
                        }
                    }
                    label2.Text = "nejdelsi slovo je '" + dd + "'";
                }

                if(radioButton1.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                }
                else
                {
                    label1.ForeColor = Color.Red;
                    label2.ForeColor = Color.Red;
                }

                if(radioButton3.Checked)
                {
                    label1.Font = new Font("", 12f);
                    label2.Font = new Font("", 12f);
                }
                else
                {
                    label1.Font = new Font("", 20f);
                    label2.Font = new Font("", 20f);
                }
            }
        }
    }
}
