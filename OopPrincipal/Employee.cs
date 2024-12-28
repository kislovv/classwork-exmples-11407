namespace OopPrincipal;

public class Employee : Human
{
    public string PlaceOfWork { get; set; }
    public Employee(string name, int age) : base(name, age)
    {
    }

    public override void Say(string message)
    {
        Console.WriteLine(PlaceOfWork);
        base.Say(message);
    }

    public override void Move()
    {
        Console.WriteLine("I'm moving, im Employee!");
    }
}