using System.Reflection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly();
        
        // Registra repositories
        var repositories = assembly.GetTypes()
            .Where(t => t.Name.EndsWith("Repository") && !t.IsInterface)
            .ToList();
            
        foreach (var repo in repositories)
        {
            var interfaceType = repo.GetInterface($"I{repo.Name}");
            if (interfaceType != null)
                services.AddScoped(interfaceType, repo);
        }
        
        // Registra services
        var serviceTypes = assembly.GetTypes()
            .Where(t => t.Name.EndsWith("Service") && !t.IsInterface)
            .ToList();
            
        foreach (var service in serviceTypes)
        {
            var interfaceType = service.GetInterface($"I{service.Name}");
            if (interfaceType != null)
                services.AddScoped(interfaceType, service);
        }
        
        return services;
    }
}