using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.backend
{
    /// <summary>
    /// Represents a week of time (normal, overtime, and billable). Days are added to this timesheet using the helper methods.
    /// <para>To add time to a specific day, use the <see cref="DayTime"/> class.</para>
    /// <para>This class cannot be instantiated. Instead, new timesheets must be created with the <see cref="New()"/> method. This should only be done at the start of a new week.</para>
    /// </summary>
    [Serializable]
    class TimeSheet
    {
        private static TimeSheet instance = null;
        private static readonly object padlock = new object();

        public string UniqueID { get; private set; }
        public Employee Employee { get; set; }
        public Dictionary<DateTime, DayTime> Days { get; private set; }
        

        private TimeSheet()
        {
            Days = new Dictionary<DateTime, DayTime>();
            GenerateUniqueID();
        }

        public static TimeSheet Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new TimeSheet();
                    }
                }
                return instance;
            }
        }

        /// <summary>
        /// Creates a new <see cref="TimeSheet"/>.
        /// </summary>
        public void New()
        {
            instance = new TimeSheet();
        }

        /// <summary>
        /// Set this instance to the specified <see cref="TimeSheet"/>.
        /// </summary>
        /// <param name="sheet"></param>
        public void SetTimeSheet(TimeSheet sheet)
        {
            instance = sheet;
        }

        /// <summary>
        /// Add the specified <see cref="DayTime"/> day to the dictionary.
        /// </summary>
        /// <param name="day"></param>
        public void AddDay(DayTime day)
        {
            if (Days.ContainsKey(day.Date.Date))
            {
                Console.WriteLine($"The day specified by the date, {day.Date.Date}, already exists in the dictionary.");
            }
            else
            {
                Days.Add(day.Date.Date, day);
            }
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

        public decimal GetHourlyPay()
        {
            decimal pay = 0.0M;
            foreach (DayTime day in Days.Values)
            {
                pay += day.GetNormalAmount();
            }
            return pay;
        }

        public decimal GetBillablePay()
        {
            decimal pay = 0.0M;
            foreach (DayTime day in Days.Values)
            {
                pay += day.GetBillableAmount();
            }
            return pay;
        }

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

        public decimal GetTotalPay()
        {
            return GetHourlyPay() + GetBillablePay() + GetOvertimePay();
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
