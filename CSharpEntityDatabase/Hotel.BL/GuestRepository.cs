using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEntityDatabase.Hotel.BL
{
    public class GuestRepository
    {


        public IEnumerable GetAllGuests()
        {

            using (var context = new HotelDBEntities())
            {
                var alldata = from g in context.Guests
                    //where g.GuestID.Equals(1)
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


        

        


    }
}