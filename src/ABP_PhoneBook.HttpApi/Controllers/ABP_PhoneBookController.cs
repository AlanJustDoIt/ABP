using ABP_PhoneBook.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ABP_PhoneBook.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ABP_PhoneBookController : AbpControllerBase
{
    protected ABP_PhoneBookController()
    {
        LocalizationResource = typeof(ABP_PhoneBookResource);
    }
}
