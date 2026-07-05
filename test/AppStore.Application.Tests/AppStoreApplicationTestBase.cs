using Volo.Abp.Modularity;

namespace AppStore;

public abstract class AppStoreApplicationTestBase<TStartupModule> : AppStoreTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
