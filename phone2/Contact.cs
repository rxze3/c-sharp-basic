namespace Phone
{
    public class Contact : IContact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public List<string> SmsHistory { get; private set; } = new List<string>();// SMS history collection
        public List<DateTime> CallHistory { get; private set; } = new List<DateTime>();// Calls history collection

        public Contact(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public void SendSms(string message)
        {
            SmsHistory.Add($"{DateTime.Now}: {message}");
            Console.WriteLine($"SMS was send: {Name} ({PhoneNumber}): {message}");
        }

        public void Calling()
        {
            CallHistory.Add(DateTime.Now);
            Console.WriteLine($"Calling: {Name} ({PhoneNumber})...");
        }

        public void ShowSmsHistory()
        {
            Console.WriteLine($"\nSMS history for {Name}:");
            foreach (var sms in SmsHistory)
            {
                Console.WriteLine(sms);
            }
        }

        public void ShowCallHistory()
        {
            Console.WriteLine($"\nCalls history for {Name}:");
            foreach (var call in CallHistory)
            {
                Console.WriteLine(call);
            }
        }
    }
}
