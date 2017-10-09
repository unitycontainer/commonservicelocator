using System;
using CommonServiceLocator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceLocation.Tests.Mocks;

namespace ServiceLocation.Tests
{
    [TestClass]
    public class ServiceLocatorFixture
    {
        [TestInitialize]
        public void TestInit()
        {
            ServiceLocator.SetLocatorProvider(null);
        }

        [TestMethod]
        public void ServiceLocatorIsLocationProviderSetReturnsTrueWhenSet()
        {
            ServiceLocator.SetLocatorProvider(() => new MockServiceLocator(null));

            Assert.IsTrue(ServiceLocator.IsLocationProviderSet);
        }

        [TestMethod]
        public void ServiceLocatorIsLocationProviderSetReturnsFalseWhenNotSet()
        {
            Assert.IsFalse(ServiceLocator.IsLocationProviderSet);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ServiceLocatorCurrentThrowsWhenLocationProviderNotSet()
        {
            var currentServiceLocator = ServiceLocator.Current;
        }
    }
}
