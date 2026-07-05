using Volo.Abp.Settings;

namespace AppStore.Settings;

public class AppStoreSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AppStoreSettings.MySetting1));
    }
}
