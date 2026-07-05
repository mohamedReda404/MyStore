using AppStore.Samples;
using Xunit;

namespace AppStore.EntityFrameworkCore.Domains;

[Collection(AppStoreTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<AppStoreEntityFrameworkCoreTestModule>
{

}
