using eCommerce.BusinessLogicLayer.Mappers;
using eCommerce.BusinessLogicLayer.ServiceContracts;
using Microsoft.Extensions.DependencyInjection;
using eCommerce.BusinessLogicLayer.Validators;
using FluentValidation;

namespace eCommerce.ProductsService.BusinessLogicLayer;

public static class DependencyInjection
{
    public static IServiceCollection AddBusinessLogicLayer(this IServiceCollection services)
    {
        // Add AutoMapper using the correct overload for assembly scanning
        services.AddAutoMapper(cfg => { }, typeof(ProductAddRequestToProductMappingProfile).Assembly);

        // Register all validators in the assembly manually (FluentValidation core)
        services.Scan(scan => scan
          .FromAssemblyOf<ProductAddRequestValidator>()
          .AddClasses(classes => classes.AssignableTo(typeof(IValidator<>)))
          .AsImplementedInterfaces()
          .WithScopedLifetime());

        services.AddScoped<IProductsService, eCommerce.BusinessLogicLayer.Services.ProductsService>();

        return services;
    }
}
