using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTracker.Properties;

namespace TimeTracker
{
    public partial class OptionsForm : Form
    {
        private string name;
        private decimal hourlyRate;
        private decimal overtimeRate;
        private decimal billableRate;

        private string savePath;

        public OptionsForm()
        {
            InitializeComponent();
        }

        private void btnSetSaveLocation_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFolderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                savePath = saveFolderBrowser.SelectedPath;
                lblLocation.Values.ExtraText = savePath;
            }
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            name = Settings.Default.UsersName;
            hourlyRate = Settings.Default.HourlyRate;
            overtimeRate = Settings.Default.OvertimeRate;
            billableRate = Settings.Default.BillableRate;
            savePath = Settings.Default.SavePath;

            txtFullName.Text = name;
            txtHourlyRate.Text = hourlyRate.ToString();
            txtOvertimeRate.Text = overtimeRate.ToString();
            txtBillableRate.Text = billableRate.ToString();
            lblLocation.Values.ExtraText = savePath;

            if (overtimeRate == (hourlyRate + (hourlyRate / 2.0M)))
            {
                chkDefaultOvertime.Checked = true;
            }
        }

        private void chkDefaultOvertime_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDefaultOvertime.Checked)
            {
                bool success = decimal.TryParse(txtHourlyRate.Text, out decimal hourly);
                if (success)
                {
                    decimal overtime = hourly + (hourly / 2.0M);
                    txtOvertimeRate.Text = overtime.ToString();
                }
            }
            else
            {
                txtOvertimeRate.Text = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                Settings.Default.UsersName = name;
                Settings.Default.HourlyRate = hourlyRate;
                Settings.Default.OvertimeRate = overtimeRate;
                Settings.Default.BillableRate = billableRate;
                Settings.Default.SavePath = savePath;
                Settings.Default.Save();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = CMessageBox.Show("This will clear all values (including save path)!\nAre you sure?", "Confirm", MessageBoxButtons.YesNo, Resources.info_32);
            if (result == DialogResult.Yes)
            {
                txtFullName.Text = "";
                txtHourlyRate.Text = "";
                txtOvertimeRate.Text = "";
                txtBillableRate.Text = "";
                chkDefaultOvertime.Checked = false;
                lblLocation.Values.ExtraText = "";

                name = "";
                hourlyRate = 0.0M;
                overtimeRate = 0.0M;
                billableRate = 0.0M;
                savePath = "";
            }
        }

        private bool ValidateFields()
        {
            bool valid = false;
            if (txtFullName.Text.Length > 0)
            {
                valid = true;
            }
            else
            {
                CMessageBox.Show("You must enter a name to appear\non the timesheet.", "No name entered", MessageBoxButtons.OK, Resources.warning_32);
                valid = false;
                return valid;
            }

            if (decimal.TryParse(txtHourlyRate.Text, out decimal h))
            {
                hourlyRate = h;
                valid = true;
            }
            else
            {
                CMessageBox.Show("The hourly rate entered was not in decimal format.", "Invalid format", MessageBoxButtons.OK, Resources.warning_32);
                valid = false;
                return valid;
            }

            if (decimal.TryParse(txtOvertimeRate.Text, out decimal o))
            {
                overtimeRate = o;
                valid = true;
            }
            else
            {
                CMessageBox.Show("The overtime rate entered was not in decimal format.", "Invalid format", MessageBoxButtons.OK, Resources.warning_32);
                valid = false;
                return valid;
            }

            if (decimal.TryParse(txtBillableRate.Text, out decimal b))
            {
                billableRate = b;
                valid = true;
            }
            else
            {
                CMessageBox.Show("The billable rate entered was not in decimal format.", "Invalid format", MessageBoxButtons.OK, Resources.warning_32);
                valid = false;
                return valid;
            }

            if (savePath.Length > 0)
            {
                valid = true;
            }
            else
            {
                CMessageBox.Show("No path specified for timesheet file.", "Invalid path", MessageBoxButtons.OK, Resources.warning_32);
                valid = false;
                return valid;
            }

            return valid;
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            name = txtFullName.Text;
        }
    }
}
