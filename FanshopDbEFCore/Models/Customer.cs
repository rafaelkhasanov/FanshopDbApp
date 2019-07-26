using System;
using System.Collections.Generic;

namespace FanshopDbEFCore
{
    public class Customer
    {
        public Customer(string firstName, string lastName, string phone, string email, DateTime? dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            DateOfBirth = dateOfBirth;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Customer() => Order = new HashSet<Order>();
        public virtual ICollection<Order> Order { get; set; }
    }
}
