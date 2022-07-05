using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Amnil.BookPublication.Web;

[Dependency(ReplaceServices = true)]
public class BookPublicationBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "BookPublication";
}
