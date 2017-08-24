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
            Employee employee1 = new Employee("Goat", DateTime.Today, "3183", 1, "Jack", "Slalom", new DateTime(1949, 3, 29), "Boredom street", "Desert city", "Desert", "493919", "Dafert", new ContactInfo("2919023932"));
            Employee employee2 = new Employee("Moose", DateTime.Today, "412", 0, "Jonn", "Jones", new DateTime(1954, 6, 23), "Windy street", "Water", "Hurrri", "5323", "Hurricane", new ContactInfo("51251341"));
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
                statusBar.Background = new SolidColorBrush(Color.FromRgb(225, 65, 65));
            }
            else
            {
                firstNameTb.Style = null;
                statusValue_Text.Content = string.Empty;
                statusBar.Background = new SolidColorBrush(Color.FromRgb(65, 105, 225));
            }
        }

        private void LastNameTb_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            (bool, string) result = Person.IsValidName(lastNameTb.Text);
            if (!result.Item1)
            {
                lastNameTb.Style = Resources["ErrorBox"] as Style;
                statusValue_Text.Content = result.Item2;
                statusBar.Background = new SolidColorBrush(Color.FromRgb(225, 65, 65));
            }
            else
            {
                lastNameTb.Style = null;
                statusValue_Text.Content = string.Empty;
                statusBar.Background = new SolidColorBrush(Color.FromRgb(65, 105, 225));
            }
        }
    }
}
