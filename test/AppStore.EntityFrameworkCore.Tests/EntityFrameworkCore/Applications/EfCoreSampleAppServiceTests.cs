using AppStore.Samples;
using Xunit;

namespace AppStore.EntityFrameworkCore.Applications;

[Collection(AppStoreTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<AppStoreEntityFrameworkCoreTestModule>
{

}
