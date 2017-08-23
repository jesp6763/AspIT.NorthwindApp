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
            // Set max character length on textboxes
            firstNameTb.MaxLength = 10;
            lastNameTb.MaxLength = 20;
            titleTb.MaxLength = 30;
            addressTb.MaxLength = 60;
            cityTb.MaxLength = 15;
            regionTb.MaxLength = 15;
            postalCodeTb.MaxLength = 10;
            countryTb.MaxLength = 15;
            homePhoneTb.MaxLength = 24;
            extensionTb.MaxLength = 4;



            /*Test - Start*/
            Employee employee1 = new Employee(@"C:\Users\jesp6763\Pictures\Flaming Skull very small.png") { TitleOfCourtesy = "Hr", FirstName = "Chris", LastName = "McDonald", BirthDate = new DateTime(1956, 11, 13), HireDate = new DateTime(1993, 8, 11) };
            Employee employee2 = new Employee(string.Empty) { TitleOfCourtesy = "Hr", FirstName = "Carl", LastName = "Johnson", BirthDate = new DateTime(1987, 4, 27), HireDate = new DateTime(2003, 5, 17) };
            employeeList.Items.Add(employee1);
            employeeList.Items.Add(employee2);
            /*Test - End*/
        }

        private void EmployeeList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void FirstNameTb_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            (bool, string) result = Person.IsValidName(firstNameTb.Text);
            if(!result.Item1)
            {
                firstNameTb.Style = Resources["ErrorBox"] as Style;
                statusValue_Text.Content = result.Item2;
            }
            else
            {
                firstNameTb.Style = null;
                statusValue_Text.Content = string.Empty;
            }
        }
    }
}
