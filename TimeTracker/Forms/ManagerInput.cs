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
using TimeTracker.utility;
using static TimeTracker.utility.CEventArgs;

namespace TimeTracker.Forms
{
    public partial class ManagerInput : KryptonForm
    {
        /// <summary>
        /// Called when the user is done inputting data on this form.
        /// </summary>
        public EventHandler OnInputDone;

        private readonly Employee manager = new Employee();

        public ManagerInput()
        {
            InitializeComponent();
        }

        private void btnAddManager_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                OnInputDone?.Invoke(this, new ManagerEventArgs(manager));
            }
        }

        private bool ValidateFields()
        {
            Employee manager = new Employee();
            if (txtFullName.Text.Length > 0)
            {
                manager.Name = txtFullName.Text;
            }
            else
            {
                CMessageBox.Show("Manager's name cannot be empty!", "Empty name", MessageBoxButtons.OK, Resources.error_32);
                return false;
            }

            if (Validator.ValidateEmail(txtEmail.Text))
            {
                manager.Email = txtEmail.Text;
            }
            else
            {
                CMessageBox.Show("Email entered was not valid!", "Invalid format", MessageBoxButtons.OK, Resources.error_32);
                return false;
            }

            if (Validator.ValidatePhoneNumber(txtPhoneNumber.Text))
            {
                manager.PhoneNumber = txtPhoneNumber.Text;
            }
            else
            {
                CMessageBox.Show("Phone number entered was not valid!", "Invalid format", MessageBoxButtons.OK, Resources.error_32);
                return false;
            }

            return true;
        }
    }
}
