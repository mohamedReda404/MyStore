using AppStore.Localization;
using Volo.Abp.Application.Services;

namespace AppStore;

/* Inherit your application services from this class.
 */
public abstract class AppStoreAppService : ApplicationService
{
    protected AppStoreAppService()
    {
        LocalizationResource = typeof(AppStoreResource);
    }
}
