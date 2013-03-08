#region Using directives

using System;

#endregion

namespace BabyShop.CommonLayer.DataTransferObjects
{
    public class ProductCartDTO
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Guid CartId { get; set; }
        public string CategoryName { get; set; }
        public string ImageURL { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Guid ModifiedBy { get; set; }
    }
}