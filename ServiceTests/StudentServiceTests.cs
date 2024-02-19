namespace ServiceTests;

using Services;
using FluentAssertions;

[TestClass]
public class StudentServiceTests
{
    private readonly StudentService _sut;

    public StudentServiceTests()
    {
        _sut = new StudentService();
    }

    [TestMethod]
    public async Task GetStudents_DefaultStudentsDefined_ShouldReturn3()
    {
        var result = await _sut.GetStudents();

        result.Should().NotBeEmpty()
            .And.HaveCount(3);
    }

    [TestMethod]
    public async Task GetRandomStudents_CalledTwice_ShouldNotBeSameResult()
    {
        var randomResult1 = await _sut.GetRandomStudents();
        var randomResult2 = await _sut.GetRandomStudents();

        randomResult1.Should().NotBeEquivalentTo(randomResult2);
    }
}