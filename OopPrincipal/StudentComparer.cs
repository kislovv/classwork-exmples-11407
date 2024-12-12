using System.Collections;

namespace OopPrincipal;

public class StudentComparer: IComparer 
{
    public int Compare(object? x, object? y)
    {
        if (x is Student student1 && y is Student student2)
        {
            return student1.Name == student2.Name 
                ? 0 : student1.Name.Length < student2.Name.Length 
                    ? -1 : 1;
        }

        throw new ArgumentException();
    }
}