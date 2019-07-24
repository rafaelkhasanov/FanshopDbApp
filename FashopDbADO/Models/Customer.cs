using System;
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
    }
}