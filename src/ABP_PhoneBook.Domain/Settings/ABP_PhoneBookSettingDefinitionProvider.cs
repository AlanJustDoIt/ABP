using Volo.Abp.Settings;

namespace ABP_PhoneBook.Settings;

public class ABP_PhoneBookSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ABP_PhoneBookSettings.MySetting1));
    }
}
