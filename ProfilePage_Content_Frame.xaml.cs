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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace Cargo_Fleet_Tracking_System
{
    /// <summary>
    /// Interaction logic for ProfilePage_Content_Frame.xaml
    /// </summary>
    public partial class ProfilePage_Content_Frame : Page
    {

        SqlConnection con;
        SqlCommand cmd;
        public ProfilePage_Content_Frame()
        {
            InitializeComponent();
        }

        private void btnSaveUser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sinel\\Documents\\UserLog.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                cmd = new SqlCommand("insert into Profile values(@Name, @LastName, @Email, @PhoneNumber, @Address, @City, @Province, @ZipCode)", con);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLastname.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@City", txtCity.Text);
                cmd.Parameters.AddWithValue("@Province", txtProvince.Text);
                cmd.Parameters.AddWithValue("@ZipCode", txtZipCode.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Profile Updated Successfully");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
