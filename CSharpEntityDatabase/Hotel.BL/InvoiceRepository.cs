using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEntityDatabase.Hotel.BL
{
    public class InvoiceRepository
    {
        /// <summary>
        /// Creates a new Invoice 
        /// </summary>
        /// <param name="guestId"></param>
        /// <param name="bookingId"></param>
        public void NewInvoice(int guestId, int bookingId, int totalBill, bool hasPaid)

        {
            // If customer has paid
            if (hasPaid == true)

            using (var context = new HotelDBEntities())
            {



                var newInvoice = new Invoice();
                newInvoice.GuestIDFK = guestId;
                newInvoice.DateCreated = DateTime.Now;
                newInvoice.DatePaid = DateTime.Now;
                newInvoice.BookingIDFK = bookingId;
                newInvoice.InvoiceTotal = totalBill;
                context.Invoices.Add(newInvoice);
                context.SaveChanges();
            }
            // Otherwise
            else

                using (var context = new HotelDBEntities())
                {
                var newInvoice = new Invoice();
                newInvoice.GuestIDFK = guestId;
                newInvoice.DateCreated = DateTime.Now;
                
                newInvoice.BookingIDFK = bookingId;
                newInvoice.InvoiceTotal = totalBill;
                context.Invoices.Add(newInvoice);
                context.SaveChanges();
            }
        }
        

        /// <summary>
        /// Gets all the Invoices in the System
        /// </summary>
        /// <returns></returns>
        public IEnumerable GetAllInvoices()
        {
            using (var context = new HotelDBEntities())
            {
                var allInvoices = from i in context.Invoices
                    //where g.GuestID.Equals(1)
                    select new

                    {
                        i.InvoiceId,
                        i.GuestIDFK,
                        i.Guest.FirstName,  
                        i.DatePaid,
                          
                        i.BookingIDFK,
                        i.InvoiceTotal

                    };


                return allInvoices.ToList();


            }
        }



        public IEnumerable GetLastBooking()
        {
            using (var context = new HotelDBEntities())
            {

                var getLastBooking = from b in context.Bookings

                    select new
                    {
                        b.BookingID
                    };






                return getLastBooking.ToList();
            };
           


        }


    }
}

