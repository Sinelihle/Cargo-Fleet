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
    /// Interaction logic for trackHours.xaml
    /// </summary>
    public partial class trackHours : Page
    {
        SqlConnection con;
        SqlCommand cmd;
        public trackHours()
        {
            InitializeComponent();
        }

        public void AddRecord()
        {
            try
            {
                con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\sinel\\Documents\\UserLog.mdf; Integrated Security = True; Connect Timeout = 30");
                con.Open();
                cmd = new SqlCommand("insert into TrackHours values(@EmpName, @Hours) ", con);
                cmd.Parameters.AddWithValue("@EmpName", txtEmpName.Text);
                cmd.Parameters.AddWithValue("@Hours", txtHours.Text);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception E)
            {

                MessageBox.Show(E.Message);
            }
         

        }

        public void ViewRecord()
        {
            try
            {
                con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\sinel\\Documents\\UserLog.mdf; Integrated Security = True; Connect Timeout = 30");
                con.Open();
                cmd = new SqlCommand("select * from TrackHours", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                adapt.Fill(dt);
                dataHours.ItemsSource = dt.DefaultView;
                adapt.Update(dt);
                con.Close();
            }
            catch (Exception E)
            {

                MessageBox.Show(E.Message);
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddRecord();
            ViewRecord();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sinel\\Documents\\UserLog.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            cmd = new SqlCommand("Delete From TrackHours", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void refreshBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewRecord();
        }
    }
}
