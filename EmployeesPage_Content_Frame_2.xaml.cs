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
    /// Interaction logic for EmployeesPage_Content_Frame_2.xaml
    /// </summary>
    public partial class EmployeesPage_Content_Frame_2 : Page
    {
        SqlConnection con;
        SqlCommand cmd;
        string name;
        string surname;
        string email;
        int phoneNumber;

        public string Username
        {
            get { return name; }
        }

        public string Surnname
        {
            get { return surname; }
        }

        public string Email
        {
            get { return email; }
        }

        public int PhoneNumber
        {
            get { return phoneNumber; }
        }
        public EmployeesPage_Content_Frame_2()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            name = txtFirstName.Text;
            surname = txtLastName.Text;
            email = txtEmail.Text;
            phoneNumber = Convert.ToInt32(txtPhone.Text);

            con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\sinel\\Documents\\UserLog.mdf; Integrated Security = True; Connect Timeout = 30");
            con.Open();
            cmd = new SqlCommand("insert into EmployeeDetails values(@FirstName, @LastName, @Email, @PhoneNumber)", con);
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Saved Successfully");
        }

        
    }
}
