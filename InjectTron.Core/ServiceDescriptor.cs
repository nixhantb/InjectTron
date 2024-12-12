//Represents a registered service's type, implementation type, and lifetime.

namespace InjectTron.InjectTron.Core
{
    public class ServiceDescriptor
    {
        public Type ServiceType { get; }
        public Type ImplementationType { get; }
        public ServiceLifetime Lifetime { get; }
        public object ImplementationInstance { get; set; }
        public object ScopedInstance { get; set; }

        public ServiceDescriptor(Type serviceType, Type implementationType, ServiceLifetime lifetime)
        {
            ServiceType = serviceType;
            ImplementationType = implementationType;
            Lifetime = lifetime;
        }
    }

    public enum ServiceLifetime
    {
        Singleton,
        Transient,
        Scoped
    }
}
