using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using DataAccessLib;
using MailOtpSenderLib;

namespace UserInterfaceLib
{
    public partial class AdminLanding : Form
    {
        Admin admin;
        int currentMouseOverRow;
        public AdminLanding(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            SetLabels();
        }

        private void AdminLanding_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Application.Exit();
            Environment.Exit(0);
        }

        //ADMIN PROFILE TAB PAGE START
        private void SetLabels()
        {
            adminIdLabel.Text += admin.AdminId;
            adminNameLabel.Text += admin.AdminFirstName + " " + admin.AdminLastName;
            adminEmailLabel.Text += admin.AdminEmail;
            adminPhoneLabel.Text += admin.AdminPhone;
            adminProfilePictureBox.ImageLocation = admin.AdminProfileImage;
        }
        private void adminLogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new Login();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void dangerZoneUnlockButton_Click(object sender, EventArgs e)
        {
            if (dangerZoneUnlockButton.Text.Equals("Unlock"))
            {
                dangerZoneUnlockButton.Text = "Lock";
                adminDangerZoneGroupBox.Enabled = true;
            }
            else
            {
                dangerZoneUnlockButton.Text = "Unlock";
                adminDangerZoneGroupBox.Enabled = false;
            }
        }

        private void adminDeleteAccountButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "WARNING", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                new AdminDataAccess().DeleteAdmin(admin.AdminId);
                this.Hide();
                var login = new Login();
                login.Closed += (s, args) => this.Close();
                login.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                dangerZoneUnlockButton.Text = "Unlock";
                adminDangerZoneGroupBox.Enabled = false;
            }
        }
        //ADMIN PROFILE TAB PAGE END

        //ADMIN HOSTEL TAB PAGE START
        private void SetAddHostelButtonStatus()
        {
            addHostelButton.Enabled = (hostelNameTextBox.Text != "" || hostelNameTextBox.Visible == false) && (hostelAddressTextBox.Text != "" || hostelAddressTextBox.Visible == false) && (hostelCapacityTextBox.Text != "" || hostelCapacityTextBox.Visible == false);
        }

        private void hostelNameTextBox_TextChanged(object sender, EventArgs e)
        {
            SetAddHostelButtonStatus();
        }

        private void hostelAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            SetAddHostelButtonStatus();
        }

        private void hostelCapacityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void hostelCapacityTextBox_TextChanged(object sender, EventArgs e)
        {
            SetAddHostelButtonStatus();
        }

        private void addHostelButton_Click(object sender, EventArgs e)
        {
            if (hostelTypeComboBox.SelectedIndex >= 0)
            {
                Hostel hostel = new Hostel();
                hostel.HostelName = hostelNameTextBox.Text;
                hostel.HostelAddress = hostelAddressTextBox.Text;
                hostel.HostelType = hostelTypeComboBox.Text;
                hostel.HostelCapacity = hostelCapacityTextBox.Text;
                hostel.AdminId = admin.AdminId;
                if (new HostelDataAccess().CreateHostel(hostel))
                {
                    MessageBox.Show("Hostel Added Successfully!", "Success");
                    hostelsDataGridView.DataSource = new HostelDataAccess().GetHostels(admin.AdminId);
                }
                else
                {
                    MessageBox.Show("Could Not Add Hostel!", "Failed");
                }
            }
            else
            {
                MessageBox.Show("Please Select Hostel Type!", "Failed");
            }
        }

        private void SetSaveEditHostelButtonStatus()
        {
            saveEditHostelButton.Enabled = (editHostelNameTextBox.Text != "" || editHostelNameTextBox.Visible == false) && (editHostelAddressTextBox.Text != "" || editHostelAddressTextBox.Visible == false);
        }

        private void editHostelNameTextBox_TextChanged(object sender, EventArgs e)
        {
            SetSaveEditHostelButtonStatus();
        }

        private void editHostelAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            SetSaveEditHostelButtonStatus();
        }

        private void editHostelButton_Click(object sender, EventArgs e)
        {
            editHostelNameTextBox.Enabled = true;
            editHostelAddressTextBox.Enabled = true;
            saveEditHostelButton.Enabled = true;
        }

        private void saveEditHostelButton_Click(object sender, EventArgs e)
        {
            editHostelNameTextBox.Enabled = false;
            editHostelAddressTextBox.Enabled = false;
            saveEditHostelButton.Enabled = false;
            editViewHostelGroupBox.Visible = false;
            Hostel hostel = new Hostel();
            hostel.HostelName = editHostelNameTextBox.Text;
            hostel.HostelAddress = editHostelAddressTextBox.Text;
            hostel.HostelType = editHostelTypeComboBox.Text;
            hostel.HostelCapacity = editHostelCapTextBox.Text;
            hostel.AdminId = admin.AdminId;
            hostel.HostelId = hostelsDataGridView.Rows[currentMouseOverRow].Cells[0].Value.ToString();
            if (new HostelDataAccess().UpdateHostel(hostel))
            {
                MessageBox.Show("Hostel Edited Successfully!", "Success");
                hostelsDataGridView.DataSource = new HostelDataAccess().GetHostels(admin.AdminId);
            }
            else
            {
                MessageBox.Show("Could Not Edit Hostel!", "Failed");
            }
        }

        private void hostelsDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                hostelGridViewContextMenuStrip.Show(MousePosition.X, MousePosition.Y);
                currentMouseOverRow = hostelsDataGridView.HitTest(e.X, e.Y).RowIndex;
            }
        }

        private void viewEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentMouseOverRow >= 0)
            {
                editViewHostelGroupBox.Visible = true;
                editHostelNameTextBox.Enabled = false;
                editHostelAddressTextBox.Enabled = false;
                saveEditHostelButton.Enabled = false;
                editHostelNameTextBox.Text = hostelsDataGridView.Rows[currentMouseOverRow].Cells[1].Value.ToString();
                editHostelAddressTextBox.Text = hostelsDataGridView.Rows[currentMouseOverRow].Cells[2].Value.ToString();
                editHostelTypeComboBox.Text = hostelsDataGridView.Rows[currentMouseOverRow].Cells[3].Value.ToString();
                editHostelCapTextBox.Text = hostelsDataGridView.Rows[currentMouseOverRow].Cells[4].Value.ToString();
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hostelsDataGridView.DataSource = new HostelDataAccess().GetHostels(admin.AdminId);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentMouseOverRow >= 0)
            {
                if (new HostelDataAccess().DeleteHostel(hostelsDataGridView.Rows[currentMouseOverRow].Cells[0].Value.ToString()))
                {
                    tenantByHostelComboBox.Items.Remove(hostelsDataGridView.Rows[currentMouseOverRow].Cells[0].Value.ToString());
                    tenantHostelIdComboBox.Items.Remove(hostelsDataGridView.Rows[currentMouseOverRow].Cells[0].Value.ToString());
                    hostelsDataGridView.DataSource = new HostelDataAccess().GetHostels(admin.AdminId);
                    editViewHostelGroupBox.Visible = false;
                    MessageBox.Show("Hostel Deleted Successfully!", "Success");
                }
                else
                {
                    MessageBox.Show("Couldn't Delete Hostel!", "Failed");
                }
            }
        }

        //ADMIN HOSTEL TAB PAGE END

        //ADMIN TENANT TAB PAGE START
        private void tenantsGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tenantGridViewContextMenuStrip.Show(MousePosition.X, MousePosition.Y);
                currentMouseOverRow = tenantsGridView.HitTest(e.X, e.Y).RowIndex;
            }
        }

        private void viewEditToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (currentMouseOverRow >= 0)
            {
                saveEditTenantButton.Enabled = false;
                viewEditTenantGroupBox.Visible = true;
                editTenantIdTextBox.Text = tenantsGridView.Rows[currentMouseOverRow].Cells[0].Value.ToString();
                editTenantFnameTextBox.Enabled = false; editTenantFnameTextBox.Text = tenantsGridView.Rows[currentMouseOverRow].Cells[1].Value.ToString();
                editTenantLNameTextBox.Enabled = false; editTenantLNameTextBox.Text = tenantsGridView.Rows[currentMouseOverRow].Cells[2].Value.ToString();
                editTenantPhoneTextBox.Enabled = false; editTenantPhoneTextBox.Text = tenantsGridView.Rows[currentMouseOverRow].Cells[3].Value.ToString();
                editTenantEmailTextBox.Enabled = false; editTenantEmailTextBox.Text = tenantsGridView.Rows[currentMouseOverRow].Cells[4].Value.ToString();
                editTenantAddressTextBox.Enabled = false; editTenantAddressTextBox.Text = tenantsGridView.Rows[currentMouseOverRow].Cells[5].Value.ToString();
                editTenantInstitutionTextBox.Enabled = false; editTenantInstitutionTextBox.Text = tenantsGridView.Rows[currentMouseOverRow].Cells[6].Value.ToString();
                editTenantProfilePictureBox.Enabled = false; editTenantProfilePictureBox.ImageLocation = tenantsGridView.Rows[currentMouseOverRow].Cells[8].Value.ToString();
                editTenantGenderTextBox.Text = tenantsGridView.Rows[currentMouseOverRow].Cells[9].Value.ToString();
                editTenantHostelIdTextBox.Text = tenantsGridView.Rows[currentMouseOverRow].Cells[10].Value.ToString();
            }
        }

        private void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<Hostel> hostels = new HostelDataAccess().GetHostels(admin.AdminId);
            foreach(var hostel in hostels)
            {
                if (!tenantByHostelComboBox.Items.Contains(hostel.HostelId))
                {
                    tenantByHostelComboBox.Items.Add(hostel.HostelId);
                }
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (currentMouseOverRow >= 0)
            {
                if (new TenantDataAccess().DeleteTenant(tenantsGridView.Rows[currentMouseOverRow].Cells[0].Value.ToString()))
                {
                    MessageBox.Show("Tenant Deleted Successfully!", "Success");
                    viewEditTenantGroupBox.Visible = false;
                }
                else
                {
                    MessageBox.Show("Couldn't Delete Tenant!", "Failed");
                }
            }
        }

        private void tenantByHostelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tenantsGridView.DataSource = new TenantDataAccess().GetTenants(tenantByHostelComboBox.Text);
        }

        private void SetAddNewTenantButtonStatus()
        {
            addNewTenantButton.Enabled = (tenantFnameTextBox.Text != "" || tenantFnameTextBox.Visible == false) && (tenantLNameTextBox.Text != "" || tenantLNameTextBox.Visible == false) && (tenantPhoneTextBox.Text != "" || tenantPhoneTextBox.Visible == false) && (tenantEmailTextBox.Text != "" || tenantEmailTextBox.Visible == false) && (tenantAddressTextBox.Text != "" || tenantAddressTextBox.Visible == false) && (tenantInstitutionTextBox.Text != "" || tenantInstitutionTextBox.Visible == false) && !(tenantPhoneTextBox.Text.Length < 11) && (new CommonValidation().IsValidEmail(tenantEmailTextBox.Text));
        }

        private void tenantFnameTextBox_TextChanged(object sender, EventArgs e)
        {
            SetAddNewTenantButtonStatus();
        }

        private void tenantLNameTextBox_TextChanged(object sender, EventArgs e)
        {
            SetAddNewTenantButtonStatus();
        }

        private void tenantPhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            SetAddNewTenantButtonStatus();
        }

        private void tenantPhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tenantEmailTextBox_TextChanged(object sender, EventArgs e)
        {
            SetAddNewTenantButtonStatus();
        }

        private void tenantAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            SetAddNewTenantButtonStatus();
        }

        private void tenantInstitutionTextBox_TextChanged(object sender, EventArgs e)
        {
            SetAddNewTenantButtonStatus();
        }

        private void tenantProfilePictureBox_Click(object sender, EventArgs e)
        {
            string imagePath = new ImageBrowser().GetImagePath();
            if (!(imagePath.Equals("")))
            {
                tenantProfilePictureBox.ImageLocation = imagePath;
            }
        }

        private void addNewTenantButton_Click(object sender, EventArgs e)
        {
            if(!new TenantDataAccess().IsPhoneEmailTaken(tenantPhoneTextBox.Text, tenantEmailTextBox.Text))
            {
                if (tenantGenderComboBox.SelectedIndex >= 0 && tenantHostelIdComboBox.SelectedIndex >= 0)
                {
                    Tenant tenant = new Tenant();
                    tenant.TenantFirstName = tenantFnameTextBox.Text;
                    tenant.TenantLastName = tenantLNameTextBox.Text;
                    tenant.TenantPhone = tenantPhoneTextBox.Text;
                    tenant.TenantEmail = tenantEmailTextBox.Text;
                    tenant.TenantAddress = tenantAddressTextBox.Text;
                    tenant.TenantInstitution = tenantInstitutionTextBox.Text;
                    tenant.TenantProfileImage = tenantProfilePictureBox.ImageLocation;
                    tenant.TenantGender = tenantGenderComboBox.Text;
                    tenant.HostelId = tenantHostelIdComboBox.Text;
                    tenant.TenantPass = new Random().Next(10000000, 99999999).ToString();
                    Hostel hostel = new HostelDataAccess().GetHostel(tenant.HostelId);
                    hostel.HostelCapacity = (Int32.Parse(hostel.HostelCapacity) - 1).ToString();
                    if ((Int32.Parse(hostel.HostelCapacity)) >= 0)
                    {
                        if (new TenantDataAccess().CreateTenant(tenant))
                        {
                            new HostelDataAccess().UpdateHostel(hostel);
                            tenantsGridView.DataSource = new TenantDataAccess().GetTenants(tenant.HostelId);
                            tenantByHostelComboBox.SelectedItem = tenant.HostelId;
                            MessageBox.Show("Tenant Added Successfully!", "Success");
                            new MailSender().Send("hostelx.x@yandex.com", "HostelX", tenantEmailTextBox.Text, tenantFnameTextBox.Text, "Tenant Account Created", "Your HostelX Tenant Account has been Created Successfully!", "<strong><p>You Have been Added as a Tenant Successfully!<br>Hostel(ID): " + tenant.HostelId + "<br>Your Email: " + tenant.TenantEmail + "<br>Your Password: " + tenant.TenantPass + "<br>You can Login to the HostelX desktop app using your Email and the above Password. You can also change your Password by using the 'Forgot Password?' option.</p></strong>");
                        }
                        else
                        {
                            MessageBox.Show("Could Not Add Tenant!", "Failed");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hostel is out of capacity!", "Failed");
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Tenant Gender/Hostel(ID)!", "Failed");
                }
            }
            else
            {
                MessageBox.Show("A Tenant Associated with this Phone/Email Already Exists!", "Failed");
            }
        }

        private void tenantGenderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tenantHostelIdComboBox.SelectedIndex = -1;
            tenantHostelIdComboBox.Items.Clear();
            tenantHostelIdComboBox.ResetText();
            List<Hostel> hostels = new HostelDataAccess().GetHostels(admin.AdminId);
            foreach (var hostel in hostels)
            {
                if ((!tenantHostelIdComboBox.Items.Contains(hostel.HostelId)) && (hostel.HostelType.Equals(tenantGenderComboBox.Text)))
                {
                    tenantHostelIdComboBox.Items.Add(hostel.HostelId);
                }
            }
        }

        private void SetSaveEditTenantButtonStatus()
        {
            saveEditTenantButton.Enabled = (editTenantFnameTextBox.Text != "" || editTenantFnameTextBox.Visible == false)&& (editTenantLNameTextBox.Text != "" || editTenantLNameTextBox.Visible == false)&& (editTenantPhoneTextBox.Text != "" || editTenantPhoneTextBox.Visible == false)&& (editTenantEmailTextBox.Text != "" || editTenantEmailTextBox.Visible == false)&& (editTenantAddressTextBox.Text != "" || editTenantAddressTextBox.Visible == false)&& (editTenantInstitutionTextBox.Text != "" || editTenantInstitutionTextBox.Visible == false)&& !(editTenantPhoneTextBox.Text.Length < 11) && (new CommonValidation().IsValidEmail(editTenantEmailTextBox.Text));
        }

        private void editTenantPhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void editTenantFnameTextBox_TextChanged(object sender, EventArgs e)
        {
            SetSaveEditTenantButtonStatus();
        }

        private void editTenantLNameTextBox_TextChanged(object sender, EventArgs e)
        {
            SetSaveEditTenantButtonStatus();
        }

        private void editTenantPhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            SetSaveEditTenantButtonStatus();
        }

        private void editTenantEmailTextBox_TextChanged(object sender, EventArgs e)
        {
            SetSaveEditTenantButtonStatus();
        }

        private void editTenantAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            SetSaveEditTenantButtonStatus();
        }

        private void editTenantInstitutionTextBox_TextChanged(object sender, EventArgs e)
        {
            SetSaveEditTenantButtonStatus();
        }

        private void editTenantProfilePictureBox_Click(object sender, EventArgs e)
        {
            string imagePath = new ImageBrowser().GetImagePath();
            if (!(imagePath.Equals("")))
            {
                editTenantProfilePictureBox.ImageLocation = imagePath;
            }
        }

        private void enableEditTenantButton_Click(object sender, EventArgs e)
        {
            saveEditTenantButton.Enabled = true;
            editTenantFnameTextBox.Enabled = true;
            editTenantLNameTextBox.Enabled = true;
            editTenantPhoneTextBox.Enabled = true;
            editTenantEmailTextBox.Enabled = true;
            editTenantAddressTextBox.Enabled = true;
            editTenantInstitutionTextBox.Enabled = true;
            editTenantProfilePictureBox.Enabled = true;
        }

        private void saveEditTenantButton_Click(object sender, EventArgs e)
        {
            Tenant tenant = new Tenant();
            tenant.TenantId = editTenantIdTextBox.Text;
            tenant.TenantFirstName = editTenantFnameTextBox.Text;
            tenant.TenantLastName = editTenantLNameTextBox.Text;
            tenant.TenantPhone = editTenantPhoneTextBox.Text;
            tenant.TenantEmail = editTenantEmailTextBox.Text;
            tenant.TenantAddress = editTenantAddressTextBox.Text;
            tenant.TenantInstitution = editTenantInstitutionTextBox.Text;
            tenant.TenantProfileImage = editTenantProfilePictureBox.ImageLocation;
            tenant.TenantGender = editTenantGenderTextBox.Text;
            tenant.HostelId = editTenantHostelIdTextBox.Text;
            if (new TenantDataAccess().UpdateTenant(tenant))
            {
                MessageBox.Show("Tenant Updated Successfully!", "Success");
                new MailSender().Send("hostelx.x@yandex.com", "HostelX", editTenantEmailTextBox.Text, editTenantFnameTextBox.Text, "Tenant Account Updated", "Your HostelX Tenant Account has been Updated Successfully!", "<strong>Your Tenant Account Details Has Been Updated by the Admin Successfully! Please Login and Check!</strong>");
            }
            else
            {
                MessageBox.Show("Could Not Update Tenant!", "Failed");
            }
            saveEditTenantButton.Enabled = false;
            viewEditTenantGroupBox.Visible = false;
        }
        //ADMIN TENANT TAB PAGE END

        //ADMIN FOOD TAB PAGE START
        private void SetAddFoodButtonStatus()
        {
            addFoodButton.Enabled = (foodNameTextBox.Text != "" || foodNameTextBox.Visible == false) && (foodQuantityTextBox.Text != "" || foodQuantityTextBox.Visible == false);
        }

        private void foodNameTextBox_TextChanged(object sender, EventArgs e)
        {
            SetAddFoodButtonStatus();
        }

        private void foodQuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            SetAddFoodButtonStatus();
        }

        private void foodQuantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void addFoodButton_Click(object sender, EventArgs e)
        {
            Food food = new Food();
            food.FoodItem = foodNameTextBox.Text;
            food.FoodQuantity = foodQuantityTextBox.Text;
            food.AdminId = admin.AdminId;
            if (new FoodDataAccess().CreateFood(food))
            {
                foodDataGridView.DataSource = new FoodDataAccess().GetFoods(admin.AdminId);
                MessageBox.Show("Food Added Successfully!", "Success");
            }
            else
            {
                MessageBox.Show("Could Not Add Food!", "Failed");
            }
        }

        private void enableEditFoodButton_Click(object sender, EventArgs e)
        {
            editFoodNameTextBox.Enabled = true;
            editFoodQtyTextBox.Enabled = true;
            saveEditFoodButton.Enabled = true;
        }

        private void SetSaveEditFoodButtonStatus()
        {
            saveEditFoodButton.Enabled = (editFoodNameTextBox.Text != "" || editFoodNameTextBox.Visible == false) && (editFoodQtyTextBox.Text != "" || editFoodQtyTextBox.Visible == false);
        }

        private void saveEditFoodButton_Click(object sender, EventArgs e)
        {
            editFoodNameTextBox.Enabled = false;
            editFoodQtyTextBox.Enabled = false;
            saveEditFoodButton.Enabled = false;
            editFoodGroupBox.Visible = false;
            Food food = new Food();
            food.FoodId = foodIdTextBox.Text;
            food.FoodItem = editFoodNameTextBox.Text;
            food.FoodQuantity = editFoodQtyTextBox.Text;
            if (new FoodDataAccess().UpdateFood(food))
            {
                foodDataGridView.DataSource = new FoodDataAccess().GetFoods(admin.AdminId);
                MessageBox.Show("Food Updated Successfully!", "Success");
            }
            else
            {
                MessageBox.Show("Could Not Update Food!", "Failed");
            }
        }

        private void viewEditToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (currentMouseOverRow >= 0)
            {
                editFoodGroupBox.Visible = true;
                editFoodNameTextBox.Enabled = false;
                editFoodQtyTextBox.Enabled = false;
                saveEditFoodButton.Enabled = false;
                foodIdTextBox.Text = foodDataGridView.Rows[currentMouseOverRow].Cells[0].Value.ToString();
                editFoodNameTextBox.Text = foodDataGridView.Rows[currentMouseOverRow].Cells[1].Value.ToString();
                editFoodQtyTextBox.Text = foodDataGridView.Rows[currentMouseOverRow].Cells[2].Value.ToString();
            }
        }

        private void refreshToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            foodDataGridView.DataSource = new FoodDataAccess().GetFoods(admin.AdminId);
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (currentMouseOverRow >= 0)
            {
                if (new FoodDataAccess().DeleteFood(foodDataGridView.Rows[currentMouseOverRow].Cells[0].Value.ToString()))
                {
                    foodDataGridView.DataSource = new FoodDataAccess().GetFoods(admin.AdminId);
                    MessageBox.Show("Food Deleted Successfully!", "Success");
                }
                else
                {
                    MessageBox.Show("Could Not Delete Food!", "Failed");
                }
            }
        }

        private void editFoodNameTextBox_TextChanged(object sender, EventArgs e)
        {
            SetSaveEditFoodButtonStatus();
        }

        private void editFoodQtyTextBox_TextChanged(object sender, EventArgs e)
        {
            SetSaveEditFoodButtonStatus();
        }

        private void editFoodQtyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void foodDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                foodContextMenuStrip.Show(MousePosition.X, MousePosition.Y);
                currentMouseOverRow = foodDataGridView.HitTest(e.X, e.Y).RowIndex;
            }
        }
        //ADMIN FOOD TAB PAGE END

        //ADMIN PAYMENT TAB PAGE START

        //ADMIN PAYMENT TAB PAGE END
    }
}

