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
    public partial class DeleteBookingForm : Form
    {
        public DeleteBookingForm()
        {
            InitializeComponent();
            var bookingRepository = new BookingRepository();
            dgvBookings.DataSource = bookingRepository.GetAllBookings();
        }

        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            var bookingRepository = new BookingRepository();
            var bookingId = int.Parse(dgvBookings.SelectedRows[0].Cells[0].Value.ToString());
            bookingRepository.DeleteBooking(bookingId);
          this.Close();
           
        }
    }
}
