#region Using directives

using System;
using System.Collections.Generic;
using BabyShop.PersistenceLayer;
using BabyShop.CommonLayer.DataTransferObjects;
using BabyShop.Models;

#endregion

namespace BabyShop.BusinessLayer.Manager
{
    public class ProductCartManager : IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool InsertProductCart(ProductCartModel productCartModel)
        {
            var productCartEntity = new ProductCartDTO();
            var productCartRepository = new ProductCartRepository();

            AutoMapper.Mapper.Map(productCartModel, productCartEntity);
            bool status = productCartRepository.InsertProductCart(productCartEntity);
            
            return status;
        }

        public bool UpdateQuantityInCart(ProductCartModel productCartModel)
        {
            var productCartEntity = new ProductCartDTO();
            var productCartRepository = new ProductCartRepository();

            AutoMapper.Mapper.Map(productCartModel, productCartEntity);
            var status = productCartRepository.UpdateQuantityInCart(productCartEntity);

            return status;
        }

        public IList<ProductCartModel> GetCartItems(Guid cartId)
        {
            var productCartRepository = new ProductCartRepository();
            IList<ProductCartModel> productCartModelList = new List<ProductCartModel>();

            var productCartEntityList = productCartRepository.GetCartItems(cartId);
            AutoMapper.Mapper.Map(productCartEntityList, productCartModelList);
            
            return productCartModelList;
        }

        public bool DeleteShoppingCart(int productCartId)
        {
            var productCartRepository = new ProductCartRepository();
            bool status = productCartRepository.DeleteCartItem(productCartId);
            return status;
        }

        public int CountCartItems(Guid cartId)
        {
            var productCartRepository = new ProductCartRepository();
            return productCartRepository.CountCartItems(cartId);
        }
    }
}