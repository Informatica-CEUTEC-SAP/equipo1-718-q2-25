using InstrumentalHub.Samples;
using Xunit;

namespace InstrumentalHub.EntityFrameworkCore.Applications;

[Collection(InstrumentalHubTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<InstrumentalHubEntityFrameworkCoreTestModule>
{

}
