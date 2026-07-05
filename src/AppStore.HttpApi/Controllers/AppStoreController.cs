using AppStore.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AppStore.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AppStoreController : AbpControllerBase
{
    protected AppStoreController()
    {
        LocalizationResource = typeof(AppStoreResource);
    }
}
