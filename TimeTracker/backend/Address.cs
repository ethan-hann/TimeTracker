using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.backend
{
    /// <summary>
    /// Represents an employee's address.
    /// </summary>
    [Serializable]
    public class Address
    {
        /// <summary>
        /// The street component of this address.
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// The city component of this address.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// The state component of this address.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// The zipcode component of this address.
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// Create an empty <see cref="Address"/> object.
        /// </summary>
        public Address()
        {

        }

        /// <summary>
        /// Create an <see cref="Address"/> object with the street, city, state, and zip code defined.
        /// </summary>
        /// <param name="street">The street component of the address.</param>
        /// <param name="city">The city component of the address.</param>
        /// <param name="state">The state component of the address.</param>
        /// <param name="zipCode">The zip code component of the address.</param>
        public Address(string street, string city, string state, string zipCode)
        {
            Street = street;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        /// <summary>
        /// Returns a string representation of this address:
        /// </summary>
        /// <returns><c>Street City, State ZipCode</c></returns>
        public override string ToString()
        {
            return $"{Street} {City}, {State} {ZipCode}";
        }
    }
}
