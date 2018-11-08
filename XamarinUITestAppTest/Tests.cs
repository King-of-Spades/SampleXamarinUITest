using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.iOS;
using Xamarin.UITest.Queries;

namespace XamarinUITestAppTest
{
    [TestFixture]
    public class Tests
    {
        iOSApp app;

        public static string AssemblyPath
        {
            get
            {
                string codebase = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codebase);
                string path = Uri.UnescapeDataString(uri.Path);
                string rt = Path.GetDirectoryName(path);

                return rt;
            }
        }

        [SetUp]
        public void BeforeEachTest()
        {
            // DONE: If the iOS app being tested is included in the solution then open
            // the Unit Tests window, right click Test Apps, select Add App Project
            // and select the app projects that should be tested.
            //

            Environment.CurrentDirectory = AssemblyPath;

            app = ConfigureApp
                .iOS
                .PreferIdeSettings()
                // TODO: Update this path to point to your iOS app and uncomment the
                // code if the app is not included in the solution.
                //.AppBundle ("../../../iOS/bin/iPhoneSimulator/Debug/XamarinUITestAppTest.iOS.app")
                .AppBundle("../../../XamarinUITestApp/bin/iPhoneSimulator/Debug/XamarinUITestApp.app")
                .StartApp();
        }

        [Test]
        public void AppLaunches()
        {
            AppResult[] elem = app.Query(q => q.Marked("lblHW"));

            Assert.IsTrue(elem.Any());
        }

        [Test]
        public void ItemDetailTest()
        {
            // setup
            app.Tap(h => h.Text("Menu 1"));
            app.WaitForElement(h => h.Text("Item List"));

            app.Tap(h => h.Marked("itm1"));
            app.WaitForElement(q => q.Text("Detail View"));

            // run
            AppResult[] text = app.Query(h => h.Class("UITextField"));

            // assert
            Assert.IsTrue(text.Any());
        }

        [Test]
        public void ReplTest()
        {
            app.Repl();
        }
    }
}
