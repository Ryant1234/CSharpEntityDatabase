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
    public partial class QueriesForm : Form
    {
        public QueriesForm()
        {
            InitializeComponent();
            var invoiceRepository = new InvoiceRepository();
            dgvInvoice.DataSource = invoiceRepository.GetAllInvoices();
        }

        private void tabInvoiceQueries_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var invoiceRepository = new InvoiceRepository();

            switch (cbInvoiceQueries.Text)
            {

                case "Get Unpaid Invoices":
                    dgvInvoice.DataSource = invoiceRepository.GetUnpaidInvoices();
                    break;

                case "Get Paid Invoices By Date":
                    dgvInvoice.DataSource = invoiceRepository.OrderPaidInvoicesByDate();
                    break;

                case "Get Paid Invoices":
                    dgvInvoice.DataSource = invoiceRepository.GetPaidInvoices();
                    break;

                case "Get All Invoices":
                    dgvInvoice.DataSource = invoiceRepository.GetAllInvoices();
                    break;
            }
        }

        private void cbBookingQueries_SelectedIndexChanged(object sender, EventArgs e)
        {
            var bookingRepository = new BookingRepository();

            switch (cbBookingQueries.Text)
            {

                case "Get Bookings With No Checkin Date":
                    dgvBookingQueries.DataSource = bookingRepository.GetBookingsWithNoCheckInDate();
                    break;

                case "Get Bookings With No Checkout Date":
                    dgvBookingQueries.DataSource = bookingRepository.GetBookingsWithNoCheckoutDate();
                    break;


            }
        }

        private void cbGuestQueries_SelectedIndexChanged(object sender, EventArgs e)
        {
            var guestRepository = new GuestRepository();

            switch (cbGuestQueries.Text)
            {

                case "Get All Guests":
                    dgvGuests.DataSource = guestRepository.GetAllGuests();
                    break;



            }
        }
    }
}

