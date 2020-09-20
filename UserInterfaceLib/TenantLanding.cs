using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLib;
using MailOtpSenderLib;

namespace UserInterfaceLib
{
    public partial class TenantLanding : Form
    {
        Tenant tenant;
        int currentMouseOverRow;
        List<Food> foods;
        int totalAmount;
        public TenantLanding(Tenant tenant)
        {
            InitializeComponent();
            this.tenant = tenant;
            SetTenantDetails();
            foods = new List<Food>();
            totalAmount = 0;
        }

        private void TenantLanding_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Application.Exit();
            Environment.Exit(0);
        }

        //TENANT PROFILE TAB PAGE START
        private void SetTenantDetails()
        {
            myProfilePictureBox.ImageLocation = tenant.TenantProfileImage;
            tenantProfileIdLabel.Text += tenant.TenantId;
            tenantProfileNameLabel.Text += tenant.TenantFirstName + " " + tenant.TenantLastName;
            tenantProfileGenderLabel.Text += tenant.TenantGender;
            tenantProfilePhoneLabel.Text += tenant.TenantPhone;
            tenantProfileEmailLabel.Text += tenant.TenantEmail;
            tenantProfileAddressLabel.Text += tenant.TenantAddress;
            tenantProfileInstLabel.Text += tenant.TenantInstitution;
            tenantProfileHostelIdLabel.Text += tenant.HostelId;
        }

        private void tenantLogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new Login();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }
        //TENANT PROFILE TAB PAGE END

        //TENANT FOOD TAB PAGE START
        private void addToCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentMouseOverRow >= 0)
            {
                if (Int32.Parse(foodDataGridView.Rows[currentMouseOverRow].Cells[2].Value.ToString()) > 0)
                {
                    Food food = new Food();
                    food.FoodId = foodDataGridView.Rows[currentMouseOverRow].Cells[0].Value.ToString();
                    food.FoodItem = foodDataGridView.Rows[currentMouseOverRow].Cells[1].Value.ToString();
                    food.FoodQuantity = foodDataGridView.Rows[currentMouseOverRow].Cells[2].Value.ToString();
                    food.FoodPrice = foodDataGridView.Rows[currentMouseOverRow].Cells[3].Value.ToString();
                    food.AdminId = foodDataGridView.Rows[currentMouseOverRow].Cells[4].Value.ToString();
                    foods.Add(food);
                    cartDataGridView.Rows.Add(food.FoodId, food.FoodItem, food.FoodQuantity, food.FoodPrice, food.AdminId);
                }
                else
                {
                    MessageBox.Show("Out of Stock!", "Failed");
                }
            }
        }

        private void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foodDataGridView.DataSource = new FoodDataAccess().GetFoods(new HostelDataAccess().GetHostel(tenant.HostelId).AdminId);
        }

        private void foodDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                foodAddContextMenuStrip.Show(MousePosition.X, MousePosition.Y);
                currentMouseOverRow = foodDataGridView.HitTest(e.X, e.Y).RowIndex;
            }
        }

        private void clearCartButtton_Click(object sender, EventArgs e)
        {
            foodMockBkashGroupBox.Visible = false;
            cartDataGridView.Rows.Clear();
            cartDataGridView.Refresh();
            foods.Clear();
            totalAmount = 0;
            orderFoodButton.Enabled = false;
        }

        private void orderFoodButton_Click(object sender, EventArgs e)
        {
            foreach(var food in foods)
            {
                totalAmount += Int32.Parse(food.FoodPrice);
            }
            foodMockBkashGroupBox.Visible = true;
            foodMockPhoneNumLabel.Text = tenant.TenantPhone;
            foodMockAmountNumLabel.Text = totalAmount.ToString();
        }

        private void foodMockYourPinTextBox_TextChanged(object sender, EventArgs e)
        {
            foodMockBkashProceedButton.Enabled = (foodMockYourPinTextBox.Text != "" || foodMockYourPinTextBox.Visible == false);
        }

        private void foodMockYourPinTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void foodMockBkashCancelButton_Click(object sender, EventArgs e)
        {
            foodMockBkashGroupBox.Visible = false;
            cartDataGridView.Rows.Clear();
            cartDataGridView.Refresh();
            foods.Clear();
            totalAmount = 0;
            orderFoodButton.Enabled = false;
        }

        private void foodMockBkashProceedButton_Click(object sender, EventArgs e)
        {
            Admin admin = new AdminDataAccess().GetAdminById(new HostelDataAccess().GetHostel(tenant.HostelId).AdminId);
            string foodListBuilder = "<p>[FOOD ORDER]";
            foreach(var food in foods)
            {
                foodListBuilder += "<br>FoodID: " + food.FoodId + "FoodItem: " + food.FoodItem + "Price: " + food.FoodPrice;
            }
            foodListBuilder += "<br>________________________________________________________________<br>Total Paid: ---------------------------------------- " + totalAmount + " Tk</p>";
            byte[] pdfReceipt = new GenerateReceipts().Generate("<strong>" + foodListBuilder + "</strong>", "TID_" + tenant.TenantId + "_PAID_" + DateTime.Now.ToString("yyyyMMddHHmmss"));
            new MailSender().Send("hostelx.x@yandex.com", "HostelX", tenant.TenantEmail, tenant.TenantFirstName + " " + tenant.TenantLastName, "Food Order Placed", "Your Order Has Been Placed Successfully!", "<strong>Your For Order Receipt: </strong>", "TID_" + tenant.TenantId + "_PAID_" + DateTime.Now.ToString("yyyyMMddHHmmss"), pdfReceipt);
            new MailSender().Send("hostelx.x@yandex.com", "HostelX", admin.AdminEmail, admin.AdminFirstName + " " + admin.AdminLastName, "New Food Order Placed", "A New Food Order Has Been Placed", "<strong>Please Deliver The Items Attached Below: </strong>", "TID_" + tenant.TenantId + "_PAID_" + DateTime.Now.ToString("yyyyMMddHHmmss"), pdfReceipt);
            MessageBox.Show("Order Placed Successfully!", "Success");
        }

        private void cartDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            orderFoodButton.Enabled = true;
        }
        //TENANT FOOD TAB PAGE END

        //TENANT PAYMENT TAB PAGE END
        private void tenantPaymentDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tenantPaymentContextMenuStrip.Show(MousePosition.X, MousePosition.Y);
                currentMouseOverRow = tenantPaymentDataGridView.HitTest(e.X, e.Y).RowIndex;
            }
        }

        private void payToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentMouseOverRow >= 0)
            {
                mockBkashGroupBox.Visible = true;
                mockPhoneNumLabel.Text = tenant.TenantPhone;
                mockAmountNumLabel.Text = tenantPaymentDataGridView.Rows[currentMouseOverRow].Cells[1].Value.ToString();
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tenantPaymentDataGridView.DataSource = new PaymentDataAccess().GetPayments(tenant.TenantId);
        }

        private void mockPinTextBox_TextChanged(object sender, EventArgs e)
        {
            paymentProceedButton.Enabled = (mockPinTextBox.Text != "" || mockPinTextBox.Visible == false);
        }

        private void mockPinTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void paymentCancelButton_Click(object sender, EventArgs e)
        {
            mockBkashGroupBox.Visible = false;
        }

        private void paymentProceedButton_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.PaymentId = tenantPaymentDataGridView.Rows[currentMouseOverRow].Cells[0].Value.ToString();
            payment.TenantId = tenant.TenantId;
            payment.Due = "0";
            payment.Paid = mockAmountNumLabel.Text;
            payment.Balance = "0";
            payment.PaymentDate = DateTime.Now.Date.ToString();
            payment.PaymentDueDate = tenantPaymentDataGridView.Rows[currentMouseOverRow].Cells[4].Value.ToString();
            if (new PaymentDataAccess().UpdatePayment(payment))
            {
                Hostel hostel = new HostelDataAccess().GetHostel(tenant.HostelId);
                Admin admin = new AdminDataAccess().GetAdminById(hostel.AdminId);
                byte[] pdfFile = new GenerateReceipts().Generate("<!DOCTYPE html><html><head><title></title></head><body><table border=\"1\"><tr><th>Hostel ID</th><th>Tenant ID</th><th>Tenant Name</th><th>Paid Amount</th><th>Due Amount</th><th>Balance</th><th>Payment Date </th><th>Payment Due Date</th></tr><tr><td>" + tenant.HostelId + "</td><td>" + tenant.TenantId + "</td><td>" + tenant.TenantFirstName + " " + tenant.TenantLastName + "</td><td>" + payment.Paid + "</td><td>" + payment.Due + "</td><td>" + payment.Balance + "</td><td>" + payment.PaymentDate + "</td><td>" + payment.PaymentDueDate + "</td></tr></table></body></html>", "TID_" + tenant.TenantId + "_PAID_" + DateTime.Now.ToString("yyyyMMddHHmmss"));
                new MailSender().Send("hostelx.x@yandex.com", "HostelX", admin.AdminEmail, "Admin", "A Tenant Just Paid Rent", "A Tenant Paid Rent!", "<strong>Receipt has been attached as PDF to this email. Please Do Not Lose it!</strong>", "TID_" + tenant.TenantId + "_PAID_" + payment.PaymentDate, pdfFile);
                new MailSender().Send("hostelx.x@yandex.com", "HostelX", tenant.TenantEmail, tenant.TenantFirstName+" "+tenant.TenantLastName, "Rent Paid Successfully!", "A Tenant Paid Rent!", "<strong>Receipt has been attached as PDF to this email. Please Do Not Lose it!</strong>", "TID_" + tenant.TenantId + "_PAID_" + payment.PaymentDate, pdfFile);
                MessageBox.Show("Paid Successfully!", "Successful");
                tenantPaymentDataGridView.DataSource = new PaymentDataAccess().GetPayments(tenant.TenantId);
                mockBkashGroupBox.Visible = false;
            }
            else
            {
                MessageBox.Show("Could Not Pay Successfully!", "Failed");
            }
        }
        //TENANT PAYMENT TAB PAGE END

        //TENANT NOTICE PAGE START
        private void noticeRefreshButton_Click(object sender, EventArgs e)
        {
            tenantNoticeDataGridView.DataSource = new NoticesDataAccess().GetNotices(tenant.HostelId);
        }
        //TENANT NOTICE PAGE END

        //TENANT EXTRAS TAB PAGE START
        private void contactAdminDetailsTextBox_TextChanged(object sender, EventArgs e)
        {
            sendContactAdminButton.Enabled = (contactAdminDetailsTextBox.Text != "" || contactAdminDetailsTextBox.Visible == false);
        }

        private void sendContactAdminButton_Click(object sender, EventArgs e)
        {
            if(contactAdminSubjectComboBox.SelectedIndex >= 0)
            {
                Hostel hostel = new HostelDataAccess().GetHostel(tenant.HostelId);
                Admin admin = new AdminDataAccess().GetAdminById(hostel.AdminId);
                new MailSender().Send("hostelx.x@yandex.com", "HostelX", admin.AdminEmail, "Admin", "Regarding: "+contactAdminSubjectComboBox.Text, "A Tenant Wants to Contact With You!", "<strong><p>Details: "+contactAdminDetailsTextBox.Text+"<br>Tenant ID: "+tenant.TenantId+"<br>Tenant Email: "+tenant.TenantEmail+"<br>Hostel ID: "+tenant.HostelId+"<p/></strong>");
                MessageBox.Show("Sent Successfully!", "Successful");
            }
            else
            {
                MessageBox.Show("Please Select a Subject!", "Failed");
            }
        }

        private void refreshTenantAdminDetailsButton_Click(object sender, EventArgs e)
        {
            Hostel hostel = new HostelDataAccess().GetHostel(tenant.HostelId);
            Admin admin = new AdminDataAccess().GetAdminById(hostel.AdminId);
            adminPictureBox.ImageLocation = admin.AdminProfileImage;
            adminIdLabel.Text += admin.AdminId;
            adminNameLabel.Text += admin.AdminFirstName + " " + admin.AdminLastName;
            adminPhoneLabel.Text += admin.AdminPhone;
            adminEmailLabel.Text += admin.AdminEmail;
            refreshTenantAdminDetailsButton.Enabled = false;
        }
        //TENANT EXTRAS TAB PAGE START
    }
}
