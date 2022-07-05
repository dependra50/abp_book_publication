using System.Threading.Tasks;

namespace Amnil.BookPublication.Data;

public interface IBookPublicationDbSchemaMigrator
{
    Task MigrateAsync();
}
