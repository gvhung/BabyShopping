#region Using directives

using BabyShop.CommonLayer.Mapper;
using BabyShop.CommonLayer.Unity;
using Microsoft.Practices.Unity;

#endregion

namespace BabyShop.CommonLayer.UnityExtension
{
    public class BabyShopUnityContainerExtension
    {
        public static void InitializeContainer()
        {
            //Initializes unity container and registers interface with service classes 
            InitializeUnityContainer();
        }

        public static void InitializeUnityContainer()
        {
            BabyShopUnityContainer.InitializeContainer();

            #region Registration of Classes

            BabyShopUnityContainer.Container.RegisterType<IMapObject, MapObject>();

            #endregion
        }
    }
}