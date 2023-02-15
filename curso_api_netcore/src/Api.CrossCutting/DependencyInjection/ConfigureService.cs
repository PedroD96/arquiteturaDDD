using Api.Domain.Interfaces.Services.Cep;
using Api.Domain.Interfaces.Services.Municipio;
using Api.Domain.Interfaces.Services.Uf;
using Api.Domain.Interfaces.Services.User;
using Api.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigrueDependenciesService (IServiceCollection serviceCollection)
        {
            //AddSingleton --> Startou a aplicação uma vez, ele jamais vai mudar.
            //AddScoped --> Se em 10 metodos ele precisar usar o IUserService, ele vai usar o a mesma instancia. Mas depois, vai alterar; F5 muda o escopo.
            //AddTransient --> Para cada instancia ele muda o escopo.
            serviceCollection.AddTransient<IUserService, UserService>();
            serviceCollection.AddTransient<ILoginService, LoginService>();
            
            serviceCollection.AddTransient<IUfService, UfService>();
            serviceCollection.AddTransient<IMunicipioService, MunicipioService>();
            serviceCollection.AddTransient<ICepService, CepService>();
        }
    }
}
