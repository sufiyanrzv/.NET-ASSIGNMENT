using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserIdTb.Text = "";
            PasswordTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserIdTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("!!!Enter the User Name and Password First");
            }
            else if (UserIdTb.Text == "Admin" && PasswordTb.Text == "Admin")
            {
                Home home = new Home();
                home.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("!!Wrong User Name or Password");
            }
        }

        private void PasswordTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
