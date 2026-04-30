namespace Online_Hotel_Booking_Dashboards
{
    partial class UserDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            panel1 = new Panel();
            pictureBox6 = new PictureBox();
            button5 = new Button();
            btnMyProfile = new Button();
            btnMyQrCode = new Button();
            btnBookRoom = new Button();
            btnMyReservation = new Button();
            label7 = new Label();
            panel2 = new Panel();
            pictureBox5 = new PictureBox();
            label2 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            lblTotalBooking = new Label();
            label3 = new Label();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            lblUpcoming = new Label();
            label4 = new Label();
            panel5 = new Panel();
            pictureBox3 = new PictureBox();
            lblCheckIn = new Label();
            label5 = new Label();
            panel6 = new Panel();
            pictureBox4 = new PictureBox();
            lblCancelled = new Label();
            label6 = new Label();
            panel7 = new Panel();
            dgvRecentRservation = new DataGridView();
            btnViewQRCode = new Button();
            label11 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentRservation).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(btnMyProfile);
            panel1.Controls.Add(btnMyQrCode);
            panel1.Controls.Add(btnBookRoom);
            panel1.Controls.Add(btnMyReservation);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(181, 565);
            panel1.TabIndex = 0;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(41, 9);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(103, 105);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 16;
            pictureBox6.TabStop = false;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(-34, 386);
            button5.Name = "button5";
            button5.Size = new Size(178, 44);
            button5.TabIndex = 15;
            button5.Text = "➜]  Logout";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // btnMyProfile
            // 
            btnMyProfile.FlatAppearance.BorderSize = 0;
            btnMyProfile.FlatStyle = FlatStyle.Flat;
            btnMyProfile.ForeColor = Color.White;
            btnMyProfile.Location = new Point(-34, 324);
            btnMyProfile.Name = "btnMyProfile";
            btnMyProfile.Size = new Size(178, 44);
            btnMyProfile.TabIndex = 14;
            btnMyProfile.Text = "👤  Profile";
            btnMyProfile.UseVisualStyleBackColor = true;
            btnMyProfile.Click += btnMyProfile_Click;
            // 
            // btnMyQrCode
            // 
            btnMyQrCode.FlatAppearance.BorderSize = 0;
            btnMyQrCode.FlatStyle = FlatStyle.Flat;
            btnMyQrCode.ForeColor = Color.White;
            btnMyQrCode.Location = new Point(-12, 261);
            btnMyQrCode.Name = "btnMyQrCode";
            btnMyQrCode.Size = new Size(178, 44);
            btnMyQrCode.TabIndex = 13;
            btnMyQrCode.Text = "⛶  My QR Code";
            btnMyQrCode.UseVisualStyleBackColor = true;
           
            // 
            // btnBookRoom
            // 
            btnBookRoom.FlatAppearance.BorderSize = 0;
            btnBookRoom.FlatStyle = FlatStyle.Flat;
            btnBookRoom.ForeColor = Color.White;
            btnBookRoom.Location = new Point(-12, 206);
            btnBookRoom.Name = "btnBookRoom";
            btnBookRoom.Size = new Size(178, 44);
            btnBookRoom.TabIndex = 12;
            btnBookRoom.Text = "🛏  Book Room";
            btnBookRoom.UseVisualStyleBackColor = true;
            btnBookRoom.Click += btnBookRoom_Click;
            // 
            // btnMyReservation
            // 
            btnMyReservation.FlatAppearance.BorderSize = 0;
            btnMyReservation.FlatStyle = FlatStyle.Flat;
            btnMyReservation.ForeColor = Color.White;
            btnMyReservation.Location = new Point(1, 149);
            btnMyReservation.Name = "btnMyReservation";
            btnMyReservation.Size = new Size(178, 44);
            btnMyReservation.TabIndex = 11;
            btnMyReservation.Text = "📅  My Reservations";
            btnMyReservation.UseVisualStyleBackColor = true;
            btnMyReservation.Click += btnMyReservation_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(41, 120);
            label7.Name = "label7";
            label7.Size = new Size(103, 23);
            label7.TabIndex = 17;
            label7.Text = "My Account";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(183, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(794, 48);
            panel2.TabIndex = 1;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(545, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(50, 40);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(601, 12);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 0;
            label2.Text = "Welcome, Customer";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(lblTotalBooking);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(243, 75);
            panel3.Name = "panel3";
            panel3.Size = new Size(156, 99);
            panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblTotalBooking
            // 
            lblTotalBooking.AutoSize = true;
            lblTotalBooking.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalBooking.Location = new Point(92, 28);
            lblTotalBooking.Name = "lblTotalBooking";
            lblTotalBooking.Size = new Size(40, 46);
            lblTotalBooking.TabIndex = 2;
            lblTotalBooking.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 3);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 1;
            label3.Text = "Total Bookings";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(lblUpcoming);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(414, 75);
            panel4.Name = "panel4";
            panel4.Size = new Size(156, 99);
            panel4.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(15, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // lblUpcoming
            // 
            lblUpcoming.AutoSize = true;
            lblUpcoming.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpcoming.Location = new Point(92, 28);
            lblUpcoming.Name = "lblUpcoming";
            lblUpcoming.Size = new Size(40, 46);
            lblUpcoming.TabIndex = 3;
            lblUpcoming.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(73, 3);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 2;
            label4.Text = "Upcoming";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(lblCheckIn);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(585, 75);
            panel5.Name = "panel5";
            panel5.Size = new Size(156, 99);
            panel5.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(17, 26);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(56, 55);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // lblCheckIn
            // 
            lblCheckIn.AutoSize = true;
            lblCheckIn.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCheckIn.Location = new Point(94, 28);
            lblCheckIn.Name = "lblCheckIn";
            lblCheckIn.Size = new Size(40, 46);
            lblCheckIn.TabIndex = 4;
            lblCheckIn.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(79, 3);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 3;
            label5.Text = "Check-in";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(pictureBox4);
            panel6.Controls.Add(lblCancelled);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(757, 75);
            panel6.Name = "panel6";
            panel6.Size = new Size(156, 99);
            panel6.TabIndex = 5;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(18, 26);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(56, 55);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // lblCancelled
            // 
            lblCancelled.AutoSize = true;
            lblCancelled.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCancelled.Location = new Point(94, 28);
            lblCancelled.Name = "lblCancelled";
            lblCancelled.Size = new Size(40, 46);
            lblCancelled.TabIndex = 5;
            lblCancelled.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(78, 3);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 4;
            label6.Text = "Cancelled";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(dgvRecentRservation);
            panel7.Controls.Add(btnViewQRCode);
            panel7.Controls.Add(label11);
            panel7.Location = new Point(214, 188);
            panel7.Name = "panel7";
            panel7.Size = new Size(731, 362);
            panel7.TabIndex = 6;
            // 
            // dgvRecentRservation
            // 
            dgvRecentRservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentRservation.Location = new Point(26, 57);
            dgvRecentRservation.Name = "dgvRecentRservation";
            dgvRecentRservation.RowHeadersWidth = 51;
            dgvRecentRservation.Size = new Size(683, 242);
            dgvRecentRservation.TabIndex = 10;
            dgvRecentRservation.CellContentClick += dgvRecentRservation_CellContentClick;
            // 
            // btnViewQRCode
            // 
            btnViewQRCode.BackColor = Color.RoyalBlue;
            btnViewQRCode.FlatAppearance.BorderSize = 0;
            btnViewQRCode.FlatStyle = FlatStyle.Flat;
            btnViewQRCode.ForeColor = Color.White;
            btnViewQRCode.Location = new Point(260, 315);
            btnViewQRCode.Name = "btnViewQRCode";
            btnViewQRCode.Size = new Size(225, 31);
            btnViewQRCode.TabIndex = 8;
            btnViewQRCode.Text = "View QR Code";
            btnViewQRCode.UseVisualStyleBackColor = false;
            btnViewQRCode.Click += btnViewQRCode_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(29, 19);
            label11.Name = "label11";
            label11.Size = new Size(159, 23);
            label11.TabIndex = 6;
            label11.Text = "Recent Reservation";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(202, 52);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(116, 20);
            label1.TabIndex = 7;
            label1.Text = "My Reservation";
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 562);
            Controls.Add(label1);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserDashboard";
            Text = "UserDashboard";
            Load += UserDashboard_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentRservation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel7;
        private Label label1;
        private Label lblTotalBooking;
        private Label lblUpcoming;
        private Label lblCheckIn;
        private Label lblCancelled;
        private Label label6;
        private Label label11;
        private Button btnViewQRCode;
        private Label label7;
        private Button button5;
        private Button btnMyProfile;
        private Button btnMyQrCode;
        private Button btnBookRoom;
        private Button btnMyReservation;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private DataGridView dgvRecentRservation;
    }
}