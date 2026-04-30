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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadReservations(); // same idea as user dashboard
        }

        // ==========================================
        // LOAD ALL RESERVATIONS (ADMIN VIEW)
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
        // COUNT STATUS (ADMIN CARDS)
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
        // VIEW QR BUTTON
        // ==========================================
        private void btnViewQRCode_Click(object sender, EventArgs e)
        {
            MyQRCode qr = new MyQRCode();
            qr.Show();
        }

        // ==========================================
        // OPTIONAL: OPEN RESERVATION FORM
        // ==========================================
        private void btnReservation_Click(object sender, EventArgs e)
        {
            CustomerBookRoom form = new CustomerBookRoom();
            form.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvRecentRservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}