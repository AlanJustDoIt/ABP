using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace ABP_PhoneBook;

public class ABP_PhoneBookWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<ABP_PhoneBookWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
