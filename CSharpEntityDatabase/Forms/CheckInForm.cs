using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpEntityDatabase.Hotel.BL;

namespace CSharpEntityDatabase.Forms
{
    public partial class CheckInForm : Form
    {
        public CheckInForm()
        {
            InitializeComponent();
            var bookingRepository = new BookingRepository();
           dgvGuests.DataSource =  bookingRepository.GetBookingsWithNoCheckInDate();
        }

        private void dgvGuests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            var checkinDate = Convert.ToDateTime(dgvGuests.SelectedRows[0].Cells[4].Value);
          

            if (checkinDate > DateTime.Today)
            {
                MessageBox.Show("You are not due to check in today, please come back again on " + checkinDate.Date);
            }

            if (checkinDate < DateTime.Today)
            {
                MessageBox.Show("Your room is not available, you were meant to show up on " + checkinDate.Date);
                
            }


            if (checkinDate == DateTime.Today)
            {
                var bookingId = int.Parse(dgvGuests.SelectedRows[0].Cells[0].Value.ToString());
             
                var bookingRepository = new BookingRepository();
                bookingRepository.CheckInGuest(bookingId);
             
                dgvGuests.DataSource = bookingRepository.GetBookingsWithNoCheckInDate();
            }
            


        }
    }
}
