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
    /// Holds information about employees. <see cref="Employee"/> objects are added to this class's dictionary.
    /// <para>These objects are serialized (saved) to disk using the <see cref="Save()"/> method here.</para>
    /// <para>This class cannot be instantiated.</para>
    /// </summary>
    [Serializable]
    public class EmployeeInformation
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

        /// <summary>
        /// Print to the console all <see cref="Employee"/> objects contained in this class's dictionary.
        /// <para>See <see cref="Employee.ToString()"/> for information on how the output is formatted.</para>
        /// </summary>
        internal void PrintAllEmployees()
        {
            foreach (Employee e in employeeDictionary.Values)
            {
                Console.WriteLine(e.ToString());
            }
        }

        /// <summary>
        /// Set the data location for the <c>employees.dat</c> file.
        /// </summary>
        /// <param name="path">The folder path in which the file should be saved.</param>
        public void SetDataLocation(string path)
        {
            saveLocation = Path.Combine(path, EMPLOYEE_DATA_FILENAME);
        }

        /// <summary>
        /// Add a <see cref="Employee"/> to the dictionary to be saved.
        /// </summary>
        /// <param name="sheet">The <see cref="Employee"/> object to be added.</param>
        public void AddEmployee(Employee employee)
        {
            if (employeeDictionary.ContainsKey(employee.UniqueID))
            {
                Console.WriteLine($"The dictionary already contains an employee with this unique id: {employee.UniqueID}");
            }
            else
            {
                employeeDictionary.Add(employee.UniqueID, employee);
            }
        }

        /// <summary>
        /// Get an <see cref="Employee"/> object associated with the uniqueID.
        /// </summary>
        /// <param name="uniqueID">The uniqueID to search for.</param>
        /// <returns></returns>
        public Employee GetEmployee(string uniqueID)
        {
            if (employeeDictionary.ContainsKey(uniqueID))
            {
                return employeeDictionary[uniqueID];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Remove, if it exists, the specified employee.
        /// </summary>
        /// <param name="sheet">The <see cref="Employee"/> object to be removed.</param>
        public void RemoveEmployee(Employee employee)
        {
            if (!employeeDictionary.ContainsKey(employee.UniqueID))
            {
                Console.WriteLine($"The key {employee.UniqueID} does not exist in the dictionary.");
            }
            else
            {
                if (!employeeDictionary.Remove(employee.UniqueID))
                {
                    Console.WriteLine($"Unable to remove the entry specified by {employee.UniqueID}.");
                }
            }
        }

        /// <summary>
        /// Save the contents of this <see cref="EmployeeInformation"/> class to disk.
        /// </summary>
        public void Save()
        {
            try
            {
                FileStream writer = new FileStream(saveLocation, FileMode.Create, FileAccess.Write);
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

        /// <summary>
        /// Load the contents from disk into this <see cref="EmployeeInformation"/> class.
        /// </summary>
        public void Load()
        {
            if (File.Exists(saveLocation))
            {
                try
                {
                    FileStream reader = new FileStream(saveLocation, FileMode.Open, FileAccess.Read);
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
