using InstrumentalHub.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace InstrumentalHub.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(InstrumentalHubEntityFrameworkCoreModule),
    typeof(InstrumentalHubApplicationContractsModule)
)]
public class InstrumentalHubDbMigratorModule : AbpModule
{
}
