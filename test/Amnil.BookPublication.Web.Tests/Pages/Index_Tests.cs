using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Amnil.BookPublication.Pages;

public class Index_Tests : BookPublicationWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
