using System.Collections.Generic;
using BabyShop.CommonLayer.DataTransferObjects;
using BabyShop.Models;
using BabyShop.PersistenceLayer;

namespace BabyShop.BusinessLayer.Manager
{
    public class ProductManager
    {
        public IList<ProductModel> GetallProducts()
        {
            var productRepository = new ProductRepository();
            IList<ProductModel> productModelList = new List<ProductModel>();

            var productEntityList = productRepository.GetallProducts();
            AutoMapper.Mapper.Map(productEntityList, productModelList);

            return productModelList;
        }

        public IList<ProductImagesModel> GetProductImagesById(int productId)
        {
            var productRepository = new ProductRepository();
            IList<ProductImagesModel> productImageModelList = new List<ProductImagesModel>();

            var productImagesEntityList = productRepository.GetProductImagesById(productId);
            AutoMapper.Mapper.Map(productImagesEntityList, productImageModelList);

            return productImageModelList;
        }
    }
}
