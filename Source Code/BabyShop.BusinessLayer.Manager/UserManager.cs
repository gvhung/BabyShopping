#region Using directives

using BabyShop.CommonLayer.DataTransferObjects;
using BabyShop.PersistenceLayer;
using BabyShop.Models;

#endregion

namespace BabyShop.BusinessLayer.Manager
{
   public class UserManager
    {
       public UserModel ValidateUser(string userName, string password)
       {
           UserRepository userRepository = new UserRepository();
           UserModel userModel = new UserModel();
           
           UserDTO userEntity = userRepository.ValidateUser(userName, password);
           AutoMapper.Mapper.Map(userEntity, userModel);
           
           return userModel;
       }

        public UserModel GetUserDetails(int userId)
        {
            UserRepository userRepository = new UserRepository();
            UserModel userModel = new UserModel();

            UserDTO userEntity = userRepository.GetUserDetails(userId);
            AutoMapper.Mapper.Map(userEntity, userModel);
            return userModel;
        }

        public bool CreateUser(UserDTO user)
        {
            bool status = false;
            UserRepository AU = new UserRepository();
            status = AU.CreateUser(user);
            return status;
        }
    }
}