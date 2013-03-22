using System;

namespace BabyShop.Models
{
    public class ProductCartModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Guid CartId { get; set; }
        public string CategoryName { get; set; }
        public string ImageURL { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Price { get; set; }
        public Guid ModifiedBy { get; set; }
    }
}