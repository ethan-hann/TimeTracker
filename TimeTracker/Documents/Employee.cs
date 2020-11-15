using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.Documents
{
    [Serializable]
    public class Employee
    {
        //Info
        public string Name { get; set; }
        public Address EmpAddress { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Employee Manager { get; set; }

        //Rates
        public decimal HourlyRate { get; set; }
        public decimal OvertimeRate { get; set; }
        public decimal BillableRate { get; set; }

        public Employee()
        {
            
        }

        public Employee(string name, Address empAddress, decimal hourlyRate, decimal overtimeRate, decimal billableRate)
        {
            Name = name;
            EmpAddress = empAddress;
            HourlyRate = hourlyRate;
            OvertimeRate = overtimeRate;
            BillableRate = billableRate;
        }
    }
}
