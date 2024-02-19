
using FluentAssertions;
using Services;

[TestClass]
public class HouseServiceTests
{
    private readonly HouseService _sut = new();

    [TestMethod]
    public async Task Test()
    {
        var result = await _sut.GetHouses();

        result.Should().NotBeEmpty()
            .And.HaveCount(4);
    }
}