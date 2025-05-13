using Microsoft.Extensions.Localization;
using InstrumentalHub.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace InstrumentalHub;

[Dependency(ReplaceServices = true)]
public class InstrumentalHubBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<InstrumentalHubResource> _localizer;

    public InstrumentalHubBrandingProvider(IStringLocalizer<InstrumentalHubResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
