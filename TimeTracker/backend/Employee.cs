using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.backend
{
    /// <summary>
    /// Represents an employee.
    /// <para>An employee has a name, address, email, phone number, manager, an hourly rate, an overtime rate, and a billable rate.</para>
    /// </summary>
    [Serializable]
    public class Employee
    {
        //Info
        public string UniqueID { get; private set; }
        public string Name { get; set; }
        public Address EmpAddress { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Employee Manager { get; set; }

        //Rates
        public decimal HourlyRate { get; set; }
        public decimal OvertimeRate { get; set; }
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
        public Employee(string name, Address empAddress, decimal hourlyRate, decimal overtimeRate, decimal billableRate)
        {
            Name = name;
            EmpAddress = empAddress;
            HourlyRate = hourlyRate;
            OvertimeRate = overtimeRate;
            BillableRate = billableRate;
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
