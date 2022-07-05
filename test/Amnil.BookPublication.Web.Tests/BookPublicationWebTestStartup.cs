using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Amnil.BookPublication;

public class BookPublicationWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<BookPublicationWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
