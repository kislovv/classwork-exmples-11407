namespace OopPrincipal;

class Program
{
    static void Main(string[] args)
    {
        var student = new Student("Kislov Kirill" , 18);
        var student2 = new Student("Kislov Kirill",
            7, TypeOfStudy.School,
            DateOnly.FromDateTime(DateTime.Now.AddYears(11)));
        
        var student3 = new Student("LOLOLO", 78)
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

    }
}