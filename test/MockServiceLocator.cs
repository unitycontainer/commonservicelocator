using System;
using System.Collections.Generic;
using System.Linq;
using CommonServiceLocator;

namespace ServiceLocation.Tests.Mocks
{
    public class MockServiceLocator : ServiceLocatorImplBase
    {
        private readonly IEnumerable<object> _objects;

        public MockServiceLocator(IEnumerable<object> list)
        {
            _objects = list;
        }



        protected override object DoGetInstance(Type serviceType, string key)
        {
            return null == key ? _objects.First(o => serviceType.IsAssignableFrom(o.GetType()))
                               : _objects.First(o => serviceType.IsAssignableFrom(o.GetType()) && Equals(key, o.GetType().FullName));
        }

        protected override IEnumerable<object> DoGetAllInstances(Type serviceType)
        {
            return _objects.Where(o => serviceType.IsAssignableFrom(o.GetType()));
        }
    }
}
