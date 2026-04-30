using System;

using System.Windows.Forms;

namespace Online_Hotel_Booking_Dashboards
{
    public partial class CustomerBookRoom : Form
    {
        public CustomerBookRoom()
        {
            InitializeComponent();
        }

        // ================= FIXED ROOM RULES =================
        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string roomType = cmbRoomType.Text;

            if (roomType == "Standard")
            {
                txtTotalAmount.Text = "3500";
                txtGuessLimit.Text = "2";
            }
            else if (roomType == "Suite")
            {
                txtTotalAmount.Text = "5000";
                txtGuessLimit.Text = "4";
            }
            else if (roomType == "Deluxe")
            {
                txtTotalAmount.Text = "10000";
                txtGuessLimit.Text = "6";
            }
            else
            {
                txtTotalAmount.Text = "";
                txtGuessLimit.Text = "";
            }
        }

        // ================= BOOK NOW =================
        private void btnBookNow_Click(object sender, EventArgs e)
        {
            // VALIDATION
            if (cmbRoomType.Text == "" ||
                txtGuessLimit.Text == "" ||
                txtTotalAmount.Text == "")
            {
                MessageBox.Show("Please complete all fields.");
                return;
            }

            if (dtpCheckIn.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Check-in cannot be in the past.");
                return;
            }

            if (dtpCheckOut.Value.Date <= dtpCheckIn.Value.Date)
            {
                MessageBox.Show("Check-out must be after check-in.");
                return;
            }

            // ================= GUEST LIMIT CHECK =================
            int guestLimit = Convert.ToInt32(txtGuessLimit.Text);
            int guestCount = Convert.ToInt32(txtGuessLimit.Text);

            if (guestCount > guestLimit)
            {
                MessageBox.Show(
                    $"This room allows only {guestLimit} guests.",
                    "Guest Limit Exceeded",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // ================= PRICE LOGIC =================
            // PRICE DOES NOT CHANGE BASED ON GUESTS
            decimal totalPrice = Convert.ToDecimal(txtTotalAmount.Text);

            // ================= SUCCESS =================
            MessageBox.Show(
                $"Booking Successful!\nTotal Price: ₱{totalPrice}",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnMyReservation_Click(object sender, EventArgs e)
        {
            UserDashboard reservations = new UserDashboard();
            reservations.Show();
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
            MyQRCode qrCode = new MyQRCode();
            qrCode.Show();
            this.Hide();
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            MyProfile profile = new MyProfile();
            profile.Show();
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