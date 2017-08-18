using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Drawing;

namespace AspIT.NorthwindApp.Entities
{
    /// <summary>
    /// Represents an employee
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// The first name of the employee
        /// </summary>
        private string firstName;
        /// <summary>
        /// The last name of the employee
        /// </summary>
        private string lastName;
        /// <summary>
        /// The title of the employee
        /// </summary>
        private string title;
        /// <summary>
        /// The title of courtesy of the employee
        /// </summary>
        private string titleOfCourtesy;
        /// <summary>
        /// The birth date of the employee
        /// </summary>
        private DateTime birthDate;
        /// <summary>
        /// The hire date of the employee
        /// </summary>
        private DateTime hireDate;
        /// <summary>
        /// The address of the employee
        /// </summary>
        private string address;
        /// <summary>
        /// The city of the employee
        /// </summary>
        private string city;
        /// <summary>
        /// The region of the employee
        /// </summary>
        private string region;
        /// <summary>
        /// The postal code of the employee
        /// </summary>
        private string postalCode;
        /// <summary>
        /// The country the employee lives in
        /// </summary>
        private string country;
        /// <summary>
        /// The employee's home phone
        /// </summary>
        private string homePhone;
        /// <summary>
        /// The extension of the employee
        /// </summary>
        private string extension;
        /// <summary>
        /// The photo of the employee
        /// </summary>
        private Image photo;
        /// <summary>
        /// The notes of the employee
        /// </summary>
        private string notes;
        /// <summary>
        /// 
        /// </summary>
        private int reportsTo;
        /// <summary>
        /// The path to the photo
        /// </summary>
        private string photoPath;

        /// <summary>
        /// Initializes a new instance of this class
        /// </summary>
        public Employee()
        {

        }

        /// <summary>
        /// Gets or sets the first name
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when value is greater than 10</exception>
        /// <exception cref="ArgumentException">Thrown when the value is empty, null or has special characters, or numbers</exception>
        public string FirstName
        {
            get => firstName;
            set
            {
                if(!string.IsNullOrWhiteSpace(value) && Regex.IsMatch(value, "^[ A-Za-z]+$"))
                {
                    if(value.Length <= 10)
                    {
                        firstName = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        /// <summary>
        /// Gets or sets the last name
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when value is greater than 20</exception>
        /// <exception cref="ArgumentException">Thrown when the value is empty, null or has special characters, or numbers</exception>
        public string LastName
        {
            get => lastName;
            set
            {
                if(!string.IsNullOrWhiteSpace(value) && Regex.IsMatch(value, "^[ A-Za-z]+$"))
                {
                    if(value.Length <= 20)
                    {
                        lastName = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        /// <summary>
        /// Gets or sets the title
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when value is greater than 30</exception>
        /// <exception cref="ArgumentException">Thrown when the value is empty, null or has special characters, or numbers</exception>
        public string Title
        {
            get => title;
            set
            {
                if(!string.IsNullOrWhiteSpace(value) && Regex.IsMatch(value, "^[ A-Za-z]+$"))
                {
                    if(value.Length <= 30)
                    {
                        title = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        /// <summary>
        /// Gets or sets the title of courtesy
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when value is greater than 25</exception>
        /// <exception cref="ArgumentException">Thrown when the value is empty, null or has special characters, or numbers</exception>
        public string TitleOfCourtesy
        {
            get => titleOfCourtesy;
            set
            {
                if(!string.IsNullOrWhiteSpace(value) && Regex.IsMatch(value, "^[ A-Za-z]+$"))
                {
                    if(value.Length <= 25)
                    {
                        titleOfCourtesy = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        /// <summary>
        /// Gets or sets the birthdate
        /// </summary>
        public DateTime BirthDate
        {
            get => birthDate;
            set
            {
                birthDate = value;
                // TODO: Validate, so you can't set birthdate to something higher than todays date
                /*
                if()
                {
                    throw new ArgumentException();
                }*/
            }
        }

        /// <summary>
        /// Gets or sets the hire date
        /// </summary>
        public DateTime HireDate
        {
            get => hireDate;
            set
            {
                hireDate = value;
                // TODO: Validate, so you can't set hire date to something higher than todays date
                /*
                if()
                {
                    throw new ArgumentException();
                }*/
            }
        }

        /// <summary>
        /// Gets or sets the address
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when value is greater than 60</exception>
        /// <exception cref="ArgumentException">Thrown when the value is empty, null or has special characters</exception>
        public string Address
        {
            get => address;
            set
            {
                if(!string.IsNullOrWhiteSpace(value) && Regex.IsMatch(value, "^[ A-Za-z0-9-]+$"))
                {
                    if(value.Length <= 60)
                    {
                        address = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }


        /// <summary>
        /// Gets or sets the city
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when value is greater than 15</exception>
        /// <exception cref="ArgumentException">Thrown when the value is empty, null or has special characters, or numbers</exception>
        public string City
        {
            get => city;
            set
            {
                if(!string.IsNullOrWhiteSpace(value) && Regex.IsMatch(value, "^[ A-Za-z]+$"))
                {
                    if(value.Length <= 15)
                    {
                        city = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        /// <summary>
        /// Gets or sets the region
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when value is greater than 15</exception>
        /// <exception cref="ArgumentException">Thrown when the value is empty, null or has special characters, or numbers</exception>
        public string Region
        {
            get => region;
            set
            {
                if(!string.IsNullOrWhiteSpace(value) && Regex.IsMatch(value, "^[ A-Za-z]+$"))
                {
                    if(value.Length <= 15)
                    {
                        region = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        /// <summary>
        /// Gets or sets the postal code
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when value is greater than 10</exception>
        /// <exception cref="ArgumentException">Thrown when the value is empty, null, has special characters, or letters</exception>
        public string PostalCode
        {
            get => postalCode;
            set
            {
                if(!string.IsNullOrWhiteSpace(value) && Regex.IsMatch(value, "^[0-9]+$"))
                {
                    if(value.Length <= 10)
                    {
                        postalCode = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        /// <summary>
        /// Gets or sets the country
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when value is greater than 15</exception>
        /// <exception cref="ArgumentException">Thrown when the value is empty, null, has special characters, or numbers</exception>
        public string Country
        {
            get => country;
            set
            {
                if(!string.IsNullOrWhiteSpace(value) && Regex.IsMatch(value, "^[ A-Za-z]+$"))
                {
                    if(value.Length <= 15)
                    {
                        country = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        /// <summary>
        /// Gets or sets the home phone
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when value is greater than 24</exception>
        /// <exception cref="ArgumentException">Thrown when the value is empty, null, has special characters, or letters</exception>
        public string HomePhone
        {
            get => homePhone;
            set
            {
                if(!string.IsNullOrWhiteSpace(value) && Regex.IsMatch(value, "^[0-9]+$"))
                {
                    if(value.Length <= 24)
                    {
                        homePhone = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        /// <summary>
        /// Gets or sets the extension
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when value is greater than 4</exception>
        /// <exception cref="ArgumentException">Thrown when the value is empty, null, or has special characters</exception>
        public string Extension
        {
            get => extension;
            set
            {
                if(!string.IsNullOrWhiteSpace(value) && Regex.IsMatch(value, "^[A-Za-z0-9]+$"))
                {
                    if(value.Length <= 4)
                    {
                        extension = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        /// <summary>
        /// Gets or sets the photo
        /// </summary>
        public Image Photo
        {
            get
            {
                if(photo == null)
                {
                    Photo = Image.FromFile(PhotoPath);
                }

                return photo;
            }
            set
            {
                photo?.Dispose();
                photo = value;
            }
        }

        /// <summary>
        /// Gets or sets the notes
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when the value is empty, or null</exception>
        public string Notes
        {
            get => notes;
            set
            {
                if(!string.IsNullOrWhiteSpace(value))
                {
                    notes = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        /// <summary>
        /// Gets or sets reports to
        /// </summary>
        public int ReportsTo
        {
            get => reportsTo;
            set => reportsTo = value;
        }

        /// <summary>
        /// Gets or sets the photo path
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when value is greater than 255</exception>
        /// <exception cref="ArgumentException">Thrown when the value is empty, null, or file does not exist</exception>
        public string PhotoPath
        {
            get => photoPath;
            set
            {
                if(!string.IsNullOrWhiteSpace(value) && File.Exists(value))
                {
                    if(value.Length <= 255)
                    {
                        photoPath = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
    }
}
