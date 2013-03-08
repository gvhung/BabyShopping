#region Using directives

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BabyShop.CommonLayer.DataTransferObjects;
using BabyShop.CommonLayer.Utilities;
using Microsoft.ApplicationBlocks.Data;

#endregion

namespace BabyShop.PersistenceLayer
{
    public class ProductCartRepository
    {
        public bool InsertProductCart(ProductCartDTO productCart)
        {
            SqlParameter[] _sqlParams = new SqlParameter[]
            {
                new SqlParameter("@Id", productCart.Id),
                new SqlParameter("@ProductId", productCart.ProductId),
                new SqlParameter("@Quantity", productCart.Quantity),
                new SqlParameter("@CartId", productCart.CartId),
                new SqlParameter("@ReturnValue", SqlDbType.SmallInt)
            };

            _sqlParams[4].Direction = ParameterDirection.Output;
            SqlHelper.ExecuteNonQuery(ConnectionClass.OpenConnection(), CommandType.StoredProcedure,
                AppConstants.INSERTPRODUCTCART, _sqlParams);

            Int16 returnValue = Convert.ToInt16(_sqlParams[4].Value);
            bool status = returnValue > 0 ? true : false;
            return status;
        }

        public IList<ProductCartDTO> GetCartItems(Guid cartId)
        {
            IList<ProductCartDTO> productCartList = new List<ProductCartDTO>();
            SqlParameter _sqlParam = new SqlParameter("@CartId", cartId);

            ////Sql Object to Access DataBase and Fetch Database Values using stored procedure            
            using (IDataReader reader = SqlHelper.ExecuteReader(
                ConnectionClass.OpenConnection(), CommandType.StoredProcedure,
                AppConstants.GETPRODUCTCARTDETAILS, _sqlParam))
            {
                while (reader.Read())
                {
                    productCartList.Add(PopulateCartItems(reader));
                }
            }
            return productCartList;
        }

        private ProductCartDTO PopulateCartItems(IDataRecord dataRecord)
        {
            ProductCartDTO productCart = new ProductCartDTO();
            productCart.Id = Convert.ToInt32(dataRecord["Id"]);
            productCart.ProductId = Convert.ToInt32(dataRecord["ProductId"]);
            productCart.CartId = new Guid(Convert.ToString(dataRecord["CartId"]));
            productCart.CategoryName = Convert.ToString(dataRecord["CategoryName"]);
            productCart.ImageURL = Convert.ToString(dataRecord["ImageURL"]);
            productCart.Quantity = Convert.ToInt32(dataRecord["Quantity"]);
            productCart.Price = Convert.ToDecimal(dataRecord["Price"]);
            return productCart;
        }

        public bool DeleteCartItem(int productCartId)
        {
            SqlParameter[] _sqlParams = new SqlParameter[]
            {
                new SqlParameter("@ProductCartId", productCartId),
                new SqlParameter("@ReturnValue", SqlDbType.Bit)
            };

            _sqlParams[1].Direction = ParameterDirection.Output;
            SqlHelper.ExecuteNonQuery(ConnectionClass.OpenConnection(), CommandType.StoredProcedure,
                AppConstants.DELETECARTITEM, _sqlParams);
            
            bool isCartItemDeleted = Convert.ToBoolean(_sqlParams[1].Value);
            return isCartItemDeleted;
        }

        public int CountCartItems(Guid cartId)
        {
            SqlParameter _sqlParam = new SqlParameter("@CartId", cartId);
            int cartItems = 0;

            ////Sql Object to Access DataBase and Fetch Database Values using stored procedure            
            using (IDataReader reader = SqlHelper.ExecuteReader(
                ConnectionClass.OpenConnection(), CommandType.StoredProcedure,
                AppConstants.COUNTCARTITEMS, _sqlParam))
            {
                if (reader.Read())
                {
                    cartItems = Convert.ToInt32(reader["CartItems"]);
                }
            }
            return cartItems;
        }
    }
}