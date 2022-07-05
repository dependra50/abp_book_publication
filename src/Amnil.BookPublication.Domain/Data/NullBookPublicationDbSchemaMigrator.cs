using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Amnil.BookPublication.Data;

/* This is used if database provider does't define
 * IBookPublicationDbSchemaMigrator implementation.
 */
public class NullBookPublicationDbSchemaMigrator : IBookPublicationDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
