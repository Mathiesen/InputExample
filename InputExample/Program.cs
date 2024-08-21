using System.Text.Json;
using InputExample.DTO;

namespace InputExample;

class Program
{
    static void Main(string[] args)
    {
        Student stu = new Student();
        Console.WriteLine("Input your name:" );
        stu.Name = Console.ReadLine();
        Console.WriteLine("Input your age:" );
        stu.Age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input your school:" );
        stu.School = Console.ReadLine();
        Console.WriteLine("Input your street name:" );
        stu.Address.StreetName = Console.ReadLine();
        Console.WriteLine("Input your house number:" );
        stu.Address.Number = Convert.ToInt32(Console.ReadLine());
        
        
         string json = JsonSerializer.Serialize(stu, new JsonSerializerOptions()
         {
             WriteIndented = true
         });
         File.WriteAllText("/tmp/json.json", json);
    }
}