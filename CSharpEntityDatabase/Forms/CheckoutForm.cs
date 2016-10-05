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
    public partial class CheckoutForm : Form
    {
        public CheckoutForm()
        {
            InitializeComponent();
            var bookingRepository = new BookingRepository();
            // This form is for checking out a Guest, so we need to load the DGV with Bookings that haven't got a checkout Date 
            dgvGuests.DataSource = bookingRepository.GetBookingsWithNoCheckoutDate();
        }
   
    
               
        private void btnCheckoutForm_Click(object sender, EventArgs e)
        {
            var bookingId = int.Parse(dgvGuests.SelectedRows[0].Cells[0].Value.ToString());

            int roomCharge = int.Parse(txtRoomCharge.Text);
            int minibarCharge = int.Parse(txtMiniBarCharge.Text);
            int resturantBill = int.Parse(txtResturantBill.Text);
            int totalBill = roomCharge + minibarCharge;
            int guestId = int.Parse(dgvGuests.SelectedRows[0].Cells[1].ToString());
            var bookingRepository = new BookingRepository();
            bookingRepository.CheckOutGuest(bookingId, minibarCharge, resturantBill);
            var invoiceRepository = new InvoiceRepository();
            invoiceRepository.NewInvoice(guestId, bookingId, totalBill);
        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {

        }

        private void txtResturantBill_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtMiniBarCharge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtRoomCharge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
