using Volo.Abp.Modularity;

namespace ABP_PhoneBook;

[DependsOn(
    typeof(ABP_PhoneBookApplicationModule),
    typeof(ABP_PhoneBookDomainTestModule)
    )]
public class ABP_PhoneBookApplicationTestModule : AbpModule
{

}
