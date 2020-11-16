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
            this.hdgrpNormalTime = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHours = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHoursCount = new System.Windows.Forms.Label();
            this.lblMinutesCount = new System.Windows.Forms.Label();
            this.lblSecondsCount = new System.Windows.Forms.Label();
            this.btnNormalClockOut = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnNormalClockIn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
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
            this.hdgrpBillableTime = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBillableHoursCount = new System.Windows.Forms.Label();
            this.lblBillableMinutesCount = new System.Windows.Forms.Label();
            this.lblBillableSecondsCount = new System.Windows.Forms.Label();
            this.btnBillableClockOut = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnBillableClockIn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.hdgrpNormalTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hdgrpNormalTime.Panel)).BeginInit();
            this.hdgrpNormalTime.Panel.SuspendLayout();
            this.hdgrpNormalTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hdgrpBillableTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hdgrpBillableTime.Panel)).BeginInit();
            this.hdgrpBillableTime.Panel.SuspendLayout();
            this.hdgrpBillableTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // hdgrpNormalTime
            // 
            this.hdgrpNormalTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hdgrpNormalTime.Location = new System.Drawing.Point(12, 36);
            this.hdgrpNormalTime.Name = "hdgrpNormalTime";
            // 
            // hdgrpNormalTime.Panel
            // 
            this.hdgrpNormalTime.Panel.Controls.Add(this.kryptonPanel1);
            this.hdgrpNormalTime.Size = new System.Drawing.Size(776, 248);
            this.hdgrpNormalTime.TabIndex = 0;
            this.hdgrpNormalTime.ValuesPrimary.Heading = "Normal Time";
            this.hdgrpNormalTime.ValuesPrimary.Image = null;
            this.hdgrpNormalTime.ValuesSecondary.Heading = "Keep track of normal, working time.";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.tableLayoutPanel1);
            this.kryptonPanel1.Controls.Add(this.btnNormalClockOut);
            this.kryptonPanel1.Controls.Add(this.btnNormalClockIn);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(774, 195);
            this.kryptonPanel1.TabIndex = 4;
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
            this.lblHoursCount.Text = "0";
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
            this.lblMinutesCount.Text = "0";
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
            this.lblSecondsCount.Text = "0";
            this.lblSecondsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNormalClockOut
            // 
            this.btnNormalClockOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNormalClockOut.Location = new System.Drawing.Point(3, 146);
            this.btnNormalClockOut.Name = "btnNormalClockOut";
            this.btnNormalClockOut.Size = new System.Drawing.Size(768, 46);
            this.btnNormalClockOut.TabIndex = 4;
            this.btnNormalClockOut.Values.ImageStates.ImageCheckedNormal = null;
            this.btnNormalClockOut.Values.ImageStates.ImageCheckedPressed = null;
            this.btnNormalClockOut.Values.ImageStates.ImageCheckedTracking = null;
            this.btnNormalClockOut.Values.ImageStates.ImageNormal = global::TimeTracker.Properties.Resources.stop_32;
            this.btnNormalClockOut.Values.Text = "Clock Out";
            this.btnNormalClockOut.Click += new System.EventHandler(this.btnClockOut_Click);
            // 
            // btnNormalClockIn
            // 
            this.btnNormalClockIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNormalClockIn.Location = new System.Drawing.Point(3, 3);
            this.btnNormalClockIn.Name = "btnNormalClockIn";
            this.btnNormalClockIn.Size = new System.Drawing.Size(768, 43);
            this.btnNormalClockIn.TabIndex = 3;
            this.btnNormalClockIn.Values.ImageStates.ImageCheckedNormal = null;
            this.btnNormalClockIn.Values.ImageStates.ImageCheckedPressed = null;
            this.btnNormalClockIn.Values.ImageStates.ImageCheckedTracking = null;
            this.btnNormalClockIn.Values.ImageStates.ImageNormal = global::TimeTracker.Properties.Resources.start_32;
            this.btnNormalClockIn.Values.Text = "Clock In";
            this.btnNormalClockIn.Click += new System.EventHandler(this.btnClockIn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.timesheetsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
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
            this.btnOpenPreferences.Size = new System.Drawing.Size(125, 22);
            this.btnOpenPreferences.Text = "Options...";
            this.btnOpenPreferences.Click += new System.EventHandler(this.OpenOptions);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Image = global::TimeTracker.Properties.Resources.info_32;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::TimeTracker.Properties.Resources.about;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(122, 6);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::TimeTracker.Properties.Resources.exit;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 22);
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
            // hdgrpBillableTime
            // 
            this.hdgrpBillableTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hdgrpBillableTime.Location = new System.Drawing.Point(13, 301);
            this.hdgrpBillableTime.Name = "hdgrpBillableTime";
            // 
            // hdgrpBillableTime.Panel
            // 
            this.hdgrpBillableTime.Panel.Controls.Add(this.kryptonPanel2);
            this.hdgrpBillableTime.Size = new System.Drawing.Size(776, 248);
            this.hdgrpBillableTime.TabIndex = 2;
            this.hdgrpBillableTime.ValuesPrimary.Heading = "Billable Time";
            this.hdgrpBillableTime.ValuesPrimary.Image = null;
            this.hdgrpBillableTime.ValuesSecondary.Heading = "Keep track of billable time.";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.tableLayoutPanel2);
            this.kryptonPanel2.Controls.Add(this.btnBillableClockOut);
            this.kryptonPanel2.Controls.Add(this.btnBillableClockIn);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(774, 195);
            this.kryptonPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(79, 52);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(616, 88);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hours";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(309, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Minutes";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(513, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Seconds";
            // 
            // lblBillableHoursCount
            // 
            this.lblBillableHoursCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBillableHoursCount.AutoSize = true;
            this.lblBillableHoursCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillableHoursCount.Location = new System.Drawing.Point(3, 28);
            this.lblBillableHoursCount.Name = "lblBillableHoursCount";
            this.lblBillableHoursCount.Size = new System.Drawing.Size(96, 32);
            this.lblBillableHoursCount.TabIndex = 6;
            this.lblBillableHoursCount.Text = "0";
            this.lblBillableHoursCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBillableMinutesCount
            // 
            this.lblBillableMinutesCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBillableMinutesCount.AutoSize = true;
            this.lblBillableMinutesCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillableMinutesCount.Location = new System.Drawing.Point(207, 28);
            this.lblBillableMinutesCount.Name = "lblBillableMinutesCount";
            this.lblBillableMinutesCount.Size = new System.Drawing.Size(96, 32);
            this.lblBillableMinutesCount.TabIndex = 7;
            this.lblBillableMinutesCount.Text = "0";
            this.lblBillableMinutesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBillableSecondsCount
            // 
            this.lblBillableSecondsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBillableSecondsCount.AutoSize = true;
            this.lblBillableSecondsCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillableSecondsCount.Location = new System.Drawing.Point(411, 28);
            this.lblBillableSecondsCount.Name = "lblBillableSecondsCount";
            this.lblBillableSecondsCount.Size = new System.Drawing.Size(96, 32);
            this.lblBillableSecondsCount.TabIndex = 8;
            this.lblBillableSecondsCount.Text = "0";
            this.lblBillableSecondsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBillableClockOut
            // 
            this.btnBillableClockOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBillableClockOut.Location = new System.Drawing.Point(3, 146);
            this.btnBillableClockOut.Name = "btnBillableClockOut";
            this.btnBillableClockOut.Size = new System.Drawing.Size(768, 46);
            this.btnBillableClockOut.TabIndex = 4;
            this.btnBillableClockOut.Values.ImageStates.ImageCheckedNormal = null;
            this.btnBillableClockOut.Values.ImageStates.ImageCheckedPressed = null;
            this.btnBillableClockOut.Values.ImageStates.ImageCheckedTracking = null;
            this.btnBillableClockOut.Values.ImageStates.ImageNormal = global::TimeTracker.Properties.Resources.stop_32;
            this.btnBillableClockOut.Values.Text = "Clock Out";
            this.btnBillableClockOut.Click += new System.EventHandler(this.btnBillableClockOut_Click);
            // 
            // btnBillableClockIn
            // 
            this.btnBillableClockIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBillableClockIn.Location = new System.Drawing.Point(3, 3);
            this.btnBillableClockIn.Name = "btnBillableClockIn";
            this.btnBillableClockIn.Size = new System.Drawing.Size(768, 43);
            this.btnBillableClockIn.TabIndex = 3;
            this.btnBillableClockIn.Values.ImageStates.ImageCheckedNormal = null;
            this.btnBillableClockIn.Values.ImageStates.ImageCheckedPressed = null;
            this.btnBillableClockIn.Values.ImageStates.ImageCheckedTracking = null;
            this.btnBillableClockIn.Values.ImageStates.ImageNormal = global::TimeTracker.Properties.Resources.start_32;
            this.btnBillableClockIn.Values.Text = "Clock In";
            this.btnBillableClockIn.Click += new System.EventHandler(this.btnBillableClockIn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.hdgrpBillableTime);
            this.Controls.Add(this.hdgrpNormalTime);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Time Tracker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hdgrpNormalTime.Panel)).EndInit();
            this.hdgrpNormalTime.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hdgrpNormalTime)).EndInit();
            this.hdgrpNormalTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hdgrpBillableTime.Panel)).EndInit();
            this.hdgrpBillableTime.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hdgrpBillableTime)).EndInit();
            this.hdgrpBillableTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup hdgrpNormalTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnOpenPreferences;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.Timer normalTimeTracker;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNormalClockOut;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNormalClockIn;
        private System.Windows.Forms.Label lblHoursCount;
        private System.Windows.Forms.Label lblMinutesCount;
        private System.Windows.Forms.Label lblSecondsCount;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timesheetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnGenerateTimesheet;
        private System.Windows.Forms.Timer billableTimeTracker;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup hdgrpBillableTime;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBillableHoursCount;
        private System.Windows.Forms.Label lblBillableMinutesCount;
        private System.Windows.Forms.Label lblBillableSecondsCount;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBillableClockOut;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBillableClockIn;
    }
}

