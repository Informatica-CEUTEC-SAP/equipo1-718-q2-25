using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using InstrumentalHub.Data;
using Volo.Abp.DependencyInjection;

namespace InstrumentalHub.EntityFrameworkCore;

public class EntityFrameworkCoreInstrumentalHubDbSchemaMigrator
    : IInstrumentalHubDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreInstrumentalHubDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the InstrumentalHubDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<InstrumentalHubDbContext>()
            .Database
            .MigrateAsync();
    }
}
