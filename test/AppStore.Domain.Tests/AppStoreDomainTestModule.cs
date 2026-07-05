using Volo.Abp.Modularity;

namespace AppStore;

[DependsOn(
    typeof(AppStoreDomainModule),
    typeof(AppStoreTestBaseModule)
)]
public class AppStoreDomainTestModule : AbpModule
{

}
