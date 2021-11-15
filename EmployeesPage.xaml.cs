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
    /// Interaction logic for EmployeesPage.xaml
    /// </summary>
    public partial class EmployeesPage : Page
    {
        SqlConnection con;
        SqlCommand cmd;
        public EmployeesPage()
        {
            InitializeComponent();
        }

     
        //Loads Employee Content on Page
        private void btnAllEmployees_Click(object sender, RoutedEventArgs e)
        {
            EmployeesFrame.Content = new EmployeesPage_Content_Frame_1();

        }

        //Loads User input content on page
        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            AddUserFrame.Content = new EmployeesPage_Content_Frame_2();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sinel\\Documents\\UserLog.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            cmd = new SqlCommand("Delete From EmployeeDetails", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
