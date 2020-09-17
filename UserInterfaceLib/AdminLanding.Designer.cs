namespace UserInterfaceLib
{
    partial class AdminLanding
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
            this.adminTabControl = new System.Windows.Forms.TabControl();
            this.profileTabPage = new System.Windows.Forms.TabPage();
            this.hostelTabPage = new System.Windows.Forms.TabPage();
            this.tenantTabPage = new System.Windows.Forms.TabPage();
            this.foodTabPage = new System.Windows.Forms.TabPage();
            this.paymentTabPage = new System.Windows.Forms.TabPage();
            this.noticeTabPage = new System.Windows.Forms.TabPage();
            this.extraTabPage = new System.Windows.Forms.TabPage();
            this.adminProfileGroupBox = new System.Windows.Forms.GroupBox();
            this.adminTabControl.SuspendLayout();
            this.profileTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminTabControl
            // 
            this.adminTabControl.Controls.Add(this.profileTabPage);
            this.adminTabControl.Controls.Add(this.hostelTabPage);
            this.adminTabControl.Controls.Add(this.tenantTabPage);
            this.adminTabControl.Controls.Add(this.foodTabPage);
            this.adminTabControl.Controls.Add(this.paymentTabPage);
            this.adminTabControl.Controls.Add(this.noticeTabPage);
            this.adminTabControl.Controls.Add(this.extraTabPage);
            this.adminTabControl.Location = new System.Drawing.Point(1, 2);
            this.adminTabControl.Name = "adminTabControl";
            this.adminTabControl.SelectedIndex = 0;
            this.adminTabControl.Size = new System.Drawing.Size(1243, 805);
            this.adminTabControl.TabIndex = 0;
            // 
            // profileTabPage
            // 
            this.profileTabPage.Controls.Add(this.adminProfileGroupBox);
            this.profileTabPage.Location = new System.Drawing.Point(4, 25);
            this.profileTabPage.Name = "profileTabPage";
            this.profileTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.profileTabPage.Size = new System.Drawing.Size(1235, 776);
            this.profileTabPage.TabIndex = 0;
            this.profileTabPage.Text = "Profile";
            this.profileTabPage.UseVisualStyleBackColor = true;
            // 
            // hostelTabPage
            // 
            this.hostelTabPage.Location = new System.Drawing.Point(4, 25);
            this.hostelTabPage.Name = "hostelTabPage";
            this.hostelTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.hostelTabPage.Size = new System.Drawing.Size(1235, 776);
            this.hostelTabPage.TabIndex = 1;
            this.hostelTabPage.Text = "Hostels";
            this.hostelTabPage.UseVisualStyleBackColor = true;
            // 
            // tenantTabPage
            // 
            this.tenantTabPage.Location = new System.Drawing.Point(4, 25);
            this.tenantTabPage.Name = "tenantTabPage";
            this.tenantTabPage.Size = new System.Drawing.Size(1235, 776);
            this.tenantTabPage.TabIndex = 2;
            this.tenantTabPage.Text = "Tenants";
            this.tenantTabPage.UseVisualStyleBackColor = true;
            // 
            // foodTabPage
            // 
            this.foodTabPage.Location = new System.Drawing.Point(4, 25);
            this.foodTabPage.Name = "foodTabPage";
            this.foodTabPage.Size = new System.Drawing.Size(1235, 776);
            this.foodTabPage.TabIndex = 3;
            this.foodTabPage.Text = "Foods";
            this.foodTabPage.UseVisualStyleBackColor = true;
            // 
            // paymentTabPage
            // 
            this.paymentTabPage.Location = new System.Drawing.Point(4, 25);
            this.paymentTabPage.Name = "paymentTabPage";
            this.paymentTabPage.Size = new System.Drawing.Size(1235, 776);
            this.paymentTabPage.TabIndex = 4;
            this.paymentTabPage.Text = "Payments";
            this.paymentTabPage.UseVisualStyleBackColor = true;
            // 
            // noticeTabPage
            // 
            this.noticeTabPage.Location = new System.Drawing.Point(4, 25);
            this.noticeTabPage.Name = "noticeTabPage";
            this.noticeTabPage.Size = new System.Drawing.Size(1235, 776);
            this.noticeTabPage.TabIndex = 5;
            this.noticeTabPage.Text = "Notices";
            this.noticeTabPage.UseVisualStyleBackColor = true;
            // 
            // extraTabPage
            // 
            this.extraTabPage.Location = new System.Drawing.Point(4, 25);
            this.extraTabPage.Name = "extraTabPage";
            this.extraTabPage.Size = new System.Drawing.Size(1235, 776);
            this.extraTabPage.TabIndex = 6;
            this.extraTabPage.Text = "Extras";
            this.extraTabPage.UseVisualStyleBackColor = true;
            // 
            // adminProfileGroupBox
            // 
            this.adminProfileGroupBox.Location = new System.Drawing.Point(7, 6);
            this.adminProfileGroupBox.Name = "adminProfileGroupBox";
            this.adminProfileGroupBox.Size = new System.Drawing.Size(699, 761);
            this.adminProfileGroupBox.TabIndex = 0;
            this.adminProfileGroupBox.TabStop = false;
            this.adminProfileGroupBox.Text = "My Profile";
            // 
            // AdminLanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 806);
            this.Controls.Add(this.adminTabControl);
            this.Name = "AdminLanding";
            this.Text = "HostelX - Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminLanding_FormClosed);
            this.adminTabControl.ResumeLayout(false);
            this.profileTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl adminTabControl;
        private System.Windows.Forms.TabPage profileTabPage;
        private System.Windows.Forms.TabPage hostelTabPage;
        private System.Windows.Forms.TabPage tenantTabPage;
        private System.Windows.Forms.TabPage foodTabPage;
        private System.Windows.Forms.TabPage paymentTabPage;
        private System.Windows.Forms.TabPage noticeTabPage;
        private System.Windows.Forms.TabPage extraTabPage;
        private System.Windows.Forms.GroupBox adminProfileGroupBox;
    }
}