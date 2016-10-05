using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpEntityDatabase.Forms;
using CSharpEntityDatabase.Hotel.BL;

namespace CSharpEntityDatabase
{
    public partial class Form1 : Form
    {
      
 


        public Form1()
        {
        
            InitializeComponent();
   

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnNewBooking_Click(object sender, EventArgs e)
        { 
            BookingForm bookingForm = new BookingForm();
            bookingForm.Show();
         
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
            var checkOutForm = new CheckoutForm();
            checkOutForm.Show();


        }
    }
        }
    

    

