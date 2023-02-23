namespace AddressBookSystem
{
    public class AddressBook
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            CreateMultipleContacts person = new CreateMultipleContacts();

            person.addContact();
            person.ListingPeople();
        }
    }
    }

