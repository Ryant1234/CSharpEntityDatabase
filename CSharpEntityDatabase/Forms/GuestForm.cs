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
    public partial class GuestForm : Form
    {
        public GuestForm()
        {
            InitializeComponent();
        }



        // Button is used for adding a new Guest
        private void btnNewGuest_Click(object sender, EventArgs e)
        {
            var guestRepository = new GuestRepository();
            guestRepository.InsertGuest(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtSuburb.Text,
                txtProvinceState.Text,
                txtCountry.Text, txtPhoneNumber.Text);
            dgvGuests.DataSource = guestRepository.GetAllGuests();
        }


        // Button is used for deleting a Guest from the Database.   
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


       // Used for updating a Guest's details. Parameter values are based upon whats in the textboxes on this Form.
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
        
        }
        

       
        // When you click on a cell in the Guests DataGridView, that rows values are passed to the associated textboxes   
        private void dgvGuests_CellClick(object sender, DataGridViewCellEventArgs e)
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
    }
    }

