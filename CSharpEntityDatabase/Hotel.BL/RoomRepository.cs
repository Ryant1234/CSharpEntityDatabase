using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEntityDatabase.Hotel.BL
{
   public class RoomRepository
    {


        /// <summary>
        /// Used for inserting a new Room to the Database. 
        /// </summary>
        /// <param name="roomType"></param>
        public void InsertRooms(string roomType)
       {
            using (var context = new HotelDBEntities())
            {

                var newRoom = new Room();
                newRoom.RoomType = roomType;
                context.Rooms.Add(newRoom);
                  context.SaveChanges();
            }
        }


        /// <summary>
        /// Returns all the Rooms.
        /// </summary>
        /// <returns></returns>
       public IEnumerable GetRooms()
       {
           using (var context = new HotelDBEntities())
           {
               var alldata = from r in context.Rooms
           
                   select new

                   {
                       r.RoomID,
                       r.RoomType
                       


                   };


               return alldata.ToList();
           }

       }



        public void AddSingleBed(int roomId, int singleBedCount)

        {
            using (var context = new HotelDBEntities())
            {
                var query = from r in context.Rooms
                            where r.RoomID == roomId
                            select r;

                var room = query.First();



                room.ExtraSingleBedCount = singleBedCount;

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Used for adding 
        /// </summary>
        /// <param name="roomId"></param>
        /// <param name="doubleBedCount"></param>
        public void AddDoubleBed(int roomId, int doubleBedCount)

        {
            using (var context = new HotelDBEntities())
            {
                var query = from r in context.Rooms
                            where r.RoomID == roomId
                            select r;

                var room = query.First();



                room.ExtraDoubleBedCount = doubleBedCount;

                context.SaveChanges();
            }
        }





        /// <summary>
        /// Deletes a Room(be careful!)
        /// </summary>
        /// <param name="roomId"></param>
        public void DeleteRoom(int roomId)
        {

            using (var context = new HotelDBEntities())
            {

                //var bookingToDelete = new Booking
                //{RoomIDFK = roomId};
                //context.Bookings.Attach(bookingToDelete);
                //context.Bookings.Remove(bookingToDelete);
                //context.SaveChanges();


                var roomToDelete = new Room
                { RoomID = roomId };


                context.Rooms.Attach(roomToDelete);
                context.Rooms.Remove(roomToDelete);
                context.SaveChanges();






            }
        }


        /// <summary>
        /// Edits a Rooms details.
        /// </summary>
        /// <param name="roomId"></param>
        /// <param name="roomType"></param>
        public void EditRoom(int roomId, string roomType)

        {
            using (var context = new HotelDBEntities())
            {
                var query = from r in context.Rooms
                            where r.RoomID == roomId
                            select r;

                var room = query.First();


                room.RoomType = roomType;

                context.SaveChanges();
            }
        }





    }

    }

