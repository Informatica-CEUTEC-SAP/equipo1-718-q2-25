using Volo.Abp.Modularity;

namespace InstrumentalHub;

[DependsOn(
    typeof(InstrumentalHubDomainModule),
    typeof(InstrumentalHubTestBaseModule)
)]
public class InstrumentalHubDomainTestModule : AbpModule
{

}
