
namespace TimeTracker.Forms
{
    partial class ManagerInput
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
            this.optionsPallete = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtFullName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.flowLayoutPanel11 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblEmail = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtEmail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.flowLayoutPanel12 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPhone = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtPhoneNumber = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnAddManager = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.flowLayoutPanel9.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel11.SuspendLayout();
            this.flowLayoutPanel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionsPallete
            // 
            this.optionsPallete.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel11);
            this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel12);
            this.flowLayoutPanel9.Controls.Add(this.btnAddManager);
            this.flowLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(434, 192);
            this.flowLayoutPanel9.TabIndex = 8;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblName);
            this.flowLayoutPanel2.Controls.Add(this.txtFullName);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(422, 42);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(3, 3);
            this.lblName.Name = "lblName";
            this.lblName.Palette = this.optionsPallete;
            this.lblName.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.lblName.Size = new System.Drawing.Size(68, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Values.Text = "Full Name: ";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(77, 3);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Palette = this.optionsPallete;
            this.txtFullName.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.txtFullName.Size = new System.Drawing.Size(342, 23);
            this.txtFullName.TabIndex = 1;
            // 
            // flowLayoutPanel11
            // 
            this.flowLayoutPanel11.Controls.Add(this.lblEmail);
            this.flowLayoutPanel11.Controls.Add(this.txtEmail);
            this.flowLayoutPanel11.Location = new System.Drawing.Point(3, 51);
            this.flowLayoutPanel11.Name = "flowLayoutPanel11";
            this.flowLayoutPanel11.Size = new System.Drawing.Size(422, 42);
            this.flowLayoutPanel11.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(3, 3);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Palette = this.optionsPallete;
            this.lblEmail.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.lblEmail.Size = new System.Drawing.Size(42, 20);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Values.Text = "Email: ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(51, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Palette = this.optionsPallete;
            this.txtEmail.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.txtEmail.Size = new System.Drawing.Size(368, 23);
            this.txtEmail.TabIndex = 1;
            // 
            // flowLayoutPanel12
            // 
            this.flowLayoutPanel12.Controls.Add(this.lblPhone);
            this.flowLayoutPanel12.Controls.Add(this.txtPhoneNumber);
            this.flowLayoutPanel12.Location = new System.Drawing.Point(3, 99);
            this.flowLayoutPanel12.Name = "flowLayoutPanel12";
            this.flowLayoutPanel12.Size = new System.Drawing.Size(422, 42);
            this.flowLayoutPanel12.TabIndex = 12;
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(3, 3);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Palette = this.optionsPallete;
            this.lblPhone.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.lblPhone.Size = new System.Drawing.Size(58, 20);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Values.Text = "Phone #: ";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(67, 3);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Palette = this.optionsPallete;
            this.txtPhoneNumber.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.txtPhoneNumber.Size = new System.Drawing.Size(125, 23);
            this.txtPhoneNumber.TabIndex = 1;
            // 
            // btnAddManager
            // 
            this.btnAddManager.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddManager.Location = new System.Drawing.Point(3, 147);
            this.btnAddManager.Name = "btnAddManager";
            this.btnAddManager.Palette = this.optionsPallete;
            this.btnAddManager.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnAddManager.Size = new System.Drawing.Size(422, 33);
            this.btnAddManager.TabIndex = 14;
            this.btnAddManager.Values.Text = "Save Manager Information";
            this.btnAddManager.Click += new System.EventHandler(this.btnAddManager_Click);
            // 
            // ManagerInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 192);
            this.Controls.Add(this.flowLayoutPanel9);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManagerInput";
            this.Palette = this.optionsPallete;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.Text = "Create Manager";
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel11.ResumeLayout(false);
            this.flowLayoutPanel11.PerformLayout();
            this.flowLayoutPanel12.ResumeLayout(false);
            this.flowLayoutPanel12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public ComponentFactory.Krypton.Toolkit.KryptonPalette optionsPallete;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtFullName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel11;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblEmail;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtEmail;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel12;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblPhone;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPhoneNumber;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddManager;
    }
}