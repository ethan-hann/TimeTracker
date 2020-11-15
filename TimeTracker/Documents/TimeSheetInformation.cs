using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.Documents
{
    class TimeSheetInformation
    {
        private static TimeSheetInformation instance = null;
        private static readonly object padlock = new object();

        private Dictionary<string, TimeSheet> timesheetDictionary;
        private BinaryFormatter formatter;

        private const string TIMESHEET_DATA_FILENAME = "timesheets.dat";

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

        public void AddTimeSheet(string uniqueName, TimeSheet sheet)
        {
            if (timesheetDictionary.ContainsKey(uniqueName))
            {
                Console.WriteLine($"The dictionary already contains a timesheet with this unique name: {uniqueName}");
            }
            else
            {
                timesheetDictionary.Add(uniqueName, sheet);
            }
        }

        public void RemoveTimeSheet(string uniqueName)
        {
            if (!timesheetDictionary.ContainsKey(uniqueName))
            {
                Console.WriteLine($"The key {uniqueName} does not exist in the dictionary.");
            }
            else
            {
                if (!timesheetDictionary.Remove(uniqueName))
                {
                    Console.WriteLine($"Unable to remove the entry specified by {uniqueName}.");
                }
            }
        }

        public void Save()
        {
            try
            {
                FileStream writer = new FileStream(TIMESHEET_DATA_FILENAME, FileMode.Create, FileAccess.Write);
                formatter.Serialize(writer, timesheetDictionary);
                writer.Close();
            } catch (Exception e)
            {
                Console.WriteLine($"Could not save the timesheet information: {e.Message}");
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);
            }
        }

        public void Load()
        {
            if (File.Exists(TIMESHEET_DATA_FILENAME))
            {
                try
                {
                    FileStream reader = new FileStream(TIMESHEET_DATA_FILENAME, FileMode.Open, FileAccess.Read);
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
