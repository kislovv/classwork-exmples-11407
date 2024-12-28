namespace OopPrincipal.Strategy;

public class NoQuack: IQuackBehaviour
{
    public void Quack()
    {
        Console.WriteLine("Мерцание сверчков");
    }
}