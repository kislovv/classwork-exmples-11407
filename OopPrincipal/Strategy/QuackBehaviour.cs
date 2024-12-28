namespace OopPrincipal.Strategy;

public class QuackBehaviour : IQuackBehaviour
{
    public void Quack()
    {
        Console.WriteLine("Ну типа... кря!");
    }
}