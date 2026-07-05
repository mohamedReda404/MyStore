using AppStore.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AppStore.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AppStoreEntityFrameworkCoreModule),
    typeof(AppStoreApplicationContractsModule)
)]
public class AppStoreDbMigratorModule : AbpModule
{
}
