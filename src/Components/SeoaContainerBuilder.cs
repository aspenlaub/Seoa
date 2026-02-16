using Autofac;
using Microsoft.Extensions.DependencyInjection;

namespace Aspenlaub.Net.GitHub.CSharp.Seoa.Components;

public static class SeoaContainerBuilder {
    public static ContainerBuilder UseSeoa(this ContainerBuilder builder, string applicationName) {
        return builder;
    }

    public static IServiceCollection UseSeoa(this IServiceCollection services, string applicationName) {
        return services;
    }
}