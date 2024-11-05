namespace Phone
{
    class Program
    {
        static List<Contact> contacts = new List<Contact>();
        static PhoneInfo phoneInfo;

        static void Main()
        {
            phoneInfo = new PhoneInfo("Samsung", "Blue", "+123456789123", "ABC666999");

            

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Show contact list");
                Console.WriteLine("2. Add contact");
                Console.WriteLine("3. Show phone characteristic");
                Console.WriteLine("0. Exit");

                Console.Write("Select operation: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ViewContacts();
                        break;
                    case "2":
                        AddContact();
                        break;
                    case "3":
                        phoneInfo.ShowPhoneInfo();
                        break;
                    case "0":
                        return;// exit from program
                    default:
                        Console.WriteLine("Incorrect input, try again.");
                        break;
                }
            }
        }

        static void ViewContacts()
        {
            Console.WriteLine("\nContact list:");
            for (int i = 0; i < contacts.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {contacts[i].Name} ({contacts[i].PhoneNumber})"); //sorting contacts and show they like a list
            }
            Console.WriteLine("0. Back");

            Console.Write("Select contact for action: ");
            string choice = Console.ReadLine();

            if (int.TryParse(choice, out int index) && index > 0 && index <= contacts.Count) //input to number,
                                                                                             //and check if the number is included in the number of contacts
            {
                ManageContact(contacts[index - 1]); 
            }
            else if (choice != "0")
            {
                Console.WriteLine("Incorrect input, try again.");
            }
        }

        static void AddContact()
        {
            Console.Write("\nInput contact name: ");
            string name = Console.ReadLine();

            Console.Write("Input contact number: ");
            string phoneNumber = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phoneNumber))
            {
                Console.WriteLine("Name and number can't be empty.");
                return;
            }

            contacts.Add(new Contact(name, phoneNumber));
            Console.WriteLine("Contact was added.");
        }

        static void ManageContact(Contact contact)
        {
            while (true)
            {
                Console.WriteLine($"\nContact: {contact.Name}");
                Console.WriteLine("1. SMS");
                Console.WriteLine("2. Call");
                Console.WriteLine("3. Show SMS history");
                Console.WriteLine("4. Show calls history");
                Console.WriteLine("0. Back");

                Console.Write("Select action: ");
                string action = Console.ReadLine();

                switch (action)
                {
                    case "1":
                        Console.Write("Input sms text: ");
                        string message = Console.ReadLine();
                        contact.SendSms(message); 
                        break;
                    case "2":
                        contact.Calling();        
                        break;
                    case "3":
                        contact.ShowSmsHistory();  
                        break;
                    case "4":
                        contact.ShowCallHistory(); 
                        break;
                    case "0":
                        return; // back to menu
                    default:
                        Console.WriteLine("Incorrect input, try again.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
