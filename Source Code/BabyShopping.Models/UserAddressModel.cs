using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BabyShop.Models
{
    public class UserAddressModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int StateId { get; set; }
        public string StateName { get; set; }
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string ZipCode { get; set; }
    }
}