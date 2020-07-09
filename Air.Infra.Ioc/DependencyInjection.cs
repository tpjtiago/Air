using Air.Application.Interfaces;
using Air.Application.Services;
using Air.Domain.Interfaces.Repositories;
using Air.Domain.Interfaces.Services;
using Air.Domain.Services;
using Air.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Air.Infra.Ioc
{
    public class DependencyInjection
    {
        public static void Registrar(IServiceCollection svcCollection)
        {
            //Aplicação
            svcCollection.AddScoped(typeof(IBaseApp<,>), typeof(BaseServiceApp<,>));
            svcCollection.AddScoped<IClienteApp, ClienteApp>();

            //Domínio
            svcCollection.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
            svcCollection.AddScoped<IClienteService, ClienteService>();

            //Repositorio
            svcCollection.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            svcCollection.AddScoped<IClienteRepository, ClienteRepository>();


        }
    }
}
