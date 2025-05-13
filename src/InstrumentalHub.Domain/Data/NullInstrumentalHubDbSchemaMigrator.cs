using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace InstrumentalHub.Data;

/* This is used if database provider does't define
 * IInstrumentalHubDbSchemaMigrator implementation.
 */
public class NullInstrumentalHubDbSchemaMigrator : IInstrumentalHubDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
