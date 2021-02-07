using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TimeTracker.Properties;
using TimeTracker.utility;

namespace TimeTracker.backend

{
    /// <summary>
    /// Represents a day of time (normal, overtime, and billable). Time is added to this day using the helper methods.
    /// <para>At the end of each day, this object is added to the <see cref="TimeSheet"/> and then saved.</para>
    /// </summary>
    [Serializable]
    public class DayTime
    {
        /// <summary>
        /// A unique GUID representing this day.
        /// </summary>
        public string UniqueID { get; set; }

        /// <summary>
        /// A list of strings representing notes for this day.
        /// </summary>
        public List<string> Notes { get; set; } = new List<string>();

        /// <summary>
        /// The amount of normal, non-overtime, non-billable time for this day.
        /// </summary>
        [XmlElement(typeof(XmlTimeSpan))]
        public TimeSpan NormalTime { get; set; }

        /// <summary>
        /// The amount of overtime, if any, this day produced.
        /// </summary>
        [XmlElement(typeof(XmlTimeSpan))]
        public TimeSpan Overtime { get; set; }

        /// <summary>
        /// The amount of billable time for this day.
        /// </summary>
        [XmlElement(typeof(XmlTimeSpan))]
        public TimeSpan BillableTime { get; set; }

        /// <summary>
        /// The date associated with this day.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Create an empty <see cref="DayTime"/> object with no <see cref="DateTime"/> associated with it.
        /// <para>Note that this object represents nothing if it has no day associated.</para>
        /// </summary>
        public DayTime()
        {
            GenerateUniqueID();
        }

        /// <summary>
        /// Create a <see cref="DayTime"/> object with the specified <see cref="DateTime"/>.
        /// </summary>
        /// <param name="date"></param>
        public DayTime(DateTime date)
        {
            Date = date;
            GenerateUniqueID();
        }

        /// <summary>
        /// Set the date with which this <see cref="DayTime"/> is associated.
        /// </summary>
        /// <param name="date">The <see cref="DateTime"/> to set this day to.</param>
        public void SetDate(DateTime date)
        {
            Date = date;
        }

        /// <summary>
        /// Add normal, non-billable, non-overtime time to this day.
        /// </summary>
        /// <param name="time">The <see cref="TimeSpan"/> representing the normal time to add.</param>
        public void AddNormalTime(TimeSpan time)
        {
            NormalTime = time;
        }

        /// <summary>
        /// Add overtime to this day.
        /// </summary>
        /// <param name="time">The <see cref="TimeSpan"/> representing the overtime to add.</param>
        public void AddOvertime(TimeSpan time)
        {
            Overtime = time;
        }

        /// <summary>
        /// Add billable time to this day.
        /// </summary>
        /// <param name="time">The <see cref="TimeSpan"/> representing the billable time to add.</param>
        public void AddBillableTime(TimeSpan time)
        {
            BillableTime = time;
        }

        /// <summary>
        /// Add a note to this day.
        /// </summary>
        /// <param name="note">The note to add.</param>
        public void AddNote(string note)
        {
            Notes.Add(note);
        }

        /// <summary>
        /// Generate a unique GUID for this day; used when adding this day to a <see cref="TimeSheet"/>.
        /// </summary>
        private void GenerateUniqueID()
        {
            UniqueID = Guid.NewGuid().ToString("B").ToUpper();
        }

        /// <summary>
        /// Get the monetary amount of pay for the normal amount of hours worked.
        /// </summary>
        /// <returns>A <see cref="decimal"/> value representing the pay for today.</returns>
        public decimal GetNormalPay()
        {
            double normalTimeHours = NormalTime.TotalHours;
            
            return (decimal) normalTimeHours * EmployeeInformation.Instance.GetEmployee().HourlyRate;
        }

        /// <summary>
        /// Get the monetary amount of pay for the billable time today.
        /// </summary>
        /// <returns>A <see cref="decimal"/> value representing the pay for today.</returns>
        public decimal GetBillablePay()
        {
            double billableTimeHours = BillableTime.TotalHours;

            return (decimal)billableTimeHours * EmployeeInformation.Instance.GetEmployee().BillableRate;
        }

        /// <summary>
        /// Get the monetary amount of pay for the overtime today.
        /// </summary>
        /// <returns>A <see cref="decimal"/> value representing the pay for today.</returns>
        public decimal GetOvertimePay()
        {
            double overtimeHours = Overtime.TotalHours;

            return (decimal)overtimeHours * EmployeeInformation.Instance.GetEmployee().OvertimeRate;
        }

        /// <summary>
        /// Get the grand monetary total of pay for today.
        /// </summary>
        /// <returns>A <see cref="decimal"/> value representing the total pay for today.</returns>
        public decimal GetTotalPay()
        {
            return GetNormalPay() + GetBillablePay() + GetOvertimePay();
        }
    }
}
