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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.hdrgrpTime = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGenerateTimesheet = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenPreferences = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnClockOut = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnClockIn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHours = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHoursCount = new System.Windows.Forms.Label();
            this.lblMinutesCount = new System.Windows.Forms.Label();
            this.lblSecondsCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hdrgrpTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hdrgrpTime.Panel)).BeginInit();
            this.hdrgrpTime.Panel.SuspendLayout();
            this.hdrgrpTime.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hdrgrpTime
            // 
            this.hdrgrpTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hdrgrpTime.Location = new System.Drawing.Point(12, 36);
            this.hdrgrpTime.Name = "hdrgrpTime";
            // 
            // hdrgrpTime.Panel
            // 
            this.hdrgrpTime.Panel.Controls.Add(this.kryptonPanel1);
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
            this.btnGenerateTimesheet.Size = new System.Drawing.Size(178, 22);
            this.btnGenerateTimesheet.Text = "Generate Timesheet";
            // 
            // btnOpenPreferences
            // 
            this.btnOpenPreferences.Image = global::TimeTracker.Properties.Resources.settings_32;
            this.btnOpenPreferences.Name = "btnOpenPreferences";
            this.btnOpenPreferences.Size = new System.Drawing.Size(178, 22);
            this.btnOpenPreferences.Text = "Preferences...";
            this.btnOpenPreferences.Click += new System.EventHandler(this.OpenOptions);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(178, 22);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.tableLayoutPanel1);
            this.kryptonPanel1.Controls.Add(this.btnClockOut);
            this.kryptonPanel1.Controls.Add(this.btnClockIn);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(774, 195);
            this.kryptonPanel1.TabIndex = 4;
            // 
            // btnClockOut
            // 
            this.btnClockOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClockOut.Location = new System.Drawing.Point(3, 146);
            this.btnClockOut.Name = "btnClockOut";
            this.btnClockOut.Size = new System.Drawing.Size(768, 46);
            this.btnClockOut.TabIndex = 4;
            this.btnClockOut.Values.Text = "Clock Out";
            // 
            // btnClockIn
            // 
            this.btnClockIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClockIn.Location = new System.Drawing.Point(3, 3);
            this.btnClockIn.Name = "btnClockIn";
            this.btnClockIn.Size = new System.Drawing.Size(768, 43);
            this.btnClockIn.TabIndex = 3;
            this.btnClockIn.Values.Text = "Clock In";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.lblHours, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblHoursCount, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMinutesCount, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSecondsCount, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(79, 52);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(616, 88);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // lblHours
            // 
            this.lblHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(105, 31);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(96, 25);
            this.lblHours.TabIndex = 3;
            this.lblHours.Text = "Hours";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Minutes";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(513, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seconds";
            // 
            // lblHoursCount
            // 
            this.lblHoursCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHoursCount.AutoSize = true;
            this.lblHoursCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursCount.Location = new System.Drawing.Point(3, 28);
            this.lblHoursCount.Name = "lblHoursCount";
            this.lblHoursCount.Size = new System.Drawing.Size(96, 32);
            this.lblHoursCount.TabIndex = 6;
            this.lblHoursCount.Text = "1";
            this.lblHoursCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinutesCount
            // 
            this.lblMinutesCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinutesCount.AutoSize = true;
            this.lblMinutesCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutesCount.Location = new System.Drawing.Point(207, 28);
            this.lblMinutesCount.Name = "lblMinutesCount";
            this.lblMinutesCount.Size = new System.Drawing.Size(96, 32);
            this.lblMinutesCount.TabIndex = 7;
            this.lblMinutesCount.Text = "1";
            this.lblMinutesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSecondsCount
            // 
            this.lblSecondsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSecondsCount.AutoSize = true;
            this.lblSecondsCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondsCount.Location = new System.Drawing.Point(411, 28);
            this.lblSecondsCount.Name = "lblSecondsCount";
            this.lblSecondsCount.Size = new System.Drawing.Size(96, 32);
            this.lblSecondsCount.TabIndex = 8;
            this.lblSecondsCount.Text = "1";
            this.lblSecondsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            ((System.ComponentModel.ISupportInitialize)(this.hdrgrpTime)).EndInit();
            this.hdrgrpTime.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.Timer timer;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClockOut;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClockIn;
        private System.Windows.Forms.Label lblHoursCount;
        private System.Windows.Forms.Label lblMinutesCount;
        private System.Windows.Forms.Label lblSecondsCount;
    }
}

