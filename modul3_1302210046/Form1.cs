using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_1302210046
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num = 0;
        int numm = 0;

        private void button13_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "" + button13.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "" + button14.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "" + button15.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "" + button16.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "" + button17.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "" + button18.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "" + button19.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "" + button20.Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "" + button21.Text;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "" + button24.Text;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if(num == 0)
            {
                num = int.Parse(label2.Text);
            }
            label2.Text = " ";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if(numm == 0)
            {
                numm = int.Parse(label2.Text);
            }
            label2.Text =  " " + (num + numm);
            num = num + numm;
            numm = 0;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
