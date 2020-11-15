using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTracker.Documents;
using TimeTracker.Properties;

namespace TimeTracker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            EmployeeInformation.Instance.SetDataLocation(Settings.Default.SavePath);
            EmployeeInformation.Instance.Load();
            TimeSheetInformation.Instance.SetDataLocation(Settings.Default.SavePath);
            TimeSheetInformation.Instance.Load();

            EmployeeInformation.Instance.PrintAllEmployees();

            Application.Run(new MainForm());
        }
    }
}
