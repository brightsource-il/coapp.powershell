//-----------------------------------------------------------------------
// <copyright company="CoApp Project">
//     Copyright (c) 2010-2013 Garrett Serack and CoApp Contributors. 
//     Contributors can be discovered using the 'git log' command.
//     All rights reserved.
// </copyright>
// <license>
//     The software is licensed under the Apache 2.0 License (the "License")
//     You may not use the software except in compliance with the License. 
// </license>
//-----------------------------------------------------------------------

using System;
using System.Reflection;

[assembly: AssemblyCompany("Outercurve Foundation")]
[assembly: AssemblyCopyright("Copyright (c) Garrett Serack, Contributors 2010-2013")]

// We no longer need to delay sign in order to strong name and sign the code before 
// we publish it, so now we will have just one set of  Version  lines, and no strong 
// naming until publishing.

[assembly: AssemblyVersion("2.5.1.0")]
[assembly: AssemblyFileVersion("2.5.1.0")]
[assembly: AssemblyProduct("CoApp Developer Powershell CmdLets")]
[assembly: AssemblyTrademark("CoApp is a non-registered trademark of Garrett Serack")]

[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
internal class AssemblyBugtrackerAttribute : Attribute {
    public readonly string TrackerUrl;

    public AssemblyBugtrackerAttribute(string trackerURL) {
        TrackerUrl = trackerURL;
    }

    public override string ToString() {
        return TrackerUrl;
    }
}