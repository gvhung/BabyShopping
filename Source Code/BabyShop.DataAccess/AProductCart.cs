using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using BabyShop.Data;

namespace BabyShop.DataAccess
{
    public class AProductCart
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd1 = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        Connection connection;
        public AProductCart()
        {
            connection = new Connection();
            con = connection.Returnconnection();
        }
        public bool InsertProductCart(EShoppingCart product)
        {
            int Success = 0;
            bool status = false;
            try
            {
                con.Open();
                cmd.CommandText = "SP_InsertProductCart";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@productId", product.ShoppingCartProductKId);
                cmd.Parameters.AddWithValue("@quantity", product.ShoppingCartQuantity);
                cmd.Parameters.AddWithValue("@price", product.ShoppingCartProductPrice);
                cmd.Parameters.AddWithValue("@shoppingId", product.ShoppingCartId);
                SqlParameter param = new SqlParameter();
                param = cmd.Parameters.AddWithValue("@returnvalue", DbType.Int32);
                param.Direction = ParameterDirection.Output;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                Success = (int)cmd.Parameters["@returnvalue"].Value;
                if (Success > 0)
                {
                    status = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return status;
        }
        public List<EShoppingCart> GetShoppingCartIteim(string CartId)
        {
            List<EShoppingCart> productCartList = new List<EShoppingCart>();
            EShoppingCart productCart;
            try
            {
                con.Open();
                cmd.CommandText = "SP_GetProductCartDetail";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@shoppingId", CartId);
                cmd.Connection = con;
                da.SelectCommand = cmd;
                ds = new DataSet();
                da.Fill(ds, "productCart");
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        productCart = new EShoppingCart();
                        productCart.ProductCategoryName = dr["ProductCategoryName"].ToString();
                        productCart.ShoppingCartProductKId = Convert.ToInt16(dr["ProductCartKId"].ToString());
                        productCart.ProductImageURL = dr["ProductImageURL"].ToString();
                        productCart.ShoppingCartQuantity = Convert.ToInt16(dr["ProductCartQuantity"].ToString());
                        productCart.ShoppingCartProductPrice = Convert.ToDecimal(dr["ProductCartPrice"].ToString());
                        productCartList.Add(productCart);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return productCartList;
        }
        public bool DeleteShoppingCart(int productCartId)
        {
            int Success = 0;
            bool status = false;
            try
            {
                con.Open();
                cmd.CommandText = "SP_DeleteShoppingCart";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@productCartId", productCartId);
                SqlParameter param = new SqlParameter();
                param = cmd.Parameters.AddWithValue("@returnvalue", DbType.Int32);
                param.Direction = ParameterDirection.Output;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                Success = (int)cmd.Parameters["@returnvalue"].Value;
                if (Success > 0)
                {
                    status = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return status;
        }
        public int CountShoppingCartItems(string cartId)
        {
            int Success = 0;
            int Status = 0;
            try
            {
                con.Open();
                cmd.CommandText = "SP_GetShoppingCartItems";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cartId", cartId);
                SqlParameter param = new SqlParameter();
                param = cmd.Parameters.AddWithValue("@returnvalue", DbType.Int16);   
                param.Direction = ParameterDirection.Output;
                cmd.Connection = con;
                Success = (int)cmd.ExecuteScalar();
                Status=Convert.ToInt16(cmd.Parameters["@returnvalue"].Value);
                if (Status < 0)
                {
                    Success = 0;
                }
            }
            catch (Exception ex)
            {
                return 0;
                throw ex;  
            }
            finally
            {
                con.Close();
            }
            return Success;
        }
    }
}
