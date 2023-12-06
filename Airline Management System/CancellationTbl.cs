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

namespace Airline_Management_System
{
    public partial class CancellationTbl : Form
    {
        public CancellationTbl()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shakt\Documents\Airlinedb.mdf;Integrated Security=True;Connect Timeout=30");


        private void Populate()
        {
            con.Open();
            string query = "select * from CancelTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            CancelDGV.DataSource = ds.Tables[0];
            con.Close();

        }
        private void FillTicketId()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select TId from TicketTbl ", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TId", typeof(string));
            dt.Load(rdr);
            TIdCb.ValueMember = "TId";
            TIdCb.DataSource = dt;

            con.Close();

        }

        string pname, ppass, pnat;

        private void FetchFliteCode()
        {
            con.Open();

            string query = "select * from TicketTbl where TId='" + TIdCb.SelectedValue.ToString() + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {

                FCodeTb.Text = dr["FCode"].ToString();




            }

            con.Close();
        }

        private void CancellationTblcs_Load(object sender, EventArgs e)
        {
            Populate();
            FillTicketId();


        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FetchFliteCode();

        }

        private void DeleteTicket()
        {


            try
            {
                con.Open();
                string query = "delete from TicketTbl where TId ='" + TIdCb.SelectedValue + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Flight Delete Successfull");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (CIdTb.Text == "" || FCodeTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into CancelTbl (CancelId,TId,FCode,CancelDate) values (" + CIdTb.Text + ",'" + TIdCb.SelectedValue + "','" + FCodeTb.Text + "', '" + CancDate.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Cancel Successfully");
                    con.Close();
                    Populate();
                    DeleteTicket();


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void TIdCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FCodeTb_TextChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CIdTb.Text = "";
            TIdCb.SelectedIndex = -1;
            FCodeTb.Text = "";
        }

        private void CancelDGV_AllowUserToAddRowsChanged(object sender, EventArgs e)
        {

        }

        private void CancelDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

