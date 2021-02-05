using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TimeTracker.Properties;

namespace TimeTracker.backend
{
    /// <summary>
    /// Holds information about timesheets. <see cref="TimeSheet"/> objects are added to this class's dictionary.
    /// <para>These objects are serialized (saved) to disk using the <see cref="Save()"/> method here.</para>
    /// <para>This class cannot be instantiated.</para>
    /// </summary>
    [Serializable]
    class TimeSheetInformation
    {
        private static TimeSheetInformation instance = null;
        private static readonly object padlock = new object();

        private const string TIMESHEET_DATA_FILENAME = "timesheets";
        private List<TimeSheet> timesheets = new List<TimeSheet>();

        private TimeSheetInformation() { }

        public static TimeSheetInformation Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new TimeSheetInformation();
                    }
                }
                return instance;
            }
        }

        /// <summary>
        /// Get a <see cref="TimeSheet"/> object associated with the date.
        /// </summary>
        /// <param name="uuid">The UUID for the timesheet to search for.</param>
        /// <returns>A <see cref="TimeSheet"/> object or <c>null</c> if no timesheet was found.</returns>
        public TimeSheet GetTimeSheet(string uuid)
        {
            try
            {
                return timesheets.Find(t => t.UniqueID.Equals(uuid));
            } catch (ArgumentNullException)
            {
                return null;
            }
        }

        public TimeSheet GetCurrentTimeSheet()
        {
            try
            {
                DateTime today = DateTime.Now;

                //Find the timesheet in which today is included in the timesheet's day range.
                return timesheets.Find(t => today >= t.Days.Keys.ElementAt(0).Date
                                        && today <= t.Days.Keys.ElementAt(t.Days.Keys.Count-1).Date);
            } catch (ArgumentNullException)
            {
                return new TimeSheet();
            }
        }

        public void AddTimeSheet(TimeSheet sheet)
        {
            int currentIndex = timesheets.FindIndex(t => t.UniqueID.Equals(sheet.UniqueID));
            if (currentIndex >= 0)
                timesheets[currentIndex] = sheet;
            else
                timesheets.Add(sheet);
        }

        public List<TimeSheet> GetTimeSheets()
        {
            return timesheets;
        }

        /// <summary>
        /// Save the contents of this <see cref="TimeSheetInformation"/> class to an XML file.
        /// </summary>
        public void Save()
        {
            string saveLocation = Path.Combine(Settings.Default.SavePath, $"{TIMESHEET_DATA_FILENAME}-{GetCurrentTimeSheet().GetWeekStart():MM-dd-yyyy} to {GetCurrentTimeSheet().GetWeekEnd():MM-dd-yyyy}.xml");
            XmlTextWriter writer = new XmlTextWriter(saveLocation, Encoding.UTF8)
            {
                Formatting = Formatting.Indented
            };
            TimeSheet sheet = GetCurrentTimeSheet();
            writer.WriteStartDocument();
            writer.WriteStartElement("timesheets"); writer.WriteAttributeString("id", sheet.UniqueID);
            writer.WriteElementString("week_start", sheet.GetWeekStart().ToString("MM/dd/yyyy"));
            writer.WriteElementString("week_end", sheet.GetWeekEnd().ToString("MM/dd/yyyy"));

            foreach (DayTime day in sheet.Days.Values)
            {
                writer.WriteStartElement("day");
                writer.WriteElementString("normal_time", day.NormalTime.ToString());
                writer.WriteElementString("overtime", day.Overtime.ToString());
                writer.WriteElementString("billable_time", day.BillableTime.ToString());
                writer.WriteElementString("date", day.Date.ToString("MM/dd/yyyy"));
                writer.WriteStartElement("notes");
                for (int i = 0; i < day.Notes.Count; i++)
                {
                    writer.WriteElementString($"note_{i}", day.Notes[i]);
                }
                writer.WriteEndElement();

                writer.WriteEndElement();
            }
            writer.WriteEndElement();

            writer.WriteEndDocument();
            writer.Flush();
            writer.Close();
        }

        /// <summary>
        /// Load all timesheets from the XML file into this <see cref="TimeSheetInformation"/> class.
        /// </summary>
        public void Load()
        {
            string saveLocation = Path.Combine(Settings.Default.SavePath, $"{TIMESHEET_DATA_FILENAME}-{GetCurrentTimeSheet().GetWeekStart():MM-dd-yyyy} to {GetCurrentTimeSheet().GetWeekEnd():MM-dd-yyyy}.xml");
            if (File.Exists(saveLocation))
            {
                XmlTextReader reader = new XmlTextReader(saveLocation);
                
                while (reader.Read())
                {
                    TimeSheet t = new TimeSheet();
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        if (reader.Name.Equals("timesheet"))
                        {
                            t.UniqueID = reader.GetAttribute("id");
                        }
                        else if (reader.Name.Equals("unique_id"))
                        {
                            t.UniqueID = reader.GetAttribute("id");
                        }
                        else if (reader.Name.Equals("week_start"))
                        {
                            t.SetWeekStart(DateTime.Parse(reader.ReadElementContentAsString()));
                        }
                        else if (reader.Name.Equals("week_end"))
                        {
                            t.SetWeekEnd(DateTime.Parse(reader.ReadElementContentAsString()));
                        }
                        else if (reader.Name.Equals("day"))
                        {
                            DayTime time = new DayTime();
                            time.SetDate(DateTime.Parse(reader.GetAttribute("date")));

                            XmlReader daySub = reader.ReadSubtree();
                            while (daySub.Read())
                            {
                                if (daySub.NodeType == XmlNodeType.Element)
                                {
                                    if (daySub.Name.Equals("normal_time"))
                                    {
                                        time.AddNormalTime(TimeSpan.Parse(daySub.ReadElementContentAsString()));
                                    }
                                    else if (daySub.Name.Equals("billable_time"))
                                    {
                                        time.AddBillableTime(TimeSpan.Parse(daySub.ReadElementContentAsString()));
                                    }
                                    else if (daySub.Name.Equals("overtime"))
                                    {
                                        time.AddOvertime(TimeSpan.Parse(daySub.ReadElementContentAsString()));
                                    }
                                    else if (daySub.Name.Equals("note"))
                                    {
                                        XmlReader noteSub = reader.ReadSubtree();
                                        while (noteSub.Read())
                                        {
                                            if (noteSub.NodeType == XmlNodeType.Element)
                                            {
                                                time.AddNote(noteSub.ReadElementContentAsString());
                                            }
                                        }
                                    }
                                }
                                if (time.Date != null)
                                    t.AddDay(time);
                                time = new DayTime();
                            }
                        }
                    }
                    timesheets.Add(t);
                }
            }
        }
    }
}
