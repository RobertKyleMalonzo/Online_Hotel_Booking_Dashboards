namespace Online_Hotel_Booking_Dashboards
{
    partial class RoomStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomStatus));
            panel2 = new Panel();
            panel1 = new Panel();
            button5 = new Button();
            label1 = new Label();
            btnReports = new Button();
            pictureBox6 = new PictureBox();
            btnUsers = new Button();
            btnReservation = new Button();
            btnRooms = new Button();
            label7 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel4 = new Panel();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(241, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(894, 96);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnReports);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(btnUsers);
            panel1.Controls.Add(btnReservation);
            panel1.Controls.Add(btnRooms);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 624);
            panel1.TabIndex = 6;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(16, 543);
            button5.Name = "button5";
            button5.Size = new Size(200, 50);
            button5.TabIndex = 15;
            button5.Text = "➜]  Logout";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(124, 57);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 19;
            label1.Text = "Dashboard";
            // 
            // btnReports
            // 
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(16, 291);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(200, 50);
            btnReports.TabIndex = 18;
            btnReports.Text = "📜 Room Status";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(16, 23);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(78, 65);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 16;
            pictureBox6.TabStop = false;
            // 
            // btnUsers
            // 
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsers.ForeColor = Color.White;
            btnUsers.Location = new Point(16, 235);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(226, 50);
            btnUsers.TabIndex = 13;
            btnUsers.Text = "🗓️ Check-In/ Check-out";
            btnUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnUsers.UseVisualStyleBackColor = true;
            // 
            // btnReservation
            // 
            btnReservation.FlatAppearance.BorderSize = 0;
            btnReservation.FlatStyle = FlatStyle.Flat;
            btnReservation.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnReservation.ForeColor = Color.White;
            btnReservation.Location = new Point(16, 179);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(200, 50);
            btnReservation.TabIndex = 12;
            btnReservation.Text = "📅  Reservation";
            btnReservation.TextAlign = ContentAlignment.MiddleLeft;
            btnReservation.UseVisualStyleBackColor = true;
            // 
            // btnRooms
            // 
            btnRooms.FlatAppearance.BorderSize = 0;
            btnRooms.FlatStyle = FlatStyle.Flat;
            btnRooms.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRooms.ForeColor = Color.White;
            btnRooms.Location = new Point(16, 123);
            btnRooms.Name = "btnRooms";
            btnRooms.Size = new Size(200, 50);
            btnRooms.TabIndex = 11;
            btnRooms.Text = "🏠 Dashboard";
            btnRooms.TextAlign = ContentAlignment.MiddleLeft;
            btnRooms.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(105, 32);
            label7.Name = "label7";
            label7.Size = new Size(126, 25);
            label7.TabIndex = 10;
            label7.Text = "Hotel System";
            // 
            // panel3
            // 
            panel3.Controls.Add(label8);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(273, 112);
            panel3.Name = "panel3";
            panel3.Size = new Size(830, 482);
            panel3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(51, 32);
            label2.Name = "label2";
            label2.Size = new Size(172, 31);
            label2.TabIndex = 0;
            label2.Text = "ROOM STATUS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(40, 167, 69);
            label3.Location = new Point(423, 65);
            label3.Name = "label3";
            label3.Size = new Size(99, 23);
            label3.TabIndex = 1;
            label3.Text = "● Available";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(220, 53, 69);
            label4.Location = new Point(528, 65);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 2;
            label4.Text = "● Occupied";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(253, 126, 20);
            label5.Location = new Point(634, 65);
            label5.Name = "label5";
            label5.Size = new Size(95, 23);
            label5.TabIndex = 3;
            label5.Text = "● Cleaning";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(108, 117, 125);
            label6.Location = new Point(735, 65);
            label6.Name = "label6";
            label6.Size = new Size(127, 23);
            label6.TabIndex = 4;
            label6.Text = "● Maintenance";
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox1);
            panel4.Location = new Point(19, 49);
            panel4.Name = "panel4";
            panel4.Size = new Size(201, 125);
            panel4.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.MidnightBlue;
            label8.Location = new Point(19, 12);
            label8.Name = "label8";
            label8.Size = new Size(153, 25);
            label8.TabIndex = 1;
            label8.Text = "Room Overview";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // RoomStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 606);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "RoomStatus";
            Text = "RoomStatus";
            Load += RoomStatus_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel1;
        private Button button5;
        private Label label1;
        private Button btnReports;
        private PictureBox pictureBox6;
        private Button btnUsers;
        private Button btnReservation;
        private Button btnRooms;
        private Label label7;
        private Panel panel3;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label8;
        private Panel panel4;
        private PictureBox pictureBox1;
    }
}