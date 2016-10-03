using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEntityDatabase.Hotel.BL
{
   public class RoomRepository
    {
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






        public void DeleteRoom(int roomId)
        {

            using (var context = new HotelDBEntities())
            {

                var roomToDelete = new Room
                { RoomID = roomId };





                context.Rooms.Attach(roomToDelete);
                context.Rooms.Remove(roomToDelete);
                context.SaveChanges();


            }
        }



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

