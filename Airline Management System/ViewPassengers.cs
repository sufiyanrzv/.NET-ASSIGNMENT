using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Management_System
{
    public partial class ViewPassengers : Form
    {
        public ViewPassengers()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shakt\Documents\Airlinedb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            con.Open();
            string query = "select*from PassengerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            PassengerDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ViewPassengers_Load(object sender, EventArgs e)
        {
            populate();

        }

        private void PassengerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < PassengerDGV.Rows.Count)
            {
                DataGridViewRow selectedRow = PassengerDGV.Rows[e.RowIndex];

                pidTb.Text = selectedRow.Cells[0].Value?.ToString();
                passnameTb.Text = selectedRow.Cells[1].Value?.ToString();
                ppassTb.Text = selectedRow.Cells[2].Value?.ToString();
                passaddTb.Text = selectedRow.Cells[3].Value?.ToString();

                string nationality = selectedRow.Cells[4].Value?.ToString();
                if (!string.IsNullOrEmpty(nationality))
                {
                    natCb.SelectedItem = nationality;
                }

                string gender = selectedRow.Cells[5].Value?.ToString();
                if (!string.IsNullOrEmpty(gender))
                {
                    gendCb.SelectedItem = gender;
                }

                pphoneTb.Text = selectedRow.Cells[6].Value?.ToString();
            }
        }



        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddPassenger addpas = new AddPassenger();
            addpas.Show();
            this.Hide();
        }

        private void passname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pidTb.Text = "";
            passnameTb.Text = "";
            ppassTb.Text = "";
            passaddTb.Text = "";
            natCb.SelectedIndex = -1;
            gendCb.SelectedIndex = -1;
            pphoneTb.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pidTb.Text == "")
            {
                MessageBox.Show("Enter the Passenger to delete");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from PassengerTbl where passId=" + pidTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Passenger delete Successful");


                    con.Close();
                    populate();


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(pidTb.Text== "" || passnameTb.Text=="" || ppassTb.Text=="" || passaddTb.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update PassengerTbl set  PassName='" + passnameTb.Text + "',PassNum='" + ppassTb.Text + "',PassAdd='" + passaddTb.Text + "',PassNat='" + natCb.SelectedItem.ToString() + "',PassGen='" + gendCb.SelectedItem.ToString() + "',PassPhone='" + pphoneTb.Text + "' where PassId="+pidTb.Text+";";
                    SqlCommand cmd=new SqlCommand(query, con);  
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Details updated Successfully");
                    con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
