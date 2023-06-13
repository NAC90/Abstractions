using Abstractions.SystemAbstractions.Abstractions;
using Abstractions.SystemAbstractions.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Abstractions.SystemAbstractions.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection UseSystemInputOutputProviders(this IServiceCollection services)
        {
            return services
                .AddSingleton<IDirectoryProvider, DirectoryProvider>()
                .AddSingleton<IPathProvider, PathProvider>()
                .AddSingleton<IFileProvider, FileProvider>();
        }
    }
}
