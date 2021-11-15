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
using System.Data;

namespace Cargo_Fleet_Tracking_System
{
    /// <summary>
    /// Interaction logic for EmployeesPage_Content_Frame_1.xaml
    /// </summary>
    public partial class EmployeesPage_Content_Frame_1 : Page
    {
        SqlConnection con;
        SqlCommand cmd;
        public EmployeesPage_Content_Frame_1()
        {
            InitializeComponent();
            ViewData();
        }

        public void ViewData()
        {
            
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sinel\\Documents\\UserLog.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            cmd = new SqlCommand("select CONCAT(FirstName,' ', LastName) AS FullName from EmployeeDetails", con);
            //cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string data = dr.GetString(0);
                lstUsers.Items.Add(data);
            }
            con.Close();
        }
         
        }
}

