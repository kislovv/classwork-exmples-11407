using System.Text.RegularExpressions;

namespace OopPrincipal;

class Program
{
    static void Main(string[] args)
    {
        var group = new StudentGroup()
        {
            Name = "11407",
            CreatedAt = DateOnly.FromDateTime(DateTime.Now),
        };
        var student = new Student("Kislov Kirill" , 18, group);
        var student2 = new Student("Kislov Kirill",
            7, TypeOfStudy.School,
            DateOnly.FromDateTime(DateTime.Now.AddYears(11)), group);
        
        var student3 = new Student("LOLOLO", 78, group)
        {
            StartStudy = DateOnly.FromDateTime(DateTime.Now)
        };
        
        Console.WriteLine(student.Name);
        
        student.ChangeSurname("Xylophone");
        
        Console.WriteLine("Hello, World!");
        
        student.Say("Hello");
        

        Human human = student;
        human.Say("fdsfsdf");
        
        IMoveable moveable = human;

        var students = new[]{student, student2, student3};
        
        Array.Sort(students, new StudentComparer());

        var h2 = new Student("afsdf", 12312, "Male", group);
        Console.WriteLine("work");
        Console.WriteLine("work");
        Console.WriteLine("work");
        Console.WriteLine("work");
        Console.WriteLine("work");

        Console.WriteLine(h2.Sex);

    }
}