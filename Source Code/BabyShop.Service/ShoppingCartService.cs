namespace BabyShopping.Service
{
    public class ShoppingCartService
    {
        //public static bool InsertProductShoppingCart(ShoppingCart cart)
        //{
        //    bool status = false;
        //    BabyShopServiceContractClient proxy = new BabyShopServiceContractClient();
        //    status = proxy.InsertProductCart(cart.ToModel());
        //    return status;
        //}

        //public static ShoppingCart[] GetShoppingCartIteim(string cartId)
        //{
        //    BabyShopServiceContractClient proxy = new BabyShopServiceContractClient();
        //    EShoppingCart[] productCartList = proxy.GetShoppingCartIteim(cartId);
        //    if (productCartList != null)
        //    {
        //        return Array.ConvertAll<EShoppingCart, ShoppingCart>(productCartList, productCartEntity => productCartEntity.ToLocal());
        //    }
        //    return null;
        //}

        //public static bool DeleteShoppingCart(int PCartKId)
        //{
        //    ServiceFactory.InitializeServiceFactory("http://localhost/BabyShopService/BabyShopService.svc");
        //    bool status = false;
        //    status = ServiceFactory.ServiceClient.DeleteShoppingCart(PCartKId);
        //    return status;
        //}

        //public static int CountShoppingCartItems(string cartId)
        //{
        //    ServiceFactory.InitializeServiceFactory("http://localhost/BabyShopService/BabyShopService.svc");
        //    int CartIterm = 0;
        //    ServiceFactory.ServiceClient.CountShoppingCartItems(cartId);
        //    return CartIterm;
        //}
    }
}