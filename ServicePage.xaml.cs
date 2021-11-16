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
    /// Interaction logic for ServicePage.xaml
    /// </summary>
    public partial class ServicePage : Page
    {
        SqlConnection con;
        SqlCommand cmd;


        public ServicePage()
        {
            InitializeComponent();
        }

        public void WeeklyData()
        {
            try
            {
                con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sinel\\Documents\\UserLog.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                cmd = new SqlCommand("insert into WeeklyAppointment values(@VehicleNo, @Appointment, @Services, @ProcedureCode, @Description)", con);
                cmd.Parameters.AddWithValue("@VehicleNo", txtVehicleNo.Text);
                cmd.Parameters.AddWithValue("@Appointment", appointDate.SelectedDate);
                cmd.Parameters.AddWithValue("@Services", txtService.Text);
                cmd.Parameters.AddWithValue("@ProcedureCode", txtCode.Text);
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Weekly Appointment successful");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        public void ShowWeeklyData()
        {
            try
            {
                con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\sinel\\Documents\\UserLog.mdf; Integrated Security = True; Connect Timeout = 30");
                con.Open();
                cmd = new SqlCommand("select * from WeeklyAppointment", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                adapt.Fill(dt);
                weeklyGrid.ItemsSource = dt.DefaultView;
                adapt.Update(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        public void DailyData()
        {
            try
            {
                con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sinel\\Documents\\UserLog.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                cmd = new SqlCommand("insert into DailyAppointment values(@VehicleNo, @Appointment, @Services, @ProcedureCode, @Description)", con);
                cmd.Parameters.AddWithValue("@VehicleNo", txtVehicleNo.Text);
                cmd.Parameters.AddWithValue("@Appointment", appointDate.SelectedDate);
                cmd.Parameters.AddWithValue("@Services", txtService.Text);
                cmd.Parameters.AddWithValue("@ProcedureCode", txtCode.Text);
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }

        public void ShowDailyData()
        {
            try
            {
                con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\sinel\\Documents\\UserLog.mdf; Integrated Security = True; Connect Timeout = 30");
                con.Open();
                cmd = new SqlCommand("select * from DailyAppointment", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                adapt.Fill(dt);
                dailyGrid.ItemsSource = dt.DefaultView;
                adapt.Update(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void weeklyBtn_Click(object sender, RoutedEventArgs e)
        {
            WeeklyData();
            ShowWeeklyData();
        }

        private void dailyBtn_Click(object sender, RoutedEventArgs e)
        {
            DailyData();
            ShowDailyData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CallServices serv = new CallServices();
            serv.Show();
        }

        private void btnUpdateDaily_Click(object sender, RoutedEventArgs e)
        {
            UpdateDaily();
        }

        public void UpdateDaily()
        {
            try
            {
                con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sinel\\Documents\\UserLog.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                cmd = new SqlCommand("Update DailyAppointment SET VehicleNo = '" + txtVehicleNo.Text + "'" + ", " + "Appointment = '" + appointDate.SelectedDate + "'" + ", " + "Services = '" + txtService.Text + "'" + ", " + "ProcedureCode = '" + txtCode.Text + "'" + ", " + "Description = '" + txtDescription.Text + "'" + " WHERE Id = '" + txtUserID.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception E)
            {

                MessageBox.Show(E.Message);
            }
           
        }

        public void UpdateWeekly()
        {
            try
            {
                con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sinel\\Documents\\UserLog.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                cmd = new SqlCommand("Update WeeklyAppointment SET VehicleNo = '" + txtVehicleNo.Text + "'" + ", " + "Appointment = '" + appointDate.SelectedDate + "'" + ", " + "Services = '" + txtService.Text + "'" + ", " + "ProcedureCode = '" + txtCode.Text + "'" + ", " + "Description = '" + txtDescription.Text + "'" + " WHERE Id = '" + txtUserID.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception E)
            {

                MessageBox.Show(E.Message);
            }

        }

        private void btnUpdateWeekly_Click(object sender, RoutedEventArgs e)
        {
            UpdateWeekly();
        }

        private void refreshBtn_Click(object sender, RoutedEventArgs e)
        {
            ShowWeeklyData();
            ShowDailyData();
        }
    }
}
