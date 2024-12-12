using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//The core of the Dependency Injection container that resolves services.
namespace InjectTron.InjectTron.Core
{
    public class DIContainer
    {
        private readonly IReadOnlyList<ServiceDescriptor> _serviceDescriptors;
        private readonly Dictionary<Type, object> _singletonInstances = new();
        private readonly Dictionary<Type, object> _scopedInstances = new();

        public DIContainer(IReadOnlyList<ServiceDescriptor> serviceDescriptors)
        {
            _serviceDescriptors = serviceDescriptors;
        }

        // Resolve services

        public TService Resolve<TService>()
        {
            return (TService)Resolve(typeof(TService));
        }

        private object Resolve (Type serviceType)
        {

            var descriptor = _serviceDescriptors.SingleOrDefault(d => d.ServiceType == serviceType);

            if(descriptor == null)
            {
                throw new InvalidOperationException($"Service of type {serviceType.Name} is not registered.");

            }

            if(descriptor.Lifetime == ServiceLifetime.Singleton)
            {
                if(!_singletonInstances.TryGetValue(serviceType, out var instance))
                {
                   instance  = CreateInstance(descriptor);
                    _singletonInstances.Add(serviceType, instance);

                }
                return instance;
            }

            if(descriptor.Lifetime == ServiceLifetime.Scoped)
            {
               
                if(!_scopedInstances.ContainsKey(serviceType))
                {
                    var instance = CreateInstance(descriptor);
                    _scopedInstances.Add(serviceType, instance);
                }
                return _scopedInstances[serviceType];
            }

            return CreateInstance(descriptor);
           
        }

        private object CreateInstance(ServiceDescriptor descriptor)
        {

            var constructorInfo = descriptor.ImplementationType.GetConstructors().First();

            var parameters = constructorInfo.GetParameters().Select(p => Resolve(p.ParameterType)).ToArray();

            return Activator.CreateInstance(descriptor.ImplementationType, parameters);
        }
    }
}
