namespace CommonServiceLocator
{
    public static class Constants
    {
        // Message shown if an exception occurs during a GetAllInstances call
        public const string ActivateAllExceptionMessage = 
            "Activation error occurred while trying to get all instances of type {0}";        
        
        //Message shown on exception in GetInstance method
        public const string ActivationExceptionMessage = 
            "Activation error occurred while trying to get instance of type {0}, key \"{1}\""; 

        //Message shown if ServiceLocator.Current called before ServiceLocationProvider is set.
        public const string ServiceLocationProviderNotSetMessage = 
            " ServiceLocationProvider must be set.";                                          
    }
}
