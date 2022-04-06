using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
                string chain = textBox1.Text;
                chain = chain.Trim(' ');

                if (radioButton1.Checked)
                {
                    int i = 0;
                    while(i<chain.Length-1)
                    {
                        if (chain[i] == ' '&&chain[i+1]==' ') 
                        {
                                chain = chain.Remove(i + 1,1);
                        }
                        else
                        {
                            i++;
                        }
                    }

                    label1.Text ="  remove:" + chain;
                }
                else
                {
                    while (chain.Contains("  "))
                    {
                        chain = chain.Replace("  ", " ");
                    }
                    label1.Text = "replace:" + chain;
                }
            }
        }
    }
}
