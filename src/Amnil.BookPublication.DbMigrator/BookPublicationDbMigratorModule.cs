using Amnil.BookPublication.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Amnil.BookPublication.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BookPublicationEntityFrameworkCoreModule),
    typeof(BookPublicationApplicationContractsModule)
    )]
public class BookPublicationDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
