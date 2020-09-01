using System;

namespace class_associations
{
    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
            System.Console.WriteLine("Here's the voucher");
        }
    }
}