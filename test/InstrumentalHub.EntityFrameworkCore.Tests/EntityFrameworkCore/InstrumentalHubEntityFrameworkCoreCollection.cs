using Xunit;

namespace InstrumentalHub.EntityFrameworkCore;

[CollectionDefinition(InstrumentalHubTestConsts.CollectionDefinitionName)]
public class InstrumentalHubEntityFrameworkCoreCollection : ICollectionFixture<InstrumentalHubEntityFrameworkCoreFixture>
{

}
