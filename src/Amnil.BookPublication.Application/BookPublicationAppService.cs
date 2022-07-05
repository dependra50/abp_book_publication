using System;
using System.Collections.Generic;
using System.Text;
using Amnil.BookPublication.Localization;
using Volo.Abp.Application.Services;

namespace Amnil.BookPublication;

/* Inherit your application services from this class.
 */
public abstract class BookPublicationAppService : ApplicationService
{
    protected BookPublicationAppService()
    {
        LocalizationResource = typeof(BookPublicationResource);
    }
}
