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






        public void NewInvoice(int guestId, int bookingId)

        {
            // Is there an option for optional variaable?? For InvoicePaid
            using (var context = new HotelDBEntities())
            {



                var newInvoice = new Invoice();
                newInvoice.GuestIDFK = guestId;
                newInvoice.DateCreated = DateTime.Now;
                newInvoice.BookingIDFK = bookingId;
                context.Invoices.Add(newInvoice);
                context.SaveChanges();
            }
        }


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
                        i.BookingIDFK

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

