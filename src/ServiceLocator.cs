using System;

namespace CommonServiceLocator
{
    /// <summary>
    /// This class provides the ambient container for this application. If your
    /// framework defines such an ambient container, use ServiceLocator.Current
    /// to get it.
    /// </summary>
    public static class ServiceLocator
    {
        private static ServiceLocatorProvider _currentProvider;

        /// <summary>
        /// The current ambient container.
        /// </summary>
        public static IServiceLocator Current
        {
            get 
            {
                if (!IsLocatorProviderSet) throw new InvalidOperationException(Constants.ServiceLocatorProviderNotSetMessage);

                return _currentProvider(); 
            }
        }

        /// <summary>
        /// Set the delegate that is used to retrieve the current container.
        /// </summary>
        /// <param name="newProvider">Delegate that, when called, will return
        /// the current ambient container.</param>
        public static void SetLocatorProvider(ServiceLocatorProvider newProvider)
        {
            _currentProvider = newProvider;
        }

        public static bool IsLocatorProviderSet => _currentProvider != null;

        [Obsolete("Use IsLocatorProviderSet instead.")]
        public static bool IsLocationProviderSet => IsLocatorProviderSet;

  }
}
