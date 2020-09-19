using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLib;
using MailOtpSenderLib;

namespace UserInterfaceLib
{
    public partial class Login : Form
    {
        int otp;
        string dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\HostelX\Images";
        public Login()
        {
            InitializeComponent();
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }
        //SIGNUP PART START
        private bool ComparePasswordBoxes()
        {
            return signupPassTextBox.Text.Equals(signupCpassTextBox.Text);
        }

        private void SetSignupButtonStatus()
        {
            signupButton.Enabled = (signupFnameTextBox.Text != "" || signupFnameTextBox.Visible == false) && (signupLnameTextBox.Text != "" || signupLnameTextBox.Visible == false) && (signupPhoneTextBox.Text != "" || signupPhoneTextBox.Visible == false) && (signupPassTextBox.Text != "" || signupPassTextBox.Visible == false) && (signupCpassTextBox.Text != "" || signupCpassTextBox.Visible == false) && (agreementCheckbox.Checked || agreementCheckbox.Visible == false) && !(signupPhoneTextBox.Text.Length < 11) && (new CommonValidation().IsValidEmail(signupEmailTextBox.Text));
            agreementCheckbox.Enabled = (signupFnameTextBox.Text != "" || signupFnameTextBox.Visible == false) && (signupLnameTextBox.Text != "" || signupLnameTextBox.Visible == false) && (signupPhoneTextBox.Text != "" || signupPhoneTextBox.Visible == false) && (signupPassTextBox.Text != "" || signupPassTextBox.Visible == false) && (signupCpassTextBox.Text != "" || signupCpassTextBox.Visible == false) && !(signupPhoneTextBox.Text.Length < 11) && (new CommonValidation().IsValidEmail(signupEmailTextBox.Text));
        }

        private void fpicPictureBox_Click(object sender, EventArgs e)
        {
            string imagePath = new ImageBrowser().GetImagePath();
            if (!(imagePath.Equals("")))
            {
                fpicPictureBox.ImageLocation = imagePath;
            }
        }

        private void signupClearPicButton_Click(object sender, EventArgs e)
        {
            fpicPictureBox.ImageLocation = "";
        }

        private void signupFnameTextBox_TextChanged(object sender, EventArgs e)
        {
            SetSignupButtonStatus();
        }

        private void signupLnameTextBox_TextChanged(object sender, EventArgs e)
        {
            SetSignupButtonStatus();
        }

        private void signupPhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            SetSignupButtonStatus();
        }

        private void signupEmailTextBox_TextChanged(object sender, EventArgs e)
        {
            SetSignupButtonStatus();
        }

        private void signupPassTextBox_TextChanged(object sender, EventArgs e)
        {
            SetSignupButtonStatus();
        }

        private void signupCpassTextBox_TextChanged(object sender, EventArgs e)
        {
            SetSignupButtonStatus();
        }

        private void agreementCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            signupButton.Enabled = agreementCheckbox.Checked;
        }

        private void agreementLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/fffffatah");
        }

        private void signupPhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            new CommonValidation().CheckForInternetConnection(this);
            if (ComparePasswordBoxes())
            {
                AdminDataAccess adminDataAccess = new AdminDataAccess();
                if (adminDataAccess.IsPhoneEmailTaken(signupPhoneTextBox.Text,signupEmailTextBox.Text))
                {
                    MessageBox.Show("An Account Associated with this Phone/Email Already Exists!\nTry Logging In", "Error");
                }
                else
                {
                    otp = new Random().Next(100000, 999999);
                    if (new OtpSender().Send(otp, signupPhoneTextBox.Text))
                    {
                        signupGroupBox.Enabled = false;
                        otpGroupBox.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Phone Number!", "Failed");
                    }
                }
            }
            else
            {
                MessageBox.Show("Password and Confirm Password must be same!", "Error");
            }
        }
        //SIGNUP PART END
        //===================

        //ADMIN LOGIN PART START
        private void SetAdminSigninButtonStatus()
        {
            adminLoginButton.Enabled = (adminLoginPassTextBox.Text != "" || adminLoginPassTextBox.Visible == false) && !(adminLoginPhoneTextBox.Text.Length < 11);
        }

        private void adminLoginPhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            SetAdminSigninButtonStatus();
            adminForgotPassGoButton.Enabled = !(adminLoginPhoneTextBox.Text.Length < 11);
        }

        private void adminLoginPassTextBox_TextChanged(object sender, EventArgs e)
        {
            SetAdminSigninButtonStatus();
            adminLoginOtpSubmitButton.Enabled = (adminLoginPassTextBox.Text != "" || adminLoginPassTextBox.Visible == false);
            adminLoginForgotPassChangeButton.Enabled = (adminLoginPassTextBox.Text != "" || adminLoginPassTextBox.Visible == false);
        }

        private void adminLoginPhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void adminLoginButton_Click(object sender, EventArgs e)
        {
            new CommonValidation().CheckForInternetConnection(this);
            AdminDataAccess adminDataAccess = new AdminDataAccess();
            Admin admin = adminDataAccess.GetAdmin(adminLoginPhoneTextBox.Text, adminLoginPassTextBox.Text);
            if (admin.AdminFirstName != null)
            {
                this.Hide();
                var dminLanding = new AdminLanding(admin);
                dminLanding.Closed += (s, args) => this.Close();
                dminLanding.Show();
            }
            else
            {
                MessageBox.Show("Account Not Found!\nPlease Re-Check Phone Number or Password.", "Error");
            }
        }
        //ADMIN LOGIN PART END
        //=======================

        //TENANT LOGIN PART START
        private void SetTenantSigninButtonStatus()
        {
            tenantLoginButton.Enabled = (tenantLoginPassTextBox.Text != "" || tenantLoginPassTextBox.Visible == false) && (new CommonValidation().IsValidEmail(tenantLoginEmailTextBox.Text));
        }

        private void tenantLoginEmailTextBox_TextChanged(object sender, EventArgs e)
        {
            SetTenantSigninButtonStatus();
        }

        private void tenantLoginPassTextBox_TextChanged(object sender, EventArgs e)
        {
            SetTenantSigninButtonStatus();
        }

        private void tenantLoginButton_Click(object sender, EventArgs e)
        {
            new CommonValidation().CheckForInternetConnection(this);
            TenantDataAccess tenantDataAccess = new TenantDataAccess();
            Tenant tenant = tenantDataAccess.GetTenant(tenantLoginEmailTextBox.Text, tenantLoginPassTextBox.Text);
            if (tenant.TenantFirstName != null)
            {
                this.Hide();
                var tenantLanding = new TenantLanding(tenant);
                tenantLanding.Closed += (s, args) => this.Close();
                tenantLanding.Show();
            }
            else
            {
                MessageBox.Show("Account Not Found!\nPlease Re-Check Email or Password.", "Error");
            }
        }
        //TENANT LOGIN PART END
        //============================

        //OTP PART START
        private void SetSubmitButtonStatus()
        {
            submitButton.Enabled = !(otpTextBox.Text.Length < 6);
        }

        private void otpTextBox_TextChanged(object sender, EventArgs e)
        {
            SetSubmitButtonStatus();
        }

        private void otpTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            new CommonValidation().CheckForInternetConnection(this);
            if (otpTextBox.Text.Equals(otp.ToString()))
            {
                otpGroupBox.Visible = false;
                signupGroupBox.Enabled = true;
                Admin admin = new Admin();
                admin.AdminFirstName = signupFnameTextBox.Text;
                admin.AdminLastName = signupLnameTextBox.Text;
                admin.AdminPass = signupPassTextBox.Text;
                admin.AdminPhone = signupPhoneTextBox.Text;
                admin.AdminEmail = signupEmailTextBox.Text;
                admin.AdminProfileImage = fpicPictureBox.ImageLocation;
                AdminDataAccess adminDataAccess = new AdminDataAccess();
                if (adminDataAccess.CreateAdmin(admin))
                {
                    new MailSender().Send("hostelx.x@yandex.com", "HostelX", signupEmailTextBox.Text, signupFnameTextBox.Text, "Admin Account Created", "Your HostelX Admin Account has been Created Successfully!", "<strong>Your HostelX Admin Account has been Created Successfully!</strong>");
                    MessageBox.Show("Account Creation Successful!\nPlease Log In.", "Successful");
                }
                else
                {
                    MessageBox.Show("Account Creation Failed!\nPlease Check Your Internet Connection!", "Error");
                }
            }
            else
            {
                MessageBox.Show("Account Creation Failed!\nPlease Input Valid OTP!", "Error");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            new CommonValidation().CheckForInternetConnection(this);
            otpGroupBox.Visible = false;
            signupGroupBox.Enabled = true;
        }

        //OTP PART END
        //==================

        //FORM CLOSING PART START
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Application.Exit();
            Environment.Exit(0);
        }
        //FORM CLOSING PART END
        //========================

        //ADMIN LOGIN FORGOT PASSWORD PART START
        private void adminForgotPassButton_Click(object sender, EventArgs e)
        {
            new CommonValidation().CheckForInternetConnection(this);
            adminCancelForgotPassButton.Visible = false;
            adminLoginButton.Visible = false;
            adminLoginPassLabel.Visible = false;
            adminLoginPassTextBox.Visible = false;
            adminCancelForgotPassButton.Visible = true;
            adminForgotPassGoButton.Visible = true;
        }

        private void adminCancelForgotPassButton_Click(object sender, EventArgs e)
        {
            new CommonValidation().CheckForInternetConnection(this);
            adminLoginOtpSubmitButton.Visible = false;
            adminLoginButton.Visible = true;
            adminLoginPassLabel.Visible = true;
            adminLoginPassTextBox.Visible = true;
            adminCancelForgotPassButton.Visible = false;
            adminForgotPassGoButton.Visible = false;
            adminLoginForgotPassOtpLabel.Visible = false;
            adminLoginForgotPassOtpTextBox.Visible = false;
            adminLoginForgotPassNewPassLabel.Visible = false;
            adminLoginPhoneTextBox.Enabled = true;
            adminLoginForgotPassChangeButton.Visible = false;
        }

        private void adminForgotPassGoButton_Click(object sender, EventArgs e)
        {
            new CommonValidation().CheckForInternetConnection(this);
            otp = new Random().Next(100000, 999999);
            if (new OtpSender().Send(otp, adminLoginPhoneTextBox.Text))
            {
                adminLoginForgotPassOtpLabel.Visible = true;
                adminLoginForgotPassOtpTextBox.Visible = true;
                adminLoginOtpSubmitButton.Visible = true;
                adminLoginPhoneTextBox.Enabled = false;
                adminForgotPassGoButton.Visible = false;
            }
            else
            {
                MessageBox.Show("Invalid Phone Number!", "Failed");
            }
        }

        private void adminLoginOtpSubmitButton_Click(object sender, EventArgs e)
        {
            new CommonValidation().CheckForInternetConnection(this);
            if (adminLoginForgotPassOtpTextBox.Text.Equals(otp.ToString()))
            {
                adminLoginForgotPassNewPassLabel.Visible = true;
                adminLoginForgotPassOtpLabel.Visible = false;
                adminLoginForgotPassOtpLabel.Visible = false;
                adminLoginForgotPassOtpTextBox.Visible = false;
                adminLoginOtpSubmitButton.Visible = false;
                adminLoginForgotPassChangeButton.Visible = true;
                adminLoginPassTextBox.Visible = true;
            }
            else
            {
                MessageBox.Show("Could not change password!\nPlease Input Valid OTP!", "Error");
            }
        }

        private void adminLoginForgotPassOtpTextBox_TextChanged(object sender, EventArgs e)
        {
            adminLoginOtpSubmitButton.Enabled = !(adminLoginForgotPassOtpTextBox.Text.Length < 6);
        }

        private void adminLoginForgotPassOtpTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void adminLoginForgotPassChangeButton_Click(object sender, EventArgs e)
        {
            new CommonValidation().CheckForInternetConnection(this);
            adminLoginOtpSubmitButton.Visible = false;
            adminLoginButton.Visible = true;
            adminLoginPassLabel.Visible = true;
            adminLoginPassTextBox.Visible = true;
            adminCancelForgotPassButton.Visible = false;
            adminForgotPassGoButton.Visible = false;
            adminLoginForgotPassOtpLabel.Visible = false;
            adminLoginForgotPassOtpTextBox.Visible = false;
            adminLoginForgotPassNewPassLabel.Visible = false;
            adminLoginPhoneTextBox.Enabled = true;
            adminLoginForgotPassChangeButton.Visible = false;
            if (new AdminDataAccess().UpdatePassword(adminLoginPhoneTextBox.Text, adminLoginPassTextBox.Text))
            {
                Admin admin = new AdminDataAccess().GetAdmin(adminLoginPhoneTextBox.Text, adminLoginPassTextBox.Text);
                new MailSender().Send("hostelx.x@yandex.com", "HostelX", admin.AdminEmail, admin.AdminFirstName, "HostelX Settings Changed", "Your HostelX Admin Password has been Changed Successfully!", "<strong>Your HostelX Admin Password has been Changed Successfully!</strong>");
                MessageBox.Show("Password Changed Successfully!\nPlease Login With New Password.", "Success");
            }
            else
            {
                MessageBox.Show("Could not change password!\nPlease Check Your Internet Connection!", "Error");
            }
        }
        //ADMIN LOGIN FORGOT PASSWORD PART END
        //=========================================

        //TENANT LOGIN FORGOT PASSWORD PART START

        //TO=DO
        //TENANT LOGIN FORGOT PASSWORD PART END
        //==============================================
    }
}
