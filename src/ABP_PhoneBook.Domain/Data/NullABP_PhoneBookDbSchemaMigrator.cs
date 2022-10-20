using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ABP_PhoneBook.Data;

/* This is used if database provider does't define
 * IABP_PhoneBookDbSchemaMigrator implementation.
 */
public class NullABP_PhoneBookDbSchemaMigrator : IABP_PhoneBookDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
