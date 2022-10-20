using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace ABP_PhoneBook.Pages;

public class Index_Tests : ABP_PhoneBookWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
