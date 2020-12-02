using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SimpleATM
{
    public partial class User_Sign_Up : Form
    {

        //Things needed:
        //RNG for PIN codes
        //SQL Connection - connection string
        //SQL Command Query

        public User_Sign_Up()
        {
            InitializeComponent();
        }

        // GENERATE NEW PIN
        private void RNGPIN_Click(object sender, EventArgs e)
        {
            Random rndPIN = new Random();
            int newPIN = rndPIN.Next(0, 9999);

            TxtNewPIN.Text = Convert.ToString(newPIN);
        }

        SqlConnection dataConn = new SqlConnection("Data Source=Localhost; Database=Bong ATM; Integrated Security=True");
        
        // GENERATE NEW USER ID
        private void BtnNewID_Click(object sender, EventArgs e)
        {
            Random rndID = new Random();
            int newID = rndID.Next(0, 9999);

            dataConn.Open();
            SqlCommand databaseCmd = new SqlCommand("select * from Users where ID='" + TextID.Text + "'", dataConn);
            SqlDataReader databaseRead = databaseCmd.ExecuteReader();

            if (newID == Convert.ToInt32(databaseRead.Read()))
            {
                newID = rndID.Next(0, 9999);
            }
               
            TextID.Text = Convert.ToString(newID);

            dataConn.Close();
        }

        // USER REGISTRATION
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            dataConn.Open();

            SqlCommand databaseCmd = new SqlCommand("select * from Users where Username='" + TxtNewUsername.Text + "'", dataConn);
            SqlDataReader databaseRead = databaseCmd.ExecuteReader();

            string newUsername = TxtNewUsername.Text;

            if (newUsername == Convert.ToString(databaseRead.Read()))
            {
                MessageBox.Show("Username already taken", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SqlCommand dataCmd = new SqlCommand("INSERT INTO Users ([ID], [Username], [PIN]) VALUES" +
                " ('" +TextID.Text+ "','" +TxtNewUsername.Text+ "','" +TxtNewPIN.Text+ "' )", dataConn);
            dataCmd.ExecuteNonQuery();

            MessageBox.Show("Register successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataConn.Close();
        }

        
    }
}
