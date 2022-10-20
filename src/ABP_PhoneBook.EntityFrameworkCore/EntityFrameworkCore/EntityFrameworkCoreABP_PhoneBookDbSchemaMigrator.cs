using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ABP_PhoneBook.Data;
using Volo.Abp.DependencyInjection;

namespace ABP_PhoneBook.EntityFrameworkCore;

public class EntityFrameworkCoreABP_PhoneBookDbSchemaMigrator
    : IABP_PhoneBookDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreABP_PhoneBookDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the ABP_PhoneBookDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ABP_PhoneBookDbContext>()
            .Database
            .MigrateAsync();
    }
}
