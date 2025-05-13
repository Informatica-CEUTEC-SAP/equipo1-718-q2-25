using InstrumentalHub.Samples;
using Xunit;

namespace InstrumentalHub.EntityFrameworkCore.Domains;

[Collection(InstrumentalHubTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<InstrumentalHubEntityFrameworkCoreTestModule>
{

}
