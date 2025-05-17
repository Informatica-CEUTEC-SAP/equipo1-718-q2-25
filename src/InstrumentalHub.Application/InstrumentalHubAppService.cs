using InstrumentalHub.Localization;
using Volo.Abp.Application.Services;
using InstrumentalHub.Domain;

namespace InstrumentalHub;

/* Inherit your application services from this class.
 */
public abstract class InstrumentalHubAppService : ApplicationService
{
    protected InstrumentalHubAppService()
    {
        LocalizationResource = typeof(InstrumentalHubResource);
    }
}
