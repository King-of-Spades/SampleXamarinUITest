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

Run the tests in project XamarinUITestAppTest

#### Runtime Error Stack Trace

Xamarin.UITest.XDB.Exceptions.DeviceAgentException : Failed to install DeviceAgent

ExitCode: 1

		-c,--codesign-identity	<codesign-identifier> [OPTIONAL] 	Identity used to codesign app bundle [device only]. Deprecated - should use profile path.	DEFAULT=
		-d,--device-id	<device-identifier>	iOS Simulator GUID or 40-digit physical device ID
		-f,--force	<force-reinstall-app> [OPTIONAL] 	Reinstall the app if the device contains an older version than the bundle specified	DEFAULT=0
		-i,--resources-path	<resources-path> [OPTIONAL] 	Path to resources (executables) to inject into app directory. A list of colon separated files may be specified.
		-p,--profile-path	<profile-path> [OPTIONAL] 	Path to provisioning profile
	install <app-path>
App com.apple.test.DeviceAgent-Runner is not installed on 62CC51D4-A834-4697-8715-4AB9B16FA336
Error installing application: Error Domain=com.facebook.FBSimulatorControl Code=0 "Simulator does not support any of the architectures ([x86_64, i386]) of the executable at /var/folders/0r/r3b8jxr92jx1kgg8c802phq40000gn/T/xdb/DeviceAgent.iOS.Dependencies/9a7eae887a041f733c06f5eef3e12600/app/DeviceAgent-Runner.app/DeviceAgent-Runner. Simulator Archs ([(null)])" UserInfo={NSLocalizedDescription=Simulator does not support any of the architectures ([x86_64, i386]) of the executable at /var/folders/0r/r3b8jxr92jx1kgg8c802phq40000gn/T/xdb/DeviceAgent.iOS.Dependencies/9a7eae887a041f733c06f5eef3e12600/app/DeviceAgent-Runner.app/DeviceAgent-Runner. Simulator Archs ([(null)])}
Stack trace:
  at Xamarin.UITest.XDB.Services.iOSDeviceAgentService.WithErrorHandling (System.Int32 eventId, System.Func`1[TResult] action, System.String errorMessage, System.Int32[] successCodes) [0x000c1] in <1bd397951f434cd4913ddc08b7bc45af>:0 
  at Xamarin.UITest.XDB.Services.iOSDeviceAgentService+<LaunchTestAsync>c__async6.MoveNext () [0x002c7] in <1bd397951f434cd4913ddc08b7bc45af>:0 
--- End of stack trace from previous location where exception was thrown ---
  at Xamarin.UITest.iOS.iOSAppLauncher.LaunchAppLocal (Xamarin.UITest.Configuration.IiOSAppConfiguration appConfiguration, Xamarin.UITest.Shared.Http.HttpClient httpClient, System.Boolean clearAppData) [0x00216] in <1bd397951f434cd4913ddc08b7bc45af>:0 
  at Xamarin.UITest.iOS.iOSAppLauncher.LaunchApp (Xamarin.UITest.Configuration.IiOSAppConfiguration appConfiguration, Xamarin.UITest.Shared.Http.HttpClient httpClient, Xamarin.UITest.TestCloud.TestCloudiOSAppConfiguration testCloudAppConfiguration, Xamarin.UITest.Shared.Http.HttpClient testCloudWsClient, Xamarin.UITest.Shared.Http.HttpClient xtcServicesClient, System.Boolean testCloudUseDeviceAgent) [0x0007a] in <1bd397951f434cd4913ddc08b7bc45af>:0 
  at Xamarin.UITest.iOS.iOSApp..ctor (Xamarin.UITest.Configuration.IiOSAppConfiguration appConfiguration, Xamarin.UITest.Shared.Execution.IExecutor executor) [0x002de] in <1bd397951f434cd4913ddc08b7bc45af>:0 
  at Xamarin.UITest.iOS.iOSApp..ctor (Xamarin.UITest.Configuration.IiOSAppConfiguration appConfiguration) [0x00000] in <1bd397951f434cd4913ddc08b7bc45af>:0 
  at Xamarin.UITest.Configuration.iOSAppConfigurator.StartApp (Xamarin.UITest.Configuration.AppDataMode appDataMode) [0x00017] in <1bd397951f434cd4913ddc08b7bc45af>:0 
  at XamarinUITestAppTest.Tests.BeforeEachTest () [0x0000c] in /Users/machinename/Projects/SampleXamarinUITest/XamarinUITestAppTest/Tests.cs:39 
  at (wrapper managed-to-native) System.Reflection.MonoMethod.InternalInvoke(System.Reflection.MonoMethod,object,object[],System.Exception&)
  at System.Reflection.MonoMethod.Invoke (System.Object obj, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, System.Object[] parameters, System.Globalization.CultureInfo culture) [0x00032] in /Users/builder/jenkins/workspace/build-package-osx-mono/2017-12/external/bockbuild/builds/mono-x64/mcs/class/corlib/System.Reflection/MonoMethod.cs:305 
