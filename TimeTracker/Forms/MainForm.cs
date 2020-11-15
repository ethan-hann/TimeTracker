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
using TimeTracker.Properties;

namespace TimeTracker
{
    public partial class MainForm : KryptonForm
    {
        private DateTime date;
        private int hours = 0;
        private int minutes = 0;
        private int seconds = 0;
        private bool paused = false;

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
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            UpdateSeconds();
            lblSecondsCount.Text = seconds.ToString();
            UpdateMinutes();
            lblMinutesCount.Text = minutes.ToString();
            lblHoursCount.Text = hours.ToString();
        }

        private void UpdateSeconds()
        {
            if (seconds > 59)
            {
                minutes += 1;
                seconds = 0;
            }
            else
            {
                seconds += 1;
            }
        }

        private void UpdateMinutes()
        {
            if (minutes > 59)
            {
                hours += 1;
                minutes = 0;
            }
        }

        private void btnClockIn_Click(object sender, EventArgs e)
        {
            timer.Start();
            timer.Enabled = true;
            btnClockIn.Visible = false;
        }

        private void btnClockOut_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Enabled = false;
            btnClockIn.Visible = true;

            minutes = 0;
            seconds = 0;
            hours = 0;

            //TODO: clock out functionality
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (paused)
            {
                timer.Start();
                paused = false;
                btnPause.Values.ImageStates.ImageNormal = Resources.pause_32;
                btnPause.Text = "Pause Time";
            }
            else
            {
                timer.Stop();
                paused = true;
                btnPause.Values.ImageStates.ImageNormal = Resources.start_32;
                btnPause.Text = "Resume Time";
            }
        }
    }
}
