using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var  person = new Person(new DateTime(1982, 2, 6));
            System.Console.WriteLine(person.Age);
            person.Name = "Angela";
            person.Introduce("Mosh");

            var otherPerson = Person.Parse(new DateTime(1992, 7, 23), "Peter");
            otherPerson.Introduce("Mosh");

            var customer = new Customer(1, "John");
            System.Console.WriteLine(customer.Id);
            System.Console.WriteLine(customer.Name);
            var order = new Order();
            customer.Orders.Add(order);
            foreach (var ord in customer.Orders)
            {
                System.Console.WriteLine("order: " + ord);
            }

            var otherCustomer = new Customer
                {
                    Id = 45,
                    Name = "Angela Gloyna"
                };

            System.Console.WriteLine(otherCustomer.Name);

            System.Console.WriteLine(Calculator.Add(new int[]{ 4, 5, 6, 9 }));
            System.Console.WriteLine(Calculator.Add(1, 2, 4, 5));
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                System.Console.WriteLine("x: {0}, y: {1}", point.X, point.Y);

                point.Move(100, 200);
                System.Console.WriteLine("x: {0}, y: {1}", point.X, point.Y);
            } catch (Exception)
            {
                System.Console.WriteLine("An unexpected error occurred.");
            }



        }
    }
}
