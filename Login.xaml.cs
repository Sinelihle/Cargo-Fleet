using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace Cargo_Fleet_Tracking_System
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        SqlConnection con;
        SqlCommand cmd;

        public Login()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
                try
                {
                    con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sinel\\Documents\\UserLog.mdf;Integrated Security=True;Connect Timeout=30");
                    con.Open();
                    cmd = new SqlCommand("insert into Login values(@Name, @Password)", con);
                    cmd.Parameters.AddWithValue("@Name", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@Password", pdbPassword.Password);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successful Login");
                    Dashboard dashboardWindow = new Dashboard();
                    dashboardWindow.Show();
                    this.Close();
                }

                catch (Exception E)
                {

                    MessageBox.Show(E.Message);
                }
        }
    }
}
