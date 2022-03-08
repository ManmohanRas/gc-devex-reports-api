using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace PresTrust.DevExReports.API.Contracts
{
    public interface IDependencyInjectionService
    {
        void Register(IServiceCollection services, IConfiguration configuration);
    }
}
