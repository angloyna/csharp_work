using System;
using System.Collections.Generic;

namespace classes
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();

        private bool IsGoldMember = false;


        public Customer()
        {
        }

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {  
            this.Name = name; 
        }

        public void Promote()
        {
            IsGoldMember = true;
        }

    }
}