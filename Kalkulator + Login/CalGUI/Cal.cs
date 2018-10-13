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
    public partial class Cal : Form
    {
        String operation = "";
        double value = 0;
        bool operation_click = false;
        public Cal()
        {
            InitializeComponent();
        }
        //buat angkanya
        private void button_click(object sender, EventArgs e)
        {
            if (operation_click) {
                textBox1.Text = "";
                operation_click = false;
            }
            Button b = (Button)sender;
           // Textbox1.Text = hasil.Text + b.Text;
            textBox1.Text = textBox1.Text + b.Text;
        
        }
        //buat operation nya kalo di klik
        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(textBox1.Text);
            operation_click = true;
            textBox2.Text = value + " " + operation;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //buat sama dengannya
        private void button12_Click(object sender, EventArgs e)
        {
            if (operation == "+") {
                textBox1.Text = (value + Double.Parse(textBox1.Text)).ToString();
                textBox2.Text = "";
            }
            if (operation == "-")
            {
                textBox1.Text = (value - Double.Parse(textBox1.Text)).ToString();
                textBox2.Text = "";
            }
            if (operation == "x")
            {
                textBox1.Text = (value * Double.Parse(textBox1.Text)).ToString();
                textBox2.Text = "";
            }
            if (operation == "/")
            {
                textBox1.Text = (value / Double.Parse(textBox1.Text)).ToString();
                textBox2.Text = "";
            }
        }
        //c / ce
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        // c /ce
        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void Cal_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            user a = new user();
            label1.Text = Convert.ToString(a.getuser());
        }

       
    }
}
