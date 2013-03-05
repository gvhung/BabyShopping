using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BabyShop.Models
{
    public class ProductCartModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string UserId { get; set; }
        public int Quantity { get; set; }
        public int OrderNumber { get; set; }
        public decimal CartPrice { get; set; }
        public string ImageURL { get; set; }
        public string CategoryName { get; set; }
    }
}