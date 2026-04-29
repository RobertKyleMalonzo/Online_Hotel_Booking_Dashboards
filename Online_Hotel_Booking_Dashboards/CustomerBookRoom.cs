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
    public partial class CustomerBookRoom : Form
    {
        public CustomerBookRoom()
        {
            InitializeComponent();
        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            
            DateTime checkInDate;
            DateTime checkOutDate;

            if (string.IsNullOrEmpty(txtCustomerName.Text) || string.IsNullOrEmpty(txtRoomType.Text) || string.IsNullOrEmpty(txtCheckInDate.Text) || string.IsNullOrEmpty(txtCheckOutDate.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
