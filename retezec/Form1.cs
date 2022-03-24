using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace retezec
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
                string samohlasky="aeiouyáéěíóúůý";
                string souhlasky= "bcčdďfghjklmnpqrřsštťvwxzž";
                int pocet_sa = 0;
                int pocet_so = 0;
                string veta = textBox1.Text;
                veta = veta.ToLower();
                for(int i=0;i<textBox1.Text.Length;i++)
                {
                    if(samohlasky.Contains(veta[i]))
                    {
                        pocet_sa++;
                    }
                    else if(souhlasky.Contains(veta[i]))
                    {
                        pocet_so++;
                    }
               
                }
                int prazdno = veta.Length-(pocet_so+pocet_sa);

                label1.Text = "pocet souhlasek je " + pocet_so;
                label2.Text = "pocet samohlasek je " + pocet_sa;
                label3.Text = "pocet ostatnich znaku je " + prazdno;


            }
        }
    }
}
