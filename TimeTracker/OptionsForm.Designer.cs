namespace TimeTracker
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtFullName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHourlyRate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblOvertime = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.chkDefaultOvertime = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblBillable = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClear = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnSetSaveLocation = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLocation = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtHourlyRate = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtOvertimeRate = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtBillableRate = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.saveFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel6);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblName);
            this.flowLayoutPanel2.Controls.Add(this.txtFullName);
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            this.lblName.Values.Text = resources.GetString("kryptonLabel1.Values.Text");
            // 
            // txtFullName
            // 
            resources.ApplyResources(this.txtFullName, "txtFullName");
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.lblHourlyRate);
            this.flowLayoutPanel3.Controls.Add(this.txtHourlyRate);
            resources.ApplyResources(this.flowLayoutPanel3, "flowLayoutPanel3");
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            // 
            // lblHourlyRate
            // 
            resources.ApplyResources(this.lblHourlyRate, "lblHourlyRate");
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Values.Text = resources.GetString("kryptonLabel1.Values.Text1");
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.lblOvertime);
            this.flowLayoutPanel4.Controls.Add(this.txtOvertimeRate);
            this.flowLayoutPanel4.Controls.Add(this.chkDefaultOvertime);
            resources.ApplyResources(this.flowLayoutPanel4, "flowLayoutPanel4");
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            // 
            // lblOvertime
            // 
            resources.ApplyResources(this.lblOvertime, "lblOvertime");
            this.lblOvertime.Name = "lblOvertime";
            this.lblOvertime.Values.Text = resources.GetString("kryptonLabel1.Values.Text2");
            // 
            // chkDefaultOvertime
            // 
            resources.ApplyResources(this.chkDefaultOvertime, "chkDefaultOvertime");
            this.chkDefaultOvertime.Name = "chkDefaultOvertime";
            this.chkDefaultOvertime.Values.Text = resources.GetString("kryptonCheckBox1.Values.Text");
            this.chkDefaultOvertime.CheckedChanged += new System.EventHandler(this.chkDefaultOvertime_CheckedChanged);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.lblBillable);
            this.flowLayoutPanel5.Controls.Add(this.txtBillableRate);
            resources.ApplyResources(this.flowLayoutPanel5, "flowLayoutPanel5");
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            // 
            // lblBillable
            // 
            resources.ApplyResources(this.lblBillable, "lblBillable");
            this.lblBillable.Name = "lblBillable";
            this.lblBillable.Values.Text = resources.GetString("kryptonLabel1.Values.Text3");
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.btnSave);
            this.flowLayoutPanel6.Controls.Add(this.btnClear);
            resources.ApplyResources(this.flowLayoutPanel6, "flowLayoutPanel6");
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.Values.Text = resources.GetString("kryptonButton2.Values.Text");
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.kryptonLabel1);
            this.flowLayoutPanel7.Controls.Add(this.btnSetSaveLocation);
            resources.ApplyResources(this.flowLayoutPanel7, "flowLayoutPanel7");
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            // 
            // kryptonLabel1
            // 
            resources.ApplyResources(this.kryptonLabel1, "kryptonLabel1");
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Values.Text = resources.GetString("kryptonLabel1.Values.Text4");
            // 
            // btnSetSaveLocation
            // 
            resources.ApplyResources(this.btnSetSaveLocation, "btnSetSaveLocation");
            this.btnSetSaveLocation.Name = "btnSetSaveLocation";
            this.btnSetSaveLocation.Values.Text = resources.GetString("kryptonButton1.Values.Text");
            this.btnSetSaveLocation.Click += new System.EventHandler(this.btnSetSaveLocation_Click);
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Controls.Add(this.lblLocation);
            resources.ApplyResources(this.flowLayoutPanel8, "flowLayoutPanel8");
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            // 
            // lblLocation
            // 
            resources.ApplyResources(this.lblLocation, "lblLocation");
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Values.Text = resources.GetString("kryptonLabel2.Values.Text");
            // 
            // txtHourlyRate
            // 
            resources.ApplyResources(this.txtHourlyRate, "txtHourlyRate");
            this.txtHourlyRate.Name = "txtHourlyRate";
            // 
            // txtOvertimeRate
            // 
            resources.ApplyResources(this.txtOvertimeRate, "txtOvertimeRate");
            this.txtOvertimeRate.Name = "txtOvertimeRate";
            // 
            // txtBillableRate
            // 
            resources.ApplyResources(this.txtBillableRate, "txtBillableRate");
            this.txtBillableRate.Name = "txtBillableRate";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.Values.Text = resources.GetString("btnSave.Values.Text");
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // OptionsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtFullName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblHourlyRate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblOvertime;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chkDefaultOvertime;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblBillable;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSetSaveLocation;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblLocation;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClear;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtHourlyRate;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtOvertimeRate;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBillableRate;
        protected System.Windows.Forms.FolderBrowserDialog saveFolderBrowser;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
    }
}