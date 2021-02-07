using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
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

        private const string TIMESHEET_DATA_FILENAME = "timesheet";
        private string saveFile = "";
        private string savePath = "";
        private static TimeSheet currentTimesheet;

        private TimeSheetInformation() 
        { 
            
        }

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

        public TimeSheet GetCurrentTimeSheet()
        {
            return currentTimesheet;
        }

        public void SetTimeSheet(TimeSheet sheet)
        {
            currentTimesheet = sheet;
        }

        /// <summary>
        /// Set the data location for the <c>timesheet-date.xml</c> file.
        /// <para>The current timesheet GUID is used to find the correct timesheet file.</para>
        /// </summary>
        /// <param name="path">The folder path in which the file should be saved.</param>
        public void SetDataLocation(string path)
        {
            saveFile = Path.Combine(path, $"{TIMESHEET_DATA_FILENAME}-{Settings.Default.CurrentTimesheetGUID}.xml");
            savePath = path;
        }

        //public void AddTimeSheet(TimeSheet sheet)
        //{
        //    int currentIndex = timesheets.FindIndex(t => t.UniqueID.Equals(sheet.UniqueID));
        //    if (currentIndex >= 0)
        //        timesheets[currentIndex] = sheet;
        //    else
        //        timesheets.Add(sheet);
        //}

        public List<TimeSheet> GetTimeSheets()
        {
            List<TimeSheet> timesheets = new List<TimeSheet>();
            foreach (string file in Directory.EnumerateFiles(savePath, "timesheet-*.xml"))
            {
                timesheets.Add(Load(file));
            }
            return timesheets;
        }

        /// <summary>
        /// Save the contents of this <see cref="TimeSheetInformation"/> class to an XML file.
        /// </summary>
        public void Save()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(TimeSheet));
            try
            {
                using (StreamWriter writer = new StreamWriter(saveFile))
                {
                    serializer.Serialize(writer, currentTimesheet);
                }
            } catch (DirectoryNotFoundException) { return; }
              catch (PathTooLongException) { return; }
        }

        /// <summary>
        /// Load all timesheets from the XML file into this <see cref="TimeSheetInformation"/> class.
        /// </summary>
        public void Load()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(TimeSheet));
            try
            {
                using (StreamReader reader = new StreamReader(saveFile))
                {
                    currentTimesheet = (TimeSheet)serializer.Deserialize(reader);
                }
            }
            catch (DirectoryNotFoundException) { return; }
            catch (FileNotFoundException) { return; }
        }

        /// <summary>
        /// Load the timesheet saved at the specified <paramref name="filePath"/>.
        /// </summary>
        /// <param name="filePath">The path to the XML timesheet file.</param>
        /// <returns>A new Timesheet object or null if the file or directory could not be found.</returns>
        public TimeSheet Load(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(TimeSheet));
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    return (TimeSheet)serializer.Deserialize(reader);
                }
            }
            catch (DirectoryNotFoundException) { return null; }
            catch (FileNotFoundException) { return null; }
        }
    }
}
