using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.backend
{
    /// <summary>
    /// Represents an employee.
    /// <para>An employee has a name, address, email, phone number, manager, lunch length, an hourly rate, an overtime rate, and a billable rate.</para>
    /// </summary>
    [Serializable]
    public class Employee
    {
        /// <summary>
        /// A unique GUID representing this employee.
        /// </summary>
        public string UniqueID { get; set; }

        /// <summary>
        /// The employee's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The <see cref="Address"/> associated with this employee.
        /// </summary>
        public Address EmpAddress { get; set; }

        /// <summary>
        /// The email address associated with this employee.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The phone number associated with this employee.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The manager <see cref="Employee"/> object associated with this employee.
        /// </summary>
        public Employee Manager { get; set; }

        /// <summary>
        /// The length (in hours) of this employee's lunch break.
        /// </summary>
        public double LunchLength { get; set; }

        /// <summary>
        /// The hourly, normal rate for this employee.
        /// </summary>
        public decimal HourlyRate { get; set; }

        /// <summary>
        /// The overtime rate for this employee.
        /// </summary>
        public decimal OvertimeRate { get; set; }

        /// <summary>
        /// The billable rate for this employee.
        /// </summary>
        public decimal BillableRate { get; set; }

        /// <summary>
        /// Construct an empty <see cref="Employee"/> object.
        /// </summary>
        public Employee()
        {
            GenerateUniqueID();
        }

        /// <summary>
        /// Construct an employee object with all necessary information defined.
        /// </summary>
        /// <param name="name">The employee's name.</param>
        /// <param name="empAddress">An <see cref="Address"/> object representing this employee's address.</param>
        /// <param name="hourlyRate">The hourly rate this employee is paid.</param>
        /// <param name="overtimeRate">The overtime rate this employee is paid.</param>
        /// <param name="billableRate">The billable rate this employee is paid.</param>
        /// <param name="lunchLength">The length (in hours) of this employee's lunch break.</param>
        public Employee(string name, Address empAddress, decimal hourlyRate, decimal overtimeRate, decimal billableRate, double lunchLength)
        {
            Name = name;
            EmpAddress = empAddress;
            HourlyRate = hourlyRate;
            OvertimeRate = overtimeRate;
            BillableRate = billableRate;
            LunchLength = lunchLength;
            GenerateUniqueID();
        }

        /// <summary>
        /// Generate a unique GUID for this employee; used when associating this employee to a <see cref="TimeSheet"/>.
        /// </summary>
        private void GenerateUniqueID()
        {
            UniqueID = Guid.NewGuid().ToString("B").ToUpper();
        }

        /// <summary>
        /// Returns a string representation of this employee.
        /// </summary>
        /// <returns><c>UniqueID: Name</c></returns>
        public override string ToString()
        {
            return $"{UniqueID}: {Name}";
        }
    }
}
