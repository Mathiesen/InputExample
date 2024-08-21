namespace InputExample.DTO;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string School { get; set; }
    public Address Address { get; set; } = new();
}