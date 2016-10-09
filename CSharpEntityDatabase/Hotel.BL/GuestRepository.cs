using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CSharpEntityDatabase.Hotel.BL
{
    public class GuestRepository
    {

        /// <summary>
        /// Gets all the Guests in our Database.
        /// </summary>
        /// <returns></returns>
        public IEnumerable GetAllGuests()
        {

            using (var context = new HotelDBEntities())
            {
                var alldata = from g in context.Guests
                    select new

                    {
                        g.GuestID,
                        g.FirstName,
                        g.LastName,
                        g.Address,
                        g.Suburb,
                        g.Province_State,
                        g.Country,
                        g.PhoneNumber
                    };


                return alldata.ToList();


            }

        }




        /// <summary>
        /// This method inserts a guest. All the variables are associated with columns in the Guest table and need to have text.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="address"></param>
        /// <param name="suburb"></param>
        /// <param name="provincestate"></param>
        /// <param name="country"></param>
        /// <param name="phonenumber"></param>
        public void InsertGuest(string firstName, string lastName, string address, string suburb, string provincestate,
            string country, string phonenumber)
        {

           // If every textbox has text in it(spaces do not count!), insert the guest
            if (firstName.Trim().Length != 0 && lastName.Trim().Length != 0 && address.Trim().Length != 0 && suburb.Trim().Length != 0 &&
                provincestate.Trim().Length != 0 && country.Trim().Length != 0 && phonenumber.Trim().Length != 0)

            {

                using (var context = new HotelDBEntities())
                {

                    var newGuest = new Guest();

                    newGuest.FirstName = firstName;
                    newGuest.LastName = lastName;
                    newGuest.Address = address;
                    newGuest.Suburb = suburb;
                    newGuest.Province_State = provincestate;
                    newGuest.Country = country;
                    newGuest.PhoneNumber = phonenumber;

                    context.Guests.Add(newGuest);
                    context.SaveChanges();
                }

                
            }

            else
            {
                MessageBox.Show("Please fill in all textboxes!");
            }

        }


        // Ok when you delete a guest you will want to be able to save their details.. maybe pass their details to a new table in the future? 


        /// <summary>
        /// Deletes a guest permanently from the Database
        /// </summary>
        /// <param name="guestId"></param>
        public void DeleteGuest(int guestId)
        {




            using (var context = new HotelDBEntities())
            {

                var guestToDelete = new Guest
                { GuestID = guestId};





                context.Guests.Attach(guestToDelete);
                    context.Guests.Remove(guestToDelete);
                    context.SaveChanges();   
            }
        }


        /// <summary>
        /// Updates a Guest's details
        /// </summary>
        /// <param name="guestId"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="address"></param>
        /// <param name="suburb"></param>
        /// <param name="provincestate"></param>
        /// <param name="country"></param>
        /// <param name="phonenumber"></param>
        public void UpdateGuest(int guestId, string firstName, string lastName, string address, string suburb, string provincestate,
            string country, string phonenumber)

        {
            using (var context = new HotelDBEntities())
            {
                var selectedGuest = context.Guests.FirstOrDefault(g => g.GuestID == guestId);


                selectedGuest.FirstName = firstName;
                selectedGuest.LastName = lastName;
                selectedGuest.Address = address;
                selectedGuest.Suburb = suburb;
                selectedGuest.Province_State = provincestate;
                selectedGuest.Country = country;
                selectedGuest.PhoneNumber = phonenumber;

                context.SaveChanges();
            }
        }



       
}



}
