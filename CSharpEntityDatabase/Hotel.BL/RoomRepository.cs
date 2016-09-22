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
       public void InsertRooms()
       {
            using (var context = new HotelDBEntities())
            {

                var newRoom = new Room();
                newRoom.NumSingleBeds = 2;
                context.Rooms.Add(newRoom);
                  context.SaveChanges();
            }
        }



       public IEnumerable GetRooms()
       {
            using (var context = new HotelDBEntities())
            {
                var alldata = from r in context.Rooms
                                  //where g.GuestID.Equals(1)
                              select new

                              {
                                  r.RoomID,
                                  r.NumSingleBeds,
            

                              };


                return alldata.ToList();
            }
    }

    }
}
