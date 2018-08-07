using System;
using Xamarin.UITest;

namespace XamarinUITestAppTest
{
    public static class Helpers
    {
        public static IApp StartSim()
        {
            return ConfigureApp.iOS.DeviceIdentifier("B52C52D7-601C-4A72-8983-FB3E4C5AEEBD").StartApp();
        }
    }
}
