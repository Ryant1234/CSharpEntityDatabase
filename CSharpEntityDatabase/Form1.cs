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
    public partial class Form1 : Form
    {
        private DateTime BookingFrom;
        private DateTime BookingTo;


        public Form1()
        {
        
            InitializeComponent();
            var guestRepository = new GuestRepository();
            dgvGuests.DataSource = guestRepository.GetAllGuests();
        }

        private void btnNewGuest_Click(object sender, EventArgs e)
        {
            GuestRepository guestRepository = new GuestRepository();
            guestRepository.InsertGuest(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtSuburb.Text,
                txtProvinceState.Text,
                txtCountry.Text, txtPhoneNumber.Text);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            var guestRepository = new GuestRepository();
          

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnNewBooking_Click(object sender, EventArgs e)
        { // NEED TO CLEAN UP??????

            var bookingRepository = new BookingRepository();
            // guestId is the value of the guestID column in the selected row  on the dgvGuests DataGridview    
            var guestId = int.Parse(dgvGuests.SelectedRows[0].Cells[0].Value.ToString()); 
            var roomId = int.Parse(dgvRooms.SelectedRows[0].Cells[0].Value.ToString());
            var bookingFrom = dtBookingFrom.Value;
            var bookingTo = dtBookingTo.Value;



            bookingRepository.NewBooking(guestId, roomId,  bookingFrom, bookingTo) ;
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            var bookingRepository = new BookingRepository();
            dgvBooking.DataSource = bookingRepository.GetAllBookingsSortedByName();
        }

        private void btnNewRoom_Click(object sender, EventArgs e)
        {
            var roomRepository = new RoomRepository();
            roomRepository.InsertRooms();
        }

        private void btnGetRooms_Click(object sender, EventArgs e)
        {
            var roomRepository = new RoomRepository();
            dgvRooms.DataSource = roomRepository.GetRooms();
        }

        private void dtBookingFrom_ValueChanged(object sender, EventArgs e)
        {
            // NEED TO CLEAN UP
            if (dtBookingFrom.Value >=dtBookingTo.Value)
            {
                dtBookingTo.Value = dtBookingFrom.Value.Date.AddDays(1); 

            
              var bookingRepository = new BookingRepository();
                dgvRooms.DataSource = bookingRepository.BookingConflict(dtBookingFrom.Value, dtBookingTo.Value);
            }

       


         var br = new BookingRepository();
            dgvRooms.DataSource = br.BookingConflict(BookingFrom.Date, BookingTo.Date);

        }

        private
            void dtBookingTo_ValueChanged (object sender, EventArgs e)
                { // NEED TO CLEAN UP
            if (dtBookingTo.Value <= dtBookingFrom.Value)
            {

                dtBookingFrom.Value = dtBookingTo.Value.AddDays(-1);
                BookingTo = dtBookingTo.Value;

               var bookingRepository = new BookingRepository();
                dgvRooms.DataSource = bookingRepository.BookingConflict(dtBookingFrom.Value, dtBookingTo.Value);
            }

            if (dtBookingTo.Value == dtBookingFrom.Value)
            {
                dtBookingFrom.Value = dtBookingTo.Value.AddDays(1);
                BookingTo = dtBookingTo.Value;

                var bookingRepository = new BookingRepository();
                dgvRooms.DataSource = bookingRepository.BookingConflict(dtBookingFrom.Value, dtBookingTo.Value);
            }

            var br = new BookingRepository();
            dgvRooms.DataSource = br.BookingConflict(dtBookingFrom.Value, dtBookingTo.Value);
        }

        private void btnCheckBooking_Click(object sender, EventArgs e)
        {
            var bookingRepository = new BookingRepository();
            dgvRooms.DataSource = bookingRepository.BookingConflict(dtBookingFrom.Value, dtBookingTo.Value);
        }
    }
        }
    

    

