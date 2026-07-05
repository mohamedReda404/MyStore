using Microsoft.Extensions.Localization;
using AppStore.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AppStore;

[Dependency(ReplaceServices = true)]
public class AppStoreBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<AppStoreResource> _localizer;

    public AppStoreBrandingProvider(IStringLocalizer<AppStoreResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
