using Amnil.BookPublication.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Amnil.BookPublication;

[DependsOn(
    typeof(BookPublicationEntityFrameworkCoreTestModule)
    )]
public class BookPublicationDomainTestModule : AbpModule
{

}
