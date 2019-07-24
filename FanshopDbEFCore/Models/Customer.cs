using System;
using System.Collections.Generic;
using FanshopBaseData.BaseModels;

namespace FanshopDbEFCore
{
    public class Customer : BaseCustomer
    {
        public Customer(string firstName, string lastName, string phone, string email, DateTime? dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            DateOfBirth = dateOfBirth;
        }
        public Customer() => Order = new HashSet<Order>();
        public virtual ICollection<Order> Order { get; set; }
    }
}
