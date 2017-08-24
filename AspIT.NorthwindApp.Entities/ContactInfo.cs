using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace AspIT.NorthwindApp.Entities
{
    /// <summary>
    /// Represents contact info
    /// </summary>
    public struct ContactInfo
    {
        /// <summary>
        /// Home phone number
        /// </summary>
        private string homePhone;

        /// <summary>
        /// Initialises an instance of this struct
        /// </summary>
        /// <param name="homePhone">The home phone number</param>
        public ContactInfo(string homePhone) : this()
        {
            HomePhone = homePhone;
        }

        #region Properties
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
        #endregion

        #region Methods
        /// <summary>
        /// Checks the specified name to see if it is valid.
        /// </summary>
        /// <param name="name">The name you want to validate</param>
        /// <returns>A boolean telling whether it is valid or not, and a string error message</returns>
        public static (bool, string) IsValidName(string name)
        {
            if (name == string.Empty)
            {
                return (false, "Navnet må ikke være tomt.");
            }

            if (name.Contains('-'))
            {
                if (name.StartsWith("-") || name.EndsWith("-"))
                {
                    return (false, "Karakteren '-' må ikke være i starten eller slutningen af navnet.");
                }

                if (!char.IsUpper(name[name.IndexOf('-') + 1]))
                {
                    return (false, "Navnet efter '-' tegnet skal starte med stort.");
                }
            }
            if (!char.IsUpper(name[0]))
            {
                return (false, "Navn skal starte med stort.");
            }

            // Check for numbers
            for (int i = 0; i < name.Length; i++)
            {
                if (char.IsNumber(name[i]))
                {
                    return (false, "Der må ikke være tal i navnet.");
                }
            }

            return (true, string.Empty);
        }
        #endregion
    }
}
