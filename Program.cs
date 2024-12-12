

using InjectTron.InjectTron.Core;
using InjectTron.InjectTron.Core.UseCases;

class Program
{

    static void Main()
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.RegisterSingleton<ILoggerService, LoggerService>();
        serviceCollection.RegisterScoped<IBankService, BankService>();

        var container = new DIContainer(serviceCollection.GetServiceDescriptors());
        var bankService = container.Resolve<IBankService>();
        bankService.TransferMoney("123", "456", 100);

    }
}