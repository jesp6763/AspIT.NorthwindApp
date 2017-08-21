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
using AspIT.NorthwindApp.Entities;

namespace AspIT.NorthwindApp.Gui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tilstandCB.SelectedIndex = 0;

            /*Test - Start*/
            Employee employee1 = new Employee(@"C:\Users\jesp6763\Pictures\Flaming Skull very small.png") { TitleOfCourtesy = "Hr", FirstName = "Chris", LastName = "McDonald", BirthDate = new DateTime(1956, 11, 13), HireDate = new DateTime(1993, 8, 11) };
            Employee employee2 = new Employee(string.Empty) { TitleOfCourtesy = "Hr", FirstName = "Carl", LastName = "Johnson", BirthDate = new DateTime(1987, 4, 27), HireDate = new DateTime(2003, 5, 17) };
            employeeList.Items.Add(employee1);
            employeeList.Items.Add(employee2);
            /*Test - End*/
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch(tilstandCB.SelectedIndex)
            {
                case 0: // Read-only | Read
                    deleteEmployeeBtn.Visibility = Visibility.Hidden;
                    editEmployeeBtn.Visibility = Visibility.Visible;
                    break;
                case 1: // Edit | Read, edit, and delete
                    deleteEmployeeBtn.Visibility = Visibility.Visible;
                    editEmployeeBtn.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void EmployeeList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(employeeList.SelectedIndex > -1)
            {
                deleteEmployeeBtn.IsEnabled = true;
                editEmployeeBtn.IsEnabled = true;
            }
            else
            {
                deleteEmployeeBtn.IsEnabled = false;
                editEmployeeBtn.IsEnabled = false;
            }
        }
    }
}
