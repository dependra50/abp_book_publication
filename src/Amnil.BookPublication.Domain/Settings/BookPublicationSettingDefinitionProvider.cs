using Volo.Abp.Settings;

namespace Amnil.BookPublication.Settings;

public class BookPublicationSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BookPublicationSettings.MySetting1));
    }
}
