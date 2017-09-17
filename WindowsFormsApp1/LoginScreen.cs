using System;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginScreen : Form
    {
        private static string clerkID;
        private string password;

        public LoginScreen()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            //creating connection
            SqlConnection sqlConn;
            string connString = "Data Source=DESKTOP-30191JE\\SQLEXPRESS01;Initial Catalog=Test1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string loginString = "select Password from UsersTable where Username=@username";
            sqlConn = new SqlConnection(connString);
            clerkID = txt_UserName.Text;
            password = txt_Password.Text;


            try
            {
                sqlConn.Open();
                SqlCommand loginCMD = new SqlCommand(loginString,sqlConn);
                loginCMD.Parameters.AddWithValue("@username",clerkID);
                object obj = loginCMD.ExecuteScalar();
                //checking if username exists
                if (obj == null)
                {
                    MessageBox.Show("Wrong username.");
                }
                else
                {
                    string check = loginCMD.ExecuteScalar().ToString();
                    check.TrimEnd();
                    //checking if password matches username
                    if(password.Equals(check))
                    {
                        this.Hide();
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong password.");
                    }
                
                }
                sqlConn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            }


        public static string getClerkID()
        {
            return clerkID;
        }
    }
}
