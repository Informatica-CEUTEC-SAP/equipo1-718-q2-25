using Volo.Abp.Modularity;

namespace InstrumentalHub;

public abstract class InstrumentalHubApplicationTestBase<TStartupModule> : InstrumentalHubTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
