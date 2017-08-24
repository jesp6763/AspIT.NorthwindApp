using System;
using System.Text.RegularExpressions;

namespace AspIT.NorthwindApp.Entities
{
    public struct ContactInfo
    {
        /// <summary>
        /// Home phone number
        /// </summary>
        private string homePhone;

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
    }
}
