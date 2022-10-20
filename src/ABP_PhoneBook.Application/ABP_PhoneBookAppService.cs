using System;
using System.Collections.Generic;
using System.Text;
using ABP_PhoneBook.Localization;
using Volo.Abp.Application.Services;

namespace ABP_PhoneBook;

/* Inherit your application services from this class.
 */
public abstract class ABP_PhoneBookAppService : ApplicationService
{
    protected ABP_PhoneBookAppService()
    {
        LocalizationResource = typeof(ABP_PhoneBookResource);
    }
}
