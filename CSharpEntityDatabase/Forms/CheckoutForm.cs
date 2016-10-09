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

        // Because you are checking out guests you need to bring back where checkout date is nULL
        public CheckoutForm()
        {
            InitializeComponent();
            var bookingRepository = new BookingRepository();
            // This form is for checking out a Guest, so we need to load the DGV with Bookings that haven't got a checkout Date 
            dgvGuests.DataSource = bookingRepository.GetBookingsWithNoCheckoutDate();
            txtResturantBill.Enabled = false;
            txtMiniBarCharge.Enabled = false;
            btnCheckout.Enabled = false;
        }

   
    
               
        private void btnCheckoutForm_Click(object sender, EventArgs e)
        {

            if (checkboxHasPaid.Checked)

            {
                var bookingId = int.Parse(dgvGuests.SelectedRows[0].Cells[0].Value.ToString());

                int roomCharge = int.Parse(txtRoomCharge.Text);
                int minibarCharge = int.Parse(txtMiniBarCharge.Text);
                int resturantBill = int.Parse(txtResturantBill.Text);
                int totalBill = roomCharge + minibarCharge;

                bool hasPaid = true;

                int guestId = int.Parse(dgvGuests.SelectedRows[0].Cells[1].Value.ToString());

                var bookingRepository = new BookingRepository();
                bookingRepository.CheckOutGuest(bookingId, minibarCharge, resturantBill);

                var invoiceRepository = new InvoiceRepository();
                invoiceRepository.NewInvoice(guestId, bookingId, totalBill, hasPaid);
                dgvGuests.DataSource = bookingRepository.GetBookingsWithNoCheckoutDate();
                this.Close();
                return;
            }

            else
            {
                var bookingId = int.Parse(dgvGuests.SelectedRows[0].Cells[0].Value.ToString());

                int roomCharge = int.Parse(txtRoomCharge.Text);
                int minibarCharge = int.Parse(txtMiniBarCharge.Text);
                int resturantBill = int.Parse(txtResturantBill.Text);
                int totalBill = roomCharge + minibarCharge;

                bool hasPaid = false;

                int guestId = int.Parse(dgvGuests.SelectedRows[0].Cells[1].Value.ToString());

                var bookingRepository = new BookingRepository();
                bookingRepository.CheckOutGuest(bookingId, minibarCharge, resturantBill);

                var invoiceRepository = new InvoiceRepository();
                invoiceRepository.NewInvoice(guestId, bookingId, totalBill, hasPaid);
                dgvGuests.DataSource = bookingRepository.GetBookingsWithNoCheckoutDate();
                this.Close();
                return;
            }
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
    
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvGuests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
           
            
        }

        private void txtResturantBill_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalBill();
        }

        private void dgvGuests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnCheckout.Enabled = true;
                txtResturantBill.Enabled = true;
                txtMiniBarCharge.Enabled = true;
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dgvGuests.Rows[rowIndex];
                txtRoomCharge.Text = row.Cells[5].Value.ToString();

            }
            catch (Exception)
            {


            }
        }

        private void txtRoomCharge_TextChanged(object sender, EventArgs e)
        {
           
        }




        private void CalculateTotalBill()
        {
            var resturantCharge = int.Parse(txtResturantBill.Text);
            var minibarCharge = int.Parse(txtMiniBarCharge.Text);
            var roomCharge = int.Parse(txtRoomCharge.Text);
            var totalBill = resturantCharge + minibarCharge + roomCharge;
            txtTotalBill.Text = totalBill.ToString();
        }

        private void txtMiniBarCharge_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalBill();
        }
    }
}
