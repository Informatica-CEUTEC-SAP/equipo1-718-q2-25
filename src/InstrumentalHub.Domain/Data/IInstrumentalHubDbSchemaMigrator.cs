using System.Threading.Tasks;

namespace InstrumentalHub.Data;

public interface IInstrumentalHubDbSchemaMigrator
{
    Task MigrateAsync();
}
