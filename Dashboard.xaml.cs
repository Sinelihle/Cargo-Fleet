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
using System.Windows.Threading;

namespace Cargo_Fleet_Tracking_System
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        DispatcherTimer timer;

        double panelWidth;
        bool hidden;
        public Dashboard()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            timer.Tick += Timer_Tick;


            panelWidth = sidePanel.Width;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                sidePanel.Width += 1;
                if (sidePanel.Width >= panelWidth)
                {
                    timer.Stop();
                    hidden = false;
                }
            }
            else
            {
                sidePanel.Width -= 1;
                if (sidePanel.Width <= 35)
                {
                    timer.Stop();
                    hidden = true;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void PanelHeader_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }


        
        private void ListViewItem_Selected_Employees(object sender, RoutedEventArgs e)
        {
            Main.Content = new EmployeesPage();
        }

        private void ListViewItem_Selected_Vehicle(object sender, RoutedEventArgs e)
        {
            Main.Content = new VehiclePage();
        }

        private void ListViewItem_Selected_Dashboard(object sender, RoutedEventArgs e)
        {
            Main.Content = new DashboardPage();
        }

        private void ListViewItem_Selected_Profile(object sender, RoutedEventArgs e)
        {
            Main.Content = new ProfilePage();
        }

        private void Services_Selected(object sender, RoutedEventArgs e)
        {
            Main.Content = new ServicePage();   
        }
    }
}
