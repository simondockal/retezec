using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P09
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
               
                string slovo = "";
                string zacatek="";
          
                for(int i=0;i<textBox1.Lines.Length;i++)
                {
                    string tecka = "";
                    string line = textBox1.Lines[i];
                    line = line.TrimEnd();
                    zacatek = line;
                    if(checkBox1.Checked)
                    {
                        zacatek = char.ToUpper(line[0])+line.Substring(1);
                     
                    }

                    if(checkBox2.Checked)
                    {
                        if(line[line.Length-1] != '.')
                        {
                            tecka = ".";
                        }
                   
                    }
                    slovo += zacatek + tecka + Environment.NewLine;
                }
                textBox1.Text = slovo;
            }

        }
    }
}
