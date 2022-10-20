using ABP_PhoneBook.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ABP_PhoneBook;

[DependsOn(
    typeof(ABP_PhoneBookEntityFrameworkCoreTestModule)
    )]
public class ABP_PhoneBookDomainTestModule : AbpModule
{

}
