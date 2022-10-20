using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ABP_PhoneBook.Web;

[Dependency(ReplaceServices = true)]
public class ABP_PhoneBookBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ABP_PhoneBook";
}
