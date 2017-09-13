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
using AspIT.NorthwindApp.DataAccess;
using AspIT.NorthwindApp.DataAccess.Repositories;
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

        /// <summary>
        /// Gets or sets the error messages
        /// </summary>
        public static Dictionary<string, string> ErrorMessages { get; } = new Dictionary<string, string>();

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

            // Set default birthdate, and hiredate
            birthDatePicker.SelectedDate = DateTime.Today;
            hireDatePicker.SelectedDate = DateTime.Today;


            /*Test - Start*/
            EmployeeDataRepository employeeRepository = new EmployeeDataRepository();
            foreach (Employee employee in employeeRepository.GetAll())
            {
                employeeList.Items.Add(employee);
            }
            /*Test - End*/
        }

        private void EmployeeList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (employeeList.SelectedIndex > -1)
            {
                Employee curEmployee = employeeList.SelectedItem as Employee;
                comboBox.Text = curEmployee.TitleOfCourtesy;
                firstNameTb.Text = curEmployee.FirstName;
                lastNameTb.Text = curEmployee.LastName;
                addressTb.Text = curEmployee.Address;
                cityTb.Text = curEmployee.City;
                regionTb.Text = curEmployee.Region;
                postalCodeTb.Text = curEmployee.PostalCode;
                countryTb.Text = curEmployee.Country;
                homePhoneTb.Text = curEmployee.ContactInfo.HomePhone;
                titleTb.Text = curEmployee.Title;
                extensionTb.Text = curEmployee.Extension;
                reportsToTb.Text = curEmployee.ReportsTo.ToString();
                notesTb.Text = curEmployee.Notes;
                hireDatePicker.SelectedDate = curEmployee.HireDate;
                birthDatePicker.SelectedDate = curEmployee.BirthDate;
            }
            
            ValidateAll();
        }

        private void FirstNameTb_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            Validate("FirstName", firstNameTb);
        }

        private void LastNameTb_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            Validate("LastName", lastNameTb);
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
        /// Validates all inputs
        /// </summary>
        private void ValidateAll()
        {
            Validate("FirstName", firstNameTb);
            Validate("LastName", lastNameTb);
            Validate("Address", addressTb);
            Validate("City", cityTb);
            Validate("Region", regionTb);
            Validate("PostalCode", postalCodeTb);
            Validate("Country", countryTb);
            Validate("Phone", homePhoneTb);
            Validate("Title", titleTb);
            Validate("Extension", extensionTb);
            Validate("ReportsTo", reportsToTb);
        }

        /// <summary>
        /// Validates the text with the specified method.
        /// </summary>
        /// <param name="validationMethod">The validation method: FirstName, LastName, City, Region, PostalCode, Country, Title, Extension, and Phone</param>
        /// <param name="textBox">The textbox to validate</param>
        private void Validate(string validationMethod, TextBox textBox)
        {
            (bool, string) result = (false, string.Empty);
            switch (validationMethod)
            {
                case "FirstName":
                    result = Person.IsValidName(textBox.Text);
                    break;
                case "LastName":
                    result = Person.IsValidName(textBox.Text);
                    break;
                case "Address":
                    result = Person.IsValidAddress(textBox.Text);
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

                if (!ErrorMessages.ContainsKey(validationMethod))
                {
                    ErrorMessages.Add(validationMethod, result.Item2);
                }
                else
                {
                    ErrorMessages[validationMethod] = result.Item2;
                }
            }
            else
            {
                textBox.Style = null;
                if (ErrorMessages.ContainsKey(validationMethod))
                {
                    ErrorMessages.Remove(validationMethod);
                }
            }

            if (ErrorMessages.Count == 0)
            {
                statusBar.Background = new SolidColorBrush(Color.FromRgb(65, 105, 225));
                statusValue_Text.Content = "Klar";

                if (employeeList.SelectedIndex > -1)
                {
                    addBtn.IsEnabled = false;
                    editBtn.IsEnabled = true;
                    deleteBtn.IsEnabled = true;
                }
                else
                {
                    addBtn.IsEnabled = true;
                    editBtn.IsEnabled = false;
                    deleteBtn.IsEnabled = false;
                }
            }
            else
            {
                statusBar.Background = new SolidColorBrush(Color.FromRgb(225, 65, 65));
                statusValue_Text.Content = ErrorMessages[ErrorMessages.Keys.ElementAt(0)];
                addBtn.IsEnabled = false;
                editBtn.IsEnabled = false;
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            EmployeeDataRepository employeeRepository = new EmployeeDataRepository();
            int? reportsTo = null;
            if (reportsToTb.Text != string.Empty)
            {
                reportsTo = int.Parse(reportsToTb.Text);
            }
            Employee employee = new Employee(comboBox.Text, titleTb.Text, hireDatePicker.SelectedDate.Value, extensionTb.Text, notesTb.Text, reportsTo, firstNameTb.Text, lastNameTb.Text, birthDatePicker.SelectedDate.Value, addressTb.Text, cityTb.Text, regionTb.Text, postalCodeTb.Text, countryTb.Text, new ContactInfo(homePhoneTb.Text));
            employeeRepository.Save(employee);
            employeeList.Items.Add(employee);
        }

        private void EmployeeList_MouseDown(object sender, MouseButtonEventArgs e)
        {
            employeeList.SelectedIndex = -1;
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            Employee employee = employeeList.SelectedItem as Employee;
            EmployeeDataRepository employeeRepository = new EmployeeDataRepository();
            employee.FirstName = firstNameTb.Text;
            employee.LastName = lastNameTb.Text;
            employee.Title = titleTb.Text;
            employee.TitleOfCourtesy = comboBox.Text;
            employee.Extension = extensionTb.Text;
            employee.HireDate = hireDatePicker.SelectedDate.Value;
            employee.BirthDate = birthDatePicker.SelectedDate.Value;
            employee.Notes = notesTb.Text;
            employee.Address = addressTb.Text;
            employee.City = cityTb.Text;
            employee.Region = regionTb.Text;
            employee.Country = countryTb.Text;
            employee.PostalCode = postalCodeTb.Text;
            employee.ContactInfo = new ContactInfo(homePhoneTb.Text);

            if (reportsToTb.Text != string.Empty)
            {
                employee.ReportsTo = int.Parse(reportsToTb.Text);
            }
            else
            {
                employee.ReportsTo = null;
            }
            employeeRepository.Update(employee.Id, employee);
            statusValue_Text.Content = "Medarbejder gemt";
            employeeList.Items.Refresh();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            EmployeeDataRepository repository = new EmployeeDataRepository();
            repository.Delete((employeeList.SelectedItem as Employee).Id);
            employeeList.Items.RemoveAt(employeeList.SelectedIndex);
        }
    }
}
