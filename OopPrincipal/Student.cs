using System.Text;

namespace OopPrincipal;

public class Student : Human, IComparable
{
    public TypeOfStudy TypeOfStudy { get; }
    public DateOnly StartStudy { get; init; }
    public DateOnly EndStudy { get; private set; }

    public Student(string name, int age) : base(name, age)
    {
        TypeOfStudy = TypeOfStudy.University;
        EndStudy = StartStudy.AddYears(4);
    }

    public Student(string name, int age, TypeOfStudy typeOfStudy, DateOnly endStudy): this(name, age)
    {
        TypeOfStudy = typeOfStudy;
        EndStudy = endStudy;
    }
    public void UpdateAge()
    {
        Age++;
    }

    public void ChangeSurname(string newSurname)
    {
        var fio = Name.Split(' ');
        fio[0] = newSurname;
        Name = string.Join(" ", fio);
    }
    
    public string AnswerTheQuestion(string question)
    {
        var answer = "";
        for (var i = 0; i < 100; i++)
        {
            answer += (char)new Random().Next(65, 91);
        }

        return $"{question}:{answer}";
    }

    public override void Say(string message)
    {
        Console.WriteLine($"{TypeOfStudy.ToString()}");
        base.Say(message);
    }

    public override void Move()
    {
        Console.WriteLine("Я двигаюсь на метро. Чучух - чучух!");
    }

    public int CompareTo(object? obj)
    {
        if (obj is not Student student)
        {
            throw new ArgumentException(); 
        }

        return student.Name == Name 
            ? 0 : student.Name.Length < Name.Length 
                ? -1 : 1;
    }
}

public enum TypeOfStudy
{
    School,
    University,
    College
}