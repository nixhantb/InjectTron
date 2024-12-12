

namespace InjectTron.InjectTron.Core
{
    public class ServiceCollection : IServiceCollection
    {

        private readonly List<ServiceDescriptor> _serviceDescriptors = new();

        public void RegisterScoped<TService, TImplementation>() where TImplementation : TService
        {
            _serviceDescriptors.Add(new ServiceDescriptor(typeof(TService), typeof(TImplementation), ServiceLifetime.Scoped));
        }

        public void RegisterSingleton<TService, TImplementation>() where TImplementation : TService
        {
            _serviceDescriptors.Add(new ServiceDescriptor(typeof(TService), typeof(TImplementation), ServiceLifetime.Singleton));
        }

        public void RegisterTransient<TService, TImplementation>() where TImplementation : TService
        {
            _serviceDescriptors.Add(new ServiceDescriptor(typeof(TService), typeof(TImplementation), ServiceLifetime.Transient));
        }
        public IReadOnlyList<ServiceDescriptor> GetServiceDescriptors() => _serviceDescriptors;
    }
}

