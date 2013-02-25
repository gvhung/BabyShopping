using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BabyShop.DataTransferObjects
{
    public class ProductCart
    {
        public int ProductCartKId
        {
            get;
            set;
        }
        public int ProductCartProductKId
        {
            get;
            set;
        }
        public string ProductCartMLoginUserId
        {
            get;
            set;
        }
        public int ProductCartQuantity
        {
            get;
            set;
        }
        public int ProductCartOrderNumber
        {
            get;
            set;
        }
        public decimal ProductCartPrice
        {
            get;
            set;
        }
        public string ProductImageURL
        {
            get;
            set;
        }
        public string ProductCategoryName
        {
            get;
            set;
        }
    }
}
