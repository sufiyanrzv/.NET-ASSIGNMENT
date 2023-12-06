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
using System.Text.RegularExpressions;

namespace Airline_Management_System
{

    public partial class ViewFlights : Form
    {
        public ViewFlights()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shakt\Documents\Airlinedb.mdf;Integrated Security=True;Connect Timeout=30");


        private void populate()
        {
            con.Open();
            string query = "select * from FlightTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            FlightDGV.DataSource = ds.Tables[0];
            con.Close();

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < FlightDGV.Rows.Count)
            {
                DataGridViewRow selectedRow = FlightDGV.Rows[e.RowIndex];

                FCodeTb.Text = selectedRow.Cells[0].Value?.ToString();



                string Source = selectedRow.Cells[1].Value?.ToString();
                if (!string.IsNullOrEmpty(Source))
                {
                    FSrcCb.SelectedItem = Source;
                }

                string dest = selectedRow.Cells[2].Value?.ToString();
                if (!string.IsNullOrEmpty(dest))
                {
                    FDestCb.SelectedItem = dest;
                }
                SeatNum.Text = selectedRow.Cells[4].Value?.ToString();

            }
        }

        private void ViewFlightscs_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FlightTbl Addf1 = new FlightTbl();
            Addf1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FCodeTb.Text = "";
            SeatNum.Text = "";
            FSrcCb.SelectedIndex = -1;
            FDestCb.SelectedIndex = -1;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (FCodeTb.Text == "")
            { MessageBox.Show("!!!!!!!Enter the Flight Code"); }
            else
            {
                con.Open();
                string query = "delete from FlightTbl where FCode='" + FCodeTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Successfull");
                con.Close();
                populate();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FCodeTb.Text == "" || FSrcCb.SelectedItem.ToString() == "" || FDestCb.SelectedItem.ToString() == "" || SeatNum.Text == "")
            {
                MessageBox.Show("!!!!Enter the value first to Upadat");

            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update FlightTbl set  FSrc='" + FSrcCb.SelectedItem.ToString() + "',FDest='" + FDestCb.SelectedItem.ToString() + "',FDate='" + FDate.Value.ToString() + "',FCap='" + SeatNum.Text + "' where FCode ='" + FCodeTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Details updated Successfully");
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
