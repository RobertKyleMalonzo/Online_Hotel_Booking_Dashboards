using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Hotel_Booking_Dashboards
{
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalBooking_Click(object sender, EventArgs e)
        {

        }

        private void lblUpcoming_Click(object sender, EventArgs e)
        {

        }

        private void lblCheckIn_Click(object sender, EventArgs e)
        {

        }

        private void lblCancelled_Click(object sender, EventArgs e)
        {

        }

        private void dgvRecentRservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMyReservation_Click(object sender, EventArgs e)
        {
            UserDashboard reservation = new UserDashboard();
            reservation.Show();
            this.Hide();
        }

        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            CustomerBookRoom bookroom = new CustomerBookRoom();
            bookroom.Show();
            this.Hide();
        }

        private void btnMyQrCode_Click(object sender, EventArgs e)
        {
            MyQRCode myQRCode = new MyQRCode();
            myQRCode.Show();
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
            {   
            // Show a message box with Yes and No buttons
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",  // Message text
                "Logout Confirmation",               // Title
                MessageBoxButtons.YesNo,             // Buttons
                MessageBoxIcon.Question              // Icon
            );

            // Check what the user clicked
            if (result == DialogResult.Yes)
            {
                // User clicked Yes → go back to login form
                LogIn loginForm = new LogIn();
                loginForm.Show();

                // Hide or close the current form (user dashboard)
                this.Hide();
            }
            // If No is clicked, nothing happens
        }
    }
    }
}
