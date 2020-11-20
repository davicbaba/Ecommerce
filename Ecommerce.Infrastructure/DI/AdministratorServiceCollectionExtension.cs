using Ecommerce.Application.Administration.Create;
using Ecommerce.Domain.Events;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Ecommerce.Infrastructure.EventBus;

namespace Ecommerce.Infrastructure.DI
{
    public class AdministratorServiceCollectionExtension
    {
        public static void AddAdministratorServices(IServiceCollection services)
        {
            // todo aqui se accede directamente al Domain y creo que esta mal por la regla de capas de la arquitectura hexagonal

            services.AddScoped<CategoryCreator>();
            services.AddScoped<IEventBus, MediatREventBus>();


            services.AddMediatR(typeof(AdministratorServiceCollectionExtension));


        }

    }
}
