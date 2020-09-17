namespace UserInterfaceLib
{
    partial class Login
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
            this.otpGroupBox = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.otpTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.signupLnameTextBox = new System.Windows.Forms.TextBox();
            this.adminLoginGroupBox = new System.Windows.Forms.GroupBox();
            this.adminLoginForgotPassNewPassLabel = new System.Windows.Forms.Label();
            this.adminLoginForgotPassOtpLabel = new System.Windows.Forms.Label();
            this.adminLoginForgotPassOtpTextBox = new System.Windows.Forms.TextBox();
            this.adminLoginForgotPassChangeButton = new System.Windows.Forms.Button();
            this.adminLoginOtpSubmitButton = new System.Windows.Forms.Button();
            this.adminForgotPassGoButton = new System.Windows.Forms.Button();
            this.adminCancelForgotPassButton = new System.Windows.Forms.Button();
            this.adminForgotPassButton = new System.Windows.Forms.Button();
            this.adminLoginButton = new System.Windows.Forms.Button();
            this.adminLoginPhoneTextBox = new System.Windows.Forms.TextBox();
            this.adminLoginPassTextBox = new System.Windows.Forms.TextBox();
            this.adminLoginPassLabel = new System.Windows.Forms.Label();
            this.adminLoginPhoneLabel = new System.Windows.Forms.Label();
            this.signupGroupBox = new System.Windows.Forms.GroupBox();
            this.signupImageGroupBox = new System.Windows.Forms.GroupBox();
            this.signupClearPicButton = new System.Windows.Forms.Button();
            this.fpicPictureBox = new System.Windows.Forms.PictureBox();
            this.signupEmailLabel = new System.Windows.Forms.Label();
            this.signupEmailTextBox = new System.Windows.Forms.TextBox();
            this.signupCpassTextBox = new System.Windows.Forms.TextBox();
            this.signupPassTextBox = new System.Windows.Forms.TextBox();
            this.signupPhoneTextBox = new System.Windows.Forms.TextBox();
            this.signupFnameTextBox = new System.Windows.Forms.TextBox();
            this.signupButton = new System.Windows.Forms.Button();
            this.agreementLinkLabel = new System.Windows.Forms.LinkLabel();
            this.agreementCheckbox = new System.Windows.Forms.CheckBox();
            this.cpassLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.lnameLabel = new System.Windows.Forms.Label();
            this.fnameLabel = new System.Windows.Forms.Label();
            this.tenantloginGroupBox = new System.Windows.Forms.GroupBox();
            this.tenantForgotPassButton = new System.Windows.Forms.Button();
            this.tenantLoginButton = new System.Windows.Forms.Button();
            this.tenantLoginEmailTextBox = new System.Windows.Forms.TextBox();
            this.tenantLoginPassTextBox = new System.Windows.Forms.TextBox();
            this.tenantLoginPassLabel = new System.Windows.Forms.Label();
            this.tenantLoginEmailLabel = new System.Windows.Forms.Label();
            this.otpGroupBox.SuspendLayout();
            this.adminLoginGroupBox.SuspendLayout();
            this.signupGroupBox.SuspendLayout();
            this.signupImageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpicPictureBox)).BeginInit();
            this.tenantloginGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // otpGroupBox
            // 
            this.otpGroupBox.Controls.Add(this.cancelButton);
            this.otpGroupBox.Controls.Add(this.submitButton);
            this.otpGroupBox.Controls.Add(this.otpTextBox);
            this.otpGroupBox.Controls.Add(this.label1);
            this.otpGroupBox.Location = new System.Drawing.Point(12, 646);
            this.otpGroupBox.Name = "otpGroupBox";
            this.otpGroupBox.Size = new System.Drawing.Size(433, 122);
            this.otpGroupBox.TabIndex = 20;
            this.otpGroupBox.TabStop = false;
            this.otpGroupBox.Text = "Verification";
            this.otpGroupBox.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.DeepPink;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(320, 62);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 32);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.SpringGreen;
            this.submitButton.Enabled = false;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Location = new System.Drawing.Point(216, 62);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 32);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // otpTextBox
            // 
            this.otpTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otpTextBox.Location = new System.Drawing.Point(71, 65);
            this.otpTextBox.MaxLength = 6;
            this.otpTextBox.Name = "otpTextBox";
            this.otpTextBox.Size = new System.Drawing.Size(124, 26);
            this.otpTextBox.TabIndex = 1;
            this.otpTextBox.TextChanged += new System.EventHandler(this.otpTextBox_TextChanged);
            this.otpTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.otpTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Enter the OTP Sent to Your Phone Number";
            // 
            // signupLnameTextBox
            // 
            this.signupLnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signupLnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupLnameTextBox.Location = new System.Drawing.Point(153, 209);
            this.signupLnameTextBox.Name = "signupLnameTextBox";
            this.signupLnameTextBox.Size = new System.Drawing.Size(235, 23);
            this.signupLnameTextBox.TabIndex = 19;
            this.signupLnameTextBox.TextChanged += new System.EventHandler(this.signupLnameTextBox_TextChanged);
            // 
            // adminLoginGroupBox
            // 
            this.adminLoginGroupBox.Controls.Add(this.adminLoginForgotPassNewPassLabel);
            this.adminLoginGroupBox.Controls.Add(this.adminLoginForgotPassOtpLabel);
            this.adminLoginGroupBox.Controls.Add(this.adminLoginForgotPassOtpTextBox);
            this.adminLoginGroupBox.Controls.Add(this.adminLoginForgotPassChangeButton);
            this.adminLoginGroupBox.Controls.Add(this.adminLoginOtpSubmitButton);
            this.adminLoginGroupBox.Controls.Add(this.adminForgotPassGoButton);
            this.adminLoginGroupBox.Controls.Add(this.adminCancelForgotPassButton);
            this.adminLoginGroupBox.Controls.Add(this.adminForgotPassButton);
            this.adminLoginGroupBox.Controls.Add(this.adminLoginButton);
            this.adminLoginGroupBox.Controls.Add(this.adminLoginPhoneTextBox);
            this.adminLoginGroupBox.Controls.Add(this.adminLoginPassTextBox);
            this.adminLoginGroupBox.Controls.Add(this.adminLoginPassLabel);
            this.adminLoginGroupBox.Controls.Add(this.adminLoginPhoneLabel);
            this.adminLoginGroupBox.Location = new System.Drawing.Point(521, 12);
            this.adminLoginGroupBox.Name = "adminLoginGroupBox";
            this.adminLoginGroupBox.Size = new System.Drawing.Size(425, 296);
            this.adminLoginGroupBox.TabIndex = 18;
            this.adminLoginGroupBox.TabStop = false;
            this.adminLoginGroupBox.Text = "Admin Login";
            // 
            // adminLoginForgotPassNewPassLabel
            // 
            this.adminLoginForgotPassNewPassLabel.AutoSize = true;
            this.adminLoginForgotPassNewPassLabel.Location = new System.Drawing.Point(32, 84);
            this.adminLoginForgotPassNewPassLabel.Name = "adminLoginForgotPassNewPassLabel";
            this.adminLoginForgotPassNewPassLabel.Size = new System.Drawing.Size(100, 17);
            this.adminLoginForgotPassNewPassLabel.TabIndex = 27;
            this.adminLoginForgotPassNewPassLabel.Text = "New Password";
            this.adminLoginForgotPassNewPassLabel.Visible = false;
            // 
            // adminLoginForgotPassOtpLabel
            // 
            this.adminLoginForgotPassOtpLabel.AutoSize = true;
            this.adminLoginForgotPassOtpLabel.Location = new System.Drawing.Point(96, 136);
            this.adminLoginForgotPassOtpLabel.Name = "adminLoginForgotPassOtpLabel";
            this.adminLoginForgotPassOtpLabel.Size = new System.Drawing.Size(37, 17);
            this.adminLoginForgotPassOtpLabel.TabIndex = 26;
            this.adminLoginForgotPassOtpLabel.Text = "OTP";
            this.adminLoginForgotPassOtpLabel.Visible = false;
            // 
            // adminLoginForgotPassOtpTextBox
            // 
            this.adminLoginForgotPassOtpTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLoginForgotPassOtpTextBox.Location = new System.Drawing.Point(156, 130);
            this.adminLoginForgotPassOtpTextBox.MaxLength = 6;
            this.adminLoginForgotPassOtpTextBox.Name = "adminLoginForgotPassOtpTextBox";
            this.adminLoginForgotPassOtpTextBox.Size = new System.Drawing.Size(124, 26);
            this.adminLoginForgotPassOtpTextBox.TabIndex = 25;
            this.adminLoginForgotPassOtpTextBox.Visible = false;
            this.adminLoginForgotPassOtpTextBox.TextChanged += new System.EventHandler(this.adminLoginForgotPassOtpTextBox_TextChanged);
            this.adminLoginForgotPassOtpTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.adminLoginForgotPassOtpTextBox_KeyPress);
            // 
            // adminLoginForgotPassChangeButton
            // 
            this.adminLoginForgotPassChangeButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.adminLoginForgotPassChangeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminLoginForgotPassChangeButton.Enabled = false;
            this.adminLoginForgotPassChangeButton.FlatAppearance.BorderSize = 0;
            this.adminLoginForgotPassChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminLoginForgotPassChangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLoginForgotPassChangeButton.ForeColor = System.Drawing.Color.White;
            this.adminLoginForgotPassChangeButton.Location = new System.Drawing.Point(220, 234);
            this.adminLoginForgotPassChangeButton.Name = "adminLoginForgotPassChangeButton";
            this.adminLoginForgotPassChangeButton.Size = new System.Drawing.Size(114, 41);
            this.adminLoginForgotPassChangeButton.TabIndex = 24;
            this.adminLoginForgotPassChangeButton.Text = "Change";
            this.adminLoginForgotPassChangeButton.UseVisualStyleBackColor = false;
            this.adminLoginForgotPassChangeButton.Visible = false;
            this.adminLoginForgotPassChangeButton.Click += new System.EventHandler(this.adminLoginForgotPassChangeButton_Click);
            // 
            // adminLoginOtpSubmitButton
            // 
            this.adminLoginOtpSubmitButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.adminLoginOtpSubmitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminLoginOtpSubmitButton.FlatAppearance.BorderSize = 0;
            this.adminLoginOtpSubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminLoginOtpSubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLoginOtpSubmitButton.ForeColor = System.Drawing.Color.White;
            this.adminLoginOtpSubmitButton.Location = new System.Drawing.Point(220, 234);
            this.adminLoginOtpSubmitButton.Name = "adminLoginOtpSubmitButton";
            this.adminLoginOtpSubmitButton.Size = new System.Drawing.Size(114, 41);
            this.adminLoginOtpSubmitButton.TabIndex = 23;
            this.adminLoginOtpSubmitButton.Text = "Submit";
            this.adminLoginOtpSubmitButton.UseVisualStyleBackColor = false;
            this.adminLoginOtpSubmitButton.Visible = false;
            this.adminLoginOtpSubmitButton.Click += new System.EventHandler(this.adminLoginOtpSubmitButton_Click);
            // 
            // adminForgotPassGoButton
            // 
            this.adminForgotPassGoButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.adminForgotPassGoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminForgotPassGoButton.Enabled = false;
            this.adminForgotPassGoButton.FlatAppearance.BorderSize = 0;
            this.adminForgotPassGoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminForgotPassGoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminForgotPassGoButton.ForeColor = System.Drawing.Color.White;
            this.adminForgotPassGoButton.Location = new System.Drawing.Point(220, 234);
            this.adminForgotPassGoButton.Name = "adminForgotPassGoButton";
            this.adminForgotPassGoButton.Size = new System.Drawing.Size(114, 41);
            this.adminForgotPassGoButton.TabIndex = 22;
            this.adminForgotPassGoButton.Text = "Go";
            this.adminForgotPassGoButton.UseVisualStyleBackColor = false;
            this.adminForgotPassGoButton.Visible = false;
            this.adminForgotPassGoButton.Click += new System.EventHandler(this.adminForgotPassGoButton_Click);
            // 
            // adminCancelForgotPassButton
            // 
            this.adminCancelForgotPassButton.BackColor = System.Drawing.Color.DeepPink;
            this.adminCancelForgotPassButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminCancelForgotPassButton.FlatAppearance.BorderSize = 0;
            this.adminCancelForgotPassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminCancelForgotPassButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminCancelForgotPassButton.ForeColor = System.Drawing.Color.White;
            this.adminCancelForgotPassButton.Location = new System.Drawing.Point(83, 234);
            this.adminCancelForgotPassButton.Name = "adminCancelForgotPassButton";
            this.adminCancelForgotPassButton.Size = new System.Drawing.Size(114, 41);
            this.adminCancelForgotPassButton.TabIndex = 21;
            this.adminCancelForgotPassButton.Text = "Cancel";
            this.adminCancelForgotPassButton.UseVisualStyleBackColor = false;
            this.adminCancelForgotPassButton.Visible = false;
            this.adminCancelForgotPassButton.Click += new System.EventHandler(this.adminCancelForgotPassButton_Click);
            // 
            // adminForgotPassButton
            // 
            this.adminForgotPassButton.BackColor = System.Drawing.Color.Transparent;
            this.adminForgotPassButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.adminForgotPassButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminForgotPassButton.FlatAppearance.BorderSize = 0;
            this.adminForgotPassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminForgotPassButton.Location = new System.Drawing.Point(145, 194);
            this.adminForgotPassButton.Name = "adminForgotPassButton";
            this.adminForgotPassButton.Size = new System.Drawing.Size(134, 34);
            this.adminForgotPassButton.TabIndex = 20;
            this.adminForgotPassButton.Text = "Forgot Password?";
            this.adminForgotPassButton.UseVisualStyleBackColor = false;
            this.adminForgotPassButton.Click += new System.EventHandler(this.adminForgotPassButton_Click);
            // 
            // adminLoginButton
            // 
            this.adminLoginButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.adminLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminLoginButton.Enabled = false;
            this.adminLoginButton.FlatAppearance.BorderSize = 0;
            this.adminLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLoginButton.ForeColor = System.Drawing.Color.White;
            this.adminLoginButton.Location = new System.Drawing.Point(154, 234);
            this.adminLoginButton.Name = "adminLoginButton";
            this.adminLoginButton.Size = new System.Drawing.Size(114, 41);
            this.adminLoginButton.TabIndex = 19;
            this.adminLoginButton.Text = "Sign In";
            this.adminLoginButton.UseVisualStyleBackColor = false;
            this.adminLoginButton.Click += new System.EventHandler(this.adminLoginButton_Click);
            // 
            // adminLoginPhoneTextBox
            // 
            this.adminLoginPhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminLoginPhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLoginPhoneTextBox.Location = new System.Drawing.Point(156, 34);
            this.adminLoginPhoneTextBox.MaxLength = 11;
            this.adminLoginPhoneTextBox.Name = "adminLoginPhoneTextBox";
            this.adminLoginPhoneTextBox.Size = new System.Drawing.Size(235, 23);
            this.adminLoginPhoneTextBox.TabIndex = 18;
            this.adminLoginPhoneTextBox.TextChanged += new System.EventHandler(this.adminLoginPhoneTextBox_TextChanged);
            this.adminLoginPhoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.adminLoginPhoneTextBox_KeyPress);
            // 
            // adminLoginPassTextBox
            // 
            this.adminLoginPassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminLoginPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLoginPassTextBox.Location = new System.Drawing.Point(156, 82);
            this.adminLoginPassTextBox.Name = "adminLoginPassTextBox";
            this.adminLoginPassTextBox.PasswordChar = '*';
            this.adminLoginPassTextBox.Size = new System.Drawing.Size(235, 23);
            this.adminLoginPassTextBox.TabIndex = 5;
            this.adminLoginPassTextBox.TextChanged += new System.EventHandler(this.adminLoginPassTextBox_TextChanged);
            // 
            // adminLoginPassLabel
            // 
            this.adminLoginPassLabel.AutoSize = true;
            this.adminLoginPassLabel.Location = new System.Drawing.Point(66, 84);
            this.adminLoginPassLabel.Name = "adminLoginPassLabel";
            this.adminLoginPassLabel.Size = new System.Drawing.Size(69, 17);
            this.adminLoginPassLabel.TabIndex = 4;
            this.adminLoginPassLabel.Text = "Password";
            // 
            // adminLoginPhoneLabel
            // 
            this.adminLoginPhoneLabel.AutoSize = true;
            this.adminLoginPhoneLabel.Location = new System.Drawing.Point(32, 36);
            this.adminLoginPhoneLabel.Name = "adminLoginPhoneLabel";
            this.adminLoginPhoneLabel.Size = new System.Drawing.Size(103, 17);
            this.adminLoginPhoneLabel.TabIndex = 3;
            this.adminLoginPhoneLabel.Text = "Phone Number";
            // 
            // signupGroupBox
            // 
            this.signupGroupBox.Controls.Add(this.signupImageGroupBox);
            this.signupGroupBox.Controls.Add(this.signupEmailLabel);
            this.signupGroupBox.Controls.Add(this.signupEmailTextBox);
            this.signupGroupBox.Controls.Add(this.signupCpassTextBox);
            this.signupGroupBox.Controls.Add(this.signupLnameTextBox);
            this.signupGroupBox.Controls.Add(this.signupPassTextBox);
            this.signupGroupBox.Controls.Add(this.signupPhoneTextBox);
            this.signupGroupBox.Controls.Add(this.signupFnameTextBox);
            this.signupGroupBox.Controls.Add(this.signupButton);
            this.signupGroupBox.Controls.Add(this.agreementLinkLabel);
            this.signupGroupBox.Controls.Add(this.agreementCheckbox);
            this.signupGroupBox.Controls.Add(this.cpassLabel);
            this.signupGroupBox.Controls.Add(this.passLabel);
            this.signupGroupBox.Controls.Add(this.phoneLabel);
            this.signupGroupBox.Controls.Add(this.lnameLabel);
            this.signupGroupBox.Controls.Add(this.fnameLabel);
            this.signupGroupBox.Location = new System.Drawing.Point(12, 12);
            this.signupGroupBox.Name = "signupGroupBox";
            this.signupGroupBox.Size = new System.Drawing.Size(433, 628);
            this.signupGroupBox.TabIndex = 17;
            this.signupGroupBox.TabStop = false;
            this.signupGroupBox.Text = "Admin Signup";
            // 
            // signupImageGroupBox
            // 
            this.signupImageGroupBox.Controls.Add(this.signupClearPicButton);
            this.signupImageGroupBox.Controls.Add(this.fpicPictureBox);
            this.signupImageGroupBox.Location = new System.Drawing.Point(37, 34);
            this.signupImageGroupBox.Name = "signupImageGroupBox";
            this.signupImageGroupBox.Size = new System.Drawing.Size(359, 100);
            this.signupImageGroupBox.TabIndex = 22;
            this.signupImageGroupBox.TabStop = false;
            this.signupImageGroupBox.Text = "Profile Image";
            // 
            // signupClearPicButton
            // 
            this.signupClearPicButton.Location = new System.Drawing.Point(241, 37);
            this.signupClearPicButton.Name = "signupClearPicButton";
            this.signupClearPicButton.Size = new System.Drawing.Size(110, 39);
            this.signupClearPicButton.TabIndex = 3;
            this.signupClearPicButton.Text = "Clear";
            this.signupClearPicButton.UseVisualStyleBackColor = true;
            this.signupClearPicButton.Click += new System.EventHandler(this.signupClearPicButton_Click);
            // 
            // fpicPictureBox
            // 
            this.fpicPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fpicPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fpicPictureBox.Image = global::UserInterfaceLib.Properties.Resources.add;
            this.fpicPictureBox.Location = new System.Drawing.Point(6, 21);
            this.fpicPictureBox.Name = "fpicPictureBox";
            this.fpicPictureBox.Size = new System.Drawing.Size(100, 73);
            this.fpicPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fpicPictureBox.TabIndex = 0;
            this.fpicPictureBox.TabStop = false;
            this.fpicPictureBox.Click += new System.EventHandler(this.fpicPictureBox_Click);
            // 
            // signupEmailLabel
            // 
            this.signupEmailLabel.AutoSize = true;
            this.signupEmailLabel.Location = new System.Drawing.Point(95, 302);
            this.signupEmailLabel.Name = "signupEmailLabel";
            this.signupEmailLabel.Size = new System.Drawing.Size(42, 17);
            this.signupEmailLabel.TabIndex = 21;
            this.signupEmailLabel.Text = "Email";
            // 
            // signupEmailTextBox
            // 
            this.signupEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signupEmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupEmailTextBox.Location = new System.Drawing.Point(153, 300);
            this.signupEmailTextBox.Name = "signupEmailTextBox";
            this.signupEmailTextBox.Size = new System.Drawing.Size(235, 23);
            this.signupEmailTextBox.TabIndex = 20;
            this.signupEmailTextBox.TextChanged += new System.EventHandler(this.signupEmailTextBox_TextChanged);
            // 
            // signupCpassTextBox
            // 
            this.signupCpassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signupCpassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupCpassTextBox.Location = new System.Drawing.Point(153, 400);
            this.signupCpassTextBox.Name = "signupCpassTextBox";
            this.signupCpassTextBox.PasswordChar = '*';
            this.signupCpassTextBox.Size = new System.Drawing.Size(235, 23);
            this.signupCpassTextBox.TabIndex = 17;
            this.signupCpassTextBox.TextChanged += new System.EventHandler(this.signupCpassTextBox_TextChanged);
            // 
            // signupPassTextBox
            // 
            this.signupPassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signupPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupPassTextBox.Location = new System.Drawing.Point(153, 351);
            this.signupPassTextBox.Name = "signupPassTextBox";
            this.signupPassTextBox.PasswordChar = '*';
            this.signupPassTextBox.Size = new System.Drawing.Size(235, 23);
            this.signupPassTextBox.TabIndex = 16;
            this.signupPassTextBox.TextChanged += new System.EventHandler(this.signupPassTextBox_TextChanged);
            // 
            // signupPhoneTextBox
            // 
            this.signupPhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signupPhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupPhoneTextBox.Location = new System.Drawing.Point(153, 256);
            this.signupPhoneTextBox.MaxLength = 11;
            this.signupPhoneTextBox.Name = "signupPhoneTextBox";
            this.signupPhoneTextBox.Size = new System.Drawing.Size(235, 23);
            this.signupPhoneTextBox.TabIndex = 15;
            this.signupPhoneTextBox.TextChanged += new System.EventHandler(this.signupPhoneTextBox_TextChanged);
            this.signupPhoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.signupPhoneTextBox_KeyPress);
            // 
            // signupFnameTextBox
            // 
            this.signupFnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signupFnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupFnameTextBox.Location = new System.Drawing.Point(153, 161);
            this.signupFnameTextBox.Name = "signupFnameTextBox";
            this.signupFnameTextBox.Size = new System.Drawing.Size(235, 23);
            this.signupFnameTextBox.TabIndex = 14;
            this.signupFnameTextBox.TextChanged += new System.EventHandler(this.signupFnameTextBox_TextChanged);
            // 
            // signupButton
            // 
            this.signupButton.BackColor = System.Drawing.Color.SpringGreen;
            this.signupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupButton.Enabled = false;
            this.signupButton.FlatAppearance.BorderSize = 0;
            this.signupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupButton.ForeColor = System.Drawing.Color.White;
            this.signupButton.Location = new System.Drawing.Point(138, 565);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(131, 41);
            this.signupButton.TabIndex = 13;
            this.signupButton.Text = "Sign Up";
            this.signupButton.UseVisualStyleBackColor = false;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // agreementLinkLabel
            // 
            this.agreementLinkLabel.AutoSize = true;
            this.agreementLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.agreementLinkLabel.LinkColor = System.Drawing.Color.Magenta;
            this.agreementLinkLabel.Location = new System.Drawing.Point(108, 531);
            this.agreementLinkLabel.Name = "agreementLinkLabel";
            this.agreementLinkLabel.Size = new System.Drawing.Size(234, 17);
            this.agreementLinkLabel.TabIndex = 12;
            this.agreementLinkLabel.TabStop = true;
            this.agreementLinkLabel.Text = "I agree to the Terms and Conditions";
            this.agreementLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.agreementLinkLabel_LinkClicked);
            // 
            // agreementCheckbox
            // 
            this.agreementCheckbox.AutoSize = true;
            this.agreementCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.agreementCheckbox.Enabled = false;
            this.agreementCheckbox.Location = new System.Drawing.Point(84, 531);
            this.agreementCheckbox.Name = "agreementCheckbox";
            this.agreementCheckbox.Size = new System.Drawing.Size(18, 17);
            this.agreementCheckbox.TabIndex = 11;
            this.agreementCheckbox.UseVisualStyleBackColor = false;
            this.agreementCheckbox.CheckedChanged += new System.EventHandler(this.agreementCheckbox_CheckedChanged);
            // 
            // cpassLabel
            // 
            this.cpassLabel.AutoSize = true;
            this.cpassLabel.Location = new System.Drawing.Point(16, 402);
            this.cpassLabel.Name = "cpassLabel";
            this.cpassLabel.Size = new System.Drawing.Size(121, 17);
            this.cpassLabel.TabIndex = 4;
            this.cpassLabel.Text = "Confirm Password";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(68, 353);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(69, 17);
            this.passLabel.TabIndex = 3;
            this.passLabel.Text = "Password";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(34, 258);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(103, 17);
            this.phoneLabel.TabIndex = 2;
            this.phoneLabel.Text = "Phone Number";
            // 
            // lnameLabel
            // 
            this.lnameLabel.AutoSize = true;
            this.lnameLabel.Location = new System.Drawing.Point(61, 211);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(76, 17);
            this.lnameLabel.TabIndex = 1;
            this.lnameLabel.Text = "Last Name";
            // 
            // fnameLabel
            // 
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.Location = new System.Drawing.Point(61, 163);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(76, 17);
            this.fnameLabel.TabIndex = 0;
            this.fnameLabel.Text = "First Name";
            // 
            // tenantloginGroupBox
            // 
            this.tenantloginGroupBox.Controls.Add(this.tenantForgotPassButton);
            this.tenantloginGroupBox.Controls.Add(this.tenantLoginButton);
            this.tenantloginGroupBox.Controls.Add(this.tenantLoginEmailTextBox);
            this.tenantloginGroupBox.Controls.Add(this.tenantLoginPassTextBox);
            this.tenantloginGroupBox.Controls.Add(this.tenantLoginPassLabel);
            this.tenantloginGroupBox.Controls.Add(this.tenantLoginEmailLabel);
            this.tenantloginGroupBox.Location = new System.Drawing.Point(519, 314);
            this.tenantloginGroupBox.Name = "tenantloginGroupBox";
            this.tenantloginGroupBox.Size = new System.Drawing.Size(425, 326);
            this.tenantloginGroupBox.TabIndex = 20;
            this.tenantloginGroupBox.TabStop = false;
            this.tenantloginGroupBox.Text = "Tenant Login";
            // 
            // tenantForgotPassButton
            // 
            this.tenantForgotPassButton.BackColor = System.Drawing.Color.Transparent;
            this.tenantForgotPassButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tenantForgotPassButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tenantForgotPassButton.FlatAppearance.BorderSize = 0;
            this.tenantForgotPassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tenantForgotPassButton.Location = new System.Drawing.Point(147, 141);
            this.tenantForgotPassButton.Name = "tenantForgotPassButton";
            this.tenantForgotPassButton.Size = new System.Drawing.Size(134, 34);
            this.tenantForgotPassButton.TabIndex = 21;
            this.tenantForgotPassButton.Text = "Forgot Password?";
            this.tenantForgotPassButton.UseVisualStyleBackColor = false;
            // 
            // tenantLoginButton
            // 
            this.tenantLoginButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.tenantLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tenantLoginButton.Enabled = false;
            this.tenantLoginButton.FlatAppearance.BorderSize = 0;
            this.tenantLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tenantLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenantLoginButton.ForeColor = System.Drawing.Color.White;
            this.tenantLoginButton.Location = new System.Drawing.Point(156, 211);
            this.tenantLoginButton.Name = "tenantLoginButton";
            this.tenantLoginButton.Size = new System.Drawing.Size(114, 41);
            this.tenantLoginButton.TabIndex = 19;
            this.tenantLoginButton.Text = "Sign In";
            this.tenantLoginButton.UseVisualStyleBackColor = false;
            this.tenantLoginButton.Click += new System.EventHandler(this.tenantLoginButton_Click);
            // 
            // tenantLoginEmailTextBox
            // 
            this.tenantLoginEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tenantLoginEmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenantLoginEmailTextBox.Location = new System.Drawing.Point(156, 34);
            this.tenantLoginEmailTextBox.MaxLength = 500;
            this.tenantLoginEmailTextBox.Name = "tenantLoginEmailTextBox";
            this.tenantLoginEmailTextBox.Size = new System.Drawing.Size(235, 23);
            this.tenantLoginEmailTextBox.TabIndex = 18;
            this.tenantLoginEmailTextBox.TextChanged += new System.EventHandler(this.tenantLoginEmailTextBox_TextChanged);
            // 
            // tenantLoginPassTextBox
            // 
            this.tenantLoginPassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tenantLoginPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenantLoginPassTextBox.Location = new System.Drawing.Point(156, 82);
            this.tenantLoginPassTextBox.Name = "tenantLoginPassTextBox";
            this.tenantLoginPassTextBox.PasswordChar = '*';
            this.tenantLoginPassTextBox.Size = new System.Drawing.Size(235, 23);
            this.tenantLoginPassTextBox.TabIndex = 5;
            this.tenantLoginPassTextBox.TextChanged += new System.EventHandler(this.tenantLoginPassTextBox_TextChanged);
            // 
            // tenantLoginPassLabel
            // 
            this.tenantLoginPassLabel.AutoSize = true;
            this.tenantLoginPassLabel.Location = new System.Drawing.Point(66, 84);
            this.tenantLoginPassLabel.Name = "tenantLoginPassLabel";
            this.tenantLoginPassLabel.Size = new System.Drawing.Size(69, 17);
            this.tenantLoginPassLabel.TabIndex = 4;
            this.tenantLoginPassLabel.Text = "Password";
            // 
            // tenantLoginEmailLabel
            // 
            this.tenantLoginEmailLabel.AutoSize = true;
            this.tenantLoginEmailLabel.Location = new System.Drawing.Point(93, 36);
            this.tenantLoginEmailLabel.Name = "tenantLoginEmailLabel";
            this.tenantLoginEmailLabel.Size = new System.Drawing.Size(42, 17);
            this.tenantLoginEmailLabel.TabIndex = 3;
            this.tenantLoginEmailLabel.Text = "Email";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 780);
            this.Controls.Add(this.tenantloginGroupBox);
            this.Controls.Add(this.otpGroupBox);
            this.Controls.Add(this.adminLoginGroupBox);
            this.Controls.Add(this.signupGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HostelX - Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.otpGroupBox.ResumeLayout(false);
            this.otpGroupBox.PerformLayout();
            this.adminLoginGroupBox.ResumeLayout(false);
            this.adminLoginGroupBox.PerformLayout();
            this.signupGroupBox.ResumeLayout(false);
            this.signupGroupBox.PerformLayout();
            this.signupImageGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fpicPictureBox)).EndInit();
            this.tenantloginGroupBox.ResumeLayout(false);
            this.tenantloginGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox otpGroupBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox otpTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox signupLnameTextBox;
        private System.Windows.Forms.GroupBox adminLoginGroupBox;
        private System.Windows.Forms.Button adminLoginButton;
        private System.Windows.Forms.TextBox adminLoginPhoneTextBox;
        private System.Windows.Forms.TextBox adminLoginPassTextBox;
        private System.Windows.Forms.Label adminLoginPassLabel;
        private System.Windows.Forms.Label adminLoginPhoneLabel;
        private System.Windows.Forms.GroupBox signupGroupBox;
        private System.Windows.Forms.TextBox signupCpassTextBox;
        private System.Windows.Forms.TextBox signupPassTextBox;
        private System.Windows.Forms.TextBox signupPhoneTextBox;
        private System.Windows.Forms.TextBox signupFnameTextBox;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.LinkLabel agreementLinkLabel;
        private System.Windows.Forms.CheckBox agreementCheckbox;
        private System.Windows.Forms.Label cpassLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label lnameLabel;
        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.GroupBox tenantloginGroupBox;
        private System.Windows.Forms.Button tenantLoginButton;
        private System.Windows.Forms.TextBox tenantLoginEmailTextBox;
        private System.Windows.Forms.TextBox tenantLoginPassTextBox;
        private System.Windows.Forms.Label tenantLoginPassLabel;
        private System.Windows.Forms.Label tenantLoginEmailLabel;
        private System.Windows.Forms.TextBox signupEmailTextBox;
        private System.Windows.Forms.GroupBox signupImageGroupBox;
        private System.Windows.Forms.Button signupClearPicButton;
        private System.Windows.Forms.PictureBox fpicPictureBox;
        private System.Windows.Forms.Label signupEmailLabel;
        private System.Windows.Forms.Button adminForgotPassButton;
        private System.Windows.Forms.Button tenantForgotPassButton;
        private System.Windows.Forms.Button adminForgotPassGoButton;
        private System.Windows.Forms.Button adminCancelForgotPassButton;
        private System.Windows.Forms.Button adminLoginOtpSubmitButton;
        private System.Windows.Forms.TextBox adminLoginForgotPassOtpTextBox;
        private System.Windows.Forms.Button adminLoginForgotPassChangeButton;
        private System.Windows.Forms.Label adminLoginForgotPassOtpLabel;
        private System.Windows.Forms.Label adminLoginForgotPassNewPassLabel;
    }
}