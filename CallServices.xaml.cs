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
    /// Interaction logic for CallServices.xaml
    /// </summary>
    public partial class CallServices : Window
    {
        SqlConnection con;
        SqlCommand cmd;
        public CallServices()
        {
            InitializeComponent();
        }
        private void okBtn_Click(object sender, RoutedEventArgs e)
        {
            InsertData();
            ShowData();
        }

        public void InsertData()
        {
            try
            {
                con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sinel\\Documents\\UserLog.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                cmd = new SqlCommand("insert into CallService values(@VehicleNo, @Appointment, @Services,@WorkToBeCompleted) ", con);
                cmd.Parameters.AddWithValue("@VehicleNo", txtVehicleNo.Text);
                cmd.Parameters.AddWithValue("@Appointment", dateAppoint.SelectedDate);
                cmd.Parameters.AddWithValue("@Services", txtServiceType.Text);
                cmd.Parameters.AddWithValue("@WorkToBeCompleted", txtCompleted.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        public void ShowData()
        {
            try
            {
                con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\sinel\\Documents\\UserLog.mdf; Integrated Security = True; Connect Timeout = 30");
                con.Open();
                cmd = new SqlCommand("select * from CallService", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                adapt.Fill(dt);
                gridData.ItemsSource = dt.DefaultView;
                adapt.Update(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            Dashboard dash = new Dashboard();
            this.Close();
            dash.Show();
        }
    }
}

