using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Net.Mime.MediaTypeNames;
using MySql.Data.MySqlClient;

namespace Online_Hotel_Booking_Dashboards
{
    public partial class MyProfile : Form
    {
        public MyProfile()
        {
            InitializeComponent();
        }

        public static class GlobalUser
        {
            public static int UserId;
        }



        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPassword.Checked)
            {

                txtPassword.PasswordChar = '\0';
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnUpgradeProfile_Click(object sender, EventArgs e)
        {
            string fullname = txtFullName.Text.Trim();
            string email = txtEmailAdress.Text.Trim();
            string phonenumber = txtPhoneNumber.Text.Trim();
            

            if (string.IsNullOrEmpty(fullname) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phonenumber))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            DBConnect db = new DBConnect();

            try
            {

                db.Open();
                string query = "UPDATE users SET fullname = @fullname, email = @email, phonenumber = @phonenumber, password = @password WHERE id = @userId";
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@fullname", fullname);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phonenumber", phonenumber);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Profile updated successfully.");

                    txtFullName.Clear();
                    txtEmailAdress.Clear();
                    txtPhoneNumber.Clear();
                }
                else
                {
                    MessageBox.Show("No changes were made to the profile.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the profile: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text.Trim();

            // ================= VALIDATION =================
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your new password.");
                return;
            }

            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                // ================= UPDATE PASSWORD =================
                string query = "UPDATE users SET password = @password WHERE id = @userId";
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@password", txtPassword);
                cmd.Parameters.AddWithValue("@userId", GlobalUser.UserId);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Password changed successfully.");

                    txtPassword.Clear();
                }
                else
                {
                    MessageBox.Show("Password update failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void btnMyReservation_Click(object sender, EventArgs e)
        {
            UserDashboard user = new UserDashboard();
            user.Show();
            this.Hide();
        }

        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            CustomerBookRoom bookRoom = new CustomerBookRoom();
            bookRoom.Show();
            this.Hide();
        }

        private void btnMyQrCode_Click(object sender, EventArgs e)
        {
            MyQRCode qRCode = new MyQRCode();
            qRCode.Show();
            this.Hide();
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            MyProfile myProfile = new MyProfile();
            myProfile.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LogIn loginForm = new LogIn();
                loginForm.Show();
                this.Hide();
            }
        }

        
    }
}
