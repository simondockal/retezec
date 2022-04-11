using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P10
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
                string chain=textBox1.Text;
                while (chain.Contains("  "))
                {
                    chain = chain.Replace("  ", " ");
                }
                string[]slova = chain.Split(' ');
                string slovo;
                for(int i=0; i < slova.Length; i++)
                {
                    slovo=slova[i];
                    if(slovo[i]>='0'&&slovo[i]<='9')
                    {
                        listBox1.Items.Add(slova);
                    }
                }
            }
        }
    }
}
