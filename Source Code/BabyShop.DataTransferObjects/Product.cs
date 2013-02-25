using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BabyShop.DataTransferObjects
{
    public class Product
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
        public int ProductCode
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
