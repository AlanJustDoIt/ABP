using ABP_PhoneBook.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ABP_PhoneBook.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ABP_PhoneBookEntityFrameworkCoreModule),
    typeof(ABP_PhoneBookApplicationContractsModule)
    )]
public class ABP_PhoneBookDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
