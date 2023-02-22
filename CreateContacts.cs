using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class CreateContacts
    {
       
        

            public string FirstName;
            public string LastName;
            public string Address;
            public string City;
            public int Pincode;
            public string State;
            public long PhoneNumber;
            public string Email;

            public CreateContacts(string fname, string lname, string address, string city, int pincode, string state, long phone, string email)
            {
                this.FirstName = fname;
                this.LastName = lname;
                this.Address = address;
                this.City = city;
                this.Pincode = pincode;
                this.State = state;
                this.PhoneNumber = phone;
                this.Email = email;

                Console.WriteLine("First Name : " + FirstName);
                Console.WriteLine("Last Name : " + LastName);
                Console.WriteLine("Address : " + Address);
                Console.WriteLine("City Name : " + City);
                Console.WriteLine("Pincode : " + Pincode);
                Console.WriteLine("State : " + State);
                Console.WriteLine("Phone Number : " + PhoneNumber);
                Console.WriteLine("Email : " + Email);

            }
        }
    }


