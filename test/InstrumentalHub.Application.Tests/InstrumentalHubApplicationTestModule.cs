using Volo.Abp.Modularity;

namespace InstrumentalHub;

[DependsOn(
    typeof(InstrumentalHubApplicationModule),
    typeof(InstrumentalHubDomainTestModule)
)]
public class InstrumentalHubApplicationTestModule : AbpModule
{

}
