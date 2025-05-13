using Volo.Abp.Settings;

namespace InstrumentalHub.Settings;

public class InstrumentalHubSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(InstrumentalHubSettings.MySetting1));
    }
}
