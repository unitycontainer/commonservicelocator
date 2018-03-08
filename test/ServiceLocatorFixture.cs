using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CommonServiceLocator.Tests.Mocks;

namespace CommonServiceLocator.Tests
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
        public void ServiceLocatorIsLocatorProviderSetReturnsTrueWhenSet()
        {
            ServiceLocator.SetLocatorProvider(() => new MockServiceLocator(null));

            Assert.IsTrue(ServiceLocator.IsLocatorProviderSet);
        }

        [TestMethod]
        public void ServiceLocatorIsLocatorProviderSetReturnsFalseWhenNotSet()
        {
            Assert.IsFalse(ServiceLocator.IsLocatorProviderSet);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ServiceLocatorCurrentThrowsWhenLocatorProviderNotSet()
        {
            var currentServiceLocator = ServiceLocator.Current;
        }
    }
}
