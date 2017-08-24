﻿using System;
using System.Text.RegularExpressions;
using System.IO;

namespace AspIT.NorthwindApp.Entities
{
    /// <summary>
    /// Represents an employee
    /// </summary>
    public class Employee : Person
    {
        #region Fields
        /// <summary>
        /// The title of the employee
        /// </summary>
        private string title;
        /// <summary>
        /// The title of courtesy of the employee
        /// </summary>
        private string titleOfCourtesy;
        /// <summary>
        /// The hire date of the employee
        /// </summary>
        private DateTime hireDate;
        /// <summary>
        /// The extension of the employee
        /// </summary>
        private string extension;
        /// <summary>
        /// The photo of the employee
        /// </summary>
        private Uri photo;
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
        #endregion

        /// <summary>
        /// Initializes a new instance of this class
        /// </summary>
        /// <param name="firstName">The person's firstname</param>
        /// <param name="lastName">The person's lastname</param>
        /// <param name="birthDate">The person's birthdate</param>
        /// <param name="address">The person's address</param>
        /// <param name="city">The city of the person</param>
        /// <param name="region">The region of the city</param>
        /// <param name="postalCode">The postal code of the city</param>
        /// <param name="country">The country</param>
        /// <param name="contactInfo">The person's contact informations</param>
        public Employee(string firstName, string lastName, DateTime birthDate, string address, string city, string region, string postalCode, string country, ContactInfo contactInfo) : base(firstName, lastName, birthDate, address, city, region, postalCode, country, contactInfo)
        {
            PhotoPath = photoPath;
        }

        #region Properties
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
        public Uri Photo
        {
            get
            {
                if(photo == null)
                {
                    photo = new Uri(PhotoPath, UriKind.RelativeOrAbsolute);
                }
                return photo;
            }
            set
            {
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
        public string PhotoPath
        {
            get => photoPath;
            set
            {
                if(!string.IsNullOrEmpty(value) || File.Exists(value))
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
                    photoPath = "/Images/IngenPhoto.png";
                }
            }
        }
        #endregion
    }
}
