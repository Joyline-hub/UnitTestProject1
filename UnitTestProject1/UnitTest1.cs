using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    public class FirefoxTesting : Hooks
    {
        [Test]
        public void FirefoxGoogleTest()
        {
            Driver.Navigate().GoToUrl("http://www.google.com");

        }
    }

    [TestFixture]
    public class IETesting : Hooks
    {
        [Test]
        public void IEGoogleTest()
        {
            Driver.Navigate().GoToUrl("http://www.durgambabooking.com/");

        }
    }
}
