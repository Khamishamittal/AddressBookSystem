using static AddressBookSystem.EditContacts;

namespace AddressBookSystem
{
    public class AddressBook
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            EditContacts person = new EditContacts();

            person.AddDetails();



            person.editContact();
            person.ListingPeople();
        }
    }
}
