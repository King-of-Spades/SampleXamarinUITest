using System;
using Xamarin.UITest;

namespace XamarinUITestAppUITest
{
    public static class ApplicationInit
    {
        public static IApp AppInit(Platform platform)
        {
            if (platform == Platform.iOS)
            {
                return ConfigureApp
                    .iOS
                    .PreferIdeSettings()
                    .AppBundle("../XamarinUITestApp/bin/iPhoneSimulator/Debug/XamarinUITestApp.exe")
                    .StartApp();
            }

            return ConfigureApp
                .Android
                .PreferIdeSettings()
                .StartApp();

        }
    }
}
