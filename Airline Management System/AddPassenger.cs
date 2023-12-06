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
using System.Security.Cryptography;

namespace Airline_Management_System
{
    public partial class AddPassenger : Form
    {
        public AddPassenger()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shakt\Documents\Airlinedb.mdf;Integrated Security=True;Connect Timeout=30");


        private void AddPassenger_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            /*  if (PhoneTb.TextLength<11)
              {
                  PhoneTb.Text = "enter valid information";
              }
              else
              {
                  PhoneTb.Text = "";
              }
            */
        }
        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Passid_Click(object sender, EventArgs e)
        {

        }

        private void PassAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            /*  con.Open();
             string query = "Truncate table PassengerTbl";
             SqlCommand cmd = new SqlCommand(query, con);
             cmd.ExecuteNonQuery();
             MessageBox.Show("Passenger Record Successfully");
             con.Close();*/






            if (PassId.Text == "" || PassAdd.Text == "" || PassName.Text == "" || PassNum.Text == "" || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into PassengerTbl (PassId,PassName, PassNum, PassAdd, PassNat, PassGen, PassPhone) values (" + PassId.Text + ",'" + PassName.Text + "','" + PassNum.Text + "', '" + PassAdd.Text + "','" + NationalityCb.SelectedItem.ToString() + "','" + GenderCb.SelectedItem.ToString() + "' ,'" + PhoneTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Record Successfully");
                    con.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void NationalityCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewPassengers viewpass = new ViewPassengers();
            viewpass.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
