/**************************************************************************\
    Copyright Microsoft Corporation. All Rights Reserved.
\**************************************************************************/

using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Markup;

[assembly: AssemblyTitle("Microsoft.Windows.Shell")]
[assembly: AssemblyDescription("Microsoft.Windows.Shell.dll")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyProduct("Microsoft\x00ae .NET Framework")]
[assembly: AssemblyCopyright("\x00a9 Microsoft Corporation.  All rights reserved.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: ComVisible(false)]
[assembly: Guid("573618e1-4f3f-4395-a3bf-ffebfb342917")]
[assembly: CLSCompliant(true)]

[assembly: AssemblyVersion("3.5.41019.1")]
[assembly: AssemblyFileVersion("3.5.41019.1")]

[assembly: XmlnsDefinition("http://schemas.microsoft.com/winfx/2006/xaml/presentation/shell", "Microsoft.Windows.Shell")]

// Code analysis suppressions:
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Standard", Justification="Internal-only namespace")]
[assembly: SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames", Justification="Assembly has strong name when published")]

[assembly: System.Resources.NeutralResourcesLanguage("en-US")]
[assembly: AssemblyDelaySign(true)]
[assembly: System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.RequestMinimum, SkipVerification = true)]

[assembly: CompilationRelaxations(CompilationRelaxations.NoStringInterning)]

[assembly: AssemblyDefaultAlias("Microsoft.Windows.Shell.dll")]

[assembly: System.Diagnostics.Debuggable(System.Diagnostics.DebuggableAttribute.DebuggingModes.DisableOptimizations | System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
