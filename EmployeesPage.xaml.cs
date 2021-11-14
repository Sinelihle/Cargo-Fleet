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

namespace Cargo_Fleet_Tracking_System
{
    /// <summary>
    /// Interaction logic for EmployeesPage.xaml
    /// </summary>
    public partial class EmployeesPage : Page
    {
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
    }
}
