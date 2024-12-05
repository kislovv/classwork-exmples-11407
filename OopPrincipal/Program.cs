namespace OopPrincipal;

class Program
{
    static void Main(string[] args)
    {
        var student = new Student("Kislov Kirill");
        var student2 = new Student("Kislov Kirill", TypeOfStudy.University);
        var student3 = new Student("LOLOLO")
        {
            age = 18,
            endStudy = DateOnly.Parse("2025-05-31"),
            startStudy = DateOnly.Parse("2024-09-01"),
        };

        student3.name = "KUKU";
        student3.age = -18;
        student3.endStudy = DateOnly.Parse("2125-05-31");
        
        Console.WriteLine("Hello, World!");
    }
}