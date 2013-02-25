using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BabyShop.Data;
using System.Data.SqlClient;
using System.Data;
namespace BabyShop.DataAccess
{
   public class AUser
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd1 = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        Connection connection;
        public AUser()
        {
            connection = new Connection();
            con = connection.Returnconnection();
        }
        public EUser ValidateUser(EUser user)
        {
            EUser userEntity=null;
            try
            {
                con.Open();
                cmd.CommandText = "SP_UserValidate";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userEmailId", user.MLoginRightsUserID);
                cmd.Parameters.AddWithValue("@userPassword", user.MLoginRightsPassword);
                cmd.Connection = con;
                da.SelectCommand = cmd;
                ds = new DataSet();
                da.Fill(ds, "user");
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        userEntity = new EUser();
                        userEntity.MLoginID = Convert.ToInt16(dr["MLoginKID"]);
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return userEntity;
        }

        public EUser GetUserDetails(int userId)
        {
            EUser userEntity = null;
            try
            {
                con.Open();
                cmd.CommandText = "SP_UserDetails";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Connection = con;
                da.SelectCommand = cmd;
                ds = new DataSet();
                da.Fill(ds, "user");
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        userEntity = new EUser();
                        userEntity.MLoginID = Convert.ToInt16(dr["MLoginKID"]);
                        userEntity.MLoginFirstName = dr["MLoginFirstName"].ToString();
                        userEntity.MLoginLastName = dr["MLoginLastName"].ToString();
                        userEntity.MLoginAddress = dr["MLoginAddress"].ToString();
                        userEntity.MLoginState = dr["MLoginState"].ToString();
                        userEntity.MLoginCountry = dr["MLoginCountry"].ToString();
                        userEntity.MLoginCity = dr["MLoginCity"].ToString();
                        userEntity.MLoginZip = dr["MLoginZip"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return userEntity;
        }

        public bool CreateUser(EUser user)
        {
            int Success = 0;
            bool status = false;
            try
            {
                con.Open();
                cmd.CommandText = "SP_CreateNewUser";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FirstName", user.MLoginFirstName);
                cmd.Parameters.AddWithValue("@LastName", user.MLoginLastName);
                cmd.Parameters.AddWithValue("@Address", user.MLoginAddress);
                cmd.Parameters.AddWithValue("@Country", user.MLoginCountry);
                cmd.Parameters.AddWithValue("@State", user.MLoginState);
                cmd.Parameters.AddWithValue("@City", user.MLoginCity);
                cmd.Parameters.AddWithValue("@UserID", user.MLoginRightsUserID);
                cmd.Parameters.AddWithValue("@Password", user.MLoginRightsPassword);
                cmd.Parameters.AddWithValue("@Zip", user.MLoginZip);
                cmd.Parameters.AddWithValue("@PrimaryPhone", user.MLoginPrimaryPhone);
                cmd.Parameters.AddWithValue("@MobilePhone", user.MLoginMobilePhone);
                cmd.Parameters.AddWithValue("@CompanyName", user.MLoginCompanyName);
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
    }
}
