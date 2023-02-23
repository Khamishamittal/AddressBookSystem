using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class CreateMultipleContacts
    {
        
    
        
        
            public class Person
            {
                public string FirstName;
                public string LastName;
                public string PhoneNumber;
                public string Addresses;
                public string City;
                public string State;
                public string ZipCode;
                public string PhoneNum;
                public string EmailId;
            }

            public static List<Person> People = new List<Person>();

            public void addContact()
            {
                Console.Write("\nEnter number of contacts you want to add: ");
                int count = 0;

                try
                {
                    count = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


                for (int i = 0; i < count; i++)
                {
                    Person person = new Person();

                    Console.Write("\nEnter First Name: ");
                    person.FirstName = Console.ReadLine();

                    Console.Write("Enter Last Name: ");
                    person.LastName = Console.ReadLine();

                    Console.Write("Enter Address : ");
                    person.Addresses = Console.ReadLine();

                    Console.Write("Enter City : ");
                    person.City = Console.ReadLine();

                    Console.Write("Enter State : ");
                    person.State = Console.ReadLine();

                    Console.Write("Enter ZipCode: ");
                    person.ZipCode = Console.ReadLine();

                    Console.Write("Enter Phone Number: ");
                    person.PhoneNum = Console.ReadLine();

                    Console.Write("Enter EmailId: ");
                    person.EmailId = Console.ReadLine();

                    People.Add(person);
                }
            }
            public static void PrintContact(Person person)
            {
                Console.WriteLine("\nFirst Name: " + person.FirstName);
                Console.WriteLine("Last Name: " + person.LastName);
                Console.WriteLine("Phone Number: " + person.PhoneNumber);
                Console.WriteLine("Address : " + person.Addresses);
                Console.WriteLine("City : " + person.City);
                Console.WriteLine("State : " + person.State);
                Console.WriteLine("ZipCode : " + person.ZipCode);
                Console.WriteLine("Phone Number: " + person.PhoneNum);
                Console.WriteLine("EmailId: " + person.EmailId);

            }

            public void editContact()
            {
                if (People.Count != 0)
                {
                    Console.WriteLine("\nEnter the Contact FirstName to modify:");
                    string name = Console.ReadLine();

                    foreach (Person person in People)
                    {
                        if (person.FirstName.ToUpper() == name.ToUpper())
                        {
                            Console.WriteLine("\nEnter your option to modify the property: ");
                            Console.WriteLine("Enter 1 to Change First name ");
                            Console.WriteLine("Enter 2 to Change Last name ");
                            Console.WriteLine("Enter 3 to Change Phone Number ");
                            Console.WriteLine("Enter 4 to Change Address ");
                            Console.WriteLine("Enter 5 to Change City ");
                            Console.WriteLine("Enter 6 to Change State ");
                            Console.WriteLine("Enter 7 to Change Pincode ");
                            Console.WriteLine("Enter 8 to Change Email ");
                            Console.WriteLine("Enter 0 to Exit ");

                            int check = Convert.ToInt32(Console.ReadLine());

                            switch (check)
                            {
                                case 1:
                                    Console.WriteLine("\nEnter  New First Name: ");
                                    person.FirstName = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("Enter  New Last Name: ");
                                    person.LastName = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.WriteLine("Enter the New Phone Number: ");
                                    person.PhoneNum = Console.ReadLine();
                                    break;
                                case 4:
                                    Console.WriteLine("Enter the New Address: ");
                                    person.Addresses = Console.ReadLine();
                                    break;
                                case 5:
                                    Console.WriteLine("Enter the New City: ");
                                    person.City = Console.ReadLine();
                                    break;
                                case 6:
                                    Console.WriteLine("Enter the New State: ");
                                    person.State = Console.ReadLine();
                                    break;
                                case 7:
                                    Console.WriteLine("Enter the New Pin Code: ");
                                    person.ZipCode = Console.ReadLine();
                                    break;
                                case 8:
                                    Console.WriteLine("Enter New Email");
                                    person.EmailId = Console.ReadLine();
                                    break;
                                case 9:
                                    return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid First Name");
                        }
                    }
                }



            }

            public void deleteContact()
            {
                Console.WriteLine("\nEnter First Name of Contact to delete: ");

                String fname = Console.ReadLine();

                foreach (Person person in People.ToList())
                {
                    if (person.FirstName.ToUpper() == fname.ToUpper())
                    {
                        People.Remove(person);
                        Console.WriteLine("\nThe Contact is Deleted From list");
                    }
                    else
                    {
                        Console.WriteLine("Contact not found");
                    }
                }
            }

            public void ListingPeople()
            {
                if (People.Count == 0)
                {
                    Console.WriteLine("\nYour address book is empty.");
                    return;
                }
                Console.WriteLine("\nHere are the Updated list in your address book:\n");
                foreach (var person in People)
                {
                    PrintContact(person);
                }
                Console.ReadKey();



            }
        }
    }

