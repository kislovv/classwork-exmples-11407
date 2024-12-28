namespace OopPrincipal;

public class SchoolStudent: Student
{
    public override TypeOfStudy TypeOfStudy { get; } = TypeOfStudy.School;

    public SchoolStudent(string name, int age) : base(name, age)
    {
    }

    public SchoolStudent(string name, int age, TypeOfStudy typeOfStudy, DateOnly endStudy) : base(name, age, typeOfStudy, endStudy)
    {
    }

    public override void Say(string message)
    {
        Console.WriteLine("Im school student!");
        base.Say(message);
    }
}