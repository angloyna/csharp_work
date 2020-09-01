namespace class_associations
{
    public class Vehicle
    {
        private string _registration_number;
        public Vehicle(string registrationNumber)
        {
            System.Console.WriteLine("Vehicle is being initialized");
            _registration_number = registrationNumber;
            
        }
    }
}