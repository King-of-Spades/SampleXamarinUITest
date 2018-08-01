# Sample Xamarin UITest

This project is in place to help demostrate a problem being faced when executing a Xamarin UI Test with an iOS Single page app.

## Prerequisites

What things you need to install the software and how to install them

- Mac High Sierra 10.13.6
- Visual Studio for Mac Community
  - 7.5.4 (build 3)
- Xcode
  - 9.4.1 (9F2000)
  
## Running the tests

Start the XamarinUITestAppUITest project to run the UI test setup

#### Runtime Error Stack Trace

NUnit.Framework.Internal.NUnitException: Rethrown ---> System.IO.FileNotFoundException: Could not load file or assembly 'System.Runtime.Remoting, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089' or one of its dependencies.
  at Xamarin.UITest.Utils.Integration.IdeConnection.Connect (System.String testAssemblyPath, Xamarin.UITest.Platform platform) [0x00017] in <1bd397951f434cd4913ddc08b7bc45af>:0
  at Xamarin.UITest.Utils.Integration.IdeIntegrationClient.TryConnect (Xamarin.UITest.Platform platform) [0x0003a] in <1bd397951f434cd4913ddc08b7bc45af>:0
  at Xamarin.UITest.iOS.iOSApp..ctor (Xamarin.UITest.Configuration.IiOSAppConfiguration appConfiguration, Xamarin.UITest.Shared.Execution.IExecutor executor) [0x0018f] in <1bd397951f434cd4913ddc08b7bc45af>:0
  at Xamarin.UITest.iOS.iOSApp..ctor (Xamarin.UITest.Configuration.IiOSAppConfiguration appConfiguration) [0x00000] in <1bd397951f434cd4913ddc08b7bc45af>:0
  at Xamarin.UITest.Configuration.iOSAppConfigurator.StartApp (Xamarin.UITest.Configuration.AppDataMode appDataMode) [0x00017] in <1bd397951f434cd4913ddc08b7bc45af>:0
  at XamarinUITestAppUITest.ApplicationInit.AppInit (Xamarin.UITest.Platform platform) [0x0000a] in /Users/<useraccount>/Projects/SampleXamarinUITest/XamarinUITestAppUITest/ApplicationInit.cs:12
  at XamarinUITestAppUITest.MainTest.SetUp () [0x00001] in /Users/<useraccount>/Projects/SampleXamarinUITest/XamarinUITestAppUITest/MainTest.cs:17
  at at (wrapper managed-to-native) System.Reflection.MonoMethod.InternalInvoke(System.Reflection.MonoMethod,object,object[],System.Exception&)
  at System.Reflection.MonoMethod.Invoke (System.Object obj, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, System.Object[] parameters, System.Globalization.CultureInfo culture) [0x00032] in /Library/Frameworks/Xamarin.iOS.framework/Versions/11.12.0.4/src/Xamarin.iOS/mcs/class/corlib/System.Reflection/MonoMethod.cs:305
  --- End of inner exception stack trace ---
  at NUnit.Framework.Internal.Reflect.InvokeMethod (System.Reflection.MethodInfo method, System.Object fixture, System.Object[] args) [0x0001d] in /Users/builder/data/lanes/5944/64fece5f/source/xamarin-macios/external/mono/external/nunit-lite/NUnitLite-1.0.0/src/framework/Internal/Reflect.cs:220
  at NUnit.Framework.Internal.Reflect.InvokeMethod (System.Reflection.MethodInfo method, System.Object fixture) [0x00000] in /Users/builder/data/lanes/5944/64fece5f/source/xamarin-macios/external/mono/external/nunit-lite/NUnitLite-1.0.0/src/framework/Internal/Reflect.cs:199
  at NUnit.Framework.Internal.Commands.OneTimeSetUpCommand.Execute (NUnit.Framework.Internal.TestExecutionContext context) [0x00058] in /Users/builder/data/lanes/5944/64fece5f/source/xamarin-macios/external/mono/external/nunit-lite/NUnitLite-1.0.0/src/framework/Internal/Commands/OneTimeSetUpCommand.cs:63
  at MonoTouch.NUnit.UI.TestCaseElement+<>c__DisplayClass0_0.<.ctor>b__0 () [0x00055] in /Users/builder/data/lanes/5944/64fece5f/source/xamarin-macios/external/Touch.Unit/NUnitLite/TouchRunner/TestCaseElement.cs:53
  at MonoTouch.Dialog.StringElement.Selected (MonoTouch.Dialog.DialogViewController dvc, UIKit.UITableView tableView, Foundation.NSIndexPath indexPath) [0x00008] in /Users/builder/data/lanes/5944/64fece5f/source/xamarin-macios/external/MonoTouch.Dialog/MonoTouch.Dialog/Elements.cs:765
  at MonoTouch.Dialog.DialogViewController.Selected (Foundation.NSIndexPath indexPath) [0x00026] in /Users/builder/data/lanes/5944/64fece5f/source/xamarin-macios/external/MonoTouch.Dialog/MonoTouch.Dialog/DialogViewController.cs:577
  at MonoTouch.Dialog.DialogViewController+Source.RowSelected (UIKit.UITableView tableView, Foundation.NSIndexPath indexPath) [0x00016] in /Users/builder/data/lanes/5944/64fece5f/source/xamarin-macios/external/MonoTouch.Dialog/MonoTouch.Dialog/DialogViewController.cs:402
  at at (wrapper managed-to-native) UIKit.UIApplication.UIApplicationMain(int,string[],intptr,intptr)
  at UIKit.UIApplication.Main (System.String[] args, System.IntPtr principal, System.IntPtr delegate) [0x00005] in /Library/Frameworks/Xamarin.iOS.framework/Versions/11.12.0.4/src/Xamarin.iOS/UIKit/UIApplication.cs:79
  at UIKit.UIApplication.Main (System.String[] args, System.String principalClassName, System.String delegateClassName) [0x0002c] in /Library/Frameworks/Xamarin.iOS.framework/Versions/11.12.0.4/src/Xamarin.iOS/UIKit/UIApplication.cs:63
  at XamarinUITestAppUITest.Application.Main (System.String[] args) [0x00001] in /Users/<useraccount>/Projects/SampleXamarinUITest/XamarinUITestAppUITest/Main.cs:17

