using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Microsoft.Practices.ServiceLocation")]
[assembly: AssemblyDescription("A simple facade that provides insulation from specific IoC containers.")]
#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif
[assembly: AssemblyCompany("Microsoft")]
[assembly: AssemblyProduct("Microsoft.Practices.ServiceLocation")]
[assembly: AssemblyCopyright("Copyright © Microsoft 2008")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

#if PORTABLE
[assembly: NeutralResourcesLanguage("en-US")]
#else
// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("ead99581-ffd4-44dd-a45b-1d8322dcfb8c")]
#endif
[assembly: CLSCompliant(true)]
[assembly: SecurityTransparent]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:
[assembly: AssemblyVersion("1.2.0.0")]
[assembly: AssemblyFileVersion("1.2.0.0")]
