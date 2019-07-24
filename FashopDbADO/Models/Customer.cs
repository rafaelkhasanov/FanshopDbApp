﻿using System;
using FanshopBaseData.BaseModels;

namespace FanshopDbADO
{
    public class Customer : BaseCustomer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public Customer(string firstName, string lastName, string phone, string email, DateTime? dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            DateOfBirth = dateOfBirth;
        }
    }
}