using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;

namespace TimeTracker.backend
{
    /// <summary>
    /// Allows easy saving and retrieving of an employee object from a saved XML file. The file path is determined by the user's options.
    /// <para>The employee object is serialized (saved) to an XML file using the <see cref="Save()"/> method here.
    /// It is retrieved (deserialized into an <see cref="Employee"/> object) using the <see cref="Load()"/> method.</para>
    /// <para>This class cannot be instantiated. Instead, it must be referenced through its <see cref="Instance"/> property.</para>
    /// </summary>
    [Serializable]
    public class EmployeeInformation
    {
        private static EmployeeInformation instance = null;
        private static readonly object padlock = new object();

        private const string EMPLOYEE_DATA_FILENAME = "employee.xml";
        private string saveLocation = "";
        private static Employee e;

        private EmployeeInformation() { }

        /// <summary>
        /// Get an instance of this class.
        /// </summary>
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
        /// Set this information's employee object.
        /// <para>Calling <see cref="Save()"/> without setting the employee results in no data being saved.</para>
        /// </summary>
        /// <param name="employee"></param>
        public void SetEmployee(Employee employee)
        {
            e = employee;
        }

        /// <summary>
        /// Gets the current employee object loaded (deserialized) from disk.
        /// </summary>
        /// <returns>An <see cref="Employee"/> object or <c>null</c> if no <see cref="Employee"/> exists.</returns>
        public Employee GetEmployee()
        {
            Load();
            return e;
        }

        /// <summary>
        /// Prints to the console the employee (and their manager)'s information to the console.
        /// <para>See <see cref="Employee.ToString()"/> for information on how the output is formatted.</para>
        /// </summary>
        public void PrintEmployee()
        {
            if (e != null)
            {
                if (e.Manager != null)
                {
                    Console.WriteLine("Employee: " + e.ToString());
                    Console.WriteLine("Manager: " + e.Manager.ToString());
                }
                else
                {
                    Console.WriteLine("Employee: " + e.ToString());
                }
            }
        }

        /// <summary>
        /// Set the data location for the <c>employee.xml</c> file.
        /// </summary>
        /// <param name="path">The folder path in which the file should be saved.</param>
        public void SetDataLocation(string path)
        {
            saveLocation = Path.Combine(path, EMPLOYEE_DATA_FILENAME);
        }

        /// <summary>
        /// Save the contents of this <see cref="EmployeeInformation"/> class to disk.
        /// </summary>
        public void Save()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            try
            {
                using (StreamWriter writer = new StreamWriter(saveLocation))
                {
                    serializer.Serialize(writer, e);
                }
            } catch (DirectoryNotFoundException) { return; }
              catch (PathTooLongException) { return; }
        }

        /// <summary>
        /// Load the employee's information from disk. Uses the last saved path to try and locate the <c>employee.xml</c> file. If the file
        ///  could not be found, this method simply returns and the current <see cref="Employee"/> object remains <c>null</c>.
        /// </summary>
        public void Load()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            try
            {
                using (StreamReader reader = new StreamReader(saveLocation))
                {
                    e = (Employee)serializer.Deserialize(reader);
                }
            } catch (DirectoryNotFoundException) { return; }
            catch (FileNotFoundException) { return; }
        }
    }
}
