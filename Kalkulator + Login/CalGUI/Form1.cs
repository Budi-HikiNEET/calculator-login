using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) {
                int a = Convert.ToInt16(textBox1.Text);
                int b = Convert.ToInt16(textBox2.Text);
                int c = a + b;
                textBox3.Text = Convert.ToString(c);
                textBox1.Text = "";
                textBox2.Text = "";
            }
            if (radioButton2.Checked) {
                int a = Convert.ToInt16(textBox1.Text);
                int b = Convert.ToInt16(textBox2.Text);
                int c = a - b;
                textBox3.Text = Convert.ToString(c);
            }
            if (radioButton3.Checked) {
                int a = Convert.ToInt16(textBox1.Text);
                int b = Convert.ToInt16(textBox2.Text);
                int c = a * b;
                textBox3.Text = Convert.ToString(c);
            }
            if (radioButton4.Checked) {
                int a = Convert.ToInt16(textBox1.Text);
                int b = Convert.ToInt16(textBox2.Text);
                int c = a / b;
                textBox3.Text = Convert.ToString(c);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
