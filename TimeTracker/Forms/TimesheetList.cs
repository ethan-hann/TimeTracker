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
using TimeTracker.Properties;

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
                sheetNode.Tag = sheet;
                tvTimesheets.Nodes.Add(sheetNode);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGenerateSelectedSheet_Click(object sender, EventArgs e)
        {
            TimeSheet selectedSheet = (TimeSheet)tvTimesheets.SelectedNode.Tag;
            if (selectedSheet != null)
            {
                GenerateTimesheet.Generate(selectedSheet);
            }
            else
            {
                CMessageBox.Show("You must select the root node of the\ntimesheet to generate it.", "Wrong node selected", MessageBoxButtons.OK, Resources.error_32);
            }
        }
    }
}
