using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TimeTracker.utility
{
    public class Validator
    {
        private static readonly string emailRegExPattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                       + "@"
                                       + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z";

        private static readonly string phoneRegExPatterns = "^(\\+\\d{1,3}( )?)?((\\(\\d{3}\\))|\\d{3})[- .]?\\d{3}[- .]?\\d{4}$"
                                        + "|^(\\+\\d{1,3}( )?)?(\\d{3}[ ]?){2}\\d{3}$"
                                        + "|^(\\+\\d{1,3}( )?)?(\\d{3}[ ]?)(\\d{2}[ ]?){2}\\d{2}$";

        /// <summary>
        /// Validates an e-mail address against an email regular expression pattern.
        /// </summary>
        /// <param name="emailAddress">The email address to validate.</param>
        /// <returns><c>True</c> if the email is valid; <c>False</c> otherwise.</returns>
        public static bool ValidateEmail(string emailAddress)
        {
            return Regex.IsMatch(emailAddress, emailRegExPattern);
        }

        /// <summary>
        /// Validates a phone number against a phone number regular expression pattern.
        /// <para>This pattern allows the phone number to be formatted in many different ways.</para>
        /// </summary>
        /// <param name="phoneNumber">The phone number to validate.</param>
        /// <returns><c>True</c> if the phone number is valid; <c>False</c> otherwise.</returns>
        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, phoneRegExPatterns);
        }
    }
}
