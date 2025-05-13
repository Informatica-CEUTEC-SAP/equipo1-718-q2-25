using Volo.Abp.Modularity;

namespace InstrumentalHub;

/* Inherit from this class for your domain layer tests. */
public abstract class InstrumentalHubDomainTestBase<TStartupModule> : InstrumentalHubTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
