using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SimpleATM
{
    public partial class bongATMLog : Form
    {
        public bongATMLog()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Things needed:
            //1. SqlConnection
            //2. SqlCommand
            //3. SqlDataReader

            SqlConnection databaseConn = new SqlConnection("Data Source=Localhost; Database=Bong ATM; Integrated Security=True");
            
            databaseConn.Open();
            SqlCommand databaseCmd = new SqlCommand("select * from Users where Username='" + txtUsername.Text + "' and PIN='" + txtPIN.Text + "'", databaseConn);

            SqlDataReader databaseRead = databaseCmd.ExecuteReader();

            if (databaseRead.Read())
            {
                bongATMDashboard bongATM = new bongATMDashboard();
                bongATM.Show(); //this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password. Please try again.", "Error!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            databaseConn.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            User_Sign_Up userSignUp = new User_Sign_Up();
            userSignUp.Show(); //this.Hide();
        }
    }
}
