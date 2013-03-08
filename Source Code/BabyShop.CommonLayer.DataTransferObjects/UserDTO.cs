using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BabyShop.CommonLayer.DataTransferObjects
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public IList<UserAddressDTO> UserAddressList { get; set; }
        public string PrimaryPhone { get; set; }
        public string SecondaryPhone { get; set; }
        public string MobilePhone { get; set; }
        public string Fax { get; set; }
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
    }
}