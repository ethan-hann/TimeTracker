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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenPreferences = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.timesheetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGenerateTimesheet = new System.Windows.Forms.ToolStripMenuItem();
            this.normalTimeTracker = new System.Windows.Forms.Timer(this.components);
            this.billableTimeTracker = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.hdgrpNormalTime = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.btnNormalClockIn = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHours = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHoursCount = new System.Windows.Forms.Label();
            this.lblMinutesCount = new System.Windows.Forms.Label();
            this.lblSecondsCount = new System.Windows.Forms.Label();
            this.hdgrpBillableTime = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.btnStartBillableTime = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.btnStopBillableTime = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBillableHoursCount = new System.Windows.Forms.Label();
            this.lblBillableMinutesCount = new System.Windows.Forms.Label();
            this.lblBillableSecondsCount = new System.Windows.Forms.Label();
            this.hdgrpTotalTime = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNormalMoney = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblBillableMoney = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnEndDay = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.rtbNotes = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hdgrpNormalTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hdgrpNormalTime.Panel)).BeginInit();
            this.hdgrpNormalTime.Panel.SuspendLayout();
            this.hdgrpNormalTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hdgrpBillableTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hdgrpBillableTime.Panel)).BeginInit();
            this.hdgrpBillableTime.Panel.SuspendLayout();
            this.hdgrpBillableTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hdgrpTotalTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hdgrpTotalTime.Panel)).BeginInit();
            this.hdgrpTotalTime.Panel.SuspendLayout();
            this.hdgrpTotalTime.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.timesheetsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpenPreferences,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.toolStripSeparator1,
            this.btnExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // btnOpenPreferences
            // 
            this.btnOpenPreferences.Image = global::TimeTracker.Properties.Resources.settings_32;
            this.btnOpenPreferences.Name = "btnOpenPreferences";
            this.btnOpenPreferences.Size = new System.Drawing.Size(180, 22);
            this.btnOpenPreferences.Text = "Options...";
            this.btnOpenPreferences.Click += new System.EventHandler(this.OpenOptions);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Image = global::TimeTracker.Properties.Resources.info_32;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::TimeTracker.Properties.Resources.about;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::TimeTracker.Properties.Resources.exit;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 22);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timesheetsToolStripMenuItem
            // 
            this.timesheetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGenerateTimesheet});
            this.timesheetsToolStripMenuItem.Name = "timesheetsToolStripMenuItem";
            this.timesheetsToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.timesheetsToolStripMenuItem.Text = "Timesheets";
            // 
            // btnGenerateTimesheet
            // 
            this.btnGenerateTimesheet.Image = global::TimeTracker.Properties.Resources.timesheet_32;
            this.btnGenerateTimesheet.Name = "btnGenerateTimesheet";
            this.btnGenerateTimesheet.Size = new System.Drawing.Size(187, 22);
            this.btnGenerateTimesheet.Text = "Generate Timesheet...";
            this.btnGenerateTimesheet.Click += new System.EventHandler(this.btnGenerateTimesheet_Click);
            // 
            // normalTimeTracker
            // 
            this.normalTimeTracker.Interval = 1000;
            this.normalTimeTracker.Tick += new System.EventHandler(this.normalTime_Tick);
            // 
            // billableTimeTracker
            // 
            this.billableTimeTracker.Interval = 1000;
            this.billableTimeTracker.Tick += new System.EventHandler(this.billableTimeTracker_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.hdgrpNormalTime);
            this.flowLayoutPanel1.Controls.Add(this.hdgrpBillableTime);
            this.flowLayoutPanel1.Controls.Add(this.hdgrpTotalTime);
            this.flowLayoutPanel1.Controls.Add(this.rtbNotes);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(783, 536);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // hdgrpNormalTime
            // 
            this.hdgrpNormalTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hdgrpNormalTime.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup[] {
            this.btnNormalClockIn});
            this.hdgrpNormalTime.Location = new System.Drawing.Point(3, 3);
            this.hdgrpNormalTime.Name = "hdgrpNormalTime";
            // 
            // hdgrpNormalTime.Panel
            // 
            this.hdgrpNormalTime.Panel.Controls.Add(this.kryptonPanel1);
            this.hdgrpNormalTime.Size = new System.Drawing.Size(776, 124);
            this.hdgrpNormalTime.TabIndex = 1;
            this.hdgrpNormalTime.ValuesPrimary.Heading = "Normal Time";
            this.hdgrpNormalTime.ValuesPrimary.Image = null;
            this.hdgrpNormalTime.ValuesSecondary.Heading = "Keep track of normal, working time.";
            // 
            // btnNormalClockIn
            // 
            this.btnNormalClockIn.Image = global::TimeTracker.Properties.Resources.start_32;
            this.btnNormalClockIn.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Inherit;
            this.btnNormalClockIn.Text = "Clock In";
            this.btnNormalClockIn.ToolTipBody = "Clock in and start the day!";
            this.btnNormalClockIn.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ToolTip;
            this.btnNormalClockIn.ToolTipTitle = "Normal";
            this.btnNormalClockIn.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Generic;
            this.btnNormalClockIn.UniqueName = "4956D308D3B54D7108B4D8A20BF50B1E";
            this.btnNormalClockIn.Click += new System.EventHandler(this.btnClockIn_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.tableLayoutPanel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(774, 60);
            this.kryptonPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
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
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(774, 60);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // lblHours
            // 
            this.lblHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(131, 17);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(122, 25);
            this.lblHours.TabIndex = 3;
            this.lblHours.Text = "Hours";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Minutes";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(643, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seconds";
            // 
            // lblHoursCount
            // 
            this.lblHoursCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHoursCount.AutoSize = true;
            this.lblHoursCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursCount.Location = new System.Drawing.Point(3, 14);
            this.lblHoursCount.Name = "lblHoursCount";
            this.lblHoursCount.Size = new System.Drawing.Size(122, 32);
            this.lblHoursCount.TabIndex = 6;
            this.lblHoursCount.Text = "0";
            this.lblHoursCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinutesCount
            // 
            this.lblMinutesCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinutesCount.AutoSize = true;
            this.lblMinutesCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutesCount.Location = new System.Drawing.Point(259, 14);
            this.lblMinutesCount.Name = "lblMinutesCount";
            this.lblMinutesCount.Size = new System.Drawing.Size(122, 32);
            this.lblMinutesCount.TabIndex = 7;
            this.lblMinutesCount.Text = "0";
            this.lblMinutesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSecondsCount
            // 
            this.lblSecondsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSecondsCount.AutoSize = true;
            this.lblSecondsCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondsCount.Location = new System.Drawing.Point(515, 14);
            this.lblSecondsCount.Name = "lblSecondsCount";
            this.lblSecondsCount.Size = new System.Drawing.Size(122, 32);
            this.lblSecondsCount.TabIndex = 8;
            this.lblSecondsCount.Text = "0";
            this.lblSecondsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hdgrpBillableTime
            // 
            this.hdgrpBillableTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hdgrpBillableTime.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup[] {
            this.btnStartBillableTime,
            this.btnStopBillableTime});
            this.hdgrpBillableTime.Location = new System.Drawing.Point(3, 133);
            this.hdgrpBillableTime.Name = "hdgrpBillableTime";
            // 
            // hdgrpBillableTime.Panel
            // 
            this.hdgrpBillableTime.Panel.Controls.Add(this.kryptonPanel2);
            this.hdgrpBillableTime.Size = new System.Drawing.Size(776, 124);
            this.hdgrpBillableTime.TabIndex = 3;
            this.hdgrpBillableTime.ValuesPrimary.Heading = "Billable Time";
            this.hdgrpBillableTime.ValuesPrimary.Image = null;
            this.hdgrpBillableTime.ValuesSecondary.Heading = "Keep track of billable time.";
            // 
            // btnStartBillableTime
            // 
            this.btnStartBillableTime.Image = global::TimeTracker.Properties.Resources.start_32;
            this.btnStartBillableTime.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Inherit;
            this.btnStartBillableTime.Text = "Start";
            this.btnStartBillableTime.ToolTipBody = "Pause the normal timer and begin billable time.";
            this.btnStartBillableTime.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ToolTip;
            this.btnStartBillableTime.ToolTipTitle = "Billable Time";
            this.btnStartBillableTime.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Generic;
            this.btnStartBillableTime.UniqueName = "2914497D0D774D15CCA1FE2B365EB0E4";
            this.btnStartBillableTime.Click += new System.EventHandler(this.btnBillableClockIn_Click);
            // 
            // btnStopBillableTime
            // 
            this.btnStopBillableTime.Image = global::TimeTracker.Properties.Resources.stop_32;
            this.btnStopBillableTime.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Inherit;
            this.btnStopBillableTime.Text = "Stop";
            this.btnStopBillableTime.ToolTipBody = "Stops the timer for billable time and resumes the normal timer.";
            this.btnStopBillableTime.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ToolTip;
            this.btnStopBillableTime.ToolTipTitle = "Billable Time";
            this.btnStopBillableTime.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Generic;
            this.btnStopBillableTime.UniqueName = "361F0935CCDC4710AB98BDB02B73F806";
            this.btnStopBillableTime.Click += new System.EventHandler(this.btnBillableClockOut_Click);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.tableLayoutPanel2);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(774, 60);
            this.kryptonPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblBillableHoursCount, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblBillableMinutesCount, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblBillableSecondsCount, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(774, 60);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hours";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(387, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Minutes";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(643, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Seconds";
            // 
            // lblBillableHoursCount
            // 
            this.lblBillableHoursCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBillableHoursCount.AutoSize = true;
            this.lblBillableHoursCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillableHoursCount.Location = new System.Drawing.Point(3, 14);
            this.lblBillableHoursCount.Name = "lblBillableHoursCount";
            this.lblBillableHoursCount.Size = new System.Drawing.Size(122, 32);
            this.lblBillableHoursCount.TabIndex = 6;
            this.lblBillableHoursCount.Text = "0";
            this.lblBillableHoursCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBillableMinutesCount
            // 
            this.lblBillableMinutesCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBillableMinutesCount.AutoSize = true;
            this.lblBillableMinutesCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillableMinutesCount.Location = new System.Drawing.Point(259, 14);
            this.lblBillableMinutesCount.Name = "lblBillableMinutesCount";
            this.lblBillableMinutesCount.Size = new System.Drawing.Size(122, 32);
            this.lblBillableMinutesCount.TabIndex = 7;
            this.lblBillableMinutesCount.Text = "0";
            this.lblBillableMinutesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBillableSecondsCount
            // 
            this.lblBillableSecondsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBillableSecondsCount.AutoSize = true;
            this.lblBillableSecondsCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillableSecondsCount.Location = new System.Drawing.Point(515, 14);
            this.lblBillableSecondsCount.Name = "lblBillableSecondsCount";
            this.lblBillableSecondsCount.Size = new System.Drawing.Size(122, 32);
            this.lblBillableSecondsCount.TabIndex = 8;
            this.lblBillableSecondsCount.Text = "0";
            this.lblBillableSecondsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hdgrpTotalTime
            // 
            this.hdgrpTotalTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hdgrpTotalTime.Location = new System.Drawing.Point(3, 263);
            this.hdgrpTotalTime.Name = "hdgrpTotalTime";
            // 
            // hdgrpTotalTime.Panel
            // 
            this.hdgrpTotalTime.Panel.Controls.Add(this.flowLayoutPanel2);
            this.hdgrpTotalTime.Size = new System.Drawing.Size(775, 118);
            this.hdgrpTotalTime.TabIndex = 4;
            this.hdgrpTotalTime.ValuesPrimary.Heading = "Today\'s Stats";
            this.hdgrpTotalTime.ValuesPrimary.Image = null;
            this.hdgrpTotalTime.ValuesSecondary.Heading = "View statistics about today. These include the total time worked and how much mon" +
    "ey was made!";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblNormalMoney);
            this.flowLayoutPanel2.Controls.Add(this.lblBillableMoney);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(773, 65);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // lblNormalMoney
            // 
            this.lblNormalMoney.Location = new System.Drawing.Point(3, 3);
            this.lblNormalMoney.Name = "lblNormalMoney";
            this.lblNormalMoney.Size = new System.Drawing.Size(76, 20);
            this.lblNormalMoney.TabIndex = 2;
            this.lblNormalMoney.Values.Text = "Normal Pay: ";
            // 
            // lblBillableMoney
            // 
            this.lblBillableMoney.Location = new System.Drawing.Point(3, 29);
            this.lblBillableMoney.Name = "lblBillableMoney";
            this.lblBillableMoney.Size = new System.Drawing.Size(75, 20);
            this.lblBillableMoney.TabIndex = 3;
            this.lblBillableMoney.Values.Text = "Billable Pay: ";
            // 
            // btnEndDay
            // 
            this.btnEndDay.ExtraText = "(end day)";
            this.btnEndDay.Image = global::TimeTracker.Properties.Resources.stop_32;
            this.btnEndDay.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Inherit;
            this.btnEndDay.Text = "Clock Out";
            this.btnEndDay.ToolTipBody = "Clock out and end the current day.";
            this.btnEndDay.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ToolTip;
            this.btnEndDay.ToolTipTitle = "Normal";
            this.btnEndDay.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Generic;
            this.btnEndDay.UniqueName = "ECF2339D11F44343B4A9206038643D05";
            // 
            // rtbNotes
            // 
            this.rtbNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbNotes.Location = new System.Drawing.Point(3, 387);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(772, 137);
            this.rtbNotes.TabIndex = 5;
            this.rtbNotes.Text = "Enter notes for today here...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnEndDay});
            this.ClientSize = new System.Drawing.Size(783, 560);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Time Tracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hdgrpNormalTime.Panel)).EndInit();
            this.hdgrpNormalTime.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hdgrpNormalTime)).EndInit();
            this.hdgrpNormalTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hdgrpBillableTime.Panel)).EndInit();
            this.hdgrpBillableTime.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hdgrpBillableTime)).EndInit();
            this.hdgrpBillableTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hdgrpTotalTime.Panel)).EndInit();
            this.hdgrpTotalTime.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hdgrpTotalTime)).EndInit();
            this.hdgrpTotalTime.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnOpenPreferences;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.Timer normalTimeTracker;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timesheetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnGenerateTimesheet;
        private System.Windows.Forms.Timer billableTimeTracker;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup hdgrpNormalTime;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btnNormalClockIn;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHoursCount;
        private System.Windows.Forms.Label lblMinutesCount;
        private System.Windows.Forms.Label lblSecondsCount;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup hdgrpBillableTime;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btnStartBillableTime;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btnStopBillableTime;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBillableHoursCount;
        private System.Windows.Forms.Label lblBillableMinutesCount;
        private System.Windows.Forms.Label lblBillableSecondsCount;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup hdgrpTotalTime;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblNormalMoney;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblBillableMoney;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnEndDay;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox rtbNotes;
    }
}

