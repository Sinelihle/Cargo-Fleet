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
    /// Interaction logic for TripsPage.xaml
    /// </summary>
    public partial class TripsPage : Page
    {
        SqlConnection con;
        SqlCommand cmd;

        public TripsPage()
        {
            InitializeComponent();
        }

        private void btnDaily_Click(object sender, RoutedEventArgs e)
        {
            AddTrip();
            ViewTrip();
        }

        public void ViewTrip()
        {
            con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\sinel\\Documents\\UserLog.mdf; Integrated Security = True; Connect Timeout = 30");
            con.Open();
            cmd = new SqlCommand("select * from Trip", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            adapt.Fill(dt);
            gridTrips.ItemsSource = dt.DefaultView;
            adapt.Update(dt);
            con.Close();
        }

        public void AddTrip()
        {
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sinel\\Documents\\UserLog.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            cmd = new SqlCommand("insert into Trip values(@Destination, @Kilometres)", con);
            cmd.Parameters.AddWithValue("@Destination", txtDestination.Text);
            cmd.Parameters.AddWithValue("@Kilometres", txtTravelled.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Trip Added");
        }

        public void ViewWeeklyTrip()
        {
            con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\sinel\\Documents\\UserLog.mdf; Integrated Security = True; Connect Timeout = 30");
            con.Open();
            cmd = new SqlCommand("select * from WeeklyTrip", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            adapt.Fill(dt);
            gridTrips.ItemsSource = dt.DefaultView;
            adapt.Update(dt);
            con.Close();
        }

        public void AddWeeklyTrip()
        {
            try
            {
                con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sinel\\Documents\\UserLog.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                cmd = new SqlCommand("insert into WeeklyTrip values(@Destination, @Kilometres)", con);
                cmd.Parameters.AddWithValue("@Destination", txtDestination.Text);
                cmd.Parameters.AddWithValue("@Kilometres", txtTravelled.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Trip Added");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnWeekly_Click(object sender, RoutedEventArgs e)
        {
            AddWeeklyTrip();
            ViewWeeklyTrip();
        }

        public void MonthlyTrips()
        {
            try
            {
                con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\sinel\\Documents\\UserLog.mdf; Integrated Security = True; Connect Timeout = 30");
                con.Open();
                cmd = new SqlCommand("select Destination, Kilometres * 4 As MonthlyKilometres from WeeklyTrip", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                adapt.Fill(dt);
                gridTrips.ItemsSource = dt.DefaultView;
                adapt.Update(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
          
        }

        private void btnMonthly_Click(object sender, RoutedEventArgs e)
        {
            MonthlyTrips();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sinel\\Documents\\UserLog.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                cmd = new SqlCommand("Delete from WeeklyTrip", con);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("Delete from Trip", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                adapt.Fill(dt);
                gridTrips.ItemsSource = dt.DefaultView;
                adapt.Update(dt);
                con.Close();
                MessageBox.Show("Records Deleted Successfully");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
         
        }
    }
}
