using Amnil.BookPublication.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Amnil.BookPublication.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class BookPublicationPageModel : AbpPageModel
{
    protected BookPublicationPageModel()
    {
        LocalizationResourceType = typeof(BookPublicationResource);
    }
}
