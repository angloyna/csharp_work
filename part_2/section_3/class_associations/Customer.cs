using System;

namespace class_associations
{
    public class Customer
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public void Promote()
        {
            var rating = CalculateRating(excludeOrders: true);
            if (rating == 0)
            {
                System.Console.WriteLine("Promoted to Level 1");
            } else
            {
                System.Console.WriteLine("Promoted to Level 2");
            }

        }

        private int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }
}