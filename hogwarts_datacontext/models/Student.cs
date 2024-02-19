namespace Models;

public record Student
{
    public Guid Id { get; init; }
    public string FirstName { get; init; } = string.Empty;
    public string? MiddleName { get; init; }
    public string LastName { get; init; } = string.Empty;
    public Guid HouseId { get; init; }

    public Student()
    {

    }

    public Student(Guid id, string firstName, string lastName)
        : this(id, firstName, null, lastName)
    {

    }

    public Student(Guid id, string firstName, string? middleName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
    }
}
