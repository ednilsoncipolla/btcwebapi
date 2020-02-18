using btc.Data.Context;
using btc.Data.Repository;
using btc.Domain.Interfaces;
using btcrio.Data.Implementations;
using btcrio.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace btc.CrossTalking.DependencyInjection
{
    public static class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<MyContext>(
                    options => options.UseMySql("server = estudomysql1.mysql.database.azure.com; Port=3306;DataBase = estudomysql1; Uid=ednilsoncipolla@estudomysql1; Pwd=MasterKey@1000")
            );

            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IRevendedorRepository, RevendedorImplementation>();
        }
    }
}
