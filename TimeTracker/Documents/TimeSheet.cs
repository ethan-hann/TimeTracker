using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.Documents
{
    [Serializable]
    class TimeSheet
    {
        private static TimeSheet instance = null;
        private static readonly object padlock = new object();

        public TimeSpan NormalTime { get; private set; }
        public TimeSpan Overtime { get; private set; }
        public TimeSpan BillableTime { get; private set; }

        TimeSheet()
        {
            
        }

        public TimeSheet Instance
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
        /// Add normal, non-billable, non-overtime time to this timesheet.
        /// </summary>
        /// <param name="time">The <see cref="TimeSpan"/> representing the normal time to add.</param>
        public void AddNormalTime(TimeSpan time)
        {
            NormalTime += time;
        }

        /// <summary>
        /// Add overtime to this timesheet.
        /// </summary>
        /// <param name="time">The <see cref="TimeSpan"/> representing the overtime to add.</param>
        public void AddOvertime(TimeSpan time)
        {
            Overtime += time;
        }

        /// <summary>
        /// Add billable time to this timesheet.
        /// </summary>
        /// <param name="time">The <see cref="TimeSpan"/> representing the billable time to add.</param>
        public void AddBillableTime(TimeSpan time)
        {
            BillableTime += time;
        }
    }
}
