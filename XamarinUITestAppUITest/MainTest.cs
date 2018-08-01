using System;
using UIKit;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace XamarinUITestAppUITest
{
    [TestFixture]
    public class MainTest
    {
        IApp myApp;

        [TestFixtureSetUp]
        public void SetUp()
        {
            myApp = ApplicationInit.AppInit(Platform.iOS);
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            myApp = null;
        }

        [Test]
        public void TestHelloWorld()
        {
            Assert.AreEqual("lblHW", myApp.Query(c => c.Class("UILabel"))[0].Label);
        }
    }
}
