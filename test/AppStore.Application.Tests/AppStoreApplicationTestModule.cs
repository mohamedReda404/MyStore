using Volo.Abp.Modularity;

namespace AppStore;

[DependsOn(
    typeof(AppStoreApplicationModule),
    typeof(AppStoreDomainTestModule)
)]
public class AppStoreApplicationTestModule : AbpModule
{

}
