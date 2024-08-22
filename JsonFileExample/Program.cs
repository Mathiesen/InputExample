using JsonFileExample.BusinessLogic.Interfaces;
using JsonFileExample.BusinessLogic;
using JsonFileExample.DTO;

namespace JsonFileExample;

class Program
{
    static void Main(string[] args)
    {
        IStudentRegistration registration = new StudentRegistration();
        Student stu = new Student();
        registration.RegisterStudent(stu);
    }
}