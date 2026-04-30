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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Users));
            panel2 = new Panel();
            pictureBox5 = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            btnReports = new Button();
            btnPayments = new Button();
            pictureBox6 = new PictureBox();
            button5 = new Button();
            btnStaff = new Button();
            btnUsers = new Button();
            btnReservation = new Button();
            btnRooms = new Button();
            label7 = new Label();
            panel7 = new Panel();
            dgvRecentRservation = new DataGridView();
            btnViewQRCode = new Button();
            label1 = new Label();
            label8 = new Label();
            panel2.SuspendLayout();
            ((ISupportInitialize)pictureBox5).BeginInit();
            panel1.SuspendLayout();
            ((ISupportInitialize)pictureBox6).BeginInit();
            panel7.SuspendLayout();
            ((ISupportInitialize)dgvRecentRservation).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(218, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(873, 64);
            panel2.TabIndex = 4;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(610, 8);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(44, 45);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(660, 17);
            label2.Name = "label2";
            label2.Size = new Size(165, 25);
            label2.TabIndex = 0;
            label2.Text = "Welcome, Admin!";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(btnReports);
            panel1.Controls.Add(btnPayments);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(btnStaff);
            panel1.Controls.Add(btnUsers);
            panel1.Controls.Add(btnReservation);
            panel1.Controls.Add(btnRooms);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(-4, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 648);
            panel1.TabIndex = 5;
            // 
            // btnReports
            // 
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(16, 450);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(200, 46);
            btnReports.TabIndex = 18;
            btnReports.Text = "📊  Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnPayments
            // 
            btnPayments.FlatAppearance.BorderSize = 0;
            btnPayments.FlatStyle = FlatStyle.Flat;
            btnPayments.ForeColor = Color.White;
            btnPayments.Location = new Point(16, 398);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(200, 46);
            btnPayments.TabIndex = 17;
            btnPayments.Text = "💳  Payments";
            btnPayments.TextAlign = ContentAlignment.MiddleLeft;
            btnPayments.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(30, 12);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(137, 128);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 16;
            pictureBox6.TabStop = false;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(16, 502);
            button5.Name = "button5";
            button5.Size = new Size(200, 46);
            button5.TabIndex = 15;
            button5.Text = "➜]  Logout";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            // 
            // btnStaff
            // 
            btnStaff.FlatAppearance.BorderSize = 0;
            btnStaff.FlatStyle = FlatStyle.Flat;
            btnStaff.ForeColor = Color.White;
            btnStaff.Location = new Point(16, 346);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(200, 46);
            btnStaff.TabIndex = 14;
            btnStaff.Text = "👤  Staff";
            btnStaff.TextAlign = ContentAlignment.MiddleLeft;
            btnStaff.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.ForeColor = Color.White;
            btnUsers.Location = new Point(16, 294);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(200, 46);
            btnUsers.TabIndex = 13;
            btnUsers.Text = "👤  Users";
            btnUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnUsers.UseVisualStyleBackColor = true;
            // 
            // btnReservation
            // 
            btnReservation.FlatAppearance.BorderSize = 0;
            btnReservation.FlatStyle = FlatStyle.Flat;
            btnReservation.ForeColor = Color.White;
            btnReservation.Location = new Point(16, 242);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(200, 46);
            btnReservation.TabIndex = 12;
            btnReservation.Text = "📅  Reservations";
            btnReservation.TextAlign = ContentAlignment.MiddleLeft;
            btnReservation.UseVisualStyleBackColor = true;
            // 
            // btnRooms
            // 
            btnRooms.FlatAppearance.BorderSize = 0;
            btnRooms.FlatStyle = FlatStyle.Flat;
            btnRooms.ForeColor = Color.White;
            btnRooms.Location = new Point(16, 190);
            btnRooms.Name = "btnRooms";
            btnRooms.Size = new Size(200, 46);
            btnRooms.TabIndex = 11;
            btnRooms.Text = "🛏  Rooms";
            btnRooms.TextAlign = ContentAlignment.MiddleLeft;
            btnRooms.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(45, 149);
            label7.Name = "label7";
            label7.Size = new Size(103, 23);
            label7.TabIndex = 10;
            label7.Text = "My Account";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(label8);
            panel7.Controls.Add(dgvRecentRservation);
            panel7.Controls.Add(btnViewQRCode);
            panel7.Location = new Point(246, 86);
            panel7.Name = "panel7";
            panel7.Size = new Size(808, 524);
            panel7.TabIndex = 24;
            // 
            // dgvRecentRservation
            // 
            dgvRecentRservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentRservation.Location = new Point(29, 62);
            dgvRecentRservation.Name = "dgvRecentRservation";
            dgvRecentRservation.RowHeadersWidth = 51;
            dgvRecentRservation.Size = new Size(750, 396);
            dgvRecentRservation.TabIndex = 10;
            // 
            // btnViewQRCode
            // 
            btnViewQRCode.BackColor = Color.RoyalBlue;
            btnViewQRCode.FlatAppearance.BorderSize = 0;
            btnViewQRCode.FlatStyle = FlatStyle.Flat;
            btnViewQRCode.ForeColor = Color.White;
            btnViewQRCode.Location = new Point(282, 479);
            btnViewQRCode.Name = "btnViewQRCode";
            btnViewQRCode.Size = new Size(225, 31);
            btnViewQRCode.TabIndex = 8;
            btnViewQRCode.Text = "View QR Code";
            btnViewQRCode.UseVisualStyleBackColor = false;
            btnViewQRCode.Click += btnViewQRCode_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(28, 17);
            label1.Name = "label1";
            label1.Size = new Size(206, 31);
            label1.TabIndex = 2;
            label1.Text = "USERS OVERVIEW";
            label1.Click += label1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.MidnightBlue;
            label8.Location = new Point(29, 15);
            label8.Name = "label8";
            label8.Size = new Size(70, 25);
            label8.TabIndex = 11;
            label8.Text = "Users: ";
            // 
            // Users
            // 
            ClientSize = new Size(1084, 632);
            Controls.Add(panel7);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Users";
            Load += Users_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((ISupportInitialize)pictureBox5).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((ISupportInitialize)pictureBox6).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((ISupportInitialize)dgvRecentRservation).EndInit();
            ResumeLayout(false);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Users_Load(object sender, EventArgs e)
        {

        }

        private void btnViewQRCode_Click(object sender, EventArgs e)
        {

        }
    }
}
