

# InjectTron: A Custom Dependency Injection Framework

InjectTron is a lightweight, customizable Dependency Injection (DI) framework built entirely from scratch in C#. It provides a solid foundation for managing object dependencies in a clean, efficient, and maintainable manner.  

## 🚀 Features  

1. **Service Registration**  
   - Register services with their respective interfaces.  
   - Supports multiple lifetimes:  
     - **Singleton**: One instance shared across the application.  
     - **Transient**: A new instance for every request.  
     - **Scoped**: One instance per defined scope.  

2. **Service Resolution**  
   - Automatically resolve registered services and their dependencies.  

3. **Injection Support**  
   - **Constructor Injection**: Automatically inject dependencies via constructors.  
   - **Property Injection** (optional): Inject dependencies into properties.  

4. **Lazy Initialization**  
   - Services are instantiated only when required, improving memory efficiency.  

5. **Reflection-Based Design**  
   - Uses .NET reflection to dynamically discover and resolve dependencies, minimizing boilerplate code.  

## 🛠️ Why InjectTron?  

Dependency Injection (DI) promotes:  
- **Loose Coupling**: Components don’t directly depend on each other, making them easier to change or replace.  
- **Testability**: Mock dependencies during unit testing.  
- **Maintainability**: Centralized control of dependencies simplifies updates.  

InjectTron is designed to give developers full control while learning the internals of DI systems, making it ideal for educational purposes and custom solutions.  


## 🖥️ How It Works  

### 1. **Service Registration**  
In the `Program.cs` file, register interfaces and their implementations using the `ServiceCollection`.  

```csharp
var serviceCollection = new ServiceCollection();
serviceCollection.RegisterSingleton<ILoggerService, LoggerService>();
serviceCollection.RegisterScoped<IBankService, BankService>();
```

### 2. **Service Resolution**  
Resolve dependencies using the `DIContainer`:  

```csharp
var container = new DIContainer(serviceCollection.GetServiceDescriptors());
var bankService = container.Resolve<IBankService>();
bankService.TransferMoney("123", "456", 100);
```

### 3. **Lifetimes**  
- **Singleton**: Shared across all resolutions.  
- **Transient**: Unique instance per resolution.  
- **Scoped**: Unique instance per defined scope (useful for web requests or specific transaction contexts).  

---

## ✨ Contributions  

Contributions, suggestions, and improvements are welcome! Please open an issue or submit a pull request to collaborate.  
