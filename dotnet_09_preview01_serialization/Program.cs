using System.Text.Json;
using Services;

var studentService = new StudentService();
var students = await studentService.GetStudents();

var options = new JsonSerializerOptions
{
    WriteIndented = true
};
var json = JsonSerializer.Serialize(students, options);
Console.WriteLine(json);