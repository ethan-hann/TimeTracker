using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTracker.backend;

namespace TimeTracker.Forms
{
    public partial class TimesheetList : KryptonForm
    {
        public TimesheetList()
        {
            InitializeComponent();
        }

        private void TimesheetList_Load(object sender, EventArgs e)
        {
            TimeSheet[] timeSheets = TimeSheetInformation.Instance.GetTimeSheets();
            foreach (TimeSheet sheet in timeSheets)
            {
                TreeNode sheetNode = new TreeNode(sheet.UniqueID);
                foreach (DayTime day in sheet.Days.Values)
                {
                    TreeNode dayNode = new TreeNode(day.Date.ToString("MM-dd-yyyy"));
                    dayNode.Nodes.Add($"Regular Hours: {day.NormalTime.TotalHours:F2}");
                    dayNode.Nodes.Add($"Overtime Hours: {day.Overtime.TotalHours:F2}");
                    dayNode.Nodes.Add($"Billable Hours: {day.BillableTime.TotalHours:F2}");
                    sheetNode.Nodes.Add(dayNode);
                }
                tvTimesheets.Nodes.Add(sheetNode);
            }
        }
    }
}
