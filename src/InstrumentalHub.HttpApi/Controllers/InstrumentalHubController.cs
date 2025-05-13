using InstrumentalHub.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace InstrumentalHub.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class InstrumentalHubController : AbpControllerBase
{
    protected InstrumentalHubController()
    {
        LocalizationResource = typeof(InstrumentalHubResource);
    }
}
