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
          dgvGuests.DataSource = guestRepository.GetAllGuests();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            var guestRepository = new GuestRepository();
          

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnNewBooking_Click(object sender, EventArgs e)
        { 
            BookingForm bookingForm = new BookingForm();
            bookingForm.Show();
         
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            var bookingRepository = new BookingRepository();
            dgvBooking.DataSource = bookingRepository.GetAllBookingsSortedByName();
        }

   

 

        private void dtBookingFrom_ValueChanged(object sender, EventArgs e)
        {
           

        }

        private
            void dtBookingTo_ValueChanged (object sender, EventArgs e)
                { 
        }

      

        private void btnDeleteGuest_Click(object sender, EventArgs e)
        {

            try
            {


                var guestId = int.Parse(lblGuestId.Text);


                var guestRepository = new GuestRepository();
                guestRepository.DeleteGuest(guestId);
                dgvGuests.DataSource = guestRepository.GetAllGuests();
            }
            catch (Exception)
            {
                
            }
    

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

       

            var guestRepository = new GuestRepository();

            guestRepository.UpdateGuest(int.Parse(lblGuestId.Text), txtFirstName.Text, txtLastName.Text,
                txtAddress.Text, txtSuburb.Text, txtProvinceState.Text, txtCountry.Text, txtPhoneNumber.Text);

            
            dgvGuests.DataSource = guestRepository.GetAllGuests();

            }
            catch (Exception)
            {

         
            }
        }

        private void dgvGuests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dgvGuests.Rows[rowIndex];

            lblGuestId.Text = row.Cells[0].Value.ToString();
            txtFirstName.Text = row.Cells[1].Value.ToString();
            txtLastName.Text = row.Cells[2].Value.ToString();
            txtAddress.Text = row.Cells[3].Value.ToString();
            txtSuburb.Text = row.Cells[4].Value.ToString();
            txtProvinceState.Text = row.Cells[5].Value.ToString();
             txtCountry.Text = row.Cells[6].Value.ToString();
            txtPhoneNumber.Text = row.Cells[7].Value.ToString();

        }

    

        private void dgvInvoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InvoiceTab_Click(object sender, EventArgs e)
        {
            var invoicerepositrory = new InvoiceRepository();
           dgvInvoices.DataSource = invoicerepositrory.GetAllInvoices();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RoomForm roomForm= new RoomForm();
            roomForm.Show();
        }

        private void btnCheckoutForm_Click(object sender, EventArgs e)
        {

        }
    }
        }
    

    

