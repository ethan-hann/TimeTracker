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
using TimeTracker.Forms;
using TimeTracker.Properties;

namespace TimeTracker
{
    //TODO: Add time employee clocked in and out; i.e. 8:30 AM and 5:00 PM to the timesheet.


    public partial class MainForm : KryptonForm
    {
        private DateTime date;

        private int normalHours = 0;
        private int billableHours = 0;
        private int normalMinutes = 0;
        private int billableMinutes = 0;
        private int normalSeconds = 0;
        private int billableSeconds = 0;

        private TimeSheet sheet;
        private DayTime today;
        private Employee employee;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenOptions(object sender, EventArgs e)
        {
            new OptionsForm().ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnEndDay.Click += btnClockOut_Click;
            date = DateTime.Now;
            Text = $"Time Tracker - {date:MM/dd/yyyy} - {date.DayOfWeek}";

            sheet = TimeSheetInformation.Instance.GetTimeSheet(Settings.Default.CurrentTimesheetGUID);
            employee = EmployeeInformation.Instance.GetEmployee(Settings.Default.LastGUID);

            if (employee == null)
            {
                DialogResult result = CMessageBox.Show("There are no employees defined! Please create one now...", "No Employees", MessageBoxButtons.OK, Resources.info_32);
                if (result == DialogResult.OK)
                {
                    new OptionsForm().ShowDialog();
                }
            }
            else
            {
                if (sheet == null)
                {
                    TimeSheet.Instance.New();
                    TimeSheet.Instance.Employee = employee;
                }
                else
                {
                    TimeSheet.Instance.SetTimeSheet(sheet);
                }

                TimeSheet.Instance.Employee = employee;
                TimeSheetInformation.Instance.AddTimeSheet(TimeSheet.Instance);
                Settings.Default.CurrentTimesheetGUID = TimeSheet.Instance.UniqueID;
                Settings.Default.Save();
            }

            today = new DayTime(date);
        }

        #region Normal Time
        private void normalTime_Tick(object sender, EventArgs e)
        {
            UpdateNormalSeconds();
            lblSecondsCount.Text = normalSeconds.ToString();
            UpdateNormalMinutes();
            lblMinutesCount.Text = normalMinutes.ToString();
            lblHoursCount.Text = normalHours.ToString();

            today.AddNormalTime(new TimeSpan(normalHours, normalMinutes, normalSeconds));

            UpdateNormalLabel();
        }

        private void UpdateNormalSeconds()
        {
            if (normalSeconds >= 59)
            {
                normalMinutes += 1;
                normalSeconds = 0;
            }
            else
            {
                normalSeconds += 1;
            }
        }

        private void UpdateNormalMinutes()
        {
            if (normalMinutes >= 59)
            {
                normalHours += 1;
                normalMinutes = 0;
            }
        }

        private void UpdateNormalLabel()
        {
            lblNormalMoney.Values.ExtraText = string.Format("{0:C}", Convert.ToDecimal(today.GetNormalPay()));
        }

        /// <summary>
        /// Begin the current day's normal timer.
        /// </summary>
        private void NormalClockIn()
        {
            normalTimeTracker.Start();
            normalTimeTracker.Enabled = true;
            btnNormalClockIn.Visible = false;
            btnStopBillableTime.Visible = false;

            if (billableTimeTracker.Enabled)
            {
                billableTimeTracker.Enabled = false;
                billableTimeTracker.Stop();
            }
        }

        private void btnClockIn_Click(object sender, EventArgs e)
        {
            NormalClockIn();
        }

        /// <summary>
        /// End the day and add the day to the current timesheet.
        /// </summary>
        private void EndDay()
        {
            normalTimeTracker.Stop();
            normalTimeTracker.Enabled = false;
            billableTimeTracker.Stop();
            billableTimeTracker.Enabled = false;

            btnNormalClockIn.Visible = true;
            btnStartBillableTime.Visible = true;
            btnStopBillableTime.Visible = true;

            today.AddNote(rtbNotes.Text);

            TimeSheet.Instance.UpdateDay(today);
            TimeSheetInformation.Instance.UpdateTimeSheet(TimeSheet.Instance);
        }

        /// <summary>
        /// Ends the current day!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClockOut_Click(object sender, EventArgs e)
        {
            EndDay();

            //TODO: clock out functionality
        }

        #endregion

        #region Billable Time
        private void billableTimeTracker_Tick(object sender, EventArgs e)
        {
            UpdateBillableSeconds();
            lblBillableSecondsCount.Text = billableSeconds.ToString();
            UpdateBillableMinutes();
            lblBillableMinutesCount.Text = billableMinutes.ToString();
            lblBillableHoursCount.Text = billableHours.ToString();

            today.AddBillableTime(new TimeSpan(billableHours, billableMinutes, billableSeconds));

            UpdateBillableLabel();
        }

        private void UpdateBillableSeconds()
        {
            if (billableSeconds >= 59)
            {
                billableMinutes += 1;
                billableSeconds = 0;
            }
            else
            {
                billableSeconds += 1;
            }
        }

        private void UpdateBillableMinutes()
        {
            if (billableMinutes >= 59)
            {
                billableHours += 1;
                billableMinutes = 0;
            }
        }

        private void UpdateBillableLabel()
        {
            lblBillableMoney.Values.ExtraText = string.Format("{0:C}", Convert.ToDecimal(today.GetBillablePay()));
        }

        private void btnBillableClockIn_Click(object sender, EventArgs e)
        {
            btnStartBillableTime.Visible = false;
            btnNormalClockIn.Visible = false;
            btnStopBillableTime.Visible = true;

            if (normalTimeTracker.Enabled)
            {
                normalTimeTracker.Enabled = false;
                normalTimeTracker.Stop();
            }

            billableTimeTracker.Enabled = true;
            billableTimeTracker.Start();
        }

        private void btnBillableClockOut_Click(object sender, EventArgs e)
        {
            billableTimeTracker.Stop();
            billableTimeTracker.Enabled = false;

            btnEndDay.Visible = true;
            btnStartBillableTime.Visible = true;
            btnStopBillableTime.Visible = false;

            normalTimeTracker.Enabled = true;
            normalTimeTracker.Start();
        }

        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TimeSheetInformation.Instance.Save();
        }

        private void btnGenerateTimesheet_Click(object sender, EventArgs e)
        {
            GenerateTimesheet.Generate();
        }

        private void btnListAllTimesheets_Click(object sender, EventArgs e)
        {
            new TimesheetList().ShowDialog();
        }
    }
}
