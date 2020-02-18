using btc.Domain.Interfaces;
using btc.Service.Revendedor;
using btcrio.Domain.Interfaces.Services.Revendedor;
using btcrio.Service.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace btc.CrossTalking
{
    public static class ConfigureService
    {
        public static void ConfigureDependenceService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IRevendedorService, RevendedorService>();
            serviceCollection.AddTransient<ILoginService, LoginService>();
        }
    }
}
