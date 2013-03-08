using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BabyShop.CommonLayer.DataTransferObjects
{
    public class ProductDTO
    {
        public int ProductKId
        {
            get;
            set;
        }
        public int ProductCategoryKId
        {
            get;
            set;
        }
        public string ProductCategoryName
        {
            get;
            set;
        }
        public decimal ProductCode
        {
            get;
            set;
        }
        public decimal ProductPrice
        {
            get;
            set;
        }
        public string ProductImageURL
        {
            get;
            set;
        }
    }
}
