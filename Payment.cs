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

namespace GymManagement
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }
        SqlConnection con = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Khushi\Documents\GymDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void FillName()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("select MName from MemberTb", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("MName", typeof(string));
            dt.Load(rdr);
            NameCb.ValueMember = "MName";
            NameCb.DataSource = dt;

            con.Close();
        }
        private void populate()
        {
            con.Open();
            string query = "select * from PaymentTb";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            adapter.Fill(ds);
            PaymentSDGV.DataSource = ds.Tables[0];

            con.Close();
        }
        private void filterByName()
        {
            con.Open();
            string query = "select * from PaymentTb where PMember='" + SearchName.Text + "';";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            adapter.Fill(ds);
            PaymentSDGV.DataSource = ds.Tables[0];

            con.Close();
        }
        private void Payment_Load(object sender, EventArgs e)
        {
            FillName();
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AmountTb.Text = "";
            payMonthDTP.Text = "";
            NameCb.Text = "";
            SearchName.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            frm.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (NameCb.Text == "" || AmountTb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                string payperiode = payMonthDTP.Value.Month.ToString() + payMonthDTP.Value.Year.ToString();
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from PaymentTb where PMember='" + NameCb.SelectedValue.ToString() + "' and PMonth='" + payperiode + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Already Paid for this month");
                }
                else
                {
                    string query = "insert into PaymentTb values('" + payperiode + "', '" + NameCb.SelectedValue.ToString() + "'," + AmountTb.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Paid Successfully");
                    populate();
                }
                con.Close();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            filterByName();
            SearchName.Text = "";   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchName.Text = "";
            populate();
        }
    }
}
