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
        public bool AddSingleBed = false;
       public bool AddBunkBed = false;
        public int RoomTypePrice;
        public int ExtraSingleBed = 50;
        public int ExtraBunkBed = 80;
        private int RoomPriceTotal;
        // Problems....
        // DGV ROOMS Can select multiple rows at once, have to use cell click, 
        public BookingForm()
        {
            InitializeComponent();
            var guestRepository = new GuestRepository();
            dgvGuests.DataSource = guestRepository.GetAllGuests();
            btnBooking.Enabled = false;
        }

        /// <summary>
        /// When the User clicks on 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvNewBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {     
     

        }

        /// <summary>
        /// The button for making a booking. More details inside. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {


            // If the User wants a Single Bed added to their Room
            if (AddSingleBed == true)

            {
                var bookingRepository = new BookingRepository();
              
                var guestId = int.Parse(dgvGuests.SelectedRows[0].Cells[0].Value.ToString());
                var roomId = int.Parse(dgvRooms.SelectedRows[0].Cells[0].Value.ToString());
                var bookingFrom = dtBookingFrom.Value;
                var bookingTo = dtBookingTo.Value;
                var addedBedType = "Extra Single Bed";


                bookingRepository.NewBooking(guestId, roomId, bookingFrom, bookingTo, addedBedType, RoomPriceTotal);
                
                MessageBox.Show("Booking has been made for room " + roomId + " for " + bookingFrom + " to " + bookingTo + " with a " + addedBedType);
                AddSingleBed = false;
            }

            // If the User wants a Bunk Bed added to their Room
            if (AddBunkBed == true)
            {
                var bookingRepository = new BookingRepository();
                var invoiceRepository = new InvoiceRepository();
                var guestId = int.Parse(dgvGuests.SelectedRows[0].Cells[0].Value.ToString());
                var roomId = int.Parse(dgvRooms.SelectedRows[0].Cells[0].Value.ToString());
                var bookingFrom = dtBookingFrom.Value;
                var bookingTo = dtBookingTo.Value;
                var addedBedType = "Extra Bunk Bed";


                bookingRepository.NewBooking(guestId, roomId, bookingFrom, bookingTo, addedBedType, RoomTypePrice);

                MessageBox.Show("Booking has been made for room " + roomId + " for " + bookingFrom + " to " + bookingTo + " with a " + addedBedType);
                AddBunkBed = false;
            }

            else
            // else they haven't added an extra Bed
            {
                var bookingRepository = new BookingRepository();
                var invoiceRepository = new InvoiceRepository();   
                var guestId = int.Parse(dgvGuests.SelectedRows[0].Cells[0].Value.ToString());
                var roomId = int.Parse(dgvRooms.SelectedRows[0].Cells[0].Value.ToString());
                var bookingFrom = dtBookingFrom.Value;
                var bookingTo = dtBookingTo.Value;
                var addedBedType = "None";


                bookingRepository.NewBooking(guestId, roomId, bookingFrom, bookingTo, addedBedType, RoomPriceTotal);

                MessageBox.Show("Booking has been made for room " + roomId + " for " + bookingFrom + " to " + bookingTo);
            }
        }


      
          // More details inside
        private void dtBookingFrom_ValueChanged(object sender, EventArgs e)
        {
            // If the DateTime we have selected is greater or equal to the bookingTo date
            if (dtBookingFrom.Value >= dtBookingTo.Value)
            {
                // Set the bookingTo date to 1 day greater then the bookingFrom date
                dtBookingTo.Value = dtBookingFrom.Value.Date.AddDays(1);


                var bookingRepository = new BookingRepository();
                dgvRooms.DataSource = bookingRepository.BookingConflict(dtBookingFrom.Value, dtBookingTo.Value);
            }

            // Otherwise check to see if we have a conflict with the dates selected


            var br = new BookingRepository();
            dgvRooms.DataSource = br.BookingConflict(dtBookingFrom.Value, dtBookingTo.Value);
        }


        // More details inside
        private void dtBookingTo_ValueChanged(object sender, EventArgs e)
        {
            {
                // If the bookingTo date is earlier then the bookingFrom date
                if (dtBookingTo.Value <= dtBookingFrom.Value)
                {
                    // Set the bookingFrom date to 1 day earlier then the bookingTo Date
                    dtBookingFrom.Value = dtBookingTo.Value.AddDays(-1);
                    //    BookingTo = dtBookingTo.Value;

                    var bookingRepository = new BookingRepository();
                    dgvRooms.DataSource = bookingRepository.BookingConflict(dtBookingFrom.Value, dtBookingTo.Value);
                }

                //if (dtBookingTo.Value == dtBookingFrom.Value)
                //{
                //    dtBookingFrom.Value = dtBookingTo.Value.AddDays(1);
                //    //  BookingTo = dtBookingTo.Value;

                //    var bookingRepository = new BookingRepository();
                //    dgvRooms.DataSource = bookingRepository.BookingConflict(dtBookingFrom.Value, dtBookingTo.Value);
                //}


                // If the dates are fine check against booked rooms. 
                var br = new BookingRepository();
                dgvRooms.DataSource = br.BookingConflict(dtBookingFrom.Value, dtBookingTo.Value);
            }
        }


        private void dgvRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        /// <summary>
        /// Fills the cbExtraBeds ComboBox based upon the value in the cell.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            cbExtraBeds.Items.Clear();
            
            var roomType = dgvRooms.SelectedRows[0].Cells[1].Value.ToString();

            switch (roomType)
            {
                case "Single Room":
                 FillComboBoxShowRoomPrice(roomType);

                    break;

                case "Double Room":
                    FillComboBoxShowRoomPrice(roomType);

                    break;

                case "Twin Room":
                    FillComboBoxShowRoomPrice(roomType);
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

            invoicerepository.NewInvoice(guestId, bookingId, RoomPriceTotal);
        
        }

        private void btnGetInvoices_Click(object sender, EventArgs e)
        {
            var invoicerepositrory = new InvoiceRepository();
            dataGridView1.DataSource = invoicerepositrory.GetLastBooking();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var bookingRepository = new BookingRepository();
            dataGridView1.DataSource = bookingRepository.GetAllBookings();
        }



        /// <summary>
        /// This is used for selecting Beds to add to the Room (Beds to add are based upon the Room type selected) 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbExtraBeds_SelectedIndexChanged(object sender, EventArgs e)
        {
           lbCharge.Items.Clear();
            switch (cbExtraBeds.Text)
            {
                case "Extra Single Bed":
                    RoomPriceTotal = ExtraSingleBed + RoomTypePrice;
                    AddSingleBed = true;
                    lbCharge.Items.Add("The room price is $" + RoomTypePrice +  " + $" + ExtraSingleBed + " for the extra bed, total is $" + (RoomPriceTotal));
                        
                    break;

                case "Extra Bunk Bed":
                    RoomPriceTotal = ExtraBunkBed + RoomTypePrice;
                    AddBunkBed = true;
                    lbCharge.Items.Add("The room price is $" + RoomTypePrice + " + $" + ExtraBunkBed + " for the extra BunkBed, total is $" + (RoomPriceTotal)
);

                    break;

              
            }
        }


        /// <summary>
        /// This method fills the Combo box based upon what Room Type the Guest wants. 
        /// </summary>
        /// <param name="roomType"></param>
        public void FillComboBoxShowRoomPrice(string roomType)
        {
            switch (roomType)
            {
                case "Single Room":
                    lbCharge.Items.Clear();
                    RoomTypePrice = 70;
                    lbCharge.Items.Add(roomType + " is $" + RoomTypePrice);

                    break;

                case "Double Room":
                    cbExtraBeds.Items.Add("Extra Single Bed");
                    cbExtraBeds.Items.Add("Extra Bunk Bed");
                    lbCharge.Items.Clear();
                    RoomTypePrice = 100;
                    lbCharge.Items.Add(roomType + " is $" + RoomTypePrice);
                    break;

                case "Twin Room":
                    cbExtraBeds.Items.Add("Extra Single Bed");
                    lbCharge.Items.Clear();
                    RoomTypePrice = 110;
                    lbCharge.Items.Add(roomType + " is $" + RoomTypePrice);
                    break;
            }


        }

        private void cbExtraBeds_MouseClick(object sender, MouseEventArgs e)
        {
            btnBooking.Enabled = true;
        }

        /// <summary>
        ///  When the User clicks a Cell in the dgvGuests a Messagebox pops up to show what Guest has been selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvGuests_CellClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
