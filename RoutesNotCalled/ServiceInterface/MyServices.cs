using System;
using ServiceStack;
using RoutesNotCalled.ServiceModel;

namespace RoutesNotCalled.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}
