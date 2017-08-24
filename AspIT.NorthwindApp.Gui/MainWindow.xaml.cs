using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            Validate("Name", firstNameTb);
        }

        private void LastNameTb_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            Validate("Name", lastNameTb);
        }

        private void AddressTb_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            Validate("Address", addressTb);
        }

        private void CityTb_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            Validate("City", cityTb);
        }

        private void RegionTb_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            Validate("Region", regionTb);
        }

        private void PostalCodeTb_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            Validate("PostalCode", postalCodeTb);
        }

        private void CountryTb_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            Validate("Country", countryTb);
        }

        private void HomePhoneTb_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            Validate("Phone", homePhoneTb);
        }

        private void TitleTb_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            Validate("Title", titleTb);
        }

        private void ExtensionTb_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            Validate("Extension", extensionTb);
        }

        private void ReportsToTb_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            Validate("ReportsTo", reportsToTb);
        }

        /// <summary>
        /// Validates the text with the specified method.
        /// </summary>
        /// <param name="validationMethod">The validation method: Name, City, Region, PostalCode, Country, Title, Extension, and Phone</param>
        /// <param name="textBox">The textbox to validate</param>
        private void Validate(string validationMethod, TextBox textBox)
        {
            (bool, string) result = (false, string.Empty);
            switch (validationMethod)
            {
                case "Name":
                    result = Person.IsValidName(textBox.Text);
                    break;
                case "City":
                    result = Person.IsValidCity(textBox.Text);
                    break;
                case "Region":
                    result = Person.IsValidRegion(textBox.Text);
                    break;
                case "PostalCode":
                    result = Person.IsValidPostalCode(textBox.Text);
                    break;
                case "Country":
                    result = Person.IsValidCountry(textBox.Text);
                    break;
                case "Title":
                    result = Employee.IsValidTitle(textBox.Text);
                    break;
                case "Extension":
                    result = Employee.IsValidExtension(textBox.Text);
                    break;
                case "ReportsTo":
                    result = Employee.IsValidReportsTo(textBox.Text);
                    break;
                case "Phone":
                    result = ContactInfo.IsValidPhone(textBox.Text);
                    break;
            }

            if (!result.Item1)
            {
                textBox.Style = Resources["ErrorBox"] as Style;
                statusBar.Background = new SolidColorBrush(Color.FromRgb(225, 65, 65));
            }
            else
            {
                textBox.Style = null;
                statusBar.Background = new SolidColorBrush(Color.FromRgb(65, 105, 225));
            }

            statusValue_Text.Content = result.Item2;
        }
    }
}
