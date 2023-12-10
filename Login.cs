using System.Diagnostics.Eventing.Reader;

namespace GymManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UidTb.Text = string.Empty;
            PassTb.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UidTb.Text == string.Empty || PassTb.Text == string.Empty)
            {
                MessageBox.Show("Missing Information");
            }
            else if(UidTb.Text == "admin" || PassTb.Text == "1234")
            {
                MainForm frm = new MainForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Id or Password");
            }
        }
    }
}
