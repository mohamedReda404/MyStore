using Xunit;

namespace AppStore.EntityFrameworkCore;

[CollectionDefinition(AppStoreTestConsts.CollectionDefinitionName)]
public class AppStoreEntityFrameworkCoreCollection : ICollectionFixture<AppStoreEntityFrameworkCoreFixture>
{

}
