using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

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

        private Dictionary<string, TimeSheet> timesheetDictionary;
        private BinaryFormatter formatter;

        private const string TIMESHEET_DATA_FILENAME = "timesheets.dat";
        private string saveLocation = "";

        TimeSheetInformation()
        {
            timesheetDictionary = new Dictionary<string, TimeSheet>();
            formatter = new BinaryFormatter();
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

        /// <summary>
        /// Set the data location for the <c>timesheets.dat</c> file.
        /// </summary>
        /// <param name="path">The folder path in which the file should be saved.</param>
        public void SetDataLocation(string path)
        {
            saveLocation = Path.Combine(path, TIMESHEET_DATA_FILENAME);
        }

        /// <summary>
        /// Add a <see cref="TimeSheet"/> to the dictionary to be saved.
        /// </summary>
        /// <param name="sheet">The <see cref="TimeSheet"/> object to be added.</param>
        public void AddTimeSheet(TimeSheet sheet)
        {
            if (timesheetDictionary.ContainsKey(sheet.UniqueID))
            {
                Console.WriteLine($"The dictionary already contains a timesheet with this unique id: {sheet.UniqueID}");
            }
            else
            {
                timesheetDictionary.Add(sheet.UniqueID, sheet);
            }
        }

        /// <summary>
        /// Updates, if it exists, the supplied <see cref="TimeSheet"/>.
        /// <para>If it does not exist, this method calls <see cref="AddTimeSheet(TimeSheet)"/> to add it to the dictionary.</para>
        /// </summary>
        /// <param name="sheet">The <see cref="TimeSheet"/> to update.</param>
        public void UpdateTimeSheet(TimeSheet sheet)
        {
            if (timesheetDictionary.ContainsKey(sheet.UniqueID))
            {
                timesheetDictionary[sheet.UniqueID] = sheet;
            }
            else
            {
                Console.WriteLine($"The dictionary does not contain a timesheet with this unique id: {sheet.UniqueID}. Adding it now...");
                timesheetDictionary.Add(sheet.UniqueID, sheet);
            }
        }

        /// <summary>
        /// Get a <see cref="TimeSheet"/> object associated with the uniqueID.
        /// </summary>
        /// <param name="uniqueID">The uniqueID to search for.</param>
        /// <returns></returns>
        public TimeSheet GetTimeSheet(string uniqueID)
        {
            if (timesheetDictionary.ContainsKey(uniqueID))
            {
                return timesheetDictionary[uniqueID];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Remove, if it exists, the specified timesheet.
        /// </summary>
        /// <param name="sheet">The <see cref="TimeSheet"/> object to be removed.</param>
        public void RemoveTimeSheet(TimeSheet sheet)
        {
            if (!timesheetDictionary.ContainsKey(sheet.UniqueID))
            {
                Console.WriteLine($"The key {sheet.UniqueID} does not exist in the dictionary.");
            }
            else
            {
                if (!timesheetDictionary.Remove(sheet.UniqueID))
                {
                    Console.WriteLine($"Unable to remove the entry specified by {sheet.UniqueID}.");
                }
            }
        }

        public TimeSheet[] GetTimeSheets()
        {
            return timesheetDictionary.Values.ToArray();
        }

        /// <summary>
        /// Save the contents of this <see cref="TimeSheetInformation"/> class to disk.
        /// </summary>
        public void Save()
        {
            try
            {
                FileStream writer = new FileStream(saveLocation, FileMode.Create, FileAccess.Write);
                formatter.Serialize(writer, timesheetDictionary);
                writer.Close();
            } catch (Exception e)
            {
                Console.WriteLine($"Could not save the timesheet information: {e.Message}");
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);
            }
        }

        /// <summary>
        /// Load the contents from disk into this <see cref="TimeSheetInformation"/> class.
        /// </summary>
        public void Load()
        {
            if (File.Exists(saveLocation))
            {
                try
                {
                    FileStream reader = new FileStream(saveLocation, FileMode.Open, FileAccess.Read);
                    timesheetDictionary = (Dictionary<string, TimeSheet>)formatter.Deserialize(reader);
                    reader.Close();
                } catch (Exception e)
                {
                    Console.WriteLine($"There is a file containing timesheet information but there was a problem reading it: {e.Message}");
                    Console.WriteLine();
                    Console.WriteLine(e.StackTrace);
                }
            }
        }
    }
}
