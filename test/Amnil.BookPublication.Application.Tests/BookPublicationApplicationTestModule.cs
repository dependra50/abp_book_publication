using Volo.Abp.Modularity;

namespace Amnil.BookPublication;

[DependsOn(
    typeof(BookPublicationApplicationModule),
    typeof(BookPublicationDomainTestModule)
    )]
public class BookPublicationApplicationTestModule : AbpModule
{

}
