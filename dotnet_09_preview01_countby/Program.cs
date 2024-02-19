using System.Text.Json;
using Services;

var studentService = new StudentService();
var students = await studentService.GetStudents();

var houseService = new HouseService();
var houses = (await houseService.GetHouses()).ToDictionary(x => x.Id);

var count = students.CountBy(x => x.HouseId).Select(x => new
{
    House = houses[x.Key].Name,
    Amount = x.Value
});

var options = new JsonSerializerOptions
{
    WriteIndented = true
};

var json = JsonSerializer.Serialize(count, options);

Console.WriteLine(json);