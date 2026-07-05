using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AppStore.Data;

/* This is used if database provider does't define
 * IAppStoreDbSchemaMigrator implementation.
 */
public class NullAppStoreDbSchemaMigrator : IAppStoreDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
