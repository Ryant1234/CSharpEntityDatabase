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

namespace CSharpEntityDatabase
{
    public partial class BookingForm : Form
    {

        // Problems....
        // DGV ROOMS Can select multiple rows at once, have to use cell click, 
        public BookingForm()
        {
            InitializeComponent();
            var guestRepository = new GuestRepository();
            dgvGuests.DataSource = guestRepository.GetAllGuests();
        }

        private void dgvNewBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dgvGuests.Rows[rowIndex];
            

            var guestId = row.Cells[0].Value.ToString();
            var firstName = row.Cells[1].Value.ToString();
            var lastName = row.Cells[2].Value.ToString();
            var address = row.Cells[3].Value.ToString();
            var phoneNumber = row.Cells[7].Value.ToString();


            MessageBox.Show("The current booking is for " + firstName + " " + lastName + " who lives at " + address +
                            " and their phone number is " +
                            phoneNumber);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var bookingRepository = new BookingRepository();
            var invoiceRepository = new InvoiceRepository();
            // guestId is the value of the guestID column in the selected row  on the dgvGuests DataGridview    
            var guestId = int.Parse(dgvGuests.SelectedRows[0].Cells[0].Value.ToString());
            var roomId = int.Parse(dgvRooms.SelectedRows[0].Cells[0].Value.ToString());
            var bookingFrom = dtBookingFrom.Value;
            var bookingTo = dtBookingTo.Value;

            

            bookingRepository.NewBooking(guestId, roomId, bookingFrom, bookingTo);
   
            MessageBox.Show("Booking has been made for room " + roomId + " for " + bookingFrom + " to " + bookingTo);
            
        }

        private void dtBookingFrom_ValueChanged(object sender, EventArgs e)
        {
            // NEED TO CLEAN UP
            if (dtBookingFrom.Value >= dtBookingTo.Value)
            {
                dtBookingTo.Value = dtBookingFrom.Value.Date.AddDays(1);


                var bookingRepository = new BookingRepository();
                dgvRooms.DataSource = bookingRepository.BookingConflict(dtBookingFrom.Value, dtBookingTo.Value);
            }




            var br = new BookingRepository();
            dgvRooms.DataSource = br.BookingConflict(dtBookingFrom.Value, dtBookingTo.Value);
        }

        private void dtBookingTo_ValueChanged(object sender, EventArgs e)
        {
            {
                // NEED TO CLEAN UP
                if (dtBookingTo.Value <= dtBookingFrom.Value)
                {

                    dtBookingFrom.Value = dtBookingTo.Value.AddDays(-1);
                    //    BookingTo = dtBookingTo.Value;

                    var bookingRepository = new BookingRepository();
                    dgvRooms.DataSource = bookingRepository.BookingConflict(dtBookingFrom.Value, dtBookingTo.Value);
                }

                if (dtBookingTo.Value == dtBookingFrom.Value)
                {
                    dtBookingFrom.Value = dtBookingTo.Value.AddDays(1);
                    //  BookingTo = dtBookingTo.Value;

                    var bookingRepository = new BookingRepository();
                    dgvRooms.DataSource = bookingRepository.BookingConflict(dtBookingFrom.Value, dtBookingTo.Value);
                }

                var br = new BookingRepository();
                dgvRooms.DataSource = br.BookingConflict(dtBookingFrom.Value, dtBookingTo.Value);
            }
        }

        private void dgvRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dgvRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            cbExtraBeds.Items.Clear();
            
            var roomType = dgvRooms.SelectedRows[0].Cells[1].Value.ToString();

            switch (roomType)
            {
                case "Single Room":

            

                    break;

                case "Double Room":
                    cbExtraBeds.Items.Add("Extra Single Bed");
                    cbExtraBeds.Items.Add("Extra Bunk Bed");
                    break;

                case "Twin Room":
                    cbExtraBeds.Items.Add("Extra Single Bed");
                    break;
            }
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {

            // I want it so when you make a booking it selects the ID of the last booking made in the system and applys
            // it to a new bookingIDFK in invoice
            var bookingId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            var guestId = int.Parse(dgvGuests.SelectedRows[0].Cells[0].Value.ToString());
var invoicerepository = new InvoiceRepository();

            invoicerepository.NewInvoice(guestId, bookingId);
        
        }

        private void btnGetInvoices_Click(object sender, EventArgs e)
        {
            var invoicerepositrory = new InvoiceRepository();
            dataGridView1.DataSource = invoicerepositrory.GetLastBooking();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var bookingRepository = new BookingRepository();
            dataGridView1.DataSource = bookingRepository.GetAllBookingsSortedByName();
        }

        private void cbExtraBeds_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
