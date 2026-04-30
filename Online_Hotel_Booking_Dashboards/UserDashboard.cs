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

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            LoadReservations();
        }

        // ==========================================
        // LOAD RESERVATION DATA
        // ==========================================
        private void LoadReservations()
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = @"SELECT reservation_id,
                                        room_number,
                                        check_in,
                                        check_out,
                                        status
                                 FROM reservations";

                MySql.Data.MySqlClient.MySqlCommand cmd =
                    new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                MySql.Data.MySqlClient.MySqlDataAdapter adapter =
                    new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);

                DataTable table = new DataTable();

                adapter.Fill(table);

                dgvRecentRservation.DataSource = table;

                // COLUMN HEADER
                dgvRecentRservation.Columns["reservation_id"].HeaderText = "Reservation ID";
                dgvRecentRservation.Columns["room_number"].HeaderText = "Room";
                dgvRecentRservation.Columns["check_in"].HeaderText = "Check-in";
                dgvRecentRservation.Columns["check_out"].HeaderText = "Check-out";
                dgvRecentRservation.Columns["status"].HeaderText = "Status";

                // ADD VIEW BUTTON
                if (!dgvRecentRservation.Columns.Contains("View"))
                {
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                    btn.Name = "View";
                    btn.HeaderText = "Action";
                    btn.Text = "View";
                    btn.UseColumnTextForButtonValue = true;

                    dgvRecentRservation.Columns.Add(btn);
                }

                // TOTAL BOOKINGS
                lblTotalBooking.Text = table.Rows.Count.ToString();

                // STATUS COUNTER
                CountStatus();

                adapter.Dispose();
                cmd.Dispose();
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

        // ==========================================
        // COUNT STATUS
        // ==========================================
        private void CountStatus()
        {
            int upcoming = 0;
            int checkin = 0;
            int cancelled = 0;

            foreach (DataGridViewRow row in dgvRecentRservation.Rows)
            {
                if (row.Cells["status"].Value != null)
                {
                    string status = row.Cells["status"].Value.ToString();

                    if (status == "Upcoming")
                        upcoming++;

                    else if (status == "Checked-in")
                        checkin++;

                    else if (status == "Cancelled")
                        cancelled++;
                }
            }

            lblUpcoming.Text = upcoming.ToString();
            lblCheckIn.Text = checkin.ToString();
            lblCancelled.Text = cancelled.ToString();
        }

        // ==========================================
        // VIEW BUTTON CLICK
        // ==========================================
        private void dgvRecentRservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 &&
                dgvRecentRservation.Columns[e.ColumnIndex].Name == "View")
            {
                DataGridViewRow row = dgvRecentRservation.Rows[e.RowIndex];

                string info =
                    "Reservation ID: " + row.Cells["reservation_id"].Value.ToString() + "\n" +
                    "Room: " + row.Cells["room_number"].Value.ToString() + "\n" +
                    "Check-in: " + row.Cells["check_in"].Value.ToString() + "\n" +
                    "Check-out: " + row.Cells["check_out"].Value.ToString() + "\n" +
                    "Status: " + row.Cells["status"].Value.ToString();

                MessageBox.Show(info, "Reservation Details",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
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

        private void btnViewQRCode_Click(object sender, EventArgs e)
        {

        }

        private void UserDashboard_Load_1(object sender, EventArgs e)
        {

        }
    }
}