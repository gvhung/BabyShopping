using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BabyShop.Data;
using BabyShop.DataAccess;

namespace BabyShop.Manager
{
   public class MProductCart:IDisposable
    {

        public void Dispose()
        {
            throw new NotImplementedException();
        }
        public bool InsertProductCart(EShoppingCart product)
        {
            AProductCart AL = new AProductCart();
            bool status = false;
            try
            {
                status = AL.InsertProductCart(product);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return status;
        }

        public List<EShoppingCart> GetShoppingCartIteim(string CartId)
        {
            AProductCart AL = new AProductCart();
            List<EShoppingCart> productCartList = new List<EShoppingCart>();
            productCartList = AL.GetShoppingCartIteim(CartId);
            return productCartList;
        }

        public bool DeleteShoppingCart(int productCartId)
        {
            AProductCart AL = new AProductCart();
            bool status = false;
            status = AL.DeleteShoppingCart(productCartId);
            return status;
        }

        public int CountShoppingCartItems(string userId)
        {
            AProductCart AL = new AProductCart();
            int cartCount = 0;
            cartCount = AL.CountShoppingCartItems(userId);
            return cartCount;
        }
    }
}
