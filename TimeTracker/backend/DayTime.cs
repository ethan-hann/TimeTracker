using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.backend

{
    /// <summary>
    /// Represents a day of time (normal, overtime, and billable). Time is added to this day using the helper methods.
    /// <para>At the end of each day, this object is added to the <see cref="TimeSheet"/> and then saved.</para>
    /// </summary>
    [Serializable]
    class DayTime
    {
        public string UniqueID { get; private set; }
        public TimeSpan NormalTime { get; private set; }
        public TimeSpan Overtime { get; private set; }
        public TimeSpan BillableTime { get; private set; }

        public DateTime Date { get; private set; }

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
            NormalTime += time;
        }

        /// <summary>
        /// Add overtime to this day.
        /// </summary>
        /// <param name="time">The <see cref="TimeSpan"/> representing the overtime to add.</param>
        public void AddOvertime(TimeSpan time)
        {
            Overtime += time;
        }

        /// <summary>
        /// Add billable time to this day.
        /// </summary>
        /// <param name="time">The <see cref="TimeSpan"/> representing the billable time to add.</param>
        public void AddBillableTime(TimeSpan time)
        {
            BillableTime += time;
        }

        /// <summary>
        /// Generate a unique GUID for this day; used when adding this day to a <see cref="TimeSheet"/>.
        /// </summary>
        private void GenerateUniqueID()
        {
            UniqueID = Guid.NewGuid().ToString();
        }
    }
}
