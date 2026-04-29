using System.Text.RegularExpressions;

namespace Online_Hotel_Booking_Dashboards
{

    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            chkShowPassword.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            // Validate email and password fields//
            if (string.IsNullOrEmpty(email))
            {

                MessageBox.Show("Please enter email");
                return;
            }

            if (string.IsNullOrEmpty(password))
            {

                MessageBox.Show("Please enter password");
                return;
            }

            // Validate email format using regular expression//
            if (!Regex.IsMatch(email, pattern))
            {
                MessageBox.Show("Invalid email format.");
            }

            // Check if email and password are empty//
            if (email == "" | password == "")
            {

                MessageBox.Show("Please enter email or pasword");
                return;
            }

            // In your Login button click event

            DBConnect dB = new DBConnect();
            try
            {
                dB.Open();
                string query = "SELECT role FROM users WHERE email = @email AND password = @password";

                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, dB.Connection))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    string role = cmd.ExecuteScalar()?.ToString();

                    if (!string.IsNullOrEmpty(role))
                    {
                        // Redirect based on role
                        switch (role)
                        {
                            case "Admin":
                                AdminDashboard adminDash = new AdminDashboard();
                                adminDash.Show();
                                this.Hide();
                                break;
                            case "Staff":
                                StaffDashboard staffDash = new StaffDashboard();
                                staffDash.Show();
                                this.Hide();
                                break;
                            case "Customer":
                                UserDashboard userDash = new UserDashboard();
                                userDash.Show();
                                this.Hide();
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Error: " + ex.Message);
            }
            finally
            {
                dB.Close();
            }
        }
        

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Show or hide password based on the checkbox state//
            if (chkShowPassword.Checked)
            {

                txtPassword.PasswordChar = '\0';
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
