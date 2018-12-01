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
        IApp app;

        [SetUp]
        public void BeforeEachTest()
        {
            app = ConfigureApp
                .iOS
                .StartApp();
        }


        [Test]
        public void ReplTest()
        {
            app.Tap(x => x.Marked("Menu 1"));
            app.Tap(x => x.Id("itm0"));
            app.Repl();
            // use the "tree" command to reproduce the bug 
        }
    }
}
