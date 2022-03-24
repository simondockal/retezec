using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03
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
                label1.Text = "";
                string chain = textBox1.Text;
                int k=0;
                int pozice = 0;
                bool nalezeno=false;
                for(int i=0;i<chain.Length;i++)
                {
                    if (chain[i] >='0'&&chain[i]<='9'&&!nalezeno)
                    {
                        k=chain[i];
                        pozice=i;  
                        nalezeno=true;
                    }
                }
                k -= 48;
                if (!nalezeno)
                {
                    for(int i=0;i<chain.Length;i++)
                    {
                        label1.Text+=chain[i];
                    }
                }
                else if(k>chain.Length)
                {
                    chain = "";
                }
                else
                {
                    string vysledek="";
                    int tk=chain.Length-k;
                    for(int i=0;i<tk;i++)
                    {
                        vysledek+=chain[i];
                    }
                    label1.Text=vysledek;
                }
            }
        }
    }
}
