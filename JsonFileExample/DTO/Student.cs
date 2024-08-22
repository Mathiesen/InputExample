namespace JsonFileExample.DTO;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string School { get; set; }
    public List<Address> Address { get; set; } = new();
}