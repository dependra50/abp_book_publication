using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Amnil.BookPublication.Data;
using Volo.Abp.DependencyInjection;

namespace Amnil.BookPublication.EntityFrameworkCore;

public class EntityFrameworkCoreBookPublicationDbSchemaMigrator
    : IBookPublicationDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreBookPublicationDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the BookPublicationDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<BookPublicationDbContext>()
            .Database
            .MigrateAsync();
    }
}
