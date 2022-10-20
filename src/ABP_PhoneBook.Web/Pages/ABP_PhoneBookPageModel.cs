using ABP_PhoneBook.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ABP_PhoneBook.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ABP_PhoneBookPageModel : AbpPageModel
{
    protected ABP_PhoneBookPageModel()
    {
        LocalizationResourceType = typeof(ABP_PhoneBookResource);
    }
}
