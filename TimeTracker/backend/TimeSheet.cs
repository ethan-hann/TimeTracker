using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Properties;

namespace TimeTracker.backend
{
    /// <summary>
    /// Represents a week of time (normal, overtime, and billable). Days are added to this timesheet using the helper methods.
    /// <para>To add time to a specific day, use the <see cref="DayTime"/> class.</para>
    /// <para>This class cannot be instantiated. Instead, new timesheets must be created with the <see cref="New()"/> method. This should only be done at the start of a new week.</para>
    /// </summary>
    [Serializable]
    public class TimeSheet
    {
        /// <summary>
        /// The unique GUID associated with this timesheet.
        /// </summary>
        public string UniqueID { get; set; }

        /// <summary>
        /// The <see cref="backend.Employee"/> object associated with this timesheet.
        /// </summary>
        public Employee Employee { get; set; }


        private DateTime weekStart;
        private DateTime weekEnd;

        /// <summary>
        /// Set the work week start date.
        /// </summary>
        /// <param name="start">The starting date of this work week.</param>
        public void SetWeekStart(DateTime start)
        {
            weekStart = start;
        }

        /// <summary>
        /// Set the work week end date.
        /// </summary>
        /// <param name="end">The ending date of this work week.</param>
        public void SetWeekEnd(DateTime end)
        {
            if (weekStart.AddDays(Settings.Default.WorkWeekLength) <= end)
            {
                weekEnd = end;
            }
        }

        /// <summary>
        /// Get the starting date of this work week.
        /// </summary>
        public DateTime GetWeekStart()
        {
            return weekStart;
        }

        /// <summary>
        /// Get the ending date of this work week.
        /// </summary>
        /// <returns></returns>
        public DateTime GetWeekEnd()
        {
            if (weekEnd == null)
            {
                if (Days != null)
                {
                    return Days.Keys.ElementAt(0).AddDays(Settings.Default.WorkWeekLength);
                }
                weekEnd = DateTime.Now.AddDays(Settings.Default.WorkWeekLength);
            }

            return weekEnd;
        }

        /// <summary>
        /// Represents the days that make up this timesheet.
        /// <para>
        /// The key is a <see cref="DateTime"/> object, however only the <see cref="DateTime.Date"/> component is used
        /// so that the time component does not affect the uniqueness of entries.
        /// </para>
        /// <para>The size of the <see cref="Days"/> dictionary is dependent on the value saved in <see cref="Settings.Default"/>.
        /// If there is an attempt to add a day to this dictionary that would make the Count go past the WorkWeekLength,
        /// a new <see cref="TimeSheet"/> instance is created.
        /// </para>
        /// </summary>
        public Dictionary<DateTime, DayTime> Days { get; private set; }

        public TimeSheet() 
        {
            Days = new Dictionary<DateTime, DayTime>(Settings.Default.WorkWeekLength);
            GenerateUniqueID();

            SetWeekStart(DateTime.Now);
            weekEnd = DateTime.Now.AddDays(Settings.Default.WorkWeekLength);
        }

        private void CreateNewTimeSheet()
        {
            Days = new Dictionary<DateTime, DayTime>(Settings.Default.WorkWeekLength);
            GenerateUniqueID();

            SetWeekStart(DateTime.Now);
            weekEnd = DateTime.Now.AddDays(Settings.Default.WorkWeekLength);
        }

        /// <summary>
        /// Add the specified <see cref="DayTime"/> day to the dictionary. If the work week has ended when calling this method, this method
        /// will create a new Timesheet instance.
        /// </summary>
        /// <param name="day">The <see cref="DayTime"/> to add.</param>
        /// <returns>The current <see cref="TimeSheet"/> instance.</returns>
        public TimeSheet AddDay(DayTime day)
        {
            if (Days.ContainsKey(day.Date.Date))
            {
                Console.WriteLine($"The day specified by the date, {day.Date.Date}, already exists in the dictionary.");
            }
            else if ((Days.Count) == Settings.Default.WorkWeekLength)
            {
                Console.WriteLine("The work week has ended. Creating a new Timesheet...");
                CreateNewTimeSheet();
                Days.Add(day.Date.Date, day);
            }
            else
            {
                Days.Add(day.Date.Date, day);
            }
            return this;
        }

        /// <summary>
        /// Update, if it exists, the specified <see cref="DayTime"/> object in the dictionary.
        /// <para>If the day does not exist yet, this method will call <see cref="AddDay(DayTime)"/> to automatically add the <see cref="DayTime"/> to the dictionary.</para>
        /// </summary>
        /// <param name="day"></param>
        public void UpdateDay(DayTime day)
        {
            if (Days.ContainsKey(day.Date.Date))
            {
                Days[day.Date.Date] = day;
            }
            else
            {
                Console.WriteLine($"The day specified by the date, {day.Date.Date}, does not exist in the dictionary. Adding it now...");
                AddDay(day);
            }
        }

        /// <summary>
        /// Removes, if it exists, the specified <see cref="DayTime"/> object from the dictionary.
        /// </summary>
        /// <param name="day"></param>
        public void RemoveDay(DayTime day)
        {
            if (!Days.ContainsKey(day.Date.Date))
            {
                Console.WriteLine($"The day specified by the date, {day.Date.Date}, does not exist in the dictionary.");
            }
            else
            {
                Days.Remove(day.Date.Date);
            }
        }

        /// <summary>
        /// Get the monetary amount of pay for the total amount of normal hours worked this work week.
        /// </summary>
        /// <returns>A <see cref="decimal"/> value representing the pay for the week.</returns>
        public decimal GetNormalPay()
        {
            decimal pay = 0.0M;
            foreach (DayTime day in Days.Values)
            {
                pay += day.GetNormalPay();
            }
            return pay;
        }

        /// <summary>
        /// Get the monetary amount of pay for the billable time worked this work week.
        /// </summary>
        /// <returns>A <see cref="decimal"/> value representing the pay for the week.</returns>
        public decimal GetBillablePay()
        {
            decimal pay = 0.0M;
            foreach (DayTime day in Days.Values)
            {
                pay += day.GetBillablePay();
            }
            return pay;
        }

        /// <summary>
        /// Get the monetary amount of pay for the total amount of overtime hours, if any, worked this work week.
        /// </summary>
        /// <returns>A <see cref="decimal"/> value representing the pay for the week.</returns>
        public decimal GetOvertimePay()
        {
            double hours = 0;
            decimal pay = 0.0M;

            foreach (DayTime day in Days.Values)
            {
                hours += day.NormalTime.TotalHours;
                hours += day.BillableTime.TotalHours;
            }
            
            if (hours > 40)
            {
                double overHours = hours - 40.0;
                for (double i = hours; i <= overHours; i++)
                {
                    pay += (decimal)i * Employee.OvertimeRate;
                }
            }
            return pay;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>A <see cref="decimal"/> value representing the grand total of pay for the week.</returns>
        public decimal GetTotalPay()
        {
            return GetNormalPay() + GetBillablePay() + GetOvertimePay();
        }

        /// <summary>
        /// Generate a unique GUID for this timesheet; used when adding this timesheet to the <see cref="TimeSheetInformation"/>.
        /// </summary>
        private void GenerateUniqueID()
        {
            UniqueID = Guid.NewGuid().ToString("B").ToUpper();
        }
    }
}
