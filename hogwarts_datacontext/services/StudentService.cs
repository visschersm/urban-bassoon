namespace Services;

using Models;
using AutoBogus;
using Bogus;

public class StudentService
{
    private readonly List<Student> _students;
    private readonly Faker<Student> _randomStudents;

    public StudentService()
    {
        _students =
        [
            new Student
            {
                Id = new Guid("8f7369b2-70f2-4c6c-96e2-b4c5f45bdca9"),
                FirstName = "Harry",
                LastName = "Potter",
                HouseId = new Guid("21fe027d-d06f-4fa2-bfd9-b6c3cb19edcd")
            },
            new Student
            {
                Id = new Guid("9c64aa23-d178-46a7-bd5b-0ce2fccfdc5b"),
                FirstName = "Ronald",
                LastName = "Weasley",
                HouseId = new Guid("21fe027d-d06f-4fa2-bfd9-b6c3cb19edcd")
            },
            new Student
            {
                Id = new Guid("8f2998cb-4cef-421a-b7ac-f3e4b3f8b930"),
                FirstName = "Hermione",
                LastName = "Granger",
                HouseId = new Guid("21fe027d-d06f-4fa2-bfd9-b6c3cb19edcd")
            },
            new Student
            {
                Id = new Guid("0a5f9006-88f6-4040-8a1c-3b83e29f2e55"),
                FirstName = "Hannah",
                LastName = "Abbott",
                HouseId = new Guid("82d5aa20-3cbc-4d66-8f13-862a9fddccfb")
            },
            new Student
            {
                Id = new Guid("7d0febe4-5051-4916-a826-29a741aea36f"),
                FirstName = "Justin",
                LastName = "Finch-Fletchley",
                HouseId = new Guid("82d5aa20-3cbc-4d66-8f13-862a9fddccfb")
            }
        ];

        _randomStudents = new AutoFaker<Student>()
            .RuleFor(x => x.FirstName, f => f.Name.FirstName())
            .RuleFor(x => x.LastName, f => f.Name.LastName());
    }

    public Task<IEnumerable<Student>> GetStudents()
    {
        return Task.FromResult<IEnumerable<Student>>(_students);
    }

    public Task<IEnumerable<Student>> GetRandomStudents()
    {
        var students = _randomStudents.Generate(3);
        return Task.FromResult<IEnumerable<Student>>(students);
    }
}