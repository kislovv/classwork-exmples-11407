namespace OopPrincipal;

public abstract class Human: IMoveable, ISpeakable, IHuman
{
    public string Name { get; protected set; }
    public int Age { get; protected set; }

    protected Human(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void Say(string message)
    {
        Console.WriteLine($"{Name} {Age}: {message}");
    }

    public abstract void Move();
}