namespace Phone
{
    //information about phone
    public class PhoneInfo
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string PhoneNumber { get; set; }
        public string SerialNumber { get; set; }

        public PhoneInfo(string model, string color, string phoneNumber, string serialNumber)
        {
            Model = model;
            Color = color;
            PhoneNumber = phoneNumber;
            SerialNumber = serialNumber;
        }

        //showing phone about
        public void ShowPhoneInfo()
        {
            Console.WriteLine("\nPhone characteristic:");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Phone number: {PhoneNumber}");
            Console.WriteLine($"Serial number: {SerialNumber}");
        }
    }
}
