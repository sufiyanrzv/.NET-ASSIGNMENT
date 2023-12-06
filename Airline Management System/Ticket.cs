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
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }

        private void Populate()
        {
            con.Open();
            string query = "select * from TicketTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            TicketDGV.DataSource = ds.Tables[0];
            con.Close();

        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shakt\Documents\Airlinedb.mdf;Integrated Security=True;Connect Timeout=30");
        private void FillPassenger()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select PassId from PassengerTbl ", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PassId", typeof(int));
            dt.Load(rdr);
            PIdCb.ValueMember = "PassId";
            PIdCb.DataSource = dt;

            con.Close();
        }


        private void FillFightCode()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select FCode from FlightTbl ", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("FCode", typeof(string));
            dt.Load(rdr);
            FCodeCb.ValueMember = "FCode";
            FCodeCb.DataSource = dt;

            con.Close();
            Populate();
        }

        string pname, ppass, pnat;

        private void Fetchpassenger()
        {
            con.Open();

            string query = "select * from PassengerTbl where PassId='" + PIdCb.SelectedValue.ToString() + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                pname = dr["PassName"].ToString();
                ppass = dr["PassNum"].ToString();
                pnat = dr["PassNat"].ToString();
                PNameTb.Text = pname;
                PPassTb.Text = ppass;
                PNatTb.Text = pnat;



            }

            con.Close();
        }
        private void Ticket_Load(object sender, EventArgs e)
        {
            FillPassenger();
            FillFightCode();


        }

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Fetchpassenger();

        }

        private void PIdCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void PPassTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void PNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void PNatTb_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TIdTb.Text == "" || PNameTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into TicketTbl (TId,FCode,  PId, PName, PPass,PNation,Amt) values (" + TIdTb.Text + ",'" + FCodeCb.SelectedValue.ToString() + "','" + PIdCb.SelectedValue.ToString() + "', '" + PNameTb.Text + "','" + PPassTb.Text + "','" + PNatTb.Text + "' ,'" + PAmtTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Booked Successfully");
                    con.Close();
                    Populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TIdTb.Text = "";
            PNameTb.Text = "";
            PNatTb.Text = "";
            PPassTb.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
