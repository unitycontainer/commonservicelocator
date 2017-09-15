#if NETSTANDARD1_0 || NETSTANDARD2_0
#define NETSTANDARD
#endif

namespace Microsoft.Practices.ServiceLocation
{
    //
    // Summary:
    //     Defines a mechanism for retrieving a service object; that is, an object that
    //     provides custom support to other objects.
    public interface IServiceProvider
#if !NETSTANDARD
        : System.IServiceProvider
#endif
    {
#if NETSTANDARD
        //
        // Summary:
        //     Gets the service object of the specified type.
        //
        // Parameters:
        //   serviceType:
        //     An object that specifies the type of service object to get.
        //
        // Returns:
        //     A service object of type serviceType.-or- null if there is no service object
        //     of type serviceType.
        object GetService(System.Type serviceType);
#endif
    }
}