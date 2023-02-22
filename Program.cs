namespace AddressBookSystem
{
    public class AddressBook
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            AddNewContact contact1 = new AddNewContact();

            contact1.AddDetails();
            contact1.ListingPeople();
        
    }
    }
}
