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

namespace TimeTracker
{
    public partial class MainForm : KryptonForm
    {
        private DateTime date;

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
    }
}
