using System;

using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using QRCoder;

namespace Online_Hotel_Booking_Dashboards
{
    public partial class MyQRCode : Form
    {
        public MyQRCode()
        {
            InitializeComponent();
        }

        string connString = "server=localhost;database=hotel_db;uid=root;pwd=;";

        // ================= LOAD QR ON FORM =================
        public void LoadQRCode(int reservationId)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                string query = @"SELECT reservation_id, user_id, room_id, check_in, check_out, status
                                 FROM reservationstbl
                                 WHERE reservation_id = @id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", reservationId);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string qrData =
                        "Reservation ID: " + dr["reservation_id"] + "\n" +
                        "User ID: " + dr["user_id"] + "\n" +
                        "Room ID: " + dr["room_id"] + "\n" +
                        "Check-in: " + dr["check_in"] + "\n" +
                        "Check-out: " + dr["check_out"] + "\n" +
                        "Status: " + dr["status"];

                    GenerateQR(qrData);
                }
            }
        }

        // ================= GENERATE QR =================
        private void GenerateQR(string text)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);

            Bitmap qrImage = qrCode.GetGraphic(8);

            pictureBoxQRCode.Image = qrImage;
        }

        // ================= DOWNLOAD QR =================
        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (pictureBoxQRCode.Image == null)
            {
                MessageBox.Show("No QR Code to download.");
                return;
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PNG Image|*.png";
            save.FileName = "BookingQRCode.png";

            if (save.ShowDialog() == DialogResult.OK)
            {
                pictureBoxQRCode.Image.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Png);
                MessageBox.Show("QR Code saved successfully!");
            }
        }

        private void btnMyReservation_Click(object sender, EventArgs e)
        {
            UserDashboard dashboard = new UserDashboard();
            dashboard.Show();
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
            MyQRCode qrCodeForm = new MyQRCode();
            qrCodeForm.Show();
            this.Hide();
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            MyProfile myProfile = new MyProfile();
            myProfile.Show();
            this.Hide();
        }

        private void LoadBookingDetails(int reservationId)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                string query = @"
                SELECT 
                    r.reservation_id,
                    r.user_id,
                    rm.room_id,
                    rm.room_type,
                    rm.price,
                    r.check_in,
                    r.check_out,
                    r.status
                FROM reservationstbl r
                INNER JOIN roomstbl rm ON r.room_id = rm.room_id
                WHERE r.reservation_id = @id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", reservationId);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    DateTime checkIn = Convert.ToDateTime(dr["check_in"]);
                    DateTime checkOut = Convert.ToDateTime(dr["check_out"]);

                    int nights = (checkOut - checkIn).Days;
                    decimal pricePerNight = Convert.ToDecimal(dr["price"]);
                    decimal totalAmount = nights * pricePerNight;

                    lblReservationID.Text = dr["reservation_id"].ToString();
                    lblUserID.Text = dr["user_id"].ToString();
                    lblFullName.Text = dr["fullname"].ToString();
                    lblRoomType.Text = dr["room_type"].ToString();
                    lblRoomID.Text = dr["room_id"].ToString();

                    lblCheckIn.Text = checkIn.ToString("MMMM dd, yyyy");
                    lblCheckOut.Text = checkOut.ToString("MMMM dd, yyyy");

                    lblNights.Text = nights.ToString();
                    lblPricePerNight.Text = "₱" + pricePerNight.ToString("N2");
                    lblTotalAmount.Text = "₱" + totalAmount.ToString("N2");
                    lblStatus.Text = dr["status"].ToString();
                }
                else
                {
                    MessageBox.Show("No booking details found.");
                }
            }
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

        private void pictureBoxQRCode_Click(object sender, EventArgs e)
        {

        }

        private void MyQRCode_Load(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }
    }
}