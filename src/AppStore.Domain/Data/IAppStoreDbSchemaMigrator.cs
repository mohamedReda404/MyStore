using System.Threading.Tasks;

namespace AppStore.Data;

public interface IAppStoreDbSchemaMigrator
{
    Task MigrateAsync();
}
