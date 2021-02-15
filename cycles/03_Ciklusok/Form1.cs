using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Ciklusok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int iOsszeg;
        Random rnd = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            iOsszeg = 0;//
            for (int i = 1; i <= 100; i++)
            {
                //ciklus utasítás
                //iOsszeg = iOsszeg + 1;
                iOsszeg += i;
            }
            
            label1.Text = iOsszeg.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            iOsszeg = 0;
            for (int i = 3; i <= 100; i=i+3)
            {
                iOsszeg += i;
            }
            label1.Text = iOsszeg.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int iSzam = int.Parse(textBox1.Text);
            bool bVanoszto = false;
            for (int i = 2; i < iSzam-1; i++)
            {
                if (iSzam%i==0)
                {
                    bVanoszto = true;
                }
            }
            if (bVanoszto)
            {
                label1.Text = "Nem prím";
            } else
            {
                label1.Text = "Prímszám";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = rnd.Next(1,11).ToString();
            //[a,b) --> next(a,b) A benne van B nincs benne
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = (2*rnd.Next(1, 6)).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            for (int i = 1; i <= 10; i++)
            {
                textBox2.Text +=rnd.Next(1, 11).ToString()+"\r\n";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int iGeneralt = 0;
            textBox2.Clear();
            while (iGeneralt != 11)
            {
                iGeneralt = rnd.Next(1, 11);
                textBox2.Text += iGeneralt.ToString() + "\r\n";
                //ciklus utasítás
            }


        }
    }
}
