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

namespace TimeTracker
{
    public partial class MainForm : KryptonForm
    {
        private DateTime date;

        private int normalHours = 0;
        private int billableHours = 0;
        private int normalMinutes = 0;
        private int billableMinutes = 0;
        private int normalSeconds = 0;
        private int billableSeconds = 0;

        private bool normalPaused = false;
        private bool billablePaused = false;

        private TimeSheet sheet;
        private DayTime today;

        private TimeSpan normalTime = new TimeSpan();
        private TimeSpan billableTime = new TimeSpan();

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
            date = DateTime.Now;
            Text = $"Time Tracker - {date:MM/dd/yyyy}";

            sheet = TimeSheetInformation.Instance.GetTimeSheet(Settings.Default.CurrentTimesheetGUID);

            if (sheet == null)
            {
                TimeSheet.Instance.New();
                TimeSheetInformation.Instance.AddTimeSheet(TimeSheet.Instance);
            }
            else
            {
                TimeSheet.Instance.SetTimeSheet(sheet);
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

        private void btnClockIn_Click(object sender, EventArgs e)
        {
            normalTimeTracker.Start();
            normalTimeTracker.Enabled = true;
            btnNormalClockIn.Visible = false;
            btnBillableClockOut.Visible = false;

            if (billableTimeTracker.Enabled)
            {
                billableTimeTracker.Enabled = false;
                billableTimeTracker.Stop();
            }
        }

        private void btnClockOut_Click(object sender, EventArgs e)
        {
            normalTimeTracker.Stop();
            normalTimeTracker.Enabled = false;
            btnNormalClockIn.Visible = true;
            btnBillableClockIn.Visible = true;
            btnBillableClockOut.Visible = true;

            today.AddNormalTime(new TimeSpan(normalHours, normalMinutes, normalSeconds));
            today.AddBillableTime(new TimeSpan(billableHours, billableMinutes, billableSeconds));
            Console.WriteLine(today.NormalTime.ToString());
            Console.WriteLine(today.BillableTime.ToString());

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
        }

        private void UpdateBillableSeconds()
        {
            if (billableSeconds >= 59)
            {
                normalMinutes += 1;
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

        private void btnBillableClockIn_Click(object sender, EventArgs e)
        {
            btnBillableClockIn.Visible = false;
            btnNormalClockIn.Visible = false;
            btnNormalClockOut.Visible = false;
            btnBillableClockOut.Visible = true;

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

            btnNormalClockOut.Visible = true;
            btnBillableClockIn.Visible = true;
            btnBillableClockOut.Visible = false;

            normalTimeTracker.Enabled = true;
            normalTimeTracker.Start();
        }

        #endregion
    }
}
