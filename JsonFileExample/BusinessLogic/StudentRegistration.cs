using System.Text.Json;
using JsonFileExample.BusinessLogic.Interfaces;
using JsonFileExample.DTO;

namespace JsonFileExample.BusinessLogic;

public class StudentRegistration : IStudentRegistration
{
    public void RegisterStudent(Student student)
    {
        student = CaptureStudent();
        var json = JsonSerializer.Serialize(student, new JsonSerializerOptions()
        {
            WriteIndented = true
        });
        File.WriteAllText("/tmp/json.json", json);
    }

    private static Student CaptureStudent()
    {
        Student student = new Student();
        GetStudentDetails(student);
        GetAddressDetails(student);
        return student;
    }

    private static void GetAddressDetails(Student student)
    {
        Console.WriteLine();
        Address address = new Address();
        Console.WriteLine("Input your street name:" );
        address.StreetName = Console.ReadLine();
        Console.WriteLine("Input your house number:" );
        address.Number = Convert.ToInt32(Console.ReadLine());
        student.Address.Add(address);
        
        Console.WriteLine("Do you have any more addresses to add? (y/n)");
        if (Console.ReadKey().Key == ConsoleKey.Y)
        {
            GetAddressDetails(student);
        }
    }

    private static void GetStudentDetails(Student student)
    {
        Console.WriteLine("Input your name:" );
        student.Name = Console.ReadLine();
        Console.WriteLine("Input your age:" );
        student.Age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input your school:" );
        student.School = Console.ReadLine();
    }
}