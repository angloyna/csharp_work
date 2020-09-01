namespace class_associations
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            : base(registrationNumber)
        {  
            System.Console.WriteLine("Car is being initialized");
        }
    }
}