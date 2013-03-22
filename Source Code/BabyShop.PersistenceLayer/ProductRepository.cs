using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BabyShop.CommonLayer.DataTransferObjects;

using System.Linq;
using System.Text;
using BabyShop.CommonLayer.Utilities;
using Microsoft.ApplicationBlocks.Data;

namespace BabyShop.PersistenceLayer
{
    public class ProductRepository
    {
        public IList<ProductDTO> GetallProducts()
        {
            IList<ProductDTO> productList = new List<ProductDTO>();

            using (IDataReader reader = SqlHelper.ExecuteReader(
                                            ConnectionClass.OpenConnection(),
                                            CommandType.StoredProcedure,
                                            AppConstants.GETPRODUCTS))
            {
                while (reader.Read())
                {
                    productList.Add(PopulateProduct(reader));
                }
            }
            return productList;
        }

        private static ProductDTO PopulateProduct(IDataRecord dataRecord)
        {
            return new ProductDTO
                              {
                                  Id = Convert.ToInt32(dataRecord["Id"]),
                                  ProductName = Convert.ToString(dataRecord["ProductName"]),
                                  Description = Convert.ToString(dataRecord["Description"]),
                                  Price = Convert.ToDecimal(dataRecord["Price"]),
                                  ImageURL = Convert.ToString(dataRecord["ImageURL"])
                              };
        }
    }
}
