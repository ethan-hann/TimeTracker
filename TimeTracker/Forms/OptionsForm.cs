using ComponentFactory.Krypton.Toolkit;
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
using TimeTracker.backend;
using TimeTracker.Forms;
using TimeTracker.Properties;
using static TimeTracker.utility.CEventArgs;

namespace TimeTracker
{
    public partial class OptionsForm : KryptonForm
    {
        public EventHandler OnOptionsSaved;

        private Employee employee;
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
                EmployeeInformation.Instance.SetDataLocation(savePath);
                Settings.Default.SavePath = savePath;
                Settings.Default.Save();
            }
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            employee = EmployeeInformation.Instance.GetEmployee();
            savePath = Settings.Default.SavePath;

            if (employee != null)
            {
                txtFullName.Text = employee.Name;
                txtHourlyRate.Text = employee.HourlyRate.ToString();
                txtOvertimeRate.Text = employee.OvertimeRate.ToString();
                txtBillableRate.Text = employee.BillableRate.ToString();
                txtLunchLength.Text = employee.LunchLength.ToString();
                cmbDaysOfWeek.SelectedItem = Settings.Default.WeekStart;
                txtWorkWeekLength.Text = Settings.Default.WorkWeekLength.ToString();

                if (employee.OvertimeRate == (employee.HourlyRate + (employee.HourlyRate / 2.0M)))
                {
                    chkDefaultOvertime.Checked = true;
                }

                txtEmail.Text = employee.Email;
                txtPhoneNumber.Text = employee.PhoneNumber;
                txtStreet.Text = employee.EmpAddress.Street;
                txtCity.Text = employee.EmpAddress.City;
                txtState.Text = employee.EmpAddress.State;
                txtZipCode.Text = employee.EmpAddress.ZipCode;
                
            }

            lblLocation.Values.ExtraText = savePath;
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

        private void txtHourlyRate_TextChanged(object sender, EventArgs e)
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
        }

        private void SaveSettings()
        {
            employee = new Employee
            {
                Name = txtFullName.Text,
                HourlyRate = decimal.Parse(txtHourlyRate.Text),
                OvertimeRate = decimal.Parse(txtOvertimeRate.Text),
                BillableRate = decimal.Parse(txtBillableRate.Text),
                Email = txtEmail.Text,
                PhoneNumber = txtPhoneNumber.Text,
                EmpAddress = new Address(txtStreet.Text, txtCity.Text, txtState.Text, txtZipCode.Text),
                LunchLength = double.Parse(txtLunchLength.Text)
            };

            EmployeeInformation.Instance.SetEmployee(employee);
            EmployeeInformation.Instance.Save();

            Settings.Default.LastGUID = employee.UniqueID;
            Settings.Default.SavePath = savePath;
            Settings.Default.WeekStart = (string)cmbDaysOfWeek.Items[cmbDaysOfWeek.SelectedIndex];
            Settings.Default.WorkWeekLength = short.Parse(txtWorkWeekLength.Text);
            Settings.Default.Save();

            OnOptionsSaved?.Invoke(this, new OptionsSavedEventArgs(employee));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                SaveSettings();
                Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = CMessageBox.Show("This will clear all values (including save path and Manager)!\nAre you sure?", "Confirm", MessageBoxButtons.YesNo, Resources.info_32);
            if (result == DialogResult.Yes)
            {
                txtFullName.Text = "";
                txtHourlyRate.Text = "";
                txtOvertimeRate.Text = "";
                txtBillableRate.Text = "";
                chkDefaultOvertime.Checked = false;
                lblLocation.Values.ExtraText = "";
                cmbDaysOfWeek.SelectedIndex = 0;
                txtLunchLength.Text = "";
                txtWorkWeekLength.Text = "";

                txtEmail.Text = "";
                txtPhoneNumber.Text = "";
                txtStreet.Text = "";
                txtCity.Text = "";
                txtState.Text = "";
                txtZipCode.Text = "";

                savePath = "";

                btnAddManager.Visible = true;
                lblManagerName.Visible = false;
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

            if (cmbDaysOfWeek.SelectedIndex >= 0)
            {
                valid = true;
            }
            else
            {
                CMessageBox.Show("Selected start of the week was invalid.", "Invalid day", MessageBoxButtons.OK, Resources.warning_32);
                valid = false;
                return valid;
            }

            if (short.TryParse(txtWorkWeekLength.Text, out short wwl))
            {
                if (wwl <= 7)
                {
                    valid = true;
                }
                else
                {
                    CMessageBox.Show("The work week cannot be longer than 7 days!", "Invalid week length", MessageBoxButtons.OK, Resources.warning_32);
                    valid = false;
                    return valid;
                }
            }
            else
            {
                CMessageBox.Show("The work week entered was not valid.", "Invalid week length", MessageBoxButtons.OK, Resources.warning_32);
                valid = false;
                return valid;
            }

            if (double.TryParse(txtLunchLength.Text, out double l))
            {
                valid = true;
            }
            else
            {
                CMessageBox.Show("The length of your lunch break was invalid.", "Invalid lunch length", MessageBoxButtons.OK, Resources.warning_32);
                valid = false;
                return valid;
            }

            if (txtEmail.Text.Length > 0 && txtEmail.Text.Contains("@"))
            {
                valid = true;
            }
            else
            {
                CMessageBox.Show("Email entered was not valid.", "Invalid email", MessageBoxButtons.OK, Resources.warning_32);
                valid = false;
                return valid;
            }

            if (txtPhoneNumber.Text.Length == 10 || (txtPhoneNumber.Text.Length == 12 && txtPhoneNumber.Text.Contains("-")))
            {
                valid = true;
            }
            else
            {
                CMessageBox.Show("Phone number entered was not valid.", "Invalid phone number", MessageBoxButtons.OK, Resources.warning_32);
                valid = false;
                return valid;
            }

            if (txtStreet.Text.Length > 0)
            {
                valid = true;
            }
            else
            {
                CMessageBox.Show("Street cannot be empty.", "Invalid address", MessageBoxButtons.OK, Resources.warning_32);
                valid = false;
                return valid;
            }

            if (txtCity.Text.Length > 0)
            {
                valid = true;
            }
            else
            {
                CMessageBox.Show("City cannot be empty.", "Invalid address", MessageBoxButtons.OK, Resources.warning_32);
                valid = false;
                return valid;
            }

            if (txtState.Text.Length > 0)
            {
                valid = true;
            }
            else
            {
                CMessageBox.Show("State cannot be empty.", "Invalid address", MessageBoxButtons.OK, Resources.warning_32);
                valid = false;
                return valid;
            }

            if (txtZipCode.Text.Length == 5 || (txtZipCode.Text.Length == 10 && txtZipCode.Text.Contains("-")))
            {
                valid = true;
            }
            else
            {
                CMessageBox.Show("Zip code entered was invalid.", "Invalid address", MessageBoxButtons.OK, Resources.warning_32);
                valid = false;
                return valid;
            }

            return valid;
        }

        private void btnAddManager_Click(object sender, EventArgs e)
        {
            ManagerInput managerInput = new ManagerInput();
            managerInput.OnInputDone += ProcessManager;
            managerInput.ShowDialog();
        }

        private void ProcessManager(object sender, EventArgs e)
        {
            if (e is ManagerEventArgs args)
            {
                btnAddManager.Visible = false;
                lblManagerName.Visible = true;
                lblManagerName.Values.ExtraText = args.Manager.Name;
            }
        }
    }
}
