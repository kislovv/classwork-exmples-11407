namespace OopPrincipal.Strategy;

public class NoFly : IFlyBehaviour
{
    public void Fly()
    {
       Console.WriteLine("Я не летаю");
    }
}