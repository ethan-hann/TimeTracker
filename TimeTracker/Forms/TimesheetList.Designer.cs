namespace TimeTracker.Forms
{
    partial class TimesheetList
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tvTimesheets = new ComponentFactory.Krypton.Toolkit.KryptonTreeView();
            this.btnGenerateSelectedSheet = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tvTimesheets);
            this.flowLayoutPanel1.Controls.Add(this.btnGenerateSelectedSheet);
            this.flowLayoutPanel1.Controls.Add(this.btnClose);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(908, 494);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tvTimesheets
            // 
            this.tvTimesheets.Location = new System.Drawing.Point(3, 3);
            this.tvTimesheets.Name = "tvTimesheets";
            this.tvTimesheets.Size = new System.Drawing.Size(905, 449);
            this.tvTimesheets.TabIndex = 1;
            // 
            // btnGenerateSelectedSheet
            // 
            this.btnGenerateSelectedSheet.Location = new System.Drawing.Point(3, 458);
            this.btnGenerateSelectedSheet.Name = "btnGenerateSelectedSheet";
            this.btnGenerateSelectedSheet.Size = new System.Drawing.Size(198, 25);
            this.btnGenerateSelectedSheet.TabIndex = 2;
            this.btnGenerateSelectedSheet.Values.Text = "Generate Selected Sheet...";
            this.btnGenerateSelectedSheet.Click += new System.EventHandler(this.btnGenerateSelectedSheet_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(207, 458);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 25);
            this.btnClose.TabIndex = 3;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // TimesheetList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimesheetList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "List of Timesheets";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TimesheetList_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTreeView tvTimesheets;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnGenerateSelectedSheet;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClose;
    }
}