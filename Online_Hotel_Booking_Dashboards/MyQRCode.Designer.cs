namespace Online_Hotel_Booking_Dashboards
{
    partial class MyQRCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyQRCode));
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
            label4 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            button1 = new Button();
            pictureBoxQRCode = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRCode).BeginInit();
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
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(181, 565);
            panel1.TabIndex = 2;
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
            button5.Location = new Point(-34, 352);
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
            btnMyProfile.Location = new Point(-31, 301);
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
            btnMyQrCode.Location = new Point(-13, 252);
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
            btnBookRoom.Location = new Point(-13, 199);
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
            btnMyReservation.Location = new Point(0, 149);
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
            panel3.Location = new Point(184, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(794, 48);
            panel3.TabIndex = 3;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(201, 69);
            label4.Name = "label4";
            label4.Size = new Size(116, 25);
            label4.TabIndex = 4;
            label4.Text = "My QR Code";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(201, 95);
            label5.Name = "label5";
            label5.Size = new Size(322, 20);
            label5.TabIndex = 5;
            label5.Text = "Show this QR code during check-in at the hotel.";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(button1);
            panel4.Controls.Add(pictureBoxQRCode);
            panel4.Location = new Point(338, 133);
            panel4.Name = "panel4";
            panel4.Size = new Size(411, 405);
            panel4.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(30, 344);
            button1.Name = "button1";
            button1.Size = new Size(354, 47);
            button1.TabIndex = 1;
            button1.Text = "Download QR Code";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBoxQRCode
            // 
            pictureBoxQRCode.Location = new Point(30, 17);
            pictureBoxQRCode.Name = "pictureBoxQRCode";
            pictureBoxQRCode.Size = new Size(353, 283);
            pictureBoxQRCode.TabIndex = 0;
            pictureBoxQRCode.TabStop = false;
            // 
            // MyQRCode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 560);
            Controls.Add(panel4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "MyQRCode";
            Text = "MyQRCode";
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
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRCode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblUser;
        private PictureBox pictureBox5;
        private Label label2;
        private PictureBox pictureBox6;
        private Button button5;
        private Button btnMyProfile;
        private Button btnMyQrCode;
        private Button btnBookRoom;
        private Button btnMyReservation;
        private Label label7;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel4;
        private Button button1;
        private PictureBox pictureBoxQRCode;
    }
}