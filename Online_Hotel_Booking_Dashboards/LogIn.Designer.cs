namespace Online_Hotel_Booking_Dashboards
{
    partial class LogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            btnSignUp = new Button();
            button1 = new Button();
            chkShowPassword = new CheckBox();
            label3 = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-9, -8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(991, 550);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnSignUp);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(chkShowPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(80, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(817, 438);
            panel1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(352, 29);
            label5.Name = "label5";
            label5.Size = new Size(377, 39);
            label5.TabIndex = 22;
            label5.Text = "Online Hotel Booking Login";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(307, 227);
            label7.Name = "label7";
            label7.Size = new Size(39, 28);
            label7.TabIndex = 24;
            label7.Text = "🔐";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(312, 157);
            label6.Name = "label6";
            label6.Size = new Size(35, 28);
            label6.TabIndex = 23;
            label6.Text = "👤";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(540, 348);
            label4.Name = "label4";
            label4.Size = new Size(23, 20);
            label4.TabIndex = 21;
            label4.Text = "or";
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.FromArgb(40, 167, 69);
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.ForeColor = SystemColors.ButtonFace;
            btnSignUp.Location = new Point(352, 371);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(394, 38);
            btnSignUp.TabIndex = 20;
            btnSignUp.Text = "Sign up";
            btnSignUp.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(46, 117, 182);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(313, 297);
            button1.Name = "button1";
            button1.Size = new Size(477, 48);
            button1.TabIndex = 19;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowPassword.ForeColor = SystemColors.ButtonFace;
            chkShowPassword.Location = new Point(313, 264);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(149, 27);
            chkShowPassword.TabIndex = 18;
            chkShowPassword.Text = "Show password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(313, 201);
            label3.Name = "label3";
            label3.Size = new Size(110, 23);
            label3.TabIndex = 17;
            label3.Text = "PASSWORD:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(352, 224);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.PlaceholderText = "Enter Password";
            txtPassword.Size = new Size(438, 34);
            txtPassword.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(313, 131);
            label2.Name = "label2";
            label2.Size = new Size(65, 23);
            label2.TabIndex = 15;
            label2.Text = "EMAIL:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(352, 154);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter Email (e.g., user@gmail.com)";
            txtEmail.Size = new Size(438, 34);
            txtEmail.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(461, 68);
            label1.Name = "label1";
            label1.Size = new Size(177, 39);
            label1.TabIndex = 13;
            label1.Text = "Sign In Here";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(27, 49);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(253, 360);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 540);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "LogIn";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label4;
        private Button btnSignUp;
        private Button button1;
        private CheckBox chkShowPassword;
        private Label label3;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtEmail;
        private Label label1;
        private PictureBox pictureBox2;
    }
}
