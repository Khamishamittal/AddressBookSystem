

namespace AddressBookSystem
{
    public class AddressBook
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            DeleteContact person = new DeleteContact();

          
            person.addContact();

            person.deleteContact();
            person.ListingPeople();
        }
    }
}
