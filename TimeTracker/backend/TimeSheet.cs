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
        public Dictionary<string, DayTime> Days { get; private set; }
        

        private TimeSheet()
        {
            Days = new Dictionary<string, DayTime>();
            GenerateUniqueID();
        }

        public TimeSheet Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        New();
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
        /// Add the specified <see cref="DayTime"/> day to the dictionary.
        /// </summary>
        /// <param name="day"></param>
        public void AddDay(DayTime day)
        {
            if (Days.ContainsKey(day.UniqueID))
            {
                Console.WriteLine($"The day specified by the key, {day.UniqueID}, already exists in the dictionary.");
            }
            else
            {
                Days.Add(day.UniqueID, day);
            }
        }

        /// <summary>
        /// Remove the specified <see cref="DayTime"/> object from the dictionary.
        /// </summary>
        /// <param name="day"></param>
        public void RemoveDay(DayTime day)
        {
            if (!Days.ContainsKey(day.UniqueID))
            {
                Console.WriteLine($"The day specified by the key, {day.UniqueID}, does not exist in the dictionary.");
            }
            else
            {
                Days.Remove(day.UniqueID);
            }
        }

        /// <summary>
        /// Generate a unique GUID for this timesheet; used when adding this timesheet to the <see cref="TimeSheetInformation"/>.
        /// </summary>
        private void GenerateUniqueID()
        {
            UniqueID = Guid.NewGuid().ToString();
        }
    }
}
