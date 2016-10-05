using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEntityDatabase.Hotel.BL
{
    public class BookingRepository
    {
        /// <summary>
        /// Gets all the bookings, sorted by bookingId
        /// </summary>
        /// <returns></returns>
        public IEnumerable GetAllBookings()
        {
            using (var context = new HotelDBEntities())
            {
                var alldata = from b in context.Bookings

                    select new
                    {
                        b.BookingID,
                        b.Guest.FirstName,
                        b.BookingFrom,
                        b.BookingTo,

                        b.GuestIDFK,
                        b.RoomIDFK



                    };


                return alldata.ToList();


            }

        }


        /// <summary>
        /// Makes a new booking for a Guest, the extraBed string determines if we are adding an extra Single, Double or no extra bed
        /// for the booking
        /// </summary>
        /// <param name="guestId"></param>
        /// <param name="roomId"></param>
        /// <param name="bookingFrom"></param>
        /// <param name="bookingTo"></param>
        /// <param name="extraBed"></param>
        public void NewBooking(int guestId, int roomId, DateTime bookingFrom, DateTime bookingTo, string extraBed, int roomPrice)
        {




            switch (extraBed)
            {
                case "Extra Single Bed":

                    using (var context = new HotelDBEntities())
                    {

                        var newBooking = new Booking();
                        newBooking.RoomIDFK = roomId;
                        newBooking.BookingFrom = bookingFrom;
                        newBooking.BookingTo = bookingTo;
                        newBooking.GuestIDFK = guestId;
                        newBooking.AddSingleBed = true;
                        newBooking.RoomPrice = roomPrice;
                        context.Bookings.Add(newBooking);


                        context.SaveChanges();
                    }
                    break;

                case "Extra Bunk Bed":
                    using (var context = new HotelDBEntities())
                    {



                        var newBooking = new Booking();
                        newBooking.RoomIDFK = roomId;
                        newBooking.BookingFrom = bookingFrom;
                        newBooking.BookingTo = bookingTo;
                        newBooking.GuestIDFK = guestId;
                        newBooking.RoomPrice = roomPrice;
                        newBooking.AddBunkBed = true;
                        context.Bookings.Add(newBooking);


                        context.SaveChanges();
                    }
                    break;
                // If no extra bed has been added
                case "None":
                    using (var context = new HotelDBEntities())
                    {



                        var newBooking = new Booking();
                        newBooking.RoomIDFK = roomId;
                        newBooking.BookingFrom = bookingFrom;
                        newBooking.BookingTo = bookingTo;
                        newBooking.GuestIDFK = guestId;
                        newBooking.RoomPrice = roomPrice;
                        context.Bookings.Add(newBooking);


                        context.SaveChanges();
                    }
                    break;

            }
        }

        /// <summary>
        /// A bit misleading in a way, it just assigns a checkout date/time to the booking 
        /// </summary>
        /// <param name="bookingId"></param>
        public void CheckOutGuest(int bookingId, int miniBarCharge, int resturantBill)
        {

            using (var context = new HotelDBEntities())
            {


                var query = from b in context.Bookings
                    where b.BookingID == bookingId
                    select b;

                var booking = query.First();

                booking.MiniBar = miniBarCharge;
                booking.ResturantBill = resturantBill;
                booking.CheckoutTime = DateTime.Now;

                context.Bookings.Add(booking);

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Checks in a guest. It takes in a bookingId 
        /// </summary>
        /// <param name="bookingId"></param>
        public void CheckInGuest(int bookingId)
        {

            using (var context = new HotelDBEntities())
            {


                var query = from b in context.Bookings
                    where b.BookingID == bookingId
                    select b;

                var booking = query.First();

                booking.CheckinTime = DateTime.Now;

                context.Bookings.Add(booking);

                context.SaveChanges();
            }
        }



        /// <summary>
        /// Checks to see if there is a room already booked for the data period that is passed in
        /// </summary>
        /// <param name="newBookingDateFrom"></param>
        /// <param name="newBookingDateTo"></param>
        /// <returns></returns>
              public  dynamic BookingConflict(DateTime newBookingDateFrom, DateTime newBookingDateTo)
        {




            using (var context = new HotelDBEntities())
            {
                
                var bookedRooms = from b in context.Bookings
                    where
                      
                     
                    // Is the date period we put in
                    (b.BookingFrom >= newBookingDateFrom.Date && b.BookingTo < newBookingDateTo.Date) ||

                        (b.BookingTo > newBookingDateFrom.Date && b.BookingTo <= newBookingDateTo.Date)

                    select b.RoomIDFK;

        // Avalible rooms are the ones that aren't  equal to booked rooms 
                var availableRooms = context.Rooms.Where(r => !bookedRooms.Contains(r.RoomID)).Select(r => new
                {
                    r.RoomID,
                    r.RoomType
                
                }).ToList();

                return availableRooms;
               
            }
        }


        /// <summary>
        /// Brings back the guests that haven't checked out yet
        /// </summary>
        /// <returns></returns>
        public IEnumerable GetBookingsWithNoCheckoutDate()
        {
            using (var context = new HotelDBEntities())
            {
                var alldata = from b in context.Bookings
                                  where b.CheckoutTime == null
                              select new

                              {
                                  b.BookingID,
                                  b.Guest.FirstName,
                                  b.BookingFrom,
                                  b.BookingTo,
                               
                                  b.GuestIDFK,
                                  b.RoomIDFK



                              };


                return alldata.ToList();


            }

        }



    }


    
}



