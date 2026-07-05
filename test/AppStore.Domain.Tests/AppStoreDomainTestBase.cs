using Volo.Abp.Modularity;

namespace AppStore;

/* Inherit from this class for your domain layer tests. */
public abstract class AppStoreDomainTestBase<TStartupModule> : AppStoreTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
