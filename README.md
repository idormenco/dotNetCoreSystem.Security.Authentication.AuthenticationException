# dotNetCoreSystem.Security.Authentication.AuthenticationException
small project to reproduce Issue with System.Security.Authentication.AuthenticationException
In order to reproduce this issue please add a certificate (named wrong.pfx with valid password see AudascanChannelFactory.cs)

Logs:
```
'dotnet.exe' (CoreCLR: DefaultDomain): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Private.CoreLib.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'E:\code\bin\Debug\netcoreapp2.1\code.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Runtime.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Threading.Tasks.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Console.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Users\ion.dormenco\.nuget\packages\system.servicemodel.primitives\4.5.3\lib\netstandard2.0\System.ServiceModel.Primitives.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Users\ion.dormenco\.nuget\packages\system.private.servicemodel\4.5.3\runtimes\win\lib\netstandard2.0\System.Private.ServiceModel.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\netstandard.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Users\ion.dormenco\.nuget\packages\system.servicemodel.http\4.5.3\lib\netstandard2.0\System.ServiceModel.Http.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Private.Uri.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Security.Cryptography.X509Certificates.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Security.Cryptography.Primitives.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Net.Primitives.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Runtime.Serialization.Xml.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Private.DataContractSerialization.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Xml.ReaderWriter.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Private.Xml.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Collections.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Diagnostics.Tracing.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Runtime.InteropServices.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.IO.FileSystem.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Threading.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Net.Security.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.ObjectModel.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Diagnostics.Tools.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Threading.Thread.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Linq.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Runtime.Extensions.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Diagnostics.Debug.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Xml.XmlSerializer.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.ComponentModel.Primitives.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Collections.NonGeneric.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Diagnostics.TraceSource.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Text.RegularExpressions.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Net.Http.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Net.WebProxy.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Security.Principal.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Reflection.DispatchProxy.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Reflection.Emit.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'ProxyBuilder'. 
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Reflection.Primitives.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Reflection.Emit.ILGeneration.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Collections.Concurrent.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Runtime.InteropServices.RuntimeInformation.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Text.Encoding.Extensions.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Net.WebHeaderCollection.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Collections.Specialized.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Diagnostics.DiagnosticSource.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\CommonExtensions\Microsoft\IntelliTrace\Microsoft.IntelliTrace.TelemetryObserver.Common.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\CommonExtensions\Microsoft\IntelliTrace\Microsoft.IntelliTrace.TelemetryObserver.CoreClr.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Reflection.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Reflection.Extensions.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\mscorlib.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Threading.Timer.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Resources.ResourceManager.dll'. Symbols loaded.
Exception thrown: 'System.IO.FileNotFoundException' in System.Private.CoreLib.dll
'dotnet.exe' (CoreCLR: clrhost): Loaded 'Microsoft.GeneratedCode'. 
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Buffers.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Net.Sockets.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\Microsoft.Win32.Primitives.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Threading.Overlapped.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Net.NameResolution.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Memory.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Security.Cryptography.Encoding.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Runtime.Numerics.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Security.Principal.Windows.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Security.Claims.dll'. Symbols loaded.
'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.5\System.Threading.ThreadPool.dll'. Symbols loaded.
Exception thrown: 'System.Security.Authentication.AuthenticationException' in System.Private.CoreLib.dll
Exception thrown: 'System.Security.Authentication.AuthenticationException' in System.Private.CoreLib.dll
Exception thrown: 'System.Security.Authentication.AuthenticationException' in System.Private.CoreLib.dll
Exception thrown: 'System.Security.Authentication.AuthenticationException' in System.Private.CoreLib.dll
```
