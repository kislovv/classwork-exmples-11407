namespace OopPrincipal;

public class Student
{
    public string name;
    public int age;
    public TypeOfStudy typeOfStudy;
    public DateOnly startStudy;
    public DateOnly endStudy;

    public Student(string name)
    {
        this.name = name;
    }

    public Student(string name, TypeOfStudy typeOfStudy): this(name)
    {
        this.typeOfStudy = typeOfStudy;
    }
}

public enum TypeOfStudy
{
    School,
    University,
    College
}