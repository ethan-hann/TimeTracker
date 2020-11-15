using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.Documents
{
    class EmployeeInformation
    {
        private static EmployeeInformation instance = null;
        private static readonly object padlock = new object();

        private Dictionary<string, Employee> employeeDictionary;
        private BinaryFormatter formatter;

        private const string EMPLOYEE_DATA_FILENAME = "employees.dat";
        private string saveLocation = "";

        EmployeeInformation()
        {
            employeeDictionary = new Dictionary<string, Employee>();
            formatter = new BinaryFormatter();
        }

        public static EmployeeInformation Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new EmployeeInformation();
                    }
                }
                return instance;
            }
        }

        public void SetDataLocation(string path)
        {
            saveLocation = Path.Combine(path, EMPLOYEE_DATA_FILENAME);
        }

        public void AddTimeSheet(string uniqueName, Employee employee)
        {
            if (employeeDictionary.ContainsKey(uniqueName))
            {
                Console.WriteLine($"The dictionary already contains an employee with this unique name: {uniqueName}");
            }
            else
            {
                employeeDictionary.Add(uniqueName, employee);
            }
        }

        public void RemoveTimeSheet(string uniqueName)
        {
            if (!employeeDictionary.ContainsKey(uniqueName))
            {
                Console.WriteLine($"The key {uniqueName} does not exist in the dictionary.");
            }
            else
            {
                if (!employeeDictionary.Remove(uniqueName))
                {
                    Console.WriteLine($"Unable to remove the entry specified by {uniqueName}.");
                }
            }
        }

        public void Save()
        {
            try
            {
                FileStream writer = new FileStream(EMPLOYEE_DATA_FILENAME, FileMode.Create, FileAccess.Write);
                formatter.Serialize(writer, employeeDictionary);
                writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Could not save the employee information: {e.Message}");
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);
            }
        }

        public void Load()
        {
            if (File.Exists(EMPLOYEE_DATA_FILENAME))
            {
                try
                {
                    FileStream reader = new FileStream(EMPLOYEE_DATA_FILENAME, FileMode.Open, FileAccess.Read);
                    employeeDictionary = (Dictionary<string, Employee>)formatter.Deserialize(reader);
                    reader.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine($"There is a file containing employee information but there was a problem reading it: {e.Message}");
                    Console.WriteLine();
                    Console.WriteLine(e.StackTrace);
                }
            }
        }
    }
}
