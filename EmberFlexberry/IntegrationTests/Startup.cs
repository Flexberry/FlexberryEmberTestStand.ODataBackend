namespace EmberFlexberryDummy
{
    using ICSSoft.STORMNET.Business;
    using ICSSoft.STORMNET.Business.Audit;
    using ICSSoft.STORMNET.Business.Interfaces;
    using ICSSoft.STORMNET.Security;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;

    public class Startup
    {
        public void ConfigureHost(IHostBuilder hostBuilder) =>
            hostBuilder
                .ConfigureHostConfiguration(builder => { builder.AddJsonFile("appsettings.json"); })
                .ConfigureAppConfiguration((context, builder) => { });

        public void ConfigureServices(IServiceCollection services, HostBuilderContext context)
        {
            string connStr = context.Configuration["DefConnStr"];
            services.AddSingleton<ISecurityManager, EmptySecurityManager>();
            services.AddSingleton<IAuditService, EmptyAuditService>();
            services.AddSingleton<IBusinessServerProvider>(serviceProvider =>
            {
                return new BusinessServerProvider(serviceProvider);
            });

            services.AddSingleton<IDataService>(serviceProvider =>
            {
                return new PostgresDataService(
                    serviceProvider.GetRequiredService<ISecurityManager>(),
                    serviceProvider.GetRequiredService<IAuditService>(),
                    serviceProvider.GetRequiredService<IBusinessServerProvider>())
                {
                    CustomizationString = connStr
                };
            });
        }
    }
}
