// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using CommonServiceLocator.Tests.Components;
using CommonServiceLocator.Tests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonServiceLocator.Tests
{

    [TestClass]
    public class ServiceLocatorAdapterFixture
    {
        protected IServiceLocator locator;

        [TestInitialize]
        public void InitAdapterFixture()
        {
            locator = new MockServiceLocator(new object[] { new SimpleLogger(),
                                             new AdvancedLogger(),
                                             new NullReferenceException() });
        }

        [TestMethod]
        public void GetInstance()
        {
            ILogger instance = locator.GetInstance<ILogger>();
            Assert.IsNotNull(instance);
        }


        [TestMethod]
        public void GetNamedInstance()
        {
            ILogger instance = locator.GetInstance<ILogger>(typeof(AdvancedLogger).FullName);
            Assert.IsInstanceOfType(instance, typeof(AdvancedLogger));
        }
    }
}
