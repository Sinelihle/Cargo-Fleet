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
    /// Interaction logic for DashboardPage.xaml
    /// </summary>
    public partial class DashboardPage : Page
    {
        SqlConnection con;
        SqlCommand cmd;
        public DashboardPage()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\sinel\\Documents\\UserLog.mdf; Integrated Security = True; Connect Timeout = 30");
                con.Open();
                cmd = new SqlCommand("select VehicleNumber, RegistrationNumber, VehicleType, Manufacturer, EngineSize, CurrentOdometerReading, NextOdometerReading from Vehicle", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                adapt.Fill(dt);
                vehicleData.ItemsSource = dt.DefaultView;
                adapt.Update(dt);
                con.Close();
            }
            catch (Exception E)
            {

                MessageBox.Show(E.Message);
            }
        }
    }
}
