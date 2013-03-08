using System;
using System.Data;
using System.Data.SqlClient;
using BabyShop.CommonLayer.DataTransferObjects;
using BabyShop.CommonLayer.Utilities;
using Microsoft.ApplicationBlocks.Data;
using System.Collections.Generic;

namespace BabyShop.PersistenceLayer
{
    public class UserRepository
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd1 = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();

        public UserRepository()
        {
            con = ConnectionClass.OpenConnection();
        }

        public UserDTO ValidateUser(string userName, string password)
        {
            UserDTO userEntity = null;
            SqlParameter[] _sqlParams = new SqlParameter[]
            {
                new SqlParameter("@UserName", userName),
                new SqlParameter("@Password", password)
            };

            ////Sql Object to Access DataBase and Fetch Database Values using stored procedure            
            using (IDataReader reader = SqlHelper.ExecuteReader(
                ConnectionClass.OpenConnection(), CommandType.StoredProcedure,
                AppConstants.VALIDATEUSER, _sqlParams))
            {
                if (reader.Read())
                {
                    userEntity = PopulateUserName(reader);
                }
            }
            return userEntity;
        }

        private UserDTO PopulateUserName(IDataRecord dataRecord)
        {
            UserDTO userEntity = new UserDTO();
            userEntity.Id = Convert.ToInt32(dataRecord["UserId"]);
            userEntity.FirstName = Convert.ToString(dataRecord["FirstName"]);
            userEntity.LastName = Convert.ToString(dataRecord["LastName"]);
            return userEntity;
        }

        public UserDTO GetUserDetails(int userId)
        {
            UserDTO userEntity = null;
            SqlParameter _sqlParam = new SqlParameter("@UserId", userId);

            ////Sql Object to Access DataBase and Fetch Database Values using stored procedure            
            using (IDataReader reader = SqlHelper.ExecuteReader(
                ConnectionClass.OpenConnection(), CommandType.StoredProcedure,
                AppConstants.GETUSERDETAILS, _sqlParam))
            {
                if (reader.Read())
                {
                    userEntity = PopulateUserAddressDetails(reader);
                }
            }
            return userEntity;
        }

        private UserDTO PopulateUserAddressDetails(IDataRecord dataRecord)
        {
            UserDTO userEntity = new UserDTO();
            IList<UserAddressDTO> userAddressEntityList = new List<UserAddressDTO>();

            userEntity.Id = Convert.ToInt32(dataRecord["UserId"]);
            userEntity.FirstName = Convert.ToString(dataRecord["FirstName"]);
            userEntity.LastName = Convert.ToString(dataRecord["LastName"]);

            UserAddressDTO userAddressEntity = new UserAddressDTO();
            userAddressEntity.Address = Convert.ToString(dataRecord["Address"]);
            userAddressEntity.City = Convert.ToString(dataRecord["City"]);
            userAddressEntity.StateName = Convert.ToString(dataRecord["StateName"]);
            userAddressEntity.CountryName = Convert.ToString(dataRecord["CountryName"]);
            userAddressEntity.ZipCode = Convert.ToString(dataRecord["ZipCode"]);
            userAddressEntityList.Add(userAddressEntity);
            userEntity.UserAddressList = userAddressEntityList;
            
            return userEntity;
        }

        public bool CreateUser(UserDTO user)
        {
            int Success = 0;
            bool status = false;
            try
            {
                con.Open();
                cmd.CommandText = "SP_CreateNewUser";
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@FirstName", user.MLoginFirstName);
                //cmd.Parameters.AddWithValue("@LastName", user.MLoginLastName);
                //cmd.Parameters.AddWithValue("@Address", user.MLoginAddress);
                //cmd.Parameters.AddWithValue("@Country", user.MLoginCountry);
                //cmd.Parameters.AddWithValue("@State", user.MLoginState);
                //cmd.Parameters.AddWithValue("@City", user.MLoginCity);
                //cmd.Parameters.AddWithValue("@UserID", user.MLoginRightsUserID);
                //cmd.Parameters.AddWithValue("@Password", user.MLoginRightsPassword);
                //cmd.Parameters.AddWithValue("@Zip", user.MLoginZip);
                //cmd.Parameters.AddWithValue("@PrimaryPhone", user.MLoginPrimaryPhone);
                //cmd.Parameters.AddWithValue("@MobilePhone", user.MLoginMobilePhone);
                //cmd.Parameters.AddWithValue("@CompanyName", user.MLoginCompanyName);
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