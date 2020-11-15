namespace TimeTracker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.hdrgrpTime = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGenerateTimesheet = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenPreferences = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClockIn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblClockInTime = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.hdrgrpTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hdrgrpTime.Panel)).BeginInit();
            this.hdrgrpTime.Panel.SuspendLayout();
            this.hdrgrpTime.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hdrgrpTime
            // 
            this.hdrgrpTime.Location = new System.Drawing.Point(12, 36);
            this.hdrgrpTime.Name = "hdrgrpTime";
            // 
            // hdrgrpTime.Panel
            // 
            this.hdrgrpTime.Panel.Controls.Add(this.lblClockInTime);
            this.hdrgrpTime.Panel.Controls.Add(this.btnClockIn);
            this.hdrgrpTime.Size = new System.Drawing.Size(776, 248);
            this.hdrgrpTime.TabIndex = 0;
            this.hdrgrpTime.ValuesPrimary.Heading = "Time";
            this.hdrgrpTime.ValuesPrimary.Image = null;
            this.hdrgrpTime.ValuesSecondary.Heading = "Start and stop the clock here";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGenerateTimesheet,
            this.btnOpenPreferences,
            this.toolStripSeparator1,
            this.btnExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // btnGenerateTimesheet
            // 
            this.btnGenerateTimesheet.Image = global::TimeTracker.Properties.Resources.timesheet_32;
            this.btnGenerateTimesheet.Name = "btnGenerateTimesheet";
            this.btnGenerateTimesheet.Size = new System.Drawing.Size(180, 22);
            this.btnGenerateTimesheet.Text = "Generate Timesheet";
            // 
            // btnOpenPreferences
            // 
            this.btnOpenPreferences.Image = global::TimeTracker.Properties.Resources.settings_32;
            this.btnOpenPreferences.Name = "btnOpenPreferences";
            this.btnOpenPreferences.Size = new System.Drawing.Size(180, 22);
            this.btnOpenPreferences.Text = "Preferences...";
            this.btnOpenPreferences.Click += new System.EventHandler(this.OpenOptions);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 22);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClockIn
            // 
            this.btnClockIn.Location = new System.Drawing.Point(3, 3);
            this.btnClockIn.Name = "btnClockIn";
            this.btnClockIn.Size = new System.Drawing.Size(768, 43);
            this.btnClockIn.TabIndex = 0;
            this.btnClockIn.Values.Text = "Clock In";
            // 
            // lblClockInTime
            // 
            this.lblClockInTime.Location = new System.Drawing.Point(3, 52);
            this.lblClockInTime.Name = "lblClockInTime";
            this.lblClockInTime.Size = new System.Drawing.Size(102, 20);
            this.lblClockInTime.TabIndex = 1;
            this.lblClockInTime.Values.Text = "(Time goes here)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hdrgrpTime);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Time Tracker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hdrgrpTime.Panel)).EndInit();
            this.hdrgrpTime.Panel.ResumeLayout(false);
            this.hdrgrpTime.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hdrgrpTime)).EndInit();
            this.hdrgrpTime.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup hdrgrpTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnGenerateTimesheet;
        private System.Windows.Forms.ToolStripMenuItem btnOpenPreferences;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClockIn;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblClockInTime;
    }
}

