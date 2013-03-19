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
            ProductCartDTO productCartEntity = new ProductCartDTO();
            ProductCartRepository productCartRepository = new ProductCartRepository();

            AutoMapper.Mapper.Map(productCartModel, productCartEntity);
            bool status = productCartRepository.InsertProductCart(productCartEntity);
            
            return status;
        }

        public bool UpdateQuantityInCart(ProductCartModel productCartModel)
        {
            ProductCartDTO productCartEntity = new ProductCartDTO();
            ProductCartRepository productCartRepository = new ProductCartRepository();

            AutoMapper.Mapper.Map(productCartModel, productCartEntity);
            bool status = productCartRepository.UpdateQuantityInCart(productCartEntity);

            return status;
        }

        public IList<ProductCartModel> GetCartItems(Guid cartId)
        {
            ProductCartRepository productCartRepository = new ProductCartRepository();
            IList<ProductCartModel> productCartModelList = new List<ProductCartModel>();

            IList<ProductCartDTO> productCartEntityList = productCartRepository.GetCartItems(cartId);
            AutoMapper.Mapper.Map(productCartEntityList, productCartModelList);
            
            return productCartModelList;
        }

        public bool DeleteShoppingCart(int productCartId)
        {
            ProductCartRepository productCartRepository = new ProductCartRepository();
            bool status = productCartRepository.DeleteCartItem(productCartId);
            return status;
        }

        public int CountCartItems(Guid cartId)
        {
            ProductCartRepository productCartRepository = new ProductCartRepository();
            return productCartRepository.CountCartItems(cartId);
        }
    }
}