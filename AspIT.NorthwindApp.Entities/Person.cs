using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AspIT.NorthwindApp.Entities
{
    public abstract class Person
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
        /// The birth date of the employee
        /// </summary>
        private DateTime birthDate;
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

        private ContactInfo contactInfo;

        #region Properties
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

        public ContactInfo ContactInfo { get => contactInfo; set => contactInfo = value; }
        #endregion

        #region Methods
        /// <summary>
        /// Checks the specified name to see if it is valid.
        /// </summary>
        /// <param name="name">Name of the person</param>
        /// <returns>A boolean telling whether it is valid or not, and a string error message</returns>
        public static (bool, string) IsValidName(string name)
        {
            if(name == string.Empty)
            {
                return (false, "Navnet må ikke være tomt.");
            }

            if(name.Contains('-'))
            {
                if(name.StartsWith("-") || name.EndsWith("-"))
                {
                    return (false, "Karakteren '-' må ikke være i starten eller slutningen af navnet.");
                }
                else if(!char.IsUpper(name[0]) || !char.IsUpper(name[name.IndexOf('-') + 1]))
                {
                    return (false, "Begge navne skal starte med stort.");
                }
            }

            return (true, string.Empty);
        }
        #endregion
    }
}
