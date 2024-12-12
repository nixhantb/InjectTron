

//Interface to register services into the container.

namespace InjectTron.InjectTron.Core
{
    public interface IServiceCollection
    {
        void RegisterSingleton<TService, TImplementation>() where TImplementation : TService;
        void RegisterTransient<TService, TImplementation>() where TImplementation : TService;
        void RegisterScoped<TService, TImplementation>() where TImplementation : TService;
    }
}
