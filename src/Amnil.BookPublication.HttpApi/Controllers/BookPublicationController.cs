using Amnil.BookPublication.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Amnil.BookPublication.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BookPublicationController : AbpControllerBase
{
    protected BookPublicationController()
    {
        LocalizationResource = typeof(BookPublicationResource);
    }
}
