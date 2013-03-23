#region Namespace

using BabyShop.CommonLayer.DataTransferObjects;
using BabyShop.Models;

#endregion

namespace BabyShop.CommonLayer.Mapper
{
    public class MapObject : IMapObject
    {
        #region IMapObject Members

        public void CreateMap()
        {
            //Mapper for ProductCartDTO and ProductCartModel
            AutoMapper.Mapper.CreateMap<ProductCartModel, ProductCartDTO>();
            AutoMapper.Mapper.CreateMap<ProductCartDTO, ProductCartModel>();

            //Mapper for UserDTO and UserModel
            AutoMapper.Mapper.CreateMap<UserDTO, UserModel>();
            AutoMapper.Mapper.CreateMap<UserModel, UserDTO>();

            //Mapper for UserAddressDTO and UserAddressModel
            AutoMapper.Mapper.CreateMap<UserAddressDTO, UserAddressModel>();
            AutoMapper.Mapper.CreateMap<UserAddressModel, UserAddressDTO>();

            AutoMapper.Mapper.CreateMap<ProductModel, ProductDTO>();
            AutoMapper.Mapper.CreateMap<ProductDTO, ProductModel>();

            AutoMapper.Mapper.CreateMap<ProductImagesModel, ProductImagesDTO>();
            AutoMapper.Mapper.CreateMap<ProductImagesDTO, ProductImagesModel>();
        }

        #endregion
    }
}