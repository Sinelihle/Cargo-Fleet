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
    /// Interaction logic for VehiclePage.xaml
    /// </summary>
    public partial class VehiclePage : Page
    {
        SqlConnection con;
        SqlCommand cmd;

        public VehiclePage()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sinel\\Documents\\UserLog.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                cmd = new SqlCommand("insert into Vehicle values(@VehicleNumber, @RegistrationNumber, @VehicleType, @Manufacturer, @EngineSize, @CurrentOdometerReading, @NextOdometerReading)", con);
                cmd.Parameters.AddWithValue("@VehicleNumber", txtVehicleNo.Text);
                cmd.Parameters.AddWithValue("@RegistrationNumber", txtregistration.Text);
                cmd.Parameters.AddWithValue("@VehicleType", txtVehicleType.Text);
                cmd.Parameters.AddWithValue("@Manufacturer", txtManufacturer.Text);
                cmd.Parameters.AddWithValue("@EngineSize", txtEngineSize.Text);
                cmd.Parameters.AddWithValue("@CurrentOdometerReading", txtCurrentOdometer.Text);
                cmd.Parameters.AddWithValue("@NextOdometerReading", txtNextOdometer.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Vehicle Information Saved Successfully");



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
