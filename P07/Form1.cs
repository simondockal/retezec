using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P07
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
                string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..","/" };
                char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',' ' };
                //0a 1b 2c 3d 4e 5f 6g 7h 8i 9j 10k 11l 12m 13n 14o 15p 16q 17r 18s 19t 20u 21v 22w 23x 24y 25z
                string chain = textBox1.Text;
                string vysledna = "";
                char znak;
                int ind;
                if (button1.Text=="zašifrovat")
                {
                    button1.Text = "odšifrovat";
                    for(int i=0;i<chain.Length;i++)
                    {
                        znak = chain[i];
                        ind=Array.IndexOf(alphabet, znak);
                        vysledna += morse[ind]+" ";
                    }
                    textBox1.Text = "";
                    vysledna=vysledna.TrimEnd();
                    textBox1.Text = vysledna;

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", "/" };
                char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ' ' };
                string chain = textBox1.Text;
                string mor;
                int ind;
                string vysledna1 = "";

                button1.Text = "zašifrovat";
                string[] ah = chain.Split(' ');
                for (int i = 0; i < ah.Length; i++)
                {
                    mor = ah[i];
                    ind = Array.IndexOf(morse, mor);
                    vysledna1 += alphabet[ind];
                }
                textBox1.Text = "";
                textBox1.Text = vysledna1;
            }
              
        }
    }
}
