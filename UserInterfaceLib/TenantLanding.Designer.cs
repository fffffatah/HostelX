namespace UserInterfaceLib
{
    partial class TenantLanding
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
            this.tenantTabControl = new System.Windows.Forms.TabControl();
            this.profileTabPage = new System.Windows.Forms.TabPage();
            this.foodTabPage = new System.Windows.Forms.TabPage();
            this.paymentTabPage = new System.Windows.Forms.TabPage();
            this.noticeTabPage = new System.Windows.Forms.TabPage();
            this.extraTabPage = new System.Windows.Forms.TabPage();
            this.tenantTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tenantTabControl
            // 
            this.tenantTabControl.Controls.Add(this.profileTabPage);
            this.tenantTabControl.Controls.Add(this.foodTabPage);
            this.tenantTabControl.Controls.Add(this.paymentTabPage);
            this.tenantTabControl.Controls.Add(this.noticeTabPage);
            this.tenantTabControl.Controls.Add(this.extraTabPage);
            this.tenantTabControl.Location = new System.Drawing.Point(-1, 2);
            this.tenantTabControl.Name = "tenantTabControl";
            this.tenantTabControl.SelectedIndex = 0;
            this.tenantTabControl.Size = new System.Drawing.Size(1247, 807);
            this.tenantTabControl.TabIndex = 0;
            // 
            // profileTabPage
            // 
            this.profileTabPage.Location = new System.Drawing.Point(4, 25);
            this.profileTabPage.Name = "profileTabPage";
            this.profileTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.profileTabPage.Size = new System.Drawing.Size(1239, 778);
            this.profileTabPage.TabIndex = 0;
            this.profileTabPage.Text = "Profile";
            this.profileTabPage.UseVisualStyleBackColor = true;
            // 
            // foodTabPage
            // 
            this.foodTabPage.Location = new System.Drawing.Point(4, 25);
            this.foodTabPage.Name = "foodTabPage";
            this.foodTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.foodTabPage.Size = new System.Drawing.Size(1239, 778);
            this.foodTabPage.TabIndex = 1;
            this.foodTabPage.Text = "Foods";
            this.foodTabPage.UseVisualStyleBackColor = true;
            // 
            // paymentTabPage
            // 
            this.paymentTabPage.Location = new System.Drawing.Point(4, 25);
            this.paymentTabPage.Name = "paymentTabPage";
            this.paymentTabPage.Size = new System.Drawing.Size(1239, 778);
            this.paymentTabPage.TabIndex = 2;
            this.paymentTabPage.Text = "Payments";
            this.paymentTabPage.UseVisualStyleBackColor = true;
            // 
            // noticeTabPage
            // 
            this.noticeTabPage.Location = new System.Drawing.Point(4, 25);
            this.noticeTabPage.Name = "noticeTabPage";
            this.noticeTabPage.Size = new System.Drawing.Size(1239, 778);
            this.noticeTabPage.TabIndex = 3;
            this.noticeTabPage.Text = "Notices";
            this.noticeTabPage.UseVisualStyleBackColor = true;
            // 
            // extraTabPage
            // 
            this.extraTabPage.Location = new System.Drawing.Point(4, 25);
            this.extraTabPage.Name = "extraTabPage";
            this.extraTabPage.Size = new System.Drawing.Size(1239, 778);
            this.extraTabPage.TabIndex = 4;
            this.extraTabPage.Text = "Extras";
            this.extraTabPage.UseVisualStyleBackColor = true;
            // 
            // TenantLanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 806);
            this.Controls.Add(this.tenantTabControl);
            this.Name = "TenantLanding";
            this.Text = "HostelX - Tenant";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TenantLanding_FormClosed);
            this.tenantTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tenantTabControl;
        private System.Windows.Forms.TabPage profileTabPage;
        private System.Windows.Forms.TabPage foodTabPage;
        private System.Windows.Forms.TabPage paymentTabPage;
        private System.Windows.Forms.TabPage noticeTabPage;
        private System.Windows.Forms.TabPage extraTabPage;
    }
}