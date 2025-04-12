using System.Runtime.InteropServices.JavaScript;
using System.Threading.Channels;
using OopPrincipal.Strategy;

namespace OopPrincipal;

class Program
{
    static void Main(string[] args)
    {
        var student = new Student("Kislov Kirill" , 18)
        {
            Cource = 1
        };
        
        var age = student.Age;
        
        ChangeStudentCourse(student, ref age);

        Console.WriteLine($"{student.Cource} {age}");
        
        var student5 = new Student("Kislov Kirill" , 18, "male");
        
        Console.WriteLine($"{student5.Name} : {student5.Sex}");
        
        var student2 = new Student("Kislov Kirill",
            7, TypeOfStudy.School,
            DateOnly.FromDateTime(DateTime.Now.AddYears(11)));
        
        var student3 = new Student("LOLOLO", 78)
        {
            StartStudy = DateOnly.FromDateTime(DateTime.Now),
            Sex = "female",
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
        
        var currency = 15;
        Console.WriteLine(currency.PluralizeRubles());


        Human h = new Student("asdsdf", 312432);
        Console.WriteLine(h.Name);
        h.Say("Hello");
        h = new Employee("sfdf", 21312321)
        {
            PlaceOfWork = "Google"
        };
        h.Say("Hello");

        var rubberDuck = new RubberDuck(new NoQuack(), new NoFly());
        rubberDuck.Quack();
        rubberDuck.QuackBehaviour = new QuackBehaviour();
        rubberDuck.Quack();
        rubberDuck.Fly();
        rubberDuck.FlyBehaviour = new FlyBehavior();
        rubberDuck.Fly();
    }


    static void ChangeStudentCourse(Student student, ref int age)
    {
        student = new Student("Kislov Kirill" , 19)
        {
            Cource = 1
        };
        student.Cource++;
        age++;
    }
}