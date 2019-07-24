﻿using System;

namespace FanshopDbDataAccessLibrary.BaseModels
{
    public class BaseCustomer : BaseEntity.BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}