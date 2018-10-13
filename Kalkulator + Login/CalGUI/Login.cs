using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CalGUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
//user.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
     

            if (user.Text == "") {
              // 
                user.Focus();
            }
            else if (password.Text == "") {
                password.Focus();
            }
           
              
            
            else
            {
                user b = new user();
                b.setuser(Convert.ToString(user.Text));
                Cal a = new Cal();
                a.Show();
                this.Hide();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            user.Focus();
        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
