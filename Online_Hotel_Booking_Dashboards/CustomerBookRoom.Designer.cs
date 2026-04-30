namespace Online_Hotel_Booking_Dashboards
{
    partial class CustomerBookRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerBookRoom));
            panel1 = new Panel();
            panel2 = new Panel();
            lblUser = new Label();
            pictureBox5 = new PictureBox();
            label2 = new Label();
            pictureBox6 = new PictureBox();
            button5 = new Button();
            btnMyProfile = new Button();
            btnMyQrCode = new Button();
            btnBookRoom = new Button();
            btnMyReservation = new Button();
            label7 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel4 = new Panel();
            txtGuessLimit = new TextBox();
            cmbRoomType = new ComboBox();
            dtpCheckOut = new DateTimePicker();
            dtpCheckIn = new DateTimePicker();
            txtTotalAmount = new TextBox();
            btnBookNow = new Button();
            label5 = new Label();
            label12 = new Label();
            label8 = new Label();
            label9 = new Label();
            label6 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(btnMyProfile);
            panel1.Controls.Add(btnMyQrCode);
            panel1.Controls.Add(btnBookRoom);
            panel1.Controls.Add(btnMyReservation);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(181, 565);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblUser);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(185, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(794, 48);
            panel2.TabIndex = 2;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(680, 12);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(40, 20);
            lblUser.TabIndex = 2;
            lblUser.Text = "User";
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
            label2.Size = new Size(80, 20);
            label2.TabIndex = 0;
            label2.Text = "Welcome, ";
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
            button5.Location = new Point(-28, 367);
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
            btnMyProfile.Location = new Point(-28, 309);
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
            btnMyQrCode.Location = new Point(-9, 259);
            btnMyQrCode.Name = "btnMyQrCode";
            btnMyQrCode.Size = new Size(178, 44);
            btnMyQrCode.TabIndex = 13;
            btnMyQrCode.Text = "⛶  My QR Code";
            btnMyQrCode.UseVisualStyleBackColor = true;
            btnMyQrCode.Click += btnMyQrCode_Click;
            // 
            // btnBookRoom
            // 
            btnBookRoom.FlatAppearance.BorderSize = 0;
            btnBookRoom.FlatStyle = FlatStyle.Flat;
            btnBookRoom.ForeColor = Color.White;
            btnBookRoom.Location = new Point(-9, 213);
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
            btnMyReservation.Location = new Point(3, 163);
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
            label7.TabIndex = 10;
            label7.Text = "My Account";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(183, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(794, 48);
            panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(545, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(601, 12);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 0;
            label3.Text = "Welcome, Customer";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(txtGuessLimit);
            panel4.Controls.Add(cmbRoomType);
            panel4.Controls.Add(dtpCheckOut);
            panel4.Controls.Add(dtpCheckIn);
            panel4.Controls.Add(txtTotalAmount);
            panel4.Controls.Add(btnBookNow);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(202, 120);
            panel4.Name = "panel4";
            panel4.Size = new Size(736, 351);
            panel4.TabIndex = 3;
            // 
            // txtGuessLimit
            // 
            txtGuessLimit.Location = new Point(194, 208);
            txtGuessLimit.Name = "txtGuessLimit";
            txtGuessLimit.Size = new Size(513, 27);
            txtGuessLimit.TabIndex = 19;
            // 
            // cmbRoomType
            // 
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Items.AddRange(new object[] { "Standard Room", "Suite Room", "Deluxe Room" });
            cmbRoomType.Location = new Point(194, 24);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(510, 28);
            cmbRoomType.TabIndex = 18;
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.Location = new Point(194, 148);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(510, 27);
            dtpCheckOut.TabIndex = 17;
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.Location = new Point(194, 84);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(510, 27);
            dtpCheckIn.TabIndex = 16;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new Point(194, 268);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(510, 27);
            txtTotalAmount.TabIndex = 15;
            // 
            // btnBookNow
            // 
            btnBookNow.BackColor = Color.SteelBlue;
            btnBookNow.FlatAppearance.BorderSize = 0;
            btnBookNow.FlatStyle = FlatStyle.Flat;
            btnBookNow.ForeColor = Color.White;
            btnBookNow.Location = new Point(312, 303);
            btnBookNow.Name = "btnBookNow";
            btnBookNow.Size = new Size(278, 38);
            btnBookNow.TabIndex = 13;
            btnBookNow.Text = "Book now";
            btnBookNow.UseVisualStyleBackColor = false;
            btnBookNow.Click += btnBookNow_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 271);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 12;
            label5.Text = "Total Amount:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(24, 212);
            label12.Name = "label12";
            label12.Size = new Size(130, 20);
            label12.TabIndex = 11;
            label12.Text = "Number of Guest:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(24, 151);
            label8.Name = "label8";
            label8.Size = new Size(118, 20);
            label8.TabIndex = 7;
            label8.Text = "Check-out Date:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(24, 87);
            label9.Name = "label9";
            label9.Size = new Size(108, 20);
            label9.TabIndex = 6;
            label9.Text = "Check-in Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(24, 27);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 5;
            label6.Text = "Room Type:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(188, 74);
            label4.Name = "label4";
            label4.Size = new Size(135, 31);
            label4.TabIndex = 0;
            label4.Text = "Book Room";
            // 
            // CustomerBookRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 563);
            Controls.Add(label4);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "CustomerBookRoom";
            Text = "CustomerReservation";
            Load += CustomerBookRoom_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox6;
        private Button button5;
        private Button btnMyProfile;
        private Button btnMyQrCode;
        private Button btnBookRoom;
        private Button btnMyReservation;
        private Label label7;
        private Panel panel2;
        private Label lblUser;
        private PictureBox pictureBox5;
        private Label label2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label3;
        private Panel panel4;
        private Label label4;
        private Label label12;
        private Label label8;
        private Label label9;
        private Label label6;
        private Label label5;
        private TextBox txtTotalAmount;
        private Button btnBookNow;
        private DateTimePicker dtpCheckOut;
        private DateTimePicker dtpCheckIn;
        private ComboBox cmbRoomType;
        private TextBox txtGuessLimit;
    }
}