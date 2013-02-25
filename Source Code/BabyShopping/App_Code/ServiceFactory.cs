#region Using directives

using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using BabyShopWebService;

#endregion

/// <summary>
/// This class is used to hold the service proxy client information
/// </summary>
public class ServiceFactory
{
    /// <summary>
    /// This pricate static member is used to hold the service proxy cleint instance
    /// </summary>
    private static BabyShopServiceContractClient serviceClient;

    /// <summary>
    /// .ctor
    /// </summary>
    public ServiceFactory()
    {
    }

    /// <summary>
    /// This method is used to instantiate the service proxy class instance
    /// </summary>
    /// <param name="serviceURL">service url</param>
    public static void InitializeServiceFactory(string serviceURL)
    {
        serviceClient = new BabyShopServiceContractClient("*", serviceURL);
    }

    /// <summary>
    /// This property is used to hold the service proxy client object
    /// </summary>
    public static BabyShopServiceContractClient ServiceClient
    {
        get { return serviceClient; }
        set
        {
            serviceClient = value;
        }
    }

    /// <summary>
    /// This method is used to register the object instances in unity container
    /// </summary>
    /// <typeparam name="T">generic type</typeparam>
    /// <param name="instance">instance</param>
    /// <param name="name">key name</param>
    public static void RegisterObjectInstance<T>(T instance, string name)
    {
        ServiceLocator.Current.GetInstance<IUnityContainer>().RegisterInstance<T>(name, instance);
    }

    /// <summary>
    /// This method is used to get the registed instance from unity container
    /// </summary>
    /// <typeparam name="T">generic type</typeparam>
    /// <param name="name">key name</param>
    /// <returns>returns instance</returns>
    public static T GetRegisteredInstance<T>(string name)
    {
        return ServiceLocator.Current.GetInstance<IUnityContainer>().Resolve<T>(name, new ResolverOverride[] { });
    }
}